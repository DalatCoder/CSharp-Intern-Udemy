using System;

namespace WorkflowEngine
{
    public class MailNotification : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Sending email...");
        }
    }
}
