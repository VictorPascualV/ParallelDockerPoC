using System.Diagnostics;
using System.IO;
using NUnit.Framework;
using System;
using System.Threading;

namespace TiendeoWebTests
{
    [SetUpFixture]
    public class GridSetup
    {
        private readonly string _workingDirectory = TestContext.CurrentContext.TestDirectory;
        private static string _batchRawOutput;
        private static string HubHost => _batchRawOutput.Split(new[] { "/tcp -> " }, StringSplitOptions.None)[1].Split('\n')[0];

        public static Uri SeleniumHubUrl => new Uri($"http://{HubHost}/wd/hub");

        [OneTimeSetUp]
        public void StartGrid()
        {
            ExecuteBatch(Path.Combine(_workingDirectory, "StartGrid.bat"));
            Thread.Sleep(3000);
        }

        [OneTimeTearDown]
        public void StopGrid()
        {
            ExecuteBatch(Path.Combine(_workingDirectory, "StopGrid.bat"));
        }

        static void ExecuteBatch(string batchFilePath)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/c " + batchFilePath)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                RedirectStandardError = true,
                RedirectStandardOutput = true
            };
            var process = Process.Start(processInfo);
            process.WaitForExit();

            _batchRawOutput = process.StandardOutput.ReadToEnd();

            process.Close();
        }
    }
}
