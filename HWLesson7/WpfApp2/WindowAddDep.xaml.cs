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
    /// Логика взаимодействия для WindowAddDepartament.xaml
    /// </summary>
    public partial class WindowAddDepartament : Window, IView
    {
        Presenter p;
        public WindowAddDepartament()
        {
            p = new Presenter(this);
            InitializeComponent();
            btnAddDep1.Click += delegate { p.AddDep(Dep); };
        }


        public string Age { get; set; }
        public int EmpId { get; set; }
        public string Salary { get; set; }
        public string NameEmp { get; set; }
        public string EmpDep { get; set; }
        public int DepId { get; set; }
        public string Dep { get => DepName.Text; set => DepName.Text = value; }
    }
}
