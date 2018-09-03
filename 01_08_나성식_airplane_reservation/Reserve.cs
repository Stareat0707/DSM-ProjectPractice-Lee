using System.ComponentModel.DataAnnotations.Schema;
using ReserveStatus;

namespace ReserveStatus
{
    public enum Status { Reserved, Waiting }
}

namespace _01_08_나성식_airplane_reservation
{
    public class Reserve
    {
        public int ReserveID { get; set; }
        public int UserID { get; set; }
        public int AirplaneID { get; set; }
        [Column(TypeName = "int")]
        public Status Status { get; set; }
    }
}
