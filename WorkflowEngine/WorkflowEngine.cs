namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var task in workflow.GetTasks())
            {
                try
                {
                    task.Execute();
                }
                catch (System.Exception)
                {
                    // Logging
                    // Terminate and persist the state of workflow
                    throw;
                }
            }
        }
    }
}
