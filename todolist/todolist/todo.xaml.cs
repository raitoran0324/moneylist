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

            public bool IsChecked
            {
                set
                {
                    if (value == true)
                    {
                        CheckMark.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        CheckMark.Visibility = Visibility.Collapsed;
                    }
                }
                get
                {
                    if (CheckMark.Visibility == Visibility)
                    return true;
                    else
                    return false;
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
            if (CheckMark.Visibility == Visibility)
            {
                CheckMark.Visibility = Visibility.Collapsed;
            }
            else
            {
                CheckMark.Visibility = Visibility.Visible;
            }
        }

        private void Money_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
