using System;

namespace Events
{
    public class MessageServer
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MessageServer: Sending text message..." + e.Video.Title);
        }
    }
}