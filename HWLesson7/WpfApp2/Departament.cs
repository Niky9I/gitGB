using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Windows;


namespace WpfApp2
{
    public class Departament
    {

      
        int _Id;
        string _Dep;

        public string Dep
        {
            get => this._Dep;
            set { this._Dep = value; }
        }

        public int Id
        {
            get => this._Id;
            set { this._Id = value; }
        }

        public override string ToString()
        { return $"{Id}\t{Dep}\t"; }




    }
}
