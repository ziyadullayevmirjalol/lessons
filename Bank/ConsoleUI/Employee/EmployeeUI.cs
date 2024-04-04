using Bank.Interfaces;
using Bank.Models;

namespace Bank.ConsoleUI.Employee
{
    internal class EmployeeUI
    {
        IEmployeeService EmployeeService;
        public void toCreate()
        {
            string Cfirstname = string.Empty;
            string Clastname = string.Empty;
            Position Cposition = new Position();
            string CpassportNumber = string.Empty;

            Console.WriteLine("------ (Employee Service Menu) Create Employee ------\n");
            Console.Write("Enter your Firstname: ");
            Cfirstname = Console.ReadLine();

            Console.Write("Enter your Lastname: ");
            Clastname = Console.ReadLine();
        CreEnter:
            Console.Write("Enter your position: \n 1. Casheer,\n 2. Administrator,\n 3. Operator,\n 3. Guard\n [1-4]: ");
            string CtoPosiotion = Console.ReadLine();
            switch (CtoPosiotion)
            {
                case "1":
                    Cposition = Position.Casheer;
                    break;
                case "2":
                    Cposition = Position.Administrator;
                    break;
                case "3":
                    Cposition = Position.Operator;
                    break;
                case "4":
                    Cposition = Position.Guard;
                    break;
                default:
                    Console.WriteLine("Invalid input!. Press any key to re-enter...");
                    Console.ReadLine();
                    goto CreEnter;
                    break;
            }
            Console.Write("Enter your Passport Number: ");
            CpassportNumber = Console.ReadLine();

            EmployeeModel CemployeeModel = new EmployeeModel();
            CemployeeModel.FirstName = Cfirstname;
            CemployeeModel.LastName = Clastname;
            CemployeeModel.PassportNumber = CpassportNumber;
            CemployeeModel.Position = Cposition;

            EmployeeService.Create(CemployeeModel);
        }
        public void toUpdate()
        {
            int Uid = 0;
            string Ufirstname = string.Empty;
            string Ulastname = string.Empty;
            Position Uposition = new Position();
            string UpassportNumber = string.Empty;

            Console.WriteLine("------ (Employee Service Menu) Update Employee ------\n");
            Console.Write("Enter your ID: ");
            string UtoId = Console.ReadLine();
            if (UtoId != "")
            {
                Uid = int.Parse(UtoId);
            }
            Console.Write("Enter your Firstname: ");
            Ufirstname = Console.ReadLine();

            Console.Write("Enter your Lastname: ");
            Ulastname = Console.ReadLine();
        UreEnter:
            Console.Write("Enter your position: \n 1. Casheer,\n 2. Administrator,\n 3. Operator,\n 3. Guard\n [1-4]: ");
            string UtoPosition = Console.ReadLine();
            switch (UtoPosition)
            {
                case "1":
                    Uposition = Position.Casheer;
                    break;
                case "2":
                    Uposition = Position.Administrator;
                    break;
                case "3":
                    Uposition = Position.Operator;
                    break;
                case "4":
                    Uposition = Position.Guard;
                    break;
                default:
                    Console.WriteLine("Invalid input!. Press any key to re-enter...");
                    Console.ReadLine();
                    goto UreEnter;
                    break;
            }
            Console.Write("Enter your Passport Number: ");
            UpassportNumber = Console.ReadLine();

            EmployeeModel UemployeeModel = new EmployeeModel();
            UemployeeModel.FirstName = Ufirstname;
            UemployeeModel.LastName = Ulastname;
            UemployeeModel.PassportNumber = UpassportNumber;
            UemployeeModel.Position = Uposition;

            EmployeeService.Update(UemployeeModel);
        }
        public void toDelete()
        {
            int Did = 0;

            Console.WriteLine("------ (Employee Service Menu) Delete Employee ------\n");
            Console.Write("Enter your ID: ");
            string UtoId = Console.ReadLine();
            if (UtoId != "")
            {
                Did = int.Parse(UtoId);
            }

            EmployeeModel DemployeeModel = new EmployeeModel();
            DemployeeModel.ID = Did;

            var found = EmployeeService.Delete(DemployeeModel);
            if (found == false)
            {
                Console.WriteLine($"Employee with ID {Did} not found!");
            }
        }
        public void toGetAll()
        {
            List<EmployeeModel> EmployeeList = new List<EmployeeModel>();
            EmployeeList = EmployeeService.GetAll();

            foreach (EmployeeModel emp in EmployeeList)
            {
                Console.WriteLine("______________________________________________________");
                Console.WriteLine($"Employee's ID is {emp.ID}");
                Console.WriteLine($"Employee's Firstname is {emp.FirstName}");
                Console.WriteLine($"Employee's Firstname is {emp.LastName}");
                Console.WriteLine($"Employee's Position is {emp.Position}");
                Console.WriteLine($"Employee's Passport Number is {emp.PassportNumber}");
                Console.WriteLine("______________________________________________________\n");
            }
        }
        public void toGetByID()
        {
            int GiD = 0;

            EmployeeModel found = new EmployeeModel();

            found = EmployeeService.GetByID(GiD);
            if (found == null)
            {
                Console.WriteLine($"Employee with ID {GiD} not found!");
            }
        }
        public void toGetByPassportNumber()
        {
            string GpassportNumber = string.Empty;

            EmployeeModel found = new EmployeeModel();

            found = EmployeeService.GetByPassportNumber(GpassportNumber);
            if (found == null)
            {
                Console.WriteLine($"Employee with Passport Number {GpassportNumber} not found!");
            }
        }
        public void toGetByPosition()
        {
            string Gposition = string.Empty;

            EmployeeModel found = new EmployeeModel();

            found = EmployeeService.GetByPassportNumber(Gposition);
            if (found == null)
            {
                Console.WriteLine($"Employees with Position {Gposition} not found!");
            }
        }
    }
}
