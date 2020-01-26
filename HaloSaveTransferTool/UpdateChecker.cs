using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloMCCPCSaveTransferTool
{
    class UpdateChecker
    {
        static internal Version NewestVersion = new Version(0, 0, 0, 0);
        static internal Version ThisVersion = new Version(0, 0, 0, 0);
        static internal string LatestReleaseLink = "https://github.com/ELREVENGE/HaloMCCPCSaveTransferTool/releases/latest";
        static internal void UpToDatePrompt()
        {
            if (!UpToDateCheck() &&
                MessageBox.Show("A new version is available, would you like to view the release on Github?", "v" + NewestVersion + " available", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                System.Diagnostics.Process.Start(LatestReleaseLink);
            }
        }
        static internal bool UpToDateCheck()
        {
            try { ThisVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion; }
            catch
            {
                MainWindow.Output.WriteLine("Failed to get current version number from: System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion update check aborted (If the application was not installed with the setup.exe this message is normal.");
                return true;
            }
            string redirectLocation;
            HttpWebRequest httpWebRequest = WebRequest.Create(LatestReleaseLink) as HttpWebRequest;
            httpWebRequest.Method = "HEAD";
            httpWebRequest.AllowAutoRedirect = false;
            HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse;
            if (httpWebResponse.StatusCode == HttpStatusCode.Redirect)
            {
                redirectLocation = httpWebResponse.GetResponseHeader("Location");
                string[] splits = redirectLocation.Split(new char[3] { '/', 'v', '.' });
                int splitsLength = splits.Length;
                int major, minor, build, revision;

                if (splitsLength > 4 &&
                    int.TryParse(splits[splitsLength - 1], out revision) &&
                    int.TryParse(splits[splitsLength - 2], out build) &&
                    int.TryParse(splits[splitsLength - 3], out minor) &&
                    int.TryParse(splits[splitsLength - 4], out major))
                {
                    NewestVersion = new Version(major, minor, build, revision);
                }
                //get version number via split / v and . compare numbers 
                if (NewestVersion <= System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion)
                {
                    MainWindow.Output.WriteLine("Application up to date");
                    return true;
                }
            }
            MainWindow.Output.WriteLine("Something went wrong checking for updates ");
            return false;
        }
    }
}
