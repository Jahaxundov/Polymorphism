
using ClassWork26._07._23;
using ClassWork26._07._23.Controllers;
using ClassWork26._07._23.Services;
using ClassWork26._07._23.Services.Interfaces;

//Bird bird = new();
//bird.Eating();

//Animal animal = new Bird();

//IPerson person = new Person();
//person.GetName();

//Employee employee = new Employee();
//Console.WriteLine(employee.GetAdress());

//ICustomMathService customMathService = new CustomMathService();
////customMathService.Sum(4, 7);
//Console.WriteLine(customMathService.GetNumbersOfSum(new int[] { 1, 2, 3, 4, 5 }));

//IEmployeeService employeeServices = new EmployeeService();
//employeeServices.Search("a");

AccountController accountController = new AccountController();
accountController.Login();
 