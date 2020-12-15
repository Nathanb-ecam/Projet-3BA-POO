using System;

namespace Consommateur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory des consommateurs");
            ConsumerFactory bxl = ConsumerFactory("city","bruxelles",120);
            Console.WriteLine(bxl.GetElectricalConsommation());

            ConsumerFactory belgium = ConsumerFactory("country","Belgique",249);
            Console.WriteLine(belgium.GetElectricalConsommation());

            ConsumerFactory starkIndustries = ConsumerFactory("country","Belgique",249);
            Console.WriteLine(starkIndustries.GetElectricalConsommation());

            ConsumerFactory securityDissipator = ConsumerFactory("dissipator","SecurityMachine",250);
            Console.WriteLine(securityDissipator.GetElectricalConsommation());

            ConsumerFactory france = ConsumerFactory("foreign","France",25);
            Console.WriteLine(france.GetElectricalConsommation());

        }
        

        public interface IConsumer
        {
            String GetElectricalConsommation();
        }
    
    }
}
