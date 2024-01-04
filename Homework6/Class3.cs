namespace Homework6
{
    internal class Class3
    {
        public void output()
        {
            double fee = 10000;
            double target = 20000;
            double rate = 0.07;
            int years = 0;

            while (fee < target)
            {
                fee += fee * rate;
                years++;
            }

            Console.WriteLine($"It will take {years} years for the fee to reach {target}.");

        }

    }
}
