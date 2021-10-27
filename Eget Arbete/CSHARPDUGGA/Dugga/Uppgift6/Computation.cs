using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dugga.Uppgift6
{
    abstract class Computation
    {
        protected int Compute(int x, int y)
        {
            return x;
        }
    }
}



//6B.Skapa en abstract metod i klassen Computation.Metoden ska heta Compute och
//den ska gå att nå från ärvande klasser men inte utifrån.Metoden ska ta två
//parametrar av typen int och returnera en int. (1p)

//6C.Skapa en klass som heter AdditionComputation. Klassen ska ärva från den
//abstracta klassen Computation. Implementationen av den abstracta metoden ska
//addera de två värdena som skickas till metoden och returnera summan. (2p)