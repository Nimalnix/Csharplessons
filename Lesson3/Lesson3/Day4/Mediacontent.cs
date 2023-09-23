using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4.Day4
{
    internal class Mediacontent
    {
        public virtual void StartPlayingContent() //only virtual method parent class can be overriden by child class
        {//if child want to override the parent class it should use Virtual
            Console.WriteLine( "start");

        }
        public virtual void StoptPlayingContent()
        {
            Console.WriteLine("stop");

        }
        public virtual void PausePlayingContent()
        {
            Console.WriteLine("Pause");

        }
        public virtual void ContinuePlayingContent()
        {
            Console.WriteLine("continue");

        }
        public sealed override string ToString()
        {
            Console.WriteLine( "Media tostring");
            return "OTT";
        }
    }
    //End of media class
    internal class AudioContent:Mediacontent
    {
        public override sealed void StartPlayingContent()//sealed avoid grand child to inherit
        {
            Console.WriteLine( "start");

            //    public  override string ToString()//even tostring sealed cannot be override again
            // {
            //     Console.WriteLine("AudioContent tostring");
            //     return "AudioContent";
            //}
        }
    }
    //End of AudioContent class
    internal class VideoContent:AudioContent
    {
        /*public override  void StartPlayingContent()//sealed avoid grand child to inherit
        {
            Console.WriteLine("start from Videocontent");
        }*/


    }
    //End of VideoContent class
    internal class MediaTester
    {
        public static void TestOne()
        {

        }
    }
    //End of MediaTester class
}
