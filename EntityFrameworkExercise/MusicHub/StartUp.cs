namespace MusicHub
{
    using System;
    using System.Text;
    using System.Threading.Tasks;
    using Data;
    using Initializer;
    using System.Linq;
    using System.Collections.Generic;
    using MusicHub.Data.Models;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            MusicHubDbContext context = 
                new MusicHubDbContext();


            DbInitializer.ResetDatabase(context);

            //Test your solutions here
        }

        public  static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder sb = new StringBuilder();

            var result = context.Albums.Where(a => a.ProducerId == producerId).Select(s =>
            new
            {
                Name = s.Name,
                ReleaseDate = s.ReleaseDate,
                ProducerName = s.Producer.Name,
                Songs = s.Songs.Select(song => new
                {
                    Name = song.Name,
                    Price = String.Format("{0:0:00}", song.Price),
                    WriterName = song.Writer.Name
                }).OrderBy(s => s.Name).ThenByDescending(s => s.WriterName)
            }) ;

            foreach (var item in result)
            {
                sb.AppendLine(item.Name);
                sb.AppendLine(item.ReleaseDate.ToString());
                sb.AppendLine(item.ProducerName);
                sb.AppendLine(item.ProducerName);
                foreach (var entity in item.Songs)
                {
                    sb.AppendLine(entity.Name);
                    sb.AppendLine(entity.Price);
                    sb.AppendLine(entity.WriterName);
                }
                sb.AppendLine();
                sb.AppendLine();
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            throw new NotImplementedException();
        }
    }
}
