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

namespace todolist
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

        // 關閉視窗的事件
        private void Window_Closed(object sender, EventArgs e)
        {
            string data = "";

            // 取得每一個項目的文字
            foreach (todo item in TodoItemList.Children)
            {
                // 文字
                data += item.ItemDate + "|" + item.ItemName + "|" + item.ItemMoney + "\r\n";
            }

            // 存檔
            System.IO.File.WriteAllText(@"C:\temp\data.txt", data);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // 讀檔
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\data.txt");

            int total = 0;

            // 逐行產生元件
            foreach (string line in lines)
            {
                // 用符號分隔
                string[] parts = line.Split('|');

                // 建立元件
                todo item = new todo();
                item.ItemDate = parts[0];
                item.ItemName = parts[1];
                item.ItemMoney = parts[2];

                int itemPrice = int.Parse(parts[2]);
                total += itemPrice;

                // 放入到 StackPanel
                TodoItemList.Children.Add(item);

                // 顯示總金額
                Total.Text = total.ToString();
            }
        }

        private void AddMark_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 建立原件
            todo item = new todo();

            // 放入到 StackPanel
            TodoItemList.Children.Add(item);
        }

        private void Total_MouseDown(object sender, MouseButtonEventArgs e)
        {
            // 讀檔            
            string[] lines = System.IO.File.ReadAllLines(@"C:\temp\data.txt");

            int total = 0;

            // 逐行產生元件
            foreach (string line in lines)
            {
                // 用符號分隔
                string[] parts = line.Split('|');

                int itemPrice = int.Parse(parts[2]);
                total += itemPrice;

                // 顯示總金額
                Total.Text = total.ToString();
            }
        }
    }
}
