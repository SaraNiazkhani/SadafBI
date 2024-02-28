using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.CustomerStockStatus.Models
{
    public class APIResponseCustomerStock
    {

        public Result[] result { get; set; }
        public int pageSize { get; set; }
        public int pageNumber { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
    }

    public class Result
    {
        public string bourseAccount { get; set; }
        public int bQty { get; set; }
        public long bFee { get; set; }
        public long bcBasis { get; set; }
        public long bProfit { get; set; }
        public int bDps { get; set; }
        public int sumRecapQty { get; set; }
        public int sumIpoQty { get; set; }
        public int sumCancelIpoQty { get; set; }
        public int convertToStock { get; set; }
        public int convertFromRight { get; set; }
        public int pQty { get; set; }
        public long pFee { get; set; }
        public long pcBasis { get; set; }
        public int sQty { get; set; }
        public long actualProfit { get; set; }
        public int rQty { get; set; }
        public int sumSalable { get; set; }
        public int price { get; set; }
        public long currentValue { get; set; }
        public long potentialProfitWe { get; set; }
        public long totalProfit { get; set; }
        public int pDps { get; set; }
        public int twrReturn { get; set; }
        public string bourseAccountName { get; set; }
        public string insMaxLCode { get; set; }
    }

}

