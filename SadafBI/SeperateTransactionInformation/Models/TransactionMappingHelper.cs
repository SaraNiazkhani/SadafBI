using SadafBI.CustomersList.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.SeperateTransactionInformation.Models
{
    public class TransactionMappingHelper
    {
        public static SqlSeparateTransactionModel MapResultsToSqlModel(Result result)
        {
            var SqlSeparate = new SqlSeparateTransactionModel
            {
                isRight = result.isRight,
                customerId = result.customerId,
                dbsAccountNumber = result.dbsAccountNumber ?? "",
                customerFullName = result.customerFullName ?? "",
                parentCustomerId = (int?)result.parentCustomerId,
                parentCustomerFullName = result.customerFullName ?? "",
                transactionDate = result.transactionDate ?? "",
                isAPurchase = result.isAPurchase,
                instrumentBourseAccount = result.instrumentBourseAccount ?? "",
                insMaxLcode = result.insMaxLcode ?? "",
                quantity = result.quantity,
                price = result.price,
                interest = result.interest,
                development = result.development,
                bourseCo = result.bourseCo,
                bourseOrg = result.bourseOrg,
                depositCo = result.depositCo,
                itManagement = result.itManagement,
                facility = result.facility,
                tax = result.tax,
                branchId = result.branchId,
                branchName = result.branchName ?? "",
                bourseReference = result.bourseReference ?? "",
                bourseAccountText = result.bourseAccountText ?? "",
                dlNumber = result.dlNumber ?? "",
                isOtc = result.isOtc,
                postTradeTime = result.postTradeTime ?? "",
                cbranchId = result.cbranchId,
                cbranchName = result.cbranchName ?? "",



            };
            return SqlSeparate;
        }

    }
}

