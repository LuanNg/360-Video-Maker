using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    /// Interaction logic for VideoFileUserControl.xaml
    /// </summary>
    public partial class VideoFileUserControl : UserControl
    {
        public string FilePath { get; private set; }
        public string FileName { get; private set; }

        public delegate string Onclick();
        public event Onclick VideoClicked;



        public VideoFileUserControl()
        {
            InitializeComponent();
        }

        public void ResetBackground()
        {
            this.Background = new SolidColorBrush(Color.FromArgb(255, 0, 0, 0));
        }


        private void UserControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            VideoClicked?.Invoke();
            this.Background = new SolidColorBrush(Color.FromRgb(25,25,100));
        }

        internal void SetPath(string p)
        {
            FilePath = p;
            FileName = System.IO.Path.GetFileName(p);
            VideoName.Content = FileName;
        }
    }
}
