using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.CustomerStockStatus.Models
{
    public class SqlCustomerStock
    {
        [Key]
        public int Id { get; set; }
        public string bourseAccount { get; set; } 
        public long bQty { get; set; }
        public long bFee { get; set; }
        public long bcBasis { get; set; }
        public long bProfit { get; set; }
        public long bDps { get; set; }
        public long sumRecapQty { get; set; }
        public long sumIpoQty { get; set; }
        public long sumCancelIpoQty { get; set; }
        public long convertToStock { get; set; }
        public long convertFromRight { get; set; }
        public long pQty { get; set; }
        public long pFee { get; set; }
        public long pcBasis { get; set; }
        public long sQty { get; set; }
        public long actualProfit { get; set; }
        public long rQty { get; set; }
        public long sumSalable { get; set; }
        public long price { get; set; }
        public long currentValue { get; set; }
        public long potentialProfitWe { get; set; }
        public long totalProfit { get; set; }
        public long pDps { get; set; }
        public long twrReturn { get; set; }
        public string bourseAccountName { get; set; } = "";
        public string insMaxLCode { get; set; } = "";
    }

}
