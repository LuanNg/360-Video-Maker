using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _360_Video_Maker.ResourceLogic
{
    public class ResourceManager
    {
        #region Singleton Logic
        static ResourceManager Instance;
        private ResourceManager()
        {

        }

        public static ResourceManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ResourceManager();
            }

            return Instance;
        }
        #endregion

        private List<string> VideoPaths = new List<string>();


        public Bitmap GetFrame(int videoIndex, int videoFrameIndex)
        {
            return null;
        }

        public void DeleteVideoFromList(int videoIndex)
        {
            VideoPaths.RemoveAt(videoIndex);
        }

        public void AddVideoFiles(List<string> paths)
        {
            VideoPaths.AddRange(paths);
        }
    }
}
