using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RechnerTest
{
	[TestClass]
	public class UnitTest1
	{
		Rechner rechner;

		[TestInitialize] //Wird vor den Tests aufgerufen
		public void ErzeugeRechner()
		{
			rechner = new Rechner();
		}

		[TestCleanup] //Wird nach den Tests ausgeführt
		public void Cleanup()
		{
			System.Console.WriteLine("Tests zu Ende");
			rechner = null;
		}

		[TestCategory("Erfolgstest")] //Kategorien, im Test Explorer sichtbar
		[TestMethod]
		public void TesteAddiere()
		{
			int actual = rechner.Addiere(10, 20);
			Assert.AreEqual(30, actual); //Jeder Test muss mit Assert ein Ergebnis liefern
		}

		[TestCategory("Fehlertest")]
		[TestMethod]
		public void TesteAddiereFehler() //Fehlertest
		{
			int x = rechner.Addiere(10, 20);
			Assert.AreNotEqual(10, x);
		}
	}
}