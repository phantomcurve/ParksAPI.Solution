using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        [StringLength(40)]
        public string Name{ get; set; }
        [StringLength(40)]
        public string Location{ get; set; }
        public bool National { get; set; }
        public bool State { get; set; }
    }
}

