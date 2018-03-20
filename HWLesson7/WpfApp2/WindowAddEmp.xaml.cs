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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для WindowAddEmployee.xaml
    /// </summary>
    public partial class WindowAddEmployee : Window, IView
    {
        Presenter p;
        public WindowAddEmployee()
        {
            p = new Presenter(this);
            InitializeComponent();
            btnAddEmp1.Click += delegate { p.AddEmp(NameEmp, Age, Salary); };
        }


        public string Age { get => EmpAge.Text; set => EmpAge.Text = value.ToString(); }
        public int EmpId { get; set; }
        public string Salary { get => EmpSalary.Text; set => EmpSalary.Text = value.ToString(); }
        public string NameEmp { get => EmpName.Text; set => EmpName.Text = value; }
        public string EmpDep { get; set; }
        public int DepId { get; set; }
        public string Dep { get; set; }
    }
}
