class Program
{
	static void Main()
	{
		Console.WriteLine("input number for factorial");
		int number = int.Parse(Console.ReadLine());
		long factorial = Factorial(number);
		Console.WriteLine($"the result is {factorial}");
	}
	static long Factorial(int x)
	{
		if (x <= 1)
		{
			return 1;
		}
		else 
		{
			return x*Factorial(x-1);
		}
	}
}