namespace Consommateur{
    class ConsumerCity : IConsumer
    {
        private string cityName;
        private int ElectricConsommation;
        public ConsumerCity(string city, int consom){
            this.cityName = city;
            this.ElectricConsommation = consom;
        }
        public virtual String GetElectricalConsommation(){
            Console.WriteLine("La ville est : {0} , elle a une consommation électrique de {1}",cityName,ElectricConsommation);
        } 
    }
}