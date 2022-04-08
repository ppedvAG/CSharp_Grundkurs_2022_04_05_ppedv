public class Program
{
	static void Main2(string[] args)
	{
		List<string> staedte = new List<string>(); //Erstellung von Liste mit Typ
		staedte.Add("Hamburg"); //Elemente hinzufügen
		staedte.Add("Wien");
		staedte.Add("Berlin");
		staedte.Add("Köln");

		Console.WriteLine(staedte[1]); //Element angreifen wie bei einem Array

		Console.WriteLine(staedte.Count); //Count statt Length wie beim Array

		staedte[1] = "Dresden"; //Wie beim Array auf Liste zugreifen mit [stelle]

		staedte.Remove("Hamburg"); //Stadt entfernen, höhere Elemente werden nachgeschoben

		foreach (string s in staedte) //Liste iterieren
		{
			Console.WriteLine(s);
		}

		staedte.Sort();

		Stack<string> staedteStack = new Stack<string>(); //Stapel
		staedteStack.Push("Berlin");
		staedteStack.Push("Wien");
		staedteStack.Push("Köln");
		staedteStack.Push("Hamburg");

		Console.WriteLine(staedteStack.Peek()); //Oberstes Element anschauen (Hamburg)

		Console.WriteLine(staedteStack.Pop()); //Oberstes Element entfernen und zurückgeben

		Queue<string> staedteQueue = new Queue<string>();
		staedteQueue.Enqueue("Berlin");
		staedteQueue.Enqueue("Wien");
		staedteQueue.Enqueue("Köln");
		staedteQueue.Enqueue("Hamburg");

		Console.WriteLine(staedteQueue.Peek()); //Vorderstes Element anschauen (Berlin)

		Console.WriteLine(staedteQueue.Dequeue()); //Vorderstes Element entfernen und zurückgeben

		//Dictionary: Liste von Key-Value Pairs
		//Jeder Key muss eindeutig sein
		Dictionary<string, int> einwohnerzahlen = new Dictionary<string, int>();
		einwohnerzahlen.Add("Wien", 2_000_000);
		einwohnerzahlen.Add("Berlin", 3_650_000);
		einwohnerzahlen.Add("Paris", 2_160_000);

		if (einwohnerzahlen.ContainsKey("Wien"))
			Console.WriteLine(einwohnerzahlen["Wien"]); //Value holen wie bei Array mit dem Key

		Console.WriteLine(einwohnerzahlen.ContainsValue(2_000_000)); //true oder false

		foreach (KeyValuePair<string, int> kv in einwohnerzahlen) //Dictionary iterieren mit KeyValuePair<KeyTyp,ValueTyp>
		{
			Console.WriteLine($"Die Stadt {kv.Key} hat {kv.Value} Einwohner");
		}
	}

	public static void PrintType<T>() where T : Program
	{
		Console.WriteLine(typeof(T).Name);
	}
}