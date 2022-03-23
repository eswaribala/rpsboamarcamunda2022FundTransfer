using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundTransfer.Adapters
{
    [ExternalTaskTopic("transfer")]
    public class BenficiaryTransferAdapter : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            string status = "failure";

            if (externalTask.Variables["toAccountNo"].Value.ToString().Length == 10)
            {
                status = "success";
            }

            resultVariables.Add("transferstatus", status);
        }
    }
}
