using Bank.Models;

namespace Bank.Interfaces;

public interface IEmployeeService
{
    void Create(EmployeeModel employee);
    bool Update(EmployeeModel employee);
    bool Delete(EmployeeModel employee);
    List<EmployeeModel> GetAll();
    EmployeeModel GetByID(int id);
    EmployeeModel GetByPassportNumber(string passportNumber);
    List<EmployeeModel> GetByPosition(Position position);
}
