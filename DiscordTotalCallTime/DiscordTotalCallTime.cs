using System;
using System.Collections;
using System.IO;
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

                    double callTime = 0, iterations = 0, averageCallTime = 0;

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

        public async static Task ExportDiscordChatFromID(String ID, String token, bool showOutput, Guna.UI2.WinForms.Guna2CircleProgressBar operationProgress)
        {
            try
            {
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

                if (showOutput) { 
                    MessageBox.Show(stdOut);
                    MessageBox.Show(stdErr);
                }

                operationProgress.Value = 60;
            }
            catch (Exception e)
            {

            }
        }

        public async static Task<ArrayList[]> GetChannelIDs(String token)
        {
            try
            {
                var url = "https://discordapp.com/api/users/@me/channels";
                JArray channels;
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers["Authorization"] = token;
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                using (JsonTextReader reader = new JsonTextReader(streamReader))

                    channels = (JArray)JToken.ReadFrom(reader);

                ArrayList ids = new ArrayList();
                ArrayList names = new ArrayList();

                foreach (var channelX in channels)
                {
                    if (channelX["type"].ToString() == "1")
                    {
                        ids.Add(channelX["id"].ToString());
                        names.Add(channelX["recipients"][0]["username"].ToString());
                    }
                }

                ArrayList idsGroup = new ArrayList();
                ArrayList namesGroup = new ArrayList();

                foreach (var channelX in channels)
                {
                    if (channelX["type"].ToString() != "1")
                    {
                        if (channelX["name"].ToString() != "")
                        {
                            idsGroup.Add(channelX["id"].ToString());
                            namesGroup.Add(channelX["name"]); ;
                        }
                        else
                        {

                            String groupName = "";
                            int membersLength = 0;

                            foreach (var recipient in channelX["recipients"])
                            {
                                groupName += $"{recipient["username"]}, ";
                                membersLength++;
                            }

                            if (groupName.Length >= 2) 
                            { 
                                groupName = groupName.Substring(0, groupName.Length - 2);
                                if (membersLength <= 1) groupName += " in Group";
                            }

                            else groupName = "Unnamed";

                            
                            try
                            {
                                idsGroup.Add(channelX["id"].ToString());
                                namesGroup.Add(groupName);
                            }
                            catch
                            {
                                idsGroup.Add(channelX["id"].ToString());
                                namesGroup.Add("Could not generate group name!");
                            }
                        }
                    }
                }


                // Reversing the group hi quick cum
                idsGroup.Reverse();
                namesGroup.Reverse();

                ids.AddRange(idsGroup);
                names.AddRange(namesGroup);

                ArrayList[] values = new ArrayList[2];
                values[0] = ids;
                values[1] = names;
                return values;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
