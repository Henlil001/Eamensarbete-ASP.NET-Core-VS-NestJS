using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models
{
    public class Nation
    {
        [Key]
        public int Id { get; set; }
        public string Nationality { get; set; }
    }
}
