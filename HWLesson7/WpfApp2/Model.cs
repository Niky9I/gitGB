using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace WpfApp2
{
    
public class Model
    {
        public static DB_EmpDepEntities db = new DB_EmpDepEntities();

       




        public static ObservableCollection<Departament> dep = new ObservableCollection<Departament>();
        public static ObservableCollection<Employee> items = new ObservableCollection<Employee>();
        
        public void FillEmpList()
        {
            items.Add(new Employee() {Id=db.TableEmp });
        }



        // Начальное заполнение списка сотрудников




        //Начальное заполнение списка департаментов


        // Добавление и удаление сотрудников
        public void Button_AddEmp(string n, string a, string s)
        { db.TableEmp.Add(new TableEmp() { NameEmp = n, Age = a, Salary = s }); db.SaveChanges(); }
        public void Button_RemoveEmp(int i) { if (i>-1) items.RemoveAt(i); }


        // Добавление и удаление департаментов
        public void Button_AddDep(string d) {dep.Add(new Departament() { Id = dep.Count + 1 ,  Dep = d }); }
        public void Button_RemoveDep(int i)
        {
            if (i > -1)
            {
                for (int e = 0; e < items.Count; e++)
                {
                    if (items[e].Dep == dep[i].Dep) { items[e].Dep = null; }
                }
                if (i > -1) dep.RemoveAt(i);
            }
        }

        //Перевод сотрудника в департамент
        public void MoveToDep(int e, int d) { if ((e > -1)&&(d>-1)) items[e].Dep = dep[d].Dep; }

        //Отображение актуального департамента для сотрудника
        public int ActualDep(int e)
        {
            int n = -1;
            if (e > -1)
            {
                if (items[e].Dep == null) return -1;
                
                for (int d = 0; d < dep.Count; d++)
                {
                    if (dep[d].Dep == items[e].Dep)
                        n = d;

                };
            }
            return n;
        }
        //public void RemoveEmpFromModel()
        //{
        //    items.RemoveAt(0);
        //}

        //public void RemoveDepFromModel()
        //{
        //    dep.RemoveAt(0);
        //}

    }
}
