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

namespace WtfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HeighBox.Text = " ";
            HeighBox.Background = Brushes.NavajoWhite;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            WeighBox.Text = " ";
            WeighBox.Background = Brushes.NavajoWhite;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_ClickCalculate(object sender, RoutedEventArgs e)
        {
            double h = double.Parse(HeighBox.Text);
            double w= double.Parse(WeighBox.Text);
            double bmi = w / (h * h);
            Answer.Text = bmi.ToString();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Text_Box1.Text = "勤加锻炼控制饮食";
                
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {
            Text_Box1.Text = "好好保持";
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            WeighBox .Text = WeightBar.Value.ToString();
        }

        private void HeightBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            HeighBox.Text = HeightBar.Value.ToString();
            double h = double.Parse(HeighBox.Text);
            double w = double.Parse(WeighBox.Text);
            double bmi = w / (h * h);
            Answer.Text = bmi.ToString();
        }

        private void Answer_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void HeighBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
