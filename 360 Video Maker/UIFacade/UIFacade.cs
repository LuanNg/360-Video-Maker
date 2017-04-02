using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _360_Video_Maker.UIFacade
{
     public class UIFacade
    {
        public List<string> ImportVideoFiles()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            ofd.Filter = "Video files (*.avi, *.mp4) | *.avi; *.mp4";

            List<string> Paths = new List<string>();

            if (ofd.ShowDialog() == true)
            {
                Paths = ofd.FileNames.ToList();
            }

            return Paths;
        }

        public void OpenProject()
        {

        }

        public void CloseProject()
        {

        }

        public void NewProject()
        {

        }

        public void SaveProject()
        {

        }

        public void SaveCameraInfo()
        {

        }

        public void LoadCameraInfo()
        {

        }

        public void GetPreviousState()
        {

        }

        public void SaveState()
        {

        }

        public void GetForwardState()
        {

        }
    }
}
