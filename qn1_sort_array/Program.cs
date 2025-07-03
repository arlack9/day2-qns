using FluentAssertions.Common;
using qn1_sort_list.List;
using System.Transactions;
using Microsoft.Extensions.DependencyInjection;



ServiceCollection services = new();

//Registering DI
services.AddTransient<ListSort>();
services.AddTransient<ListInput>();


//Interface not used here concrete classes and Set ListInput as main entry class.
var app = services.BuildServiceProvider().GetRequiredService<ListInput>();


app.UserMenu();


