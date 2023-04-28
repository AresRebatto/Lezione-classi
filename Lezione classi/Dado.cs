using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_classi
{
    class Dado
    {
        //attributi
        private string _colore { get; set; }
        private int _numeroFacce;
        static private int n = 4; //Utilizzare static implica che l'attributo si riferisca alla classe e non all'oggeto. E' come avere una costante

        public Dado(string colore, int nFacce)//Costruttore. Ha lo stesso nome della classe
        {
            this._colore = colore; //this si riferisce all'oggetto corrente: evita incomprensioni dovute ai nomi
            this._numeroFacce = nFacce;
        }

        public Dado() //Overload: la possibilità di creare più costruttori a patto che la firma(ovvero i paramentri richiesti) siano differenti
        {
            this._colore = "undefined";
            this._numeroFacce = 6;
        }

        //I metodi sono azioni che possono compiere gli oggetti
        public int LancioDadi()
        {
            Random rnd = new Random();
            return rnd.Next(1, _numeroFacce+1);//1 a 6. rnd.Next(1, 7);
        }  

        static public void Numero()
        { Console.WriteLine(n); }


        

    }

}
