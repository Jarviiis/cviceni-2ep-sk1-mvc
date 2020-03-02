using Microsoft.AspNetCore.Mvc;

namespace _01_HelloWorld.Controllers
{
    public class HelloWorldController : Controller
    {
        // vyvola se pomoci URL https://localhost:<port>/HelloWorld
        // nebo take pomoci URL https://localhost:<port>/HelloWorld/Index
        public string Index()
        {
            return "Toto je defaultní akce controlleru Hello World.";
        }

        // vyvola se pomoci URL https://localhost:<port>/HelloWorld/Pozdrav
        // pocet pozdravu se zadava v URL jako HelloWorld/Pozdrav?kolikrat=
        public string Pozdrav(int kolikrat = 1)
        {
            string odpoved = "";

            for (int i = 0; i < kolikrat; i++)
                odpoved += "Ahoj, světe!\n";

            return odpoved;
        }
    }
}