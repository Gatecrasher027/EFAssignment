// See https://aka.ms/new-console-template for more information

using EntityFramework.Presentation.UI;
using Serilog;
using Serilog.Core;

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("logs/mylog.txt")
    .CreateLogger();
Log.Information("Application Started");
Log.Debug("This is a debug message");

ManageDepartment manageDepartment = new ManageDepartment();
manageDepartment.Run();

ManageEmployee manageEmployee = new ManageEmployee();
manageEmployee.Run();
