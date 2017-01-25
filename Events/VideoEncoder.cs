using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Events
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //1- Define a delegate
        //2- Create a event based on that delegate
        //3- Rasie the event
                
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); /*EventArgs args*/

        //public event VideoEncodedEventHandler VideoEncoded;

        //.net framework 2.0+ have EventHandler to create delegate and event.
        //EventHandler
        //Eventhandler<TEventArgs>
        public EventHandler<VideoEventArgs> VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video..." + video.Title);
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        //.net framework convention suggest event publisher methods 
        //1)protected
        //2)virtual
        //3)void
        //4)On+EventName
        protected virtual void OnVideoEncoded(Video video)
        {
            //if (VideoEncoded != null)
            //    VideoEncoded(this, EventArgs.Empty);

            //using null propagation C# 6.0
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }


    }
}