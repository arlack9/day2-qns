//Employee Linq

using Microsoft.Extensions.DependencyInjection;
using qn2_linq_dictionary.DataSeeding;
using qn2_linq_dictionary.LinqOps;
using qn2_linq_dictionary.Models;

ServiceCollection services = new();


//Registering DI 
services.AddTransient<EmployeeData>();
services.AddTransient<EmployeeLinq>();

var employeeApp = services.BuildServiceProvider().GetRequiredService<EmployeeLinq>();

employeeApp.EmployeeAvgSalary();