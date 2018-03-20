using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp2
{
    public interface IView
    {
        string Age { get; set; }
        int EmpId { get; }
        string Salary { get; set; }
        string NameEmp { get; set; }
        string EmpDep { get; set; }
        int DepId { get;}
        string Dep { get; set; }

    }

   
}
