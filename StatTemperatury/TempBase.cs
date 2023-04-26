using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StatTemperatury
{
    public abstract class TempBase : ITempaeratura
    {
        public string godzina => throw new NotImplementedException();

        public string minuta => throw new NotImplementedException();

        public delegate void TempAddedDelegate(object sender, EventArgs args);
        public abstract event TempAddedDelegate TempAdded;


        public TempBase(string godzina, string minuta) 
        {
            this.Godzina = godzina;
            this.Minuta = minuta;
        }
        public string Godzina { get; private set; } 

        public string Minuta { get; private set; }

       

        public abstract void AddTemp(float temp);

        public abstract void AddTemp(double temp);


        public abstract void AddTemp(int temp);


        public abstract void AddTemp(string temp);

        public abstract Statistics GetStatistics();
        

        public void skala(string temp)
        {
            throw new NotImplementedException();
        }
    }
}
