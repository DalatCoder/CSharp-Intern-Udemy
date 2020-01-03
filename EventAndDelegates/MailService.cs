using System;

namespace EventAndDelegates
{
    public class MailService
    {
        public void OnVideoEncoded(object sender, EventArgs e)
        {
            var videoEventArgs = e as VideoEventArgs;
            if (videoEventArgs != null)
            {
                Console.WriteLine($"Video title: {videoEventArgs.Video.Title}.");
                Console.WriteLine("MailService: Sending an email...");
            }
        }
    }
}
