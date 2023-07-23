using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreDatabase.Entities
{
    [Table("OrderLineItems")]
    public class OrderLineItem
    {
        //problem in intial migration? idk if this is needed:
        [Key]
        public int OrderLineItemId { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public float Price { get; set; }

        public virtual Product? Product { get; set; }
    }
}
