using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models
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
        public Nation Nation { get; set; }
    }
}
