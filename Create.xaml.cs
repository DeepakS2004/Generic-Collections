using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Xml.Linq;

namespace Generic_Collections
{
    /// <summary>
    /// Interaction logic for Create.xaml
    /// </summary>
    public partial class Create : Page
    {
        List<Diary> diary;
        public Create(string Username)
        {
            InitializeComponent();
            lblusername.Content = Username;
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            diary = new List<Diary>();
            string folderpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string fullpath = System.IO.Path.Combine(folderpath, "JSSoft", "Dairycontent.txt");

            if (File.Exists(fullpath))
            {
                string value = File.ReadAllText(fullpath);
                List<Diary> values = JsonConvert.DeserializeObject<List<Diary>>(value);

                if (value.Count() > 0)
                {
                    diary.AddRange(values);
                }
            }

            Diary odairy = new Diary();
            odairy.Username = lblusername.Content.ToString();
            odairy.Date = dtp.SelectedDate.Value.ToShortDateString();
            odairy.Content = txtcontent.Text;
            diary.Add(odairy);
            string js = JsonConvert.SerializeObject(diary);

            if (Directory.Exists(folderpath + "//JSSoft"))
            {
                File.WriteAllText(fullpath, js);
            }
            else
            {
                Directory.CreateDirectory(folderpath + "//JSSoft");
                File.WriteAllText(fullpath, js);
            }
            txtcontent.Clear();
           
        }
    }
    public class Diary
    {
        public string Username { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
    }
}
