using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CliWrap;
using CliWrap.Buffered;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DiscordTotalCallTime
{
    internal class DiscordTotalCallTime
    {

        public async static Task<double[]> ImportJSonFromFile(String fileName)
        {
            try
            {
                using (StreamReader file = File.OpenText(fileName))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o = (JObject)JToken.ReadFrom(reader);

                    double callTime = 0, iterations = 0 , averageCallTime = 0;

                    foreach (var message in o["messages"])
                    {
                        if (message["type"].ToString() == "Call")
                        {
                            try
                            {
                                if (message["timestamp"].ToString() != "null" && message["callEndedTimestamp"].ToString() != null)
                                {
                                    // Getting both timestamps of call beginning and call end
                                    String timestamp = message["timestamp"].ToString();
                                    String timestampEnd = message["callEndedTimestamp"].ToString();

                                    // Converting timestamps to DateTime
                                    DateTime start = DateTime.Parse(timestamp);
                                    DateTime end = DateTime.Parse(timestampEnd);

                                    // Calculating the timespan between call start and end and saving it as a timespan object
                                    TimeSpan duration = end - start;

                                    averageCallTime += duration.TotalSeconds;
                                    iterations++;
                                    // Getting the total duration in seconds and adding it to the global total call time
                                    callTime += duration.TotalSeconds;

                                    
                                }
                            }
                            catch
                            {
                                // This code is unreachable but it's here for the memes https://www.youtube.com/watch?v=2gQl3JDz0dM
                            }
                        }
                    }
                    return new double[] { callTime, iterations };
                }
            }
            catch
            {
                
            }
            
            return null;

        }

        public async static Task ExportDiscordChatFromID(String ID, String token, Guna.UI2.WinForms.Guna2CircleProgressBar operationProgress)
        {
            try
            {
                var url = "https://discordapp.com/api/users/@me/channels";
                JArray channels;
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers["Authorization"] = token;
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                operationProgress.Value = 15;
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                using (JsonTextReader reader = new JsonTextReader(streamReader))

                    channels = (JArray)JToken.ReadFrom(reader);

                Dictionary<string, string> channelDictionary = new Dictionary<string, string>();
                operationProgress.Value = 30;
                foreach (var channelX in channels)
                {
                    if (channelX["type"].ToString() == "1")
                    {
                        channelDictionary.Add(channelX["id"].ToString(), channelX["recipients"][0]["username"].ToString());
                    }
                    else
                    {
                        String groupName = ">>";

                        foreach (var recipient in channelX["recipients"])
                        {
                            groupName += $"{recipient["username"]}, ";
                        }

                        groupName = groupName.Substring(0, groupName.Length - 2);

                        channelDictionary.Add(channelX["id"].ToString(), channelX["name"].ToString());
                    }
                }
                operationProgress.Value = 50;
                String arguments = $"DiscordChatExporter.Cli.dll export -t {token} -c {ID} -f Json -o messages.json";
                String workingDir = Directory.GetCurrentDirectory();

                var stdOutBuffer = new StringBuilder();
                var stdErrBuffer = new StringBuilder();

                var result = await (Cli.Wrap($"dotnet"))
                    .WithArguments(arguments)
                    .WithWorkingDirectory(workingDir)
                    .WithValidation(CommandResultValidation.None)
                    .WithStandardOutputPipe(PipeTarget.ToStringBuilder(stdOutBuffer))
                    .WithStandardErrorPipe(PipeTarget.ToStringBuilder(stdErrBuffer))
                    .ExecuteBufferedAsync();

                var stdOut = stdOutBuffer.ToString();
                var stdErr = stdErrBuffer.ToString();

                MessageBox.Show(stdOut);
                MessageBox.Show(stdErr);

                operationProgress.Value = 60;
            }
            catch(Exception e)
            {
                
            }
        }
    }
}
