using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool isDrivable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }

        public void MakeHonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }
    }
}
