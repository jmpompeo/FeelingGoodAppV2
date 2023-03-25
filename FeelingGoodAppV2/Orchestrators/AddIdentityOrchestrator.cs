using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FeelingGoodAppV2.Functions
{
    public class AddIdentityOrchestrator
    {
        private readonly ILogger<AddIdentityOrchestrator> logger;
        public AddIdentityOrchestrator(ILogger<AddIdentityOrchestrator> logger)
        {
            this.logger = logger;
        }

        [FunctionName(nameof(AddIdentityOrchestrator))]
        public static async Task<List<string>> RunOrchestrator(
            [OrchestrationTrigger] IDurableOrchestrationContext context, HttpRequest httpRequest, IDurableClient durableClient)
        {
            var nullList = new List<string>();
            return nullList; 
        }
    }
}