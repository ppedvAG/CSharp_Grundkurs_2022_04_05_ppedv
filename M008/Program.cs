public class Program
{
	static void Main(string[] args)
	{
		Mensch m = new Mensch("Hans", 27);
		m.Name = "Hans"; //Name wird vererbt von Lebewesen
		m.PrintStatus();

		Lebewesen l = new Lebewesen("Gustav");
	}
}

public class Lebewesen
{
	public string Name { get; set; }

	public Lebewesen(string name)
	{
		Name = name;
	}

	public virtual void PrintStatus() //virtual: kann überschrieben werden, muss aber nicht
	{
		Console.WriteLine(Name);
	}
}

public sealed class Mensch : Lebewesen //sealed: Vererbung verhindern
{
	//Alle Felder und Methoden übernommen (Name, PrintName())

	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name) //Konstruktoren verketten: base um etwas in der Oberklasse aufzurufen
	{
		Alter = alter;
	}

	//Methode in Lebewesen überschrieben (überschrieben mit override)
	//Sealed verhindert weiteres überschreiben
	public override sealed void PrintStatus()
	{
		Console.WriteLine($"{Name} {Alter}");
	}
}

//public class Kind : Mensch
//{

//}