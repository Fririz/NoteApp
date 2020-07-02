using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace NoteAppNew
{
    class Update
    {
        public void Download()
        {
            string remoteUri = "https://1drv.ms/u/s!Av2jxua4bSzGiR3GQSG0MyiZRPcT?e=1U0We6";
            string fileName = "NoteAppNew123123.exe", myStringWebResource = null;

            WebClient myWebClient = new WebClient();

            myStringWebResource = remoteUri + fileName;

            myWebClient.DownloadFile(myStringWebResource, fileName);
        }
    }
}
