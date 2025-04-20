using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDbData
{
    public class HockeyPlayer
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int HightInCm { get; set; }
        public int WeightInKg { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int NationId { get; set; }

    }
}
