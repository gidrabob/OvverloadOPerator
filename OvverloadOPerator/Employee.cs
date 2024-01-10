namespace OvverloadOPerator
{
    public class Employee
    {        
        public int Salary { get; set; }
        public static Employee operator +(Employee firstVariable, int secondVariable)
        {
            return new Employee { Salary = firstVariable.Salary + secondVariable };
        }
        public static Employee operator -(Employee firstVariable, int secondVariable)
        {
            return new Employee { Salary = firstVariable.Salary - secondVariable };
        }
        public static bool operator == (Employee firstVariable, Employee secondVariable)
        {
            if (firstVariable.Salary != secondVariable.Salary) 
                return false;
            else
                return true;
        }
        public static bool operator !=(Employee firstVariable, Employee secondVariable)
        {
            return !(firstVariable.Salary == secondVariable.Salary);
        }
        public static bool operator > (Employee firstVariable, Employee secondVariable)
        {
                return firstVariable.Salary > secondVariable.Salary;
        }
        public static bool operator < (Employee firstVariable, Employee secondVariable)
        {
            return !(firstVariable.Salary < secondVariable.Salary);
        }

        public void ShowSalary()
        {
            Console.WriteLine(Salary);
        }
    }
}
