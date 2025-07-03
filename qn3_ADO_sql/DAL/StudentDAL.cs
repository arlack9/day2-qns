using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using qn3_ADO_sql.Shared;

namespace qn3_ADO_sql.DAL;

public class StudentDAL
{
    public void AllStudents()
    {
        using SqlConnection conn = new SqlConnection(Constants.DbConnection);
        string query = "select * from students";
        SqlCommand cmd = new SqlCommand(query, conn);
        conn.Open();

        var reader = cmd.ExecuteReader();
        Console.WriteLine("\nAll Students \n");
        while (reader.Read())
        {
            Console.WriteLine($"{reader["Id"]}, {reader["Name"]}, {reader["Dept"]}, {reader["Marks"]}");
        }
    }

    public void StudentsHigherMark()
    {
        using SqlConnection conn = new SqlConnection(Constants.DbConnection);
        string query = "select * from Students where Marks>80";
        SqlCommand cmd = new SqlCommand(query, conn);

        conn.Open();
        var reader = cmd.ExecuteReader();


        

        Console.WriteLine("##################################");
        Console.WriteLine("\nStudents with Marks > 80\n");
        Console.WriteLine("##################################");

        while (reader.Read())
        {
            Console.WriteLine($"{reader["Name"]} - {reader["Marks"]}");
        }
    }

    public void UpdateMarks(int id, int newMarks)
    {
        using SqlConnection conn = new SqlConnection(Constants.DbConnection);
        string query = "update Students set Marks = @Marks where Id = @Id";
        SqlCommand cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Marks", newMarks);
        cmd.Parameters.AddWithValue("@Id", id);
        conn.Open();
        cmd.ExecuteNonQuery();

        Console.WriteLine("##################################");
        Console.WriteLine($"Student {id} new marks updated {newMarks} successfully.");

        Console.WriteLine("##################################");
    }

    public void DeleteStudent(int id)
    {
        using SqlConnection conn = new SqlConnection(Constants.DbConnection);
        string query = " delete from Students where Id = @Id";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);
        conn.Open();
        cmd.ExecuteNonQuery();
        Console.WriteLine("##################################");
        Console.WriteLine($"Student Deleted Id:{id}");
        Console.WriteLine("##################################");
        
    }
}
