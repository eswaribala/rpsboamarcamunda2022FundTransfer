using CamundaClient.Dto;
using CamundaClient.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundTransfer.Adapters
{
    [ExternalTaskTopic("otp")]
    public class OTPMessageAdapter : IExternalTaskAdapter
    {
        public void Execute(ExternalTask externalTask, ref Dictionary<string, object> resultVariables)
        {
            Boolean status = false;
           if(externalTask.Variables["otp"].Value.ToString().Length == 4)
            {
                status = true;
            }
            resultVariables.Add("status", status);

        }
    }
}
