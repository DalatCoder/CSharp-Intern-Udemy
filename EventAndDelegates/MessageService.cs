using System;

namespace EventAndDelegates
{
    public class MessageService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            var videoEventArgs = e as VideoEventArgs;
            if (videoEventArgs != null)
            {
                Console.WriteLine("MessageService: Sending a SMS...");
                System.Console.WriteLine($"Current video {videoEventArgs.Video.Title}.");
            }
        }
    }
}
