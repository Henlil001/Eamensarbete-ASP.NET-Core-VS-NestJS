using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations;

namespace dotnet_api.Models.DTO
{
    public class AddPlayerDTO
    {
        public string FullName { get; set; }
        public int HightInCm { get; set; }
        public int WeightInKg { get; set; }
        public string Club { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int NationId { get; set; }
    }
}
