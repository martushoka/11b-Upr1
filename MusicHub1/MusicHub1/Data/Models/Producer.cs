using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicHub1.Models
{
   public class Producer
    {
        public Producer()
        {
            this.Songs = new HashSet<Song>();
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]

        public string Name { get; set; }

        public string Pseudonym { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
