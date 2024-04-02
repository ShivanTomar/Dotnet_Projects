using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string OrderNo { get; set; }
        public string PayMethod { get; set; }
        public decimal GrandToatal { get; set; }

        [ForeignKey("CustomerId")] 
        public int CustomerId { get; set; }
        public Customer CustId { get; set; }


    }
}
