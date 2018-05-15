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
        string heightNumber;
        string weightNumber;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //建立关闭程式代码
            this.Close();
        }

        private void Title_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void FormalBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AsianBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void weightSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                //轉化拉杆數值
                weightNumber = weightSlider.Value.ToString();
            }

        }

        private void heigtSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsInitialized)
            {
                //轉化拉杆數值
                heightNumber = heigtSlider.Value.ToString();

                double heightWeight = (heigtSlider.Value - heigtSlider.Minimum) / (heigtSlider.Maximum - heigtSlider.Minimum);
                double range = heigtSlider.ActualWidth - heigtSlider.ActualWidth;
                double bmi = weightSlider.Value / Math.Pow(heigtSlider.Value / 100, 2);
            }
        }

        private void closeBtn_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
