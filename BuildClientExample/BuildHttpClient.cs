using Microsoft.VisualStudio.Services.Common;
using System;
using System.Net;

namespace BuildClientExample
{
    public static class BuildHttpClient
    {
        public static void BuildClient()
        {
            string tfsUrl = "http://tfs:8080";
            string userName = "user";
            string password = "pw";
            string domain = "yourdomain";

            var wc = new WindowsCredential(new NetworkCredential(userName, password, domain));
            var credentials = new VssCredentials(wc);
            var buildHttpClient = new Microsoft.TeamFoundation.Build.WebApi.BuildHttpClient(new Uri(tfsUrl), credentials);
        }
    }
}
