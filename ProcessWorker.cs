using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyAndArchive
{
    class ProcessWorker
    {
        public static void Run(string cmd, string tool, string source, string destination)
        {
            Process process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = tool,
                    Arguments = string.Format(cmd, source, destination),
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
    }
}
