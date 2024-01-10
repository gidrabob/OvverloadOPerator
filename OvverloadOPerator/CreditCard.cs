namespace OvverloadOPerator
{
    public class CreditCard
    {
        public int MoneyOnCredit {  get; set; }
        public int CVC { get; set; } = 369;
        public static CreditCard operator +(CreditCard firstVariable, int secondVariable)
        {
            return new CreditCard { MoneyOnCredit = firstVariable.MoneyOnCredit + secondVariable };
        }
        public static CreditCard operator -(CreditCard firstVariable, int secondVariable)
        {
            return new CreditCard { MoneyOnCredit = firstVariable.MoneyOnCredit - secondVariable };
        }
        public static bool operator ==(CreditCard firstVariable, int secondVariable)
        {
            if (firstVariable.CVC != secondVariable)
                return false;
            else
                return true;
        }
        public static bool operator !=(CreditCard firstVariable, int secondVariable)
        {
            return !(firstVariable.CVC == secondVariable);
        }
        public static bool operator >(CreditCard firstVariable, CreditCard secondVariable)
        {
            return firstVariable.MoneyOnCredit > secondVariable.MoneyOnCredit;
        }
        public static bool operator <(CreditCard firstVariable, CreditCard secondVariable)
        {
            return !(firstVariable.MoneyOnCredit < secondVariable.MoneyOnCredit);
        }

        public void ShowMoneyOnCredit()
        {
            Console.WriteLine(MoneyOnCredit);
        }
    }
}
