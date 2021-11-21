using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [Required]
        [StringLength(40)]
        public string Name{ get; set; }
        [Required]
        [StringLength(40)]
        public string Location{ get; set; }
        [Required]
        public bool National { get; set; }
        [Required]
        public bool State { get; set; }
    }
}

