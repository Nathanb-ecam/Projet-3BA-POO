using System;
namespace Consommateur{
public static class ConsumerFactory{
        public static IConsumer Build(string t,string name,int conso)
        {
                switch(t)
                {
                    case "city":
                        return new ConsumerCity(name,conso);
                    case "country":
                        return new ConsumerCountry(name,conso);
                    case "entreprise":
                        return new ConsumerEntreprise(name,conso);
                    case "dissipator":
                        return new ConsumerDissipator(name,conso);
                    case "foreign":
                        return new ConsumerForeign(name, conso);

                }
        }
        
    }
}