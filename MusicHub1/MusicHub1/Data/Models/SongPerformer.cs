using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub1.Models
{
   public class SongPerformer
    {
        public int SongId { get; set; }
        
        [Required]

        public string Song { get; set; }

        public int PerformerId { get; set; }

        [Required]

        public Performer Performer { get; set; }
    }
}
