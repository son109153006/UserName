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

namespace user
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
        //單機密碼輸入程式
        private void button_go_Click(object sender, RoutedEventArgs e)
        {
            if(username.Text == "abc" && password.Text == "123")
            {
                txtInto.Text = "輸入成功，請繼續使用";
            }
            else
            {
                txtInto.Text = "輸入失敗，請重新輸入";
            }
        }
    }
}
