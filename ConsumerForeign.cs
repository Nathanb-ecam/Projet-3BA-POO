using System;
namespace Consommateur{
    class ConsumerForeign : IConsumer{
        private string name;
        private int ElectricDemand;
        public ConsumerForeign(string n, int e){
            this.name = n;
            this.ElectricDemand = e;
        }
        public virtual String GetElectricalConsommation(){
            Console.WriteLine("La  {0} a une consommation électrique de {1}",name,ElectricDemand);
        }
    }
}