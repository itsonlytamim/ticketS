using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class OrderDetails
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int uId { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        [ForeignKey("uId")]
        public User user { get; set; }
        [ForeignKey("TicketId")]
        public Tickets Ticket { get; set; }
    }
}
