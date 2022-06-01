using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicHub.Data.Models
{
    public partial class Album
    {

        public Album()
        {
            Songs = new HashSet<Song>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [ForeignKey(nameof(Producer))]
        public int ProducerId { get; set; }

        public Producer Producer { get; set; }


        public decimal Sum { get {
                decimal sum = 0;
                foreach (var item in Songs)
                {
                    sum += item.Price;
                }
                return sum; 
            } 
            set { } }
        public ICollection<Song> Songs { get; set; }

    }
}
