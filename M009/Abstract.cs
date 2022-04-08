namespace M009;

public class Abstract
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch("Hans", 33);
		Hund h = new Hund("Bello");

		List<Lebewesen> lebewesens = new List<Lebewesen>(); //Unterschiedliche Unterklassen in die selbe Liste geben
		lebewesens.Add(m);
		lebewesens.Add(h);
		
		foreach (Lebewesen l in lebewesens)
		{
			l.PrintStatus(); //Abstrakte Methode bei jedem Objekt ausführen
		}
	}
}

public abstract class Lebewesen //abstract um Objekt Erstellung zu verhindern
{
	/// <summary>
	/// Der Name des Lebewesens
	/// </summary>
	public string Name { get; set; }

	public Lebewesen(string name)
	{
		Name = name;
	}

	/// <summary>
	/// Gibt den Status des Lebewesens aus
	/// </summary>
	public abstract void PrintStatus(); //abstrakte Methode ohne Body (mit ; am Ende)
}

public class Mensch : Lebewesen //Strg + . auf Klassenname um alle abstrakten Member zu implementieren
{
	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name)
	{
		Alter = alter;
	}

	/// <summary>
	/// Gibt Name und Alter aus
	/// </summary>
	public override void PrintStatus() //Unterklasse muss abstrakte Methode überschreiben
	{
		Console.WriteLine($"Mensch: {Name} {Alter}");
	}
}

public class Hund : Lebewesen
{
	/// <summary>
	/// Der Standardkonstruktor des Lebewesens
	/// </summary>
	/// <param name="name">Der Name des Lebewesens</param>
	public Hund(string name) : base(name)
	{

	}

	public override void PrintStatus()
	{
		Console.WriteLine($"Hund: {Name}");
	}
}