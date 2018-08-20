using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Models
{
    public class Value
    {
        public int ID { get; set; }

[MaxLength(255)]
        public string Name { get; set; }
    }
}