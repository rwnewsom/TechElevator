namespace Exercises.Classes
{
    public class Employee
    {

        //PROPERTIES
        public int EmployeeId { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; set; }

        public string FullName 
        { 
            get
            {
                return ($"{this.LastName}, {this.FirstName}");
            } 
        }

        public string Department { get; set; }

        public double AnnualSalary { get; private set; }

        //CONSTRUCTORS

        public Employee(int employeeId, string firstName, string lastName, double salary)
        {
            this.EmployeeId = employeeId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.AnnualSalary = salary;
        }

        //METHODS

        public void RaiseSalary(double percent)
        {
            double percentRaise = percent / 100;
            this.AnnualSalary *= (1+percentRaise);
        }

    }
}
