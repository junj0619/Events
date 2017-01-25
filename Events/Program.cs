using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();   //publisher
            var mailServer = new MailService();      //subscriber
            var messageServer = new MessageServer(); //subscriber

            videoEncoder.VideoEncoded += mailServer.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageServer.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}
