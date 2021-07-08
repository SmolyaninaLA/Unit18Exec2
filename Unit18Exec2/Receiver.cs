using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using System.Threading.Tasks;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos.Streams;

namespace Unit18Exec2
{
    public class Receiver
    {

        YoutubeClient youtube;

        public Receiver()
        {
            youtube = new YoutubeClient();
        }

        public async Task GetInfoVideo(string Url)
        {

            var video = await youtube.Videos.GetAsync(Url);

            Console.WriteLine("Информация о видео " + Url);

            var title = video.Title;
            var author = video.Author.Title;
            var duration = video.Duration;
            var description = video.Description;
            
           
            Console.WriteLine("Название: {0} ",title);
            Console.WriteLine("Автор: {0} ", author);
            Console.WriteLine("Продолжительность: {0}", duration);
            Console.WriteLine("Описание: {0} ", description);

        }

        public async Task DownloadVideo(string Url)
        {
            Console.WriteLine("Загружаается видео ");

            await youtube.Videos.DownloadAsync(Url, "video.mp4",
                                o => o.SetPreset(ConversionPreset.UltraFast)  
                                     .SetFFmpegPath("path/to/ffmpeg"));

            Console.WriteLine("Загрузка завершена!");
        }
    }
}
