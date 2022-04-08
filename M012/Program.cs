public class Program
{
	static void Main(string[] args)
	{
		try
		{
			int x = int.Parse(Console.ReadLine());
			if (x == 5)
				throw new TestException("Ein Fehler ist aufgetreten"); //throw: Exception werfen
		}
		catch (FormatException ex) //Falsche Eingabe fangen
		{
			Console.WriteLine("Eingabe ist keine Zahl");
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.StackTrace);
		}
		catch (OverflowException ex) //Eingabe zu groß fangen
		{
			Console.WriteLine("Zahl zu groß");
			Console.WriteLine(ex.Message);
		}
		catch (TestException ex) //Eigene Exception fangen
		{
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.StackTrace);
		}
		catch (Exception ex) //Alle anderen Fehler
		{
			Console.WriteLine("Anderer Fehler");
			Console.WriteLine(ex.Message);
		}
		finally //Finally Block wird immer am Ende ausgeführt
		{
			Console.WriteLine("Finally Block ausgeführt");
		}
	}
}