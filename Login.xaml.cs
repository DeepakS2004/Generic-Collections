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
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace Generic_Collections
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, RoutedEventArgs e)
        {
           List<Student> student = new List<Student>();
            string folderpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullpath = System.IO.Path.Combine(folderpath, "JSSoft", "userdata.txt");

            if (File.Exists(fullpath))
            {
                string value = File.ReadAllText(fullpath);
                List<Student> values = JsonConvert.DeserializeObject<List<Student>>(value);

                var std = from stud in values
                          where stud.Name == txtname.Text && stud.Email == txtemail.Text 
                          select stud;
                Student list = std.ToList().FirstOrDefault();
                if (list != null)
                {
                    MessageBox.Show("Login Successfull");
                    Home ohome = new Home(list.Name);
                    this.Close();
                    ohome.Show();
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
                
            }
            else
            {
                MessageBox.Show("Login Failed");
            }
          

        }

        private void btnregister_Click(object sender, RoutedEventArgs e)
        {
            MainWindow oregister = new MainWindow();
            oregister.Show();
        }
    }
}
