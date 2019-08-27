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

namespace WPFDemo {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void BtnOne_Click(object sender, RoutedEventArgs e) {
            MessageBox.Show("I was clicked");
        }

        private void BtnTwo_Click(object sender, RoutedEventArgs e) {
            btnOne.Height -= 10;
        }

        private void BtnThree_Click(object sender, RoutedEventArgs e) {
            btnOne.Height += 10;

        }
    }
}
