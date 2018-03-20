using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;


namespace WpfApp2
{
    public class Employee
    {
        string _Age;
        int _Id;
        string _Salary;
        string _NameEmp;
        string _Dep;



        public int Id { get => this._Id; set { this._Id = value; } }
        public string NameEmp { get => this._NameEmp; set { this._NameEmp = value; } }
        public string Age { get => this._Age; set { this._Age = value; } }
        public string Salary { get => this._Salary; set { this._Salary = value; } }
        public string Dep { get => this._Dep; set { this._Dep = value; } }
        public override string ToString()
        { return $" {Id}\t{NameEmp}\t{Age}\t{Salary}\t{Dep}"; }

      

       



        

       

      
    }
    

}
