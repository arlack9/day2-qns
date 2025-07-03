using qn3_ADO_sql.DAL;
using qn3_ADO_sql.DataSeeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qn3_ADO_sql;

internal class Program
{
    static void Main(string[] args)
    {

        DblInit.InitDb();

        var dal = new StudentDAL();

        dal.AllStudents();
        dal.StudentsHigherMark();
        dal.UpdateMarks(3, 70);
        dal.DeleteStudent(5);

    }
}

