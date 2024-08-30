using System;

public class Class1
{
	public void ArrayLesson()
	{
        Console.Write("What number are you looking for? ");
        int search = Convert.ToInt32(Console.ReadLine());

        /*Array of Numbers*/
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        /*List*/
        List<int> listNumbers = new List<int>();

        int position = -1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == search)
            {
                position = i;
            }
        }
        if (position > -1)
        {
            Console.WriteLine($"Number {search} is in position {position + 1}");
        }
        else
        {
            Console.WriteLine($"Number {search} not found");
        }
    }

    public void ListLesson()
    {
        /*List*/
        List<int> listNumbers = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter a number: ")
            listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
        }
        if (position > -1)
        {
            Console.WriteLine($"Number {search} is in position {position + 1}");
        }
        else
        {
            Console.WriteLine($"Number {search} not found");
        }
    }
}
