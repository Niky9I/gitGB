using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    public class Presenter
    {
        Model model;
        IView view;

        public Presenter(IView View)
        {
            this.view = View;
            model = new Model();
        }

        public void AddEmp(string n, string a, string s) {model.Button_AddEmp(n,a,s);}
        public void AddDep(string d) { model.Button_AddDep(d); }
        public void RemoveEmp(int i) { model.Button_RemoveEmp(i); }
        public void RemoveDep(int i) { model.Button_RemoveDep(i); }
        public void MoveEmp(int e, int d) { model.MoveToDep(e, d); }
        public int GetActualDep(int e) { return model.ActualDep(e); }
        //public void RemoveEmpFromModel() { model.RemoveEmpFromModel(); }
        //public void RemoveDepFromModel() { model.RemovepFromModel(); }

    }
}
