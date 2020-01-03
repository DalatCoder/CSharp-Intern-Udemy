using System;

namespace WorkflowEngine
{
    public class CallThirdPartyService : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Calling third-party services to process the video.");
        }
    }
}
