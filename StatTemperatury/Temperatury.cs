using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTemperatury
{
    public class Temperatury : ITempaeratura
    {
        public string godzina => throw new NotImplementedException();

        public string minuta => throw new NotImplementedException();

      //  public event TempAddedDelegate TempAdded;
       

        public void AddTemp(float temp)
        {
            throw new NotImplementedException();
        }

        public void AddTemp(double temp)
        {
            throw new NotImplementedException();
        }

        public void AddTemp(int temp)
        {
            throw new NotImplementedException();
        }

        public void AddTemp(string temp)
        {
            throw new NotImplementedException();
        }

        public Statistics GetStatistics()
        {
            throw new NotImplementedException();
        }

        public void skala(string temp)
        {
            throw new NotImplementedException();
        }
    }
}
