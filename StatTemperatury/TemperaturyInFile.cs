using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatTemperatury
{
    public class TemperaturyInFile : TempBase
    {
        private List<float> temperatury = new List<float>();
        private const string fileName = "temperatury.txt";

        public override event TempAddedDelegate TempAdded;

        public TemperaturyInFile(string godzina, string minuta) : base(godzina, minuta)
        {
        }

        //  public override event TempAddedDelegate TempAdded;

        public override void AddTemp(float temp)
        {
            if (temp >= 0 && temp <= 1000)
            {
                using (var writer = File.AppendText(fileName))
                {

                    writer.WriteLine(temp);
                }
                if (TempAdded != null)
                {
                    TempAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid valute of temperature");
            }
        }

        public override void AddTemp(double temp)
        {
            //if (float.TryParse(temp, out float result))
            //{
            //    this.AddTemp(result);
            //}
            //else
            //{
            //    Console.WriteLine("double nie dokonano konwersji");
            //}
           //throw new NotImplementedException();
        }

        public override void AddTemp(int temp)
        {
            throw new NotImplementedException();
        }

        public override void AddTemp(string temp)
        {
            //throw new NotImplementedException();
            if (float.TryParse(temp, out float result))
            {
                this.AddTemp(result);

            }
            else
            {
                Console.WriteLine("nie dokonano konwersji");
            }
        }

        public override Statistics GetStatistics()
        {
            var tempFromFile = this.ReadTempFromFile();
            var result = this.CountStatistics(tempFromFile);

            return result;
        }
        private List<float> ReadTempFromFile()
        {
            var temps = new List<float>();
            if (File.Exists($"{fileName}"))

            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = (float.Parse(line));
                        temps.Add(number);
                        line = reader.ReadLine();
                    }

                }
            }
            return temps;
        }

        private Statistics CountStatistics(List<float> temps)
        {
            var statistics = new Statistics();

            foreach (var temp in temps)
            {
                ;
                statistics.AddTemp(temp);
                if (temp >= 0)
                {

                }

            }
            return statistics;
        }
    }
}

