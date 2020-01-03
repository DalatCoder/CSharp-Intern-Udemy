namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var videoProcessorWorkflow = new VideoProcessorWorkflow();
            videoProcessorWorkflow.Add(new UploadVideoToCloud());
            videoProcessorWorkflow.Add(new CallThirdPartyService());
            videoProcessorWorkflow.Add(new MailNotification());
            videoProcessorWorkflow.Add(new ChangeStatus());

            var engine = new WorkflowEngine();
            engine.Run(videoProcessorWorkflow);
        }
    }
}
