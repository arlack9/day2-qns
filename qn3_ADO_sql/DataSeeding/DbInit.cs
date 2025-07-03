using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using qn3_ADO_sql.Shared;

namespace qn3_ADO_sql.DataSeeding
{
    public static class DblInit
    {
        public static void InitDb()
        {
            using (SqlConnection conn = new SqlConnection(Constants.MasterConnection))
            {
                string createDb = "if db_id('q3') is null create database q3";
                SqlCommand cmd = new SqlCommand(createDb, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            using (SqlConnection conn = new SqlConnection(Constants.DbConnection))
            {
              
                string tableseed = @"if object_id('Students', 'U') is null 
                                    create table Students(Id INT PRIMARY KEY, Name NVARCHAR(60), Dept NVARCHAR(60), Marks INT);
                                    
                                    insert into Students (Id,Name,Dept,Marks) values (1,'Anu','CS',80), (2,'Arya','DA',78),(3,'Arjun','CS',45),
                                    (4,'Kashyap','MI',90),(5,'Mrinal','BIO',60);
                                    ";

                SqlCommand cmd = new SqlCommand(tableseed, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("Db Seeded");
        }
    }
}

