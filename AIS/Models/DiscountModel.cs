using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS.Models
{
    public enum DiscountType
	{
	    WholeOrder,
        Individual,
        None
	}
    public class DiscountModel : BaseModel
    {
        public decimal DiscountInPercent { get; set; }
        public DiscountType DiscountType { get; set; }
        public int MinQuantity { get; set; }
        public ProductModel Product { get; set; }

    }
}
