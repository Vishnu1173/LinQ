using ListViewLinq.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ListViewLinq
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Employee> list {  get; set; }

        public MainWindow()
        {

           
            InitializeComponent();
        //    list = new List<Employee>();
        //    {
        //        list.Add(new Employee { Name = txtname.Text, Id = Convert.ToInt32(txtid.Text), Age = Convert.ToInt32(txtage.Text), Gender = txtgender.Text, Salary = Convert.ToInt32(txtsalary.Text) });
        //    }
        //    datasave.ItemsSource = list;
            
        }

        private void btnsave_Click(object sender, RoutedEventArgs e)
        {
            if (list is null)
            {
                list = new List<Employee>()
                {
                    new Employee { Name = txtname.Text, Id = Convert.ToInt32(txtid.Text), Age = Convert.ToInt32(txtage.Text), Gender = txtgender.Text, Salary = Convert.ToInt32(txtsalary.Text) }
                };
            }
            //Employee employee = new Employee();
            //employee.Name = "sathish";
            //employee.Id = 12;
            //employee.Age = 23;
            //employee.Gender = "Male";
            //employee.Salary = 22000;
            //list.Add(employee);
            datasave.ItemsSource = null;
            datasave.ItemsSource = list;
            var listofdata = from value in list
                             where value.Name.Contains(txtname.Text) == true
                             select value;
            datasave.ItemsSource = null;
            datasave.ItemsSource = listofdata;
        }

        private void txtsearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var listofdata = from value in list
                             where value.Name.Contains(txtname.Text) == true
                             select value;
            datasave.ItemsSource = null;
            datasave.ItemsSource = listofdata;
        }
    }
}
//if (list is null)
//{
//    list = new List<Employee>();
//}           

//foreach (var item in list)
//{
//    datasave.Items.Add(item.Name);
//    datasave.Items.Add(item.Id);
//    datasave.Items.Add(item.Age);
//    datasave.Items.Add(item.Gender);
//    datasave.Items.Add(item.Salary);
//}
// datasave.ItemsSource = list;