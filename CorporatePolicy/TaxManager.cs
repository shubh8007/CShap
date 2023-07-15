namespace CorporatePolicy
{
    public class TaxManager
    {



        public  double serviceTax(double amount)
        {

            double factor = 0.8;

            return (amount*factor);
            Console.WriteLine("Service tAx is deducted...");
        }

        public double incomeTax(double amount)
        {

            double factor = 0.82;
            return (amount *factor);
            Console.WriteLine("Income tax is deducted.........");
        }

    }
}