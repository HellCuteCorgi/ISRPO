namespace LR1
{
    public class Class1
    {
        public void addition(float x, float y)
        {
            float summ = x + y;
            Console.Write(x + "+" + y + "=" + summ);
            Console.WriteLine();
        }

        internal void subtraction(float x, float y)
        {
            float min = x - y;
            Console.Write(x + "-" + y + "=" + min);
            Console.WriteLine();

        }

        public void generation(float x, float y)
        {
            float gen = x * y;
            Console.Write(x + "*" + y + "=" + gen);
            Console.WriteLine();

        }
        internal void degree(float x, float y)
        {
            float deg = x / y;
            Console.Write(x + "/" + y + "=" + deg);
            Console.WriteLine();

        }
    }
}