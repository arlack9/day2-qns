using qn2_linq_dictionary.DataSeeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qn2_linq_dictionary.LinqOps;

internal class EmployeeLinq
{
    private EmployeeData _ed;
    public EmployeeLinq(EmployeeData ed)
    {
        _ed = ed;  
    }

    public void EmployeeAvgSalary()
    {
        var empDict=_ed.EmployeeDataSeeding();
        //debug 
        //foreach(var items in empDict)
        //{
        //    Console.WriteLine($"{empDict}");
        //}

        //LINQ age > 20
        var ageList = empDict.Values.Where(e => e.Age > 25).ToList();

        Console.WriteLine("##################################");
        Console.WriteLine("Employees with age > 25");
        Console.WriteLine("##################################");
        foreach (var item in ageList)
        {
            Console.WriteLine($"{item.Name} {item.Age} yr old");
        }

        //LINQ employees names descending order

        var nameList = empDict.Values.OrderByDescending(e => e.Name).ToList();
        Console.WriteLine("##################################");
        Console.WriteLine("Employees with name descending order");
        Console.WriteLine("##################################");

        foreach (var item in nameList)
        {
            Console.WriteLine($"{item.Name} {item.Age} yr old");
        }

        //LINQ FirstOrDefault
        Console.WriteLine("##################################");
        Console.WriteLine("First or Default Employee");
        Console.WriteLine("##################################");

        var defaultList = empDict.Values.FirstOrDefault();
        

        Console.WriteLine($"{defaultList.Name} {defaultList.Age} yr old");

     
        //Console.WriteLine($"{defaultList}");



    }
}
