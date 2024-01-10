namespace OvverloadOPerator
{
    public class City
    {
        public int Population {  get; set; }
        public static City operator +(City firstVariable, int secondVariable)
        {
            return new City { Population = firstVariable.Population + secondVariable };
        }
        public static City operator -(City firstVariable, int secondVariable)
        {
            return new City { Population = firstVariable.Population - secondVariable };
        }
        public static bool operator ==(City firstVariable, City secondVariable)
        {
            if (firstVariable.Population != secondVariable.Population)
                return false;
            else
                return true;
        }
        public static bool operator !=(City firstVariable, City secondVariable)
        {
            return !(firstVariable.Population == secondVariable.Population);
        }
        public static bool operator >(City firstVariable, City secondVariable)
        {
            return firstVariable.Population > secondVariable.Population;
        }
        public static bool operator <(City firstVariable, City secondVariable)
        {
            return !(firstVariable.Population < secondVariable.Population);
        }

        public void ShowPopulation()
        {
            Console.WriteLine(Population);
        }
    }
}
