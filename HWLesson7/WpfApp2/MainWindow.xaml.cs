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
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.ComponentModel;

namespace WpfApp2
{
   
    public partial class MainWindow : Window, IView
    {

      


       

         Presenter p;
        public MainWindow()
        {

            InitializeComponent();
            p = new Presenter(this);

            //Model.FillListEmp();
            //GetData.GetDataEmp();
            lbEmployee.ItemsSource = Model.items;
           
            //Model.FillListDep();
            lbDepartament.ItemsSource = Model.dep;


            //btnAddEmp.Click += delegate { p.AddEmp();};
            //btnAddDep.Click += delegate { p.AddDep(); };
            //btnRemoveEmpfromModel.Click += delegate { p.RemoveEmpFromModel(); };
            //btnRemoveDepfromModel.Click += delegate { p.RemoveDepFromModel(); };


            btnRemoveEmp.Click += delegate { p.RemoveEmp(lbEmployee.SelectedIndex); };
            btnRemoveDep.Click += delegate { p.RemoveDep(lbDepartament.SelectedIndex); };
            lbDepartament.SelectionChanged += delegate { p.MoveEmp(lbEmployee.SelectedIndex, lbDepartament.SelectedIndex); lbEmployee.Items.Refresh(); };
            lbEmployee.SelectionChanged += delegate { lbDepartament.SelectedIndex= p.GetActualDep(lbEmployee.SelectedIndex); };
            

        }

       

        public string Age { get ; set; }
        public int EmpId { get => lbEmployee.SelectedIndex;}
        public string Salary { get; set; }
        public string NameEmp { get; set; }
        public string EmpDep { get; set; }
        public int DepId { get => lbDepartament.SelectedIndex;}
        public string Dep { get; set; }
        public int CurrentEmpIndex;
        public int CurrentDepIndex;

        

        private void btnAddEmp_Click(object sender, RoutedEventArgs e)
        {
            WindowAddEmployee windowaddemp = new WindowAddEmployee();
            windowaddemp.ShowDialog();

        }
        private void btnAddDep_Click(object sender, RoutedEventArgs e)
        {
            WindowAddDepartament windowadddep = new WindowAddDepartament();
            windowadddep.ShowDialog();

        }

    
    }


}
