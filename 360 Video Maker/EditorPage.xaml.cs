﻿using System;
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
    /// Interaction logic for EditorPage.xaml
    /// </summary>
    public partial class EditorPage : Page
    {

        UIFacade.UIFacade Facade = new UIFacade.UIFacade();

        public EditorPage()
        {
            InitializeComponent();
        }

        private void OpenVideoFiles_Event(object sender, RoutedEventArgs e)
        {
            List<string> paths = Facade.ImportVideoFiles();

            foreach(string p in paths)
            {
                VideoFileUserControl vfuc = new VideoFileUserControl();
                vfuc.SetPath(p);
                Files.Children.Add(vfuc);
            }
        }
    }
}
