

namespace Assignment5_3_1
{
    internal class Program
    {
        //You have a long flowerbed in which some of the plots are planted, and some are not. However, flowers cannot be planted in adjacent plots.
        //Given an integer array flowerbed containing 0's and 1's, where 0 means empty and 1 means not empty, and an integer n.
        //return true if n new flowers can be planted in the flowerbed without violating the no-adjacent-flowers rule and false otherwise.

        //Edgecases: length = 1 with an open plot, check 1st and last indexs without index out of range 


        // If current elem is 0 
          //and
            //If either i is equal to 0(first index) OR index of i - 1(prev index) == to 0(empty plot)
          //and
            //If either i is equal to plotLength - 1(Last index) OR index of i + 1(next index) == to 0(empty plot)
                //If all checks are true, change flowerbed[i] to 1, subtract 1 seed, and increment by 2(weve already checked the next elem in most cases)
        // Else increment by 1(flowerbed[i] == 1)
        // Return a check to see if seeds are lessthan or equal to 0

        static void Main(string[] args)
        {
            int[] flowerbed = { 0, 0, 1, 0, 0, 0 , 1};
            int seeds = 2;
            Console.WriteLine($"Can we plant {seeds} seeds?  { PlantAdjacentPlots(flowerbed, seeds) }");
        }

        static bool PlantAdjacentPlots(int[] flowerbed, int seeds)
        {
            Console.WriteLine($"Start Seeds amount: {seeds}");
            PrintArray(flowerbed);

            int plotLength = flowerbed.Length;
            int i = 0;
            while (i < plotLength && seeds > 0)
            {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == plotLength - 1 || flowerbed[i + 1] == 0))
                {
                    flowerbed[i] = 1;
                    seeds--;
                    i += 2;
                }
                else
                {
                    i++;
                }
            }

            Console.WriteLine($"End Seeds amount: {seeds}");
            PrintArray(flowerbed);
            return seeds <= 0;
        }

        static void PrintArray(int[] arr)
        {
            Console.Write("|");
            foreach (int i in arr)
            {
                Console.Write($" {i} |");
            }
            Console.WriteLine();
        }
    }
}
