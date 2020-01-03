using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void Add(ITask task);
        void Remove(ITask task);
        IEnumerable<ITask> GetTasks();
    }
}
