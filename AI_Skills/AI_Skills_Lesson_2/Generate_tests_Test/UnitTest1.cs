using Xunit;
using Generate_tests;

public class EmployeeTests
{
    [Fact]
    public void CalculateSalary_DeveloperWith6YearsExperience_ReturnsCorrectSalary()
    {
        // Arrange
        Employee employee = new Employee(
            experience: 6,
            position: "developer",
            workedHours: 160);

        // Act
        decimal result = employee.CalculateSalary();

        // Assert
        decimal expected = 103684m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateSalary_ManagerWith10YearsExperience_ReturnsCorrectSalary()
    {
        // Arrange
        Employee employee = new Employee(
            experience: 10,
            position: "manager",
            workedHours: 160);

        // Act
        decimal result = employee.CalculateSalary();

        // Assert
        decimal expected = 80500m;

        Assert.Equal(expected, result);
    }

    [Fact]
    public void CalculateSalary_UnknownPosition_UsesDefaultRate()
    {
        // Arrange
        Employee employee = new Employee(
            experience: 1,
            position: "cleaner",
            workedHours: 100);

        // Act
        decimal result = employee.CalculateSalary();

        // Assert
        decimal expected = 24150m;

        Assert.Equal(expected, result);
    }
}