using _360_Video_Maker.UIFacade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _360_Video_Maker
{
    /// <summary>
    /// Interaction logic for EditorPage.xaml
    /// </summary>
    /// 
    public partial class EditorPage : Page
    {

        UIFacade.UIFacade Facade = new UIFacade.UIFacade();
        EventSender Sender = new EventSender();

        public EditorPage()
        {
            InitializeComponent();

            U_Coordinate_Control.ValueChanged += CoordChanged;
        }

        private void CoordChanged(double value)
        {

        }

        private void OpenVideoFiles_Event(object sender, RoutedEventArgs e)
        {
            List<string> paths = Facade.ImportVideoFiles();
            

            foreach (string p in paths)
            {
                VideoFileUserControl vfuc = new VideoFileUserControl();
                vfuc.VideoClicked += Vfuc_VideoClicked;
                vfuc.SetPath(p);
                vfuc.SetVideoInformation(p);

                VideoFilesList.Children.Add(vfuc);
            }
        }

        

        

        private void Vfuc_VideoClicked(object e)
        {
            for (int i = 0; i < VideoFilesList.Children.Count; i++)
            {
                if (!VideoFilesList.Children[i].Equals(e))
                {
                    ((VideoFileUserControl)VideoFilesList.Children[i]).ResetBackground();
                }
            }
        }

        private void ScrollViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                for (int i = 0; i < VideoFilesList.Children.Count; i++)
                {
                    var control = VideoFilesList.Children[i] as VideoFileUserControl;
                    if (control.isSelected == true)
                    {
                        Facade.DeleteFileFromLibrary(i);
                        VideoFilesList.Children.RemoveAt(i);
                        break;
                    }
                }
            }
        }
    }
}
