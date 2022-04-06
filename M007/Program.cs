public class Program
{
	static void Main(string[] args)
	{
		Person.ZaehlePerson(); //statischen Methodenaufruf
		//Person.SetVorname(""); //Methode kann nicht aufgerufen werden, da nicht statisch

		//Wertetyp
		int original = 5;
		int x = original;
		original = 10; //x bleibt auf 5

		//Referenztyp
		Person p = new Person();
		Person p2 = p;
		p.Nachname = "Test"; //Name von p2 wird auch verändert
	}

	~Program() //Destruktor wird aufgerufen wenn das Objekt vom Garbage Collector weggeworfen wird
	{
		Console.WriteLine("Program entfernt");
	}
}