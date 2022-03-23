using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using FundTransfer.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * http://localhost:8080/engine-rest/message
 * {
  "messageName" : "ftstartmessage",
 "businessKey" : "100",
  
  "processVariables" : {
    "customerId" : {"value" : 1378459, "type": "Long"
                  },
     "fromAccountNo":{"value":4858547,"type": "Long"},
     "toAccountNo":{"value":48585444,"type": "Long"},
       "amount":{"value":50000,"type": "Long"},
     "mode":{"value":"NEFT","type":"String"},
     "remarks":{"value" : "Loan", "type": "String"}
              
    
  }
}
 */

namespace FundTransfer.Adapters
{
    [ExternalTaskTopic("fundtransfer")]
    public class FundTransferMessageAdapter : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Console.WriteLine("Customer Id {0}", 
                externalTask.Variables["customerId"].Value);
            Console.WriteLine("From Account No {0}",
                externalTask.Variables["fromAccountNo"].Value);
            Console.WriteLine("To AccountNo {0}",
                externalTask.Variables["toAccountNo"].Value);
            Console.WriteLine("Amount {0}",
                externalTask.Variables["amount"].Value);
            Console.WriteLine("Mode {0}",
               externalTask.Variables["mode"].Value);
            Console.WriteLine("Remarks {0}",
                externalTask.Variables["remarks"].Value);
            Mode modeValue = (Mode)Enum.Parse(typeof(Mode), externalTask.Variables["mode"].Value.ToString(), true);

            FundTransferModel fundTransfer = new FundTransferModel
            {
                CustomerId= Convert.ToInt64(externalTask.Variables["customerId"].Value),
                FromAccountNo=Convert.ToInt64(externalTask.Variables["fromAccountNo"].Value),
                ToAccountNo=Convert.ToInt64(externalTask.Variables["toAccountNo"].Value),
                Amount= Convert.ToInt64(externalTask.Variables["amount"].Value),
                Mode= modeValue,
                Remarks= externalTask.Variables["remarks"].Value.ToString()

            };
        }
    }
}
