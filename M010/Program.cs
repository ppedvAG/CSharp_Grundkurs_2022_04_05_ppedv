public class Program
{
	static void Main(string[] args)
	{
		IArbeit arbeiter = new Mensch
		{
			Gehalt = 2000,
			Job = "Softwareentwickler"
		};
		arbeiter.Lohnauszahlung(); //IArbeit Methode

		ITeilzeitArbeit teilzeitArbeiter = (ITeilzeitArbeit) arbeiter;
		teilzeitArbeiter.Lohnauszahlung(); //Hier auf ITeilzeitArbeit Methode zugreifen
	}
}

public class Mensch : IArbeit, ITeilzeitArbeit //Interface implementiert wie bei Vererbung
{
	private int gehalt;

	public int Gehalt 
	{ 
		get => gehalt; 
		set => gehalt = value; 
	}

	private string job;

	public string Job 
	{ 
		get => job; 
		set => job = value;
	}

	void IArbeit.Lohnauszahlung() //Hier spezifisch Interface angeben, da beide Interfaces eine gleichnamige Methode haben
	{
		Console.WriteLine($"Dieser Mensch hat ein Gehalt von {Gehalt} mit {IArbeit.Wochenstunden} Stunden für den Job {Job} verdient"); //IArbeit.Wochenstunden verwendet
	}

	void ITeilzeitArbeit.Lohnauszahlung()
	{
		Console.WriteLine($"Dieser Mensch hat ein Gehalt von {Gehalt} mit {ITeilzeitArbeit.Wochenstunden} Stunden für den Job {Job} verdient");
	}
}

public interface IArbeit //Interface Deklaration
{
	static int Wochenstunden = 40;

	int Gehalt { get; set; }

	string Job { get; set; } //Properties ohne Access Modifier

	void Lohnauszahlung(); //"Abstrakte" Methode, kein Body

	void Lohnauszahlung2() { } //Body in Interface möglich aber Bad Practice
}

public interface ITeilzeitArbeit
{
	static int Wochenstunden = 20;

	void Lohnauszahlung();
}