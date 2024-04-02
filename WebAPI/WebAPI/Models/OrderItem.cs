using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderItemId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderID { get; set; }
        [ForeignKey("ItemId")]
        public int ItemId { get; set; }
        public int Quantity { get; set; }
       
        public Order OrdID { get; set; }
        public Item ItmID { get; set; }
    }
}
