using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
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
            Console.WriteLine("Customer Id {0}", externalTask.Variables["customerId"].Value);
        }
    }
}
