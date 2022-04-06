namespace M006
{
	public class Program
	{
		public int Test; //Feld in Objekt

		static void Main(string[] args)
		{
			Program p = new Program();
			p.Print(); //Zugriff auf die Print Methode
			p.Test = 5; //Zugriff auf das Test Feld

			Person person = new Person(); //Objekt erstellen mit new
			person.SetVorname("Hans"); //Set-Methode
			Console.WriteLine(person.GetVorname()); //Get-Methode

			person.Nachname = "Peter";
			Console.WriteLine(person.Nachname);

			//person.Gehalt = 5;

			Person p2 = new Person("Hans", "Peter"); //Konstruktor mit 2 Parametern
		}

		public void Print() //Methode in Objekt
		{
			Console.WriteLine("Test");
		}
	}

	namespace Unternamespace //Unternamespace im Obernamespace drinnen
	{

	}
}

namespace M006.UnternamespaceAusserhalb //Unternamespace außerhalb
{

}