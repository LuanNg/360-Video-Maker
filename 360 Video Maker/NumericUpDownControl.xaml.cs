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
    /// Interaction logic for NumericUpDownControl.xaml
    /// </summary>
    public partial class NumericUpDownControl : UserControl
    {

        public double IncrementValue { get; set; }
        public double CurrentValue { get; set; }
        public delegate void ValueChangedFunction(double value);
        public event ValueChangedFunction ValueChanged;

        public double MaxValue { get; set; }
        public double MinValue { get; set; }

        public NumericUpDownControl()
        {
            InitializeComponent();
            IncrementValue = 0.1;
            CurrentValue = 0.0;
        }

        private void IncrementUp_Event(object sender, RoutedEventArgs e)
        {
            CurrentValue += IncrementValue;
            IncrementTextControl.Text = CurrentValue.ToString();
            ValueChanged?.Invoke(CurrentValue);
        }

        private void IncrementDown_Event(object sender, RoutedEventArgs e)
        {
            CurrentValue -= IncrementValue;
            IncrementTextControl.Text = CurrentValue.ToString();
            ValueChanged?.Invoke(CurrentValue);
        }

        private void IncrementTextControl_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                image.Visibility = Visibility.Hidden;
                if (IncrementTextControl.Text.Trim() != string.Empty)
                {
                    CurrentValue = double.Parse(IncrementTextControl.Text);
                    ValueChanged?.Invoke(CurrentValue);

                    IncrementTextControl.Text = IncrementTextControl.Text.Trim();
                    IncrementTextControl.CaretIndex = IncrementTextControl.Text.Count();
                }
            }
            catch
            {
                image.Visibility = Visibility.Visible;
            }
        }
    }
}
