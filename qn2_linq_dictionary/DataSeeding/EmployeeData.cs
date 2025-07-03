using qn2_linq_dictionary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using qn2_linq_dictionary.Models;

namespace qn2_linq_dictionary.DataSeeding;



internal class EmployeeData
{

    public Dictionary<int,Employee> EmployeeDataSeeding()
    {
         var employees = new Dictionary<int, Employee>
                        {
                            {1,new Employee(){Id=1001, Name="Akku", Age=30}},
                            {2,new Employee(){Id=1002,Name="Arun",Age=40}},
                            {3,new Employee(){Id=1003,Name="Anu",Age=25}},
                            {4,new Employee(){Id=1004,Name="Arya",Age=30}},
                            {5,new Employee(){Id=1005,Name="Ash",Age=290}}
                        };

        return employees;

    }



}
