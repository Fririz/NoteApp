using System.Net;
using System.IO;

namespace Updater
{
    class Update
    {
        string path;
        public Update(string Path)
        {
            path = Path;
        }


        public void UpdaterFunc()
        {
            File.Delete(path);
            string remoteUri = "https://github.com/Fririz/NoteApp/releases/download/1.0/NoteApp.exe";
            string fileName = "NoteApp.exe", myStringWebResource = null;
            WebClient myWebClient = new WebClient();
            myStringWebResource = remoteUri + fileName;

            myWebClient.DownloadFile(myStringWebResource, fileName);
        }
    }
}
