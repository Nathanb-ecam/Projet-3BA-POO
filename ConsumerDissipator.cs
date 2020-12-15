using System;
namespace Consommateur{
    class ConsumerDissipator : IConsumer{
        private string securityMachine;
        private int maxConsommation;
        public ConsumerDissipator(string name, int conso){
            this.securityMachine = name;
            this.maxConsommation = conso;
        }
        public virtual String GetElectricalConsommation(){
            Console.WriteLine("La  {0} a une consommation électrique de {1}",securityMachine,maxConsommation);
        }
    }
}