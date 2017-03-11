using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CopyAndArchive
{
    class ProcessWorker
    {
        public static void Run(string cmd, string tool, string source, string destination)
        {
            string parsed_cmd = ParseCmd(cmd, source, destination);

            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = tool,
                    Arguments = parsed_cmd,
                    UseShellExecute = false,
                    RedirectStandardOutput = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            process.WaitForExit();

            if (process.ExitCode != 0)
                throw new Exception("Command return error code: " + process.ExitCode);
        }

        public static string ParseCmd(string cmd, string source, string destination)
        {
            StringBuilder new_command = new StringBuilder();

            int curr = cmd.IndexOf('{');
            int begin = 0;
            int length = 0;

            while (curr != -1)
            {
                length = curr - begin;
                new_command.Append(cmd.Substring(begin, length));

                string path = String.Empty;
                bool leave = false;
                while(!leave)
                {
                    char c = cmd[++curr];
                    switch (c)
                    {
                        case '0':
                            path = source;
                            break;
                        case '1':
                            path = destination +
                                Path.DirectorySeparatorChar +
                                Path.GetFileName(source);
                            break;
                        case 'd':
                            path = Path.GetDirectoryName(path);
                            break;
                        case 'n':
                            path = Path.GetDirectoryName(path) + 
                                Path.DirectorySeparatorChar + 
                                Path.GetFileNameWithoutExtension(path);
                            break;
                        case 'e':
                            path = Path.GetExtension(path);
                            break;
                        case '}':
                            leave = true;
                            break;
                        default:
                            throw new Exception("Parser error, unknonw paramater symbol: " + c);
                    }
                }

                new_command.Append(path);

                begin = ++curr;
                curr = cmd.IndexOf('{', begin);
            }

            return new_command.ToString();
        }
    }
}
