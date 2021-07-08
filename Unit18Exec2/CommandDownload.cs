using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Unit18Exec2
{
    public class CommandDownload : ICommand
    {
        Receiver receiver;


        public CommandDownload(Receiver receiver) => this.receiver = receiver;


        public async Task Run(string url)
        {
            await receiver.DownloadVideo(url);
        }
    }

}
