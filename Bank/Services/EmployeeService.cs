using Bank.Interfaces;
using Bank.Models;

namespace Bank.Services;

public class EmployeeService : IEmployeeService
{
    List<EmployeeModel> employees;
    public EmployeeService()
    {
        employees = new List<EmployeeModel>();
    }
    public void Create(EmployeeModel employee)
    {
        employees.Add(employee);
    }
    public bool Delete(EmployeeModel employee)
    {
        bool foundEmployee = false;
        foreach (EmployeeModel emp in employees)
        {
            if (emp.ID == employee.ID)
            {
                employees.Remove(emp);
                foundEmployee = true;
            }
        }
        return foundEmployee;
    }
    public List<EmployeeModel> GetAll()
    {
        return employees;
    }
    public EmployeeModel GetByID(int id)
    {
        EmployeeModel found = null;
        foreach (EmployeeModel emp in employees)
        {
            if (emp.ID != id)
            {
                found = emp;
            }
        }
        return found;
    }
    public EmployeeModel GetByPassportNumber(string passportNumber)
    {
        EmployeeModel found = null;
        foreach (EmployeeModel emp in employees)
        {
            if (emp.PassportNumber == passportNumber)
            {
                found = emp;
            }
        }
        return found;
    }
    public List<EmployeeModel> GetByPosition(Position position)
    {
        List<EmployeeModel> employeesByPosition = new List<EmployeeModel>();
        foreach (EmployeeModel emp in employees)
        {
            if (emp.Position == position)
            {
                employeesByPosition.Add(emp);
            }
        }
        return employeesByPosition;
    }
    public bool Update(EmployeeModel employee)
    {
        bool found = false;
        foreach (EmployeeModel emp in employees)
        {
            if (emp.ID == employee.ID)
            {
                if (employee.FirstName != string.Empty)
                {
                    emp.FirstName = employee.FirstName;
                }
                if (emp.LastName != string.Empty)
                {
                    emp.LastName = employee.LastName;
                }
                if (emp.PassportNumber != string.Empty)
                {
                    emp.PassportNumber = employee.PassportNumber;
                }
                if (employee.Position != Position.None)
                {
                    emp.Position = employee.Position;
                }
                found = true;
                break;
            }
        }
        return found;
    }
}


