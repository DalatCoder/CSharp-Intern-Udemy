using System;

namespace WorkflowEngine
{
    public class UploadVideoToCloud : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Uploading the video to the cloud storage.");
        }
    }
}
