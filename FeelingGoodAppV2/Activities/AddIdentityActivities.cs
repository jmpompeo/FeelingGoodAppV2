using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.DurableTask;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace FeelingGoodAppV2.Activities
{
    public class AddIdentityActivities
    {
        private readonly ILogger<AddIdentityActivities> _log;
        public AddIdentityActivities(ILogger<AddIdentityActivities> log)
        {
            _log = log;
        }
        [FunctionName(nameof(AddIdentityActivities))]
        public async Task<string> AuthenticateUser(
            [ActivityTrigger] string userId)
        {
            userId = "hello";
            return userId;
        }
    }
}