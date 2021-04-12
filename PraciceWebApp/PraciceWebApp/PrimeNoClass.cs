namespace PraciceWebApp
{
    public class PrimeNoClass
    {
        public PrimeNoClass(int num)
        {
            number = num;
        }

        public int number { get; set; }

        public string GetValue()
        {
            int flag = 0;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                return "Prime";
            else
                return "Composite";
        }
    }
}