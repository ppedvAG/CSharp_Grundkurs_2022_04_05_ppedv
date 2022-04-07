public class Program
{
	static void Main2(string[] args)
	{
		Lebewesen lw = new Mensch("Hans", 27); //Mensch auf Lebewesen Variable zuweisen

		if (lw.GetType() == typeof(Lebewesen)) //GetType() holt den Laufzeittypen (Mensch)
		{
			//false
		}

		if (lw.GetType() == typeof(Mensch)) //typeof(Type): holt ein Type Objekt aus einem Klassennamen
		{
			//true
		}

		if (lw is Lebewesen) //Schauen ob Typ in Vererbungshierarchie ist
		{
			//true
		}

		if (lw is Mensch)
		{
			//true
		}


		Mensch m = new Mensch("Peter", 55);
		Lebewesen lw2 = (Lebewesen) m; //lw2 weis das m ein Mensch ist

		lw2.PrintStatus(); //PrintStatus() von Mensch

		#region Methode überschreiben mit new
		Mensch m2 = new Mensch("Gustav", 44);
		m2.PrintStatus();

		Lebewesen lw3 = (Lebewesen) m2; //new: Verbindung trennen zwischen Ober- und Unterklasse
		lw3.PrintStatus();
		#endregion
	}
}

public class Lebewesen
{
	public string Name { get; set; }

	public Lebewesen(string name)
	{
		Name = name;
	}

	public virtual void PrintStatus()
	{
		Console.WriteLine(Name);
	}
}

public class Mensch : Lebewesen
{
	public int Alter { get; set; }

	public Mensch(string name, int alter) : base(name)
	{
		Alter = alter;
	}

	public new void PrintStatus()
	{
		Console.WriteLine($"{Name} {Alter}");
	}
}