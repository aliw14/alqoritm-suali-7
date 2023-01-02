namespace alqoritm_suali_7;
class Program
{
    static void Main(string[] args)
    {

        int count = 0;
        int[] numbers = { 8, 9, 12, 4, 10 };
        for (int i = 0; i < numbers.Length; i++)

            if (numbers[i] % 7 == 1 || numbers[i] % 7 == 2 || numbers[i] % 7 == 5) 
               

            {
                count++;

            }
         Console.WriteLine(count);



    }
}

