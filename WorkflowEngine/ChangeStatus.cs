using System;

namespace WorkflowEngine
{
    public class ChangeStatus : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Changing status...");
        }
    }
}
