namespace OvverloadOPerator
{
    public class Programm
    {
        public static void Main()
        {
            //Employee humanOne = new Employee { Salary = 800 };
            //humanOne.Salary = humanOne.Salary + 200;            
            //humanOne.ShowSalary();

            //Employee humanTwo = new Employee { Salary = 1200 };
            //humanTwo.Salary = humanTwo.Salary - 100;
            //humanTwo.ShowSalary();

            //if (humanOne.Salary == humanTwo.Salary)
            //{
            //    Console.WriteLine("You have equal salaries");
            //}
            //else
            //    Console.WriteLine("You have not equal salaries");

            //if (humanOne.Salary < humanTwo.Salary)
            //{
            //    Console.WriteLine("Salary EmployeeTwo is more");
            //}
            //else if (humanOne.Salary > humanTwo.Salary)
            //{
            //    Console.WriteLine("Salary EmployeeOne is more");
            //}
            //else { Console.WriteLine("Salary is equals"); }

            //------------------------------------------------------------------------------------------------

            //City cityOne = new City { Population = 10000 };
            //cityOne.Population = cityOne.Population + 400;
            //cityOne.ShowPopulation();

            //City cityTwo = new City { Population = 12000 };
            //cityTwo.Population = cityTwo.Population - 1000;
            //cityTwo.ShowPopulation();

            //if (cityOne.Population == cityTwo.Population)
            //{
            //    Console.WriteLine("You have equal Population");
            //}
            //else
            //    Console.WriteLine("You have not equal Population ");

            //if (cityOne.Population < cityTwo.Population)
            //{
            //    Console.WriteLine("Population EmployeeTwo is more");
            //}
            //else if (cityOne.Population > cityTwo.Population)
            //{
            //    Console.WriteLine("Population cityOne is more");
            //}
            //else { Console.WriteLine("Population is equals"); }

            //------------------------------------------------------------------------------------------------

            CreditCard firstCredit = new CreditCard { MoneyOnCredit = 400 };
            firstCredit.MoneyOnCredit = firstCredit.MoneyOnCredit + 50;
            firstCredit.ShowMoneyOnCredit();

            CreditCard secondCredit = new CreditCard { MoneyOnCredit = 1200 };
            secondCredit.MoneyOnCredit = secondCredit.MoneyOnCredit - 100;
            secondCredit.ShowMoneyOnCredit();

            Console.WriteLine("Enter you CVC code:");
            int cvcCode = Convert.ToInt32(Console.ReadLine());
            if (firstCredit.CVC == cvcCode)
            {
                Console.WriteLine("You CVC code is correct");
            }
            else
                Console.WriteLine("You CVC code is wrong");

            if (firstCredit.MoneyOnCredit < secondCredit.MoneyOnCredit)
            {
                Console.WriteLine("Money on CreditTwo is more");
            }
            else if (firstCredit.MoneyOnCredit > secondCredit.MoneyOnCredit)
            {
                Console.WriteLine("Money on CreditOne is more");
            }
            else { Console.WriteLine("Money is equals on both creditcard"); }


        }
    }
}