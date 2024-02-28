

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.CustomerStockStatus.Models
{
    public class CustomerStockMappingHelper
    {
        public static SqlCustomerStock MapResultToSQLModel(Result result)
        {
            var CustomerStock = new SqlCustomerStock
            {
                bourseAccount = result.bourseAccount ,
                bQty = result.bQty,
                bFee=result.bFee,
                bProfit=result.bProfit,
                bDps=result.bDps,
                sumRecapQty=result.sumRecapQty,
                sumIpoQty=result.sumIpoQty,
                convertToStock=result.convertToStock,
                convertFromRight= result.convertFromRight,
                pQty = result.pQty,
                pFee= result.pFee,
                pcBasis= result.pcBasis,
                sQty= result.sQty,
                actualProfit= result.actualProfit,
                rQty= result.rQty,
                sumSalable= result.sumSalable,
                price= result.price,
                currentValue= result.currentValue,
                potentialProfitWe= result.potentialProfitWe,
                totalProfit= result.totalProfit,
                pDps= result.pDps,
                twrReturn = result.twrReturn,
                bourseAccountName=result.bourseAccountName,
                insMaxLCode=result.insMaxLCode
            };
            return CustomerStock;
        }
    }
}
