using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FFMPEGUI
{
    internal class ProcessStart
    {
        internal static void StartExternalProcess(string executablePath, string parameters)
        {
            try
            {
                // Create a new process start info
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = executablePath,
                    Arguments = parameters,
                    UseShellExecute = false, // Required to redirect input/output
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true // Set to true to run the process in the background
                };

                // Start the process
                using (Process process = new Process { StartInfo = startInfo })
                {
                    process.Start();

                    // Optionally, you can write to the standard input stream
                    using (var streamWriter = process.StandardInput)
                    {
                        if (streamWriter.BaseStream.CanWrite)
                        {
                            streamWriter.WriteLine("Input data for the external process");
                            // You can write additional input as needed
                        }
                    }

                    // Optionally, you can read from the standard output stream
                    using (var streamReader = process.StandardOutput)
                    {
                        if (streamReader.BaseStream.CanRead)
                        {
                            string outputData = streamReader.ReadToEnd();
                            Console.WriteLine("Output from the external process:\n" + outputData);
                            // Process the output data as needed
                        }
                    }

                    // Wait for the process to exit
                    process.WaitForExit();

                    // Optionally, you can check the exit code
                    int exitCode = process.ExitCode;
                    Console.WriteLine("External process exited with code: " + exitCode);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
