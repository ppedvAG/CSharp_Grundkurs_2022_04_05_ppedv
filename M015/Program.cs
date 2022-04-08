using Newtonsoft.Json;
using static System.Environment;

public class Program
{
	static void Main(string[] args)
	{
		//Desktop Folder (C:\User\<Name>\Desktop)
		string desktop = GetFolderPath(SpecialFolder.DesktopDirectory);

		//Path Klasse für Pfadoperationen
		string folderPath = Path.Combine(desktop, "M015");

		if (Directory.Exists(folderPath) == false) //Checken ob Ordner existiert
			Directory.CreateDirectory(folderPath); //Ordner erstellen

		string filePath = Path.Combine(folderPath, "Test.txt");
		StreamWriter sw = new StreamWriter(filePath);
		sw.WriteLine("Test1");
		sw.WriteLine("Test2");
		sw.WriteLine("Test3");
		sw.Flush(); //Mit Flush Inhalt schreiben
		sw.Dispose(); //RAM freigeben

		using StreamWriter sw2 = new StreamWriter(filePath) { AutoFlush = true }; //using: ruft am Ende automatisch Dispose() auf
		sw2.WriteLine("Test1");
		sw2.WriteLine("Test2");
		sw2.WriteLine("Test3");

		using StreamReader sr = new StreamReader(filePath);
		string s = sr.ReadToEnd(); //Alles einlesen

		sr.BaseStream.Position = 0; //Zurücksetzen um nochmal einzulesen

		List<string> lines = new List<string>(); //Einlesen Zeile für Zeile
		string read = sr.ReadLine();
		while (!sr.EndOfStream)
		{
			lines.Add(read);
			read = sr.ReadLine();
		}

		Fahrzeug f = new Fahrzeug() { Marke = "BMW", MaxV = 250 };
		File.WriteAllText(filePath, JsonConvert.SerializeObject(f)); //Serialize: Objekt zu JSON konvertieren

		string json = File.ReadAllText(filePath);
		Fahrzeug readFahrzeug = JsonConvert.DeserializeObject<Fahrzeug>(json); //Deserialize: Objekt von JSON erstellen
	}

	public class Fahrzeug
	{
		public string Marke;

		public int MaxV;
	}
}