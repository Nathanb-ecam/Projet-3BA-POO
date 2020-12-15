using System;
namespace Consommateur{
    class ConsumerCountry : IConsumer
    {
        private string countryName;
        private int ElectricConsommation;
        public ConsumerCountry(string name, int conso){
            this.countryName = name;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation(){
            Console.WriteLine("La  {0} a une consommation électrique de {1}",countryName,ElectricConsommation);
        }
    }
}