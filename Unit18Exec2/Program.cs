using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Unit18Exec2
{
       
    class Program
    {
        static async Task Main(string[] args)
        {
           
            var Url = @"https://www.youtube.com/watch?v=9q5Hq1nHboU";
              

            var sender = new Sender();
            var receiver = new Receiver();

            sender.GetCommand(new CommandGetInfo(receiver));
            await receiver.GetInfoVideo(Url);

            sender.GetCommand(new CommandDownload(receiver));
            await receiver.DownloadVideo(Url);

        }
    }
}
