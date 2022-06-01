using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MusicHub.Data.Models
{
    public partial class SongPerformer
    {
        [Key]
        public int SongId { get; set; }

        [Required]
        public Song Song { get; set; }

        [Required]

        [Key]
        public int PerformerId { get; set; }

        [Required]
        public Performer Performer { get; set; }

    }
}
