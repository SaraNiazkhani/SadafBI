using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SadafBI.SeperateTransactionInformation.Models
{
  
        public class SqlSeparateTransactionModel
        {
            [Key]
            public int Id { get; set; }
            public int isRight { get; set; }
            public int customerId { get; set; }
            public string dbsAccountNumber { get; set; } = "";
            public string customerFullName { get; set; } = "";
            public int? parentCustomerId { get; set; }
            public string parentCustomerFullName { get; set; } = "";
            public string transactionDate { get; set; } = "";
            public int? isAPurchase { get; set; }
            public string instrumentBourseAccount { get; set; } = "";
            public string insMaxLcode { get; set; } = "";
            public int? quantity { get; set; }
            public int? price { get; set; }
            public int? interest { get; set; }
            public int? development { get; set; }
            public int? bourseCo { get; set; }
            public int? bourseOrg { get; set; }
            public int? depositCo { get; set; }
            public int? itManagement { get; set; }
            public int? facility { get; set; }
            public long? tax { get; set; }
            public int? branchId { get; set; }
            public string branchName { get; set; } = "";
            public string bourseReference { get; set; } = "";
            public string bourseAccountText { get; set; } = "";
            public string dlNumber { get; set; } = "";
            public int? isOtc { get; set; }
            public string postTradeTime { get; set; } = "";
            public int? cbranchId { get; set; }
            public string cbranchName { get; set; } = "";



  
     

    
   

    }
    }

