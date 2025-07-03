using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace qn1_sort_list.List;

internal class ListInput
{
    List<string> stringList = new();

    private ListSort _sort;
  
    private string _inputstring="";
 
    public ListInput(ListSort sort)
    {
        _sort = sort;
    }
    public void UserMenu()
    {
        Console.WriteLine("\n####################################");
        Console.WriteLine("Demonstrate string sorting");
        Console.WriteLine("####################################");

        do
        {
          
            Console.WriteLine("\n####################################");
            Console.WriteLine("Please Enter some strings, (press / to sort)");
            _inputstring =Console.ReadLine()??"";

            if (_inputstring == "/")
            {
                break;
            }
            stringList.Add(_inputstring);

            showList();

        }

        while (_inputstring != "/");


        Console.WriteLine("\n####################################");
        Console.WriteLine("Sorted List");
        Console.WriteLine("####################################");
        var sortedList=_sort.SortItems(stringList);
        
        foreach (var item in sortedList)
        {
            Console.WriteLine($"\n{item}");
        }


    }

    public void showList()
    {
        Console.WriteLine("\n####################################");
        Console.WriteLine("Entered strings so far");
        Console.WriteLine("####################################");
        foreach (var item in stringList)
        {
            Console.WriteLine($" ,{item}");
        }
    }
}
