using System;
using System.Threading;

namespace EventAndDelegates
{
    public class VideoEncoder
    {
        // first param is object: source/ sender
        // second param is EventArgs
        public event EventHandler VideoEncoded;

        // first param is object: source/ sender
        // second param is custom VideoEventArgs derived from EventArgs
        // public event EventHandler<VideoEventArgs> VideoEncoding;

        public void Encode(Video video)
        {
            // Some encoding logic...
            Console.WriteLine("Video encoding...");
            Thread.Sleep(3000);
            // ====================================

            OnVideoEncoded(video); // pusblish event
        }

        // .NET convention
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs { Video = video });
        }
    }
}
