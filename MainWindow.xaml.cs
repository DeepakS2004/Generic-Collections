using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Generic_Collections
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> student;
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void btnenter_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["logo"] = new SolidColorBrush(Colors.SkyBlue);
            //Student obj = new Student();
            //obj.Name = txtname.Text.ToString();
            //obj.Age = Convert.ToInt32(txtage.Text);
            //obj.Email = txtemail.Text.ToString();
            //obj.Salary = Convert.ToInt32(txtsalary.Text);

            //if(student == null)
            //{
            //    student = new List<Student>();
            //}
            //student.Add(obj);


            //if (student.Count > 1)
            //{
            //    Data odata = new Data(student);
            //    odata.Show();
            //}
            //student = new List<Student>();
            //string folderpath = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            //string fullpath = System.IO.Path.Combine(folderpath, "JSSoft", "userdata.txt");

            //if (File.Exists(fullpath))
            //{
            //    string value = File.ReadAllText(fullpath);
            //  List<Student> values = JsonConvert.DeserializeObject<List<Student>>(value);

            //    if (value.Count() > 0) 
            //    {
            //        student.AddRange(values);
            //    }
            //}
            
            //Student std  = new Student();
            //std.Name =txtname.Text;
            //std.Age = Convert.ToInt32(txtage.Text);
            //std.Salary = Convert.ToInt32(txtsalary.Text);
            //std.Email = txtemail.Text;
            //student.Add(std);
            ////student.Add(new Student { Name = "ram", Age = 21, Email = "ts@", Salary = 908876 });
          
            //string js = JsonConvert.SerializeObject(student);
          
            //if (Directory.Exists(folderpath + "//JSSoft"))
            //{
            //    File.WriteAllText(fullpath, js);
            //}
            //else
            //{
            //    Directory.CreateDirectory(folderpath + "//JSSoft");
            //    File.WriteAllText(fullpath,js);
            //}
            //txtage.Clear();
            //txtsalary.Clear();
            //txtname.Clear();
            //txtemail.Clear();

            //Stack<Student> stack = new Stack<Student>();
            //stack.Push(new Student { Name = "ram", Age = 21, Email = "ts@", Salary = 908876 });
            //stack.Pop();

            //Queue<Student> queue = new Queue<Student>();
            //queue.Enqueue(new Student { Name = "ram", Age = 21, Email = "ts@", Salary = 908876 });
            //queue.Dequeue();

            //Dictionary<string, Student> dict = new Dictionary<string, Student>();
            //dict.Add("101", new Student { Name = "ram", Age = 21, Email = "ts@", Salary = 908876 });
            //foreach (KeyValuePair<string, Student> kvp in dict)
            //{
            //    MessageBox.Show(kvp.ToString());
            //}
           
            //SortedDictionary<string,Student> sdict = new SortedDictionary<string, Student>();
            //sdict.Add("106", new Student { Name = "am", Age = 21, Email = "ts@", Salary = 9076 });
            //sdict.Add("101", new Student { Name = "ram", Age = 21, Email = "ts@", Salary = 908876 });
           

            //HashSet<string> list = new HashSet<string>();
            //list.Add("ram");
            //list.Add("raj");

            //LinkedList<string> link = new LinkedList<string>();
            //link.AddFirst("ram");
            //link.AddFirst("raju");
            //link.AddLast("arun");
            //LinkedListNode<string> node = link.First;
            //link.AddAfter(node, "Deepak");
            //link.AddBefore(node, "sow");

                }
    }
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

    }
}