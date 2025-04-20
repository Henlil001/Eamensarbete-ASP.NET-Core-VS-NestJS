using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeedDbData
{
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public string Nationality { get; set; }
    }
}
