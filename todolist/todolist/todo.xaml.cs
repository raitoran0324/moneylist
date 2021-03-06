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

namespace todolist
{
    /// <summary>
    /// todo.xaml 的互動邏輯
    /// </summary>
    public partial class todo : UserControl
    {
        DateTime myDate = DateTime.Now;
        
        public string ItemName
        {
            get
            {
                return ItemNameTb.Text;
            }
            set
            {
                ItemNameTb.Text = value;
            }

        }

        public string ItemMoney
        {
            
            get
            {
                return Money.Text;
            }
            set
            {
                Money.Text = value;
            }
        }

        public string ItemDate
        {
            
            get
            {
                string D = myDate.ToString("M / d");
                return D;
            }
            set
            {
                string D = myDate.ToString("M / d");
                D = value;
            }
        }


        public todo()
        {
            InitializeComponent();
        }

        private void ItemNameTb_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void CheckBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
 
        }

        private void Money_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Money_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Key < Key.D0) != (e.Key > Key.D9))
            {
            e.Handled = true;
            }

        }

        private void DateA_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void DateA_Loaded(object sender, RoutedEventArgs e)
        {
            DateA.Text = myDate.ToString("M / d");
        }
    }
}
