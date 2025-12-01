// See https://aka.ms/new-console-template for more information

class MainClass
{
	public static void Main(string[] args) {
		int total = 0;
		
		for (int i = 1; i <= 100; i++) {
			int calculation = i * i;
			total += calculation;

			Console.WriteLine($"{i} * {i} = {calculation} | {total}");
		}
	}
}