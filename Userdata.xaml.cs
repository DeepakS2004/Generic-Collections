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
using System.IO;
using Newtonsoft.Json;
using System.Collections;

namespace Generic_Collections
{
    /// <summary>
    /// Interaction logic for Userdata.xaml
    /// </summary>
     
    public partial class Userdata : Page
    {
        public List<Diary> listdiary {  get; set; }
        public Userdata(string Username)
        {
            InitializeComponent();
            lblusername.Content = Username;
          
            string folderpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullpath = System.IO.Path.Combine(folderpath, "JSSoft", "Dairycontent.txt");
            if (File.Exists(fullpath))
            {
                string value = File.ReadAllText(fullpath);
                listdiary = JsonConvert.DeserializeObject<List<Diary>>(value);
            }
             
            

            listdata.ItemsSource = listdiary;
        }

        private void btnsearch_Click(object sender, RoutedEventArgs e)
        {
            var val = from data in listdiary
                      where data.Username.ToLower().Contains(txtsearch.Text.ToLower()) || data.Content.ToLower().Contains(txtsearch.Text.ToLower()) 
                      select data;
            listdata.ItemsSource = null;
            listdata.ItemsSource = val;


            
           

        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            var asc = listdiary.OrderBy(x => x.Date).ThenBy(x => x.Username);
            listdata.ItemsSource = null;
            listdata.ItemsSource = asc;
        }

        private void btnend_Click(object sender, RoutedEventArgs e)
        {
            var des = listdiary.OrderByDescending(x => x.Date).ThenByDescending(x => x.Username);
            listdata.ItemsSource = null;
            listdata.ItemsSource = des;

        }

       
            

        private void btngrp_Click(object sender, RoutedEventArgs e)
        {
                var grp = listdiary.ToLookup(x => x.Date);
                listdata.ItemsSource = null;
                listdata.ItemsSource = grp;
            
        }

        private void btntype_Click(object sender, RoutedEventArgs e)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("apple");
            arrayList.Add(123);
            arrayList.Add(true);

            var types = arrayList.OfType<string>();
            var Bool = arrayList.OfType<bool>();
            
        }
    }
}
