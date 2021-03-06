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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private RenderPage RP = new RenderPage();
        private EditorPage EP = new EditorPage();

        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            MainFrame.Content = EP;
        }

        private void GoToRenderer_MenuItem(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = RP;
        }

        private void GoToEditor_MenuItem(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = EP;
        }


    }
}
