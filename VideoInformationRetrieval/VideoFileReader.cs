using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace VideoInformationRetrieval
{
    public class VideoFileReader : AForge.Video.FFMPEG.VideoFileReader
    {
        public Bitmap GetFrameAtIndex(int index)
        {
            if (index == 0)
            {
                return base.ReadVideoFrame();
            }

            if (index < 0)
            {
                return null;
            }

            for (int i = 0; i < index; i++)
            {
                base.ReadVideoFrame();
            }

            return ReadVideoFrame();
        }
    }
}
