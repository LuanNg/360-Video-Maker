using Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoInformationRetrieval;

namespace VideoInformationRetrieval
{
    public static class VideoInformationRetrieval
    {
        private static VideoFileReader VFR = new VideoFileReader();

        public static VideoInformation GetVideoInformation (string filePath)
        {
            VFR.Open(filePath);

            VideoInformation vi = new VideoInformation() {
                frameRate = VFR.FrameRate,
                frames = VFR.FrameCount,
                duration = TimeSpan.FromSeconds((double)VFR.FrameCount / VFR.FrameRate)
            };

            return vi;
        }

        public static Bitmap GetVideoFrame(string filePath, int index)
        {
            VFR.Open(filePath);
            return VFR.GetFrameAtIndex(index);
        }
    }
}