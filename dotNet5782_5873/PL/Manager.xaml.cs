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
using System.Windows.Shapes;

namespace PL
{
    /// <summary>
    /// Interaction logic for Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new NewProduct().Show();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new NewProduct().Show();
        }
    }
}
