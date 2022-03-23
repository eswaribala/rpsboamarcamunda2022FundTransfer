using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
