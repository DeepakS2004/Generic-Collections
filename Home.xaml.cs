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
using Newtonsoft.Json;
using System.IO;

namespace Generic_Collections
{
    
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        Create create;
        Userdata userdata;
        public Home(string Username)
        {
            InitializeComponent();
            create = new Create(Username);
            userdata = new Userdata(Username);

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            
            mainframe.Content = create; 
        }

       

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            mainframe.Content = userdata;
        }
    }
   
}
