using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StatTemperatury
{
    public interface ITempaeratura
    {
        string godzina { get; }
        string minuta { get; }
        void AddTemp(float temp);
        void AddTemp(double temp);
        void AddTemp(int temp);
        void AddTemp(string temp);
        void skala (string temp);
    //    event TempAddedDelegate TempAdded;

        Statistics GetStatistics();
    }
}
