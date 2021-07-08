using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;
using System.Threading.Tasks;

namespace Unit18Exec2
{
    public class CommandGetInfo : ICommand
    {
        Receiver receiver;


        public CommandGetInfo(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public async Task Run(string url)
        {
            await receiver.GetInfoVideo(url);
        }
    }

}
