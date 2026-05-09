using Generate_tests;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Employee employee = new Employee(
    experience: 6,
    position: "developer",
    workedHours: 160);

employee.ShowInfo();