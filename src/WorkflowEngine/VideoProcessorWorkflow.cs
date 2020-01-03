using System.Collections.Generic;

namespace WorkflowEngine
{
    public class VideoProcessorWorkflow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public VideoProcessorWorkflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }

        // Return read-only version of _tasks list
        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }
    }
}
