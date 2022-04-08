namespace M011;

public class Linq
{
	static void Main(string[] args)
	{
		#region Einfaches Linq
		List<int> ints = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

		Console.WriteLine(ints.Average());
		Console.WriteLine(ints.Min());
		Console.WriteLine(ints.Max());

		Console.WriteLine(ints.Sum());

		Console.WriteLine(ints.First()); //Erstes Element der Liste, Exception wenn Liste leer
		Console.WriteLine(ints.FirstOrDefault()); //null zurück wenn die Liste leer ist

		Console.WriteLine(ints.Last()); //Letztes Element der Liste, Exception wenn Liste leer
		Console.WriteLine(ints.LastOrDefault()); //null zurück wenn die Liste leer ist
		#endregion

		List<Fahrzeug> fahrzeuge = new List<Fahrzeug>
		{
			new Fahrzeug(251, FahrzeugMarke.BMW),
			new Fahrzeug(274, FahrzeugMarke.BMW),
			new Fahrzeug(146, FahrzeugMarke.BMW),
			new Fahrzeug(208, FahrzeugMarke.Audi),
			new Fahrzeug(189, FahrzeugMarke.Audi),
			new Fahrzeug(133, FahrzeugMarke.VW),
			new Fahrzeug(253, FahrzeugMarke.VW),
			new Fahrzeug(304, FahrzeugMarke.BMW),
			new Fahrzeug(151, FahrzeugMarke.VW),
			new Fahrzeug(250, FahrzeugMarke.VW),
			new Fahrzeug(217, FahrzeugMarke.Audi),
			new Fahrzeug(125, FahrzeugMarke.Audi)
		};

		#region Vergleich Linq Schreibweisen
		//Alle BMWs aus der Liste holen
		List<Fahrzeug> bmws = new List<Fahrzeug>();
		foreach (Fahrzeug f in fahrzeuge)
			if (f.Marke == FahrzeugMarke.BMW)
				bmws.Add(f);

		//Standard-Linq: SQL-ähnliche Schreibweise (alt)
		List<Fahrzeug> bmwsSQL = (from auto in fahrzeuge 
								  where auto.Marke == FahrzeugMarke.BMW 
								  select auto).ToList();

		//Methodenkette: Neueste Schreibweise, kürzer und übersichtlicher
		List<Fahrzeug> bmwsNeu = fahrzeuge.Where(fzg => fzg.Marke == FahrzeugMarke.BMW).ToList();
		#endregion

		#region Erweitertes Linq
		//Höchste Geschwindigkeit von allen Autos
		Console.WriteLine(fahrzeuge.Max(auto => auto.MaxGeschwindigkeit));

		//Sortieren nach Geschwindigkeit (schnell -> langsam)
		List<Fahrzeug> schnellLangsam = fahrzeuge.OrderByDescending(auto => auto.MaxGeschwindigkeit).ToList();

		//Alle Automarken
		List<FahrzeugMarke> marken = fahrzeuge.Select(auto => auto.Marke).ToList();

		//Jede Marke einmal
		List<FahrzeugMarke> distinct = marken.Distinct().ToList();

		//Alle Geschwindigkeiten aufsummieren
		int summeGeschwindigkeiten = fahrzeuge.Sum(auto => auto.MaxGeschwindigkeit);

		//Durchschnittsgeschwindigkeit von allen VWs
		double avgVW = fahrzeuge.Where(auto => auto.Marke == FahrzeugMarke.VW).Average(auto => auto.MaxGeschwindigkeit);

		//Schauen ob alle Autos über 200 fahren können
		bool alleAutosSchnell = fahrzeuge.All(auto => auto.MaxGeschwindigkeit > 200);

		//Schauen ob mindestens ein Fahrzeug in der Liste ist
		bool mindestensEinFahrzeug = fahrzeuge.Any();

		//Schauen ob mindestens ein Auto über 300 fahren kann
		bool einAuto300 = fahrzeuge.Any(auto => auto.MaxGeschwindigkeit > 300);

		//Gruppieren nach Automarke (BMW, Audi, VW + die entsprechenden Autos)
		List<IGrouping<FahrzeugMarke, Fahrzeug>> groupedFahrzeug = fahrzeuge.GroupBy(auto => auto.Marke).ToList();

		//Autos aus Gruppe herausholen
		List<Fahrzeug> bmwGroup = groupedFahrzeug[0].Select(auto => auto).ToList();
		#endregion

		//Liste in gleich große Teile unterteilen
		List<Fahrzeug[]> pagedFahrzeug = fahrzeuge.Chunk(5).ToList();

		//Liste ausgeben
		string output = "";
		foreach (Fahrzeug f in fahrzeuge)
			output += $"Marke: {f.Marke}, Maximalgeschwindigkeit: {f.MaxGeschwindigkeit}\n";
		Console.WriteLine(output);

		Console.WriteLine(fahrzeuge.Aggregate("", (aggregator, auto) => aggregator + $"Marke: {auto.Marke}, Maximalgeschwindigkeit: {auto.MaxGeschwindigkeit}\n"));

		//Überspringe die ersten 5 Fahrzeuge und nimm dann 5 Fahrzeuge
		List<Fahrzeug> skipTake = fahrzeuge.Skip(5).Take(5).ToList();
	}

	public class Fahrzeug
	{
		public int MaxGeschwindigkeit;

		public FahrzeugMarke Marke;

		public Fahrzeug(int v, FahrzeugMarke fm)
		{
			MaxGeschwindigkeit = v;
			Marke = fm;
		}
	}

	public enum FahrzeugMarke
	{
		BMW,
		Audi,
		VW
	}
}
