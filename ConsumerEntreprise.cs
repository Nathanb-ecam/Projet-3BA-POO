namespace Consommateur{
    class ConsumerEntreprise : IConsumer
    {
        private string entrepriseName;
        private int ElectricConsommation;
        public ConsumerEntreprise(string entreprise, int conso){
            this.entrepriseName = entreprise;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation(){
            Console.WriteLine("L'entreprise {0} a une consommation électrique de {1}",entrepriseName,ElectricConsommation);
        }
    }
}