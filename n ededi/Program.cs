namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tam eded daxil edin");
            int number=Convert.ToInt32(Console.ReadLine());

            if(number<0)
            {
                number= -number;
            }
            if (number == 0)
            {
                Console.WriteLine("Ededin mertebe sayi:1"); 
                return;
            }
            int countnumber = 0;
            while (number > 0)
            {
                number/= 10;
                countnumber++;
            }

            Console.WriteLine("Ededin mertebe sayi; " + countnumber);
        }
    }
}
