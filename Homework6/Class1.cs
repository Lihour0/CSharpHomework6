namespace Homework6
{
    internal class Class1
    {
        int sum;
        int inputNum;
        public void input()

        {
            do
            {
                inputNum = int.Parse(Console.ReadLine());
                sum += inputNum;
            } while (inputNum != 0);


        }
        public void output()
        {
            Console.WriteLine(sum);

        }
    }
}
