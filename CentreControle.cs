using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtInfoBA3_2
{
    [Serializable]
    public abstract class CentreControle
    {

    }

    public interface IWeatherPublisher
    {
        void AddSubscriber(IWeatherObserver subscriber);
        void RemoveSubscriber(IWeatherObserver subscriber);
        void NotifyObservers();
    }

    public interface IWeatherObserver
    {
        void Update(float temp, float wind);
    }

    public interface IDisplayElement
    {
        void Display();
    }

    public class WeatherData : IWeatherPublisher
    {
        private IList<IWeatherObserver> observers = new List<IWeatherObserver>();
        private float temperature;
        private float wind;

        public WeatherData()
        {
            observers = new List<IWeatherObserver>();
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.Update(temperature, wind);
            }
        }

        public void AddSubscriber(IWeatherObserver subscriber)
        {
            observers.Add(subscriber);
        }

        public void RemoveSubscriber(IWeatherObserver subscriber)
        {
            if (observers != null && observers.Count() > 0)
            {
                observers.Remove(subscriber);
            }
        }

        public void SetMeasurements(float temperature, float wind)
        {
            this.temperature = temperature;
            this.wind = wind;

            NotifyObservers();
        }
        // peut etre un getter?
    }

    public class CurrentConditionsDisplay : IWeatherObserver, IDisplayElement
    {
        private float temperature;
        private float wind;
        private IWeatherPublisher _weatherData;

        public CurrentConditionsDisplay(IWeatherPublisher weatherData)
        {
            _weatherData = weatherData;

            weatherData.AddSubscriber(this);
        }

        public void Update(float temperature, float wind)
        {
            this.temperature = temperature;
            this.wind = wind;

            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temperature + " degrees celcius and" + wind + " knots windstrength");
        }
    }

    public interface ICentral
    {
        String GetInfo();

        void Connected(string a);

        string getSort();

        string getInfo2();
    }

    interface IProductionFlexible
    {
        int ProdUp();
        int ProdDown();
    }




    [Serializable]
    class CentralGaz : ICentral, IProductionFlexible
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private string sort;
        private List<string> connexionGaz = new List<string>();

        public CentralGaz(string z, int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
            this.sort = z;
        }

        public void Connected(string a)
        {
            connexionGaz.Add(a);
        }

        public string getSort()
        {
            return sort;
        }

        public int ProdUp()
        {
            return (this.production += 10);
        }

        public int ProdDown()
        {
            return (this.production -= 10);
        }

        public virtual String GetInfo()
        {
            return String.Format("Centrale Gaz: produis {0} W/s , cout: {1} euro/W , polue: {2} co2/s ", production, coutProd, co2prod);
        }

        public string getInfo2()
        {
            string res = " ";
            foreach (var unElem in connexionGaz)
            {
                res += " - " + unElem + " - ";
            }
            return ("La centrale Gaz est connecté à" + res + "par cable de 750W/max");
        }
    }

    interface IDepandantMeteo
    {
        int MeteoFavorable();
        int MeteoDefavorable();
        int MeteoNoEff();

    }

    [Serializable]
    class CentralEolien :  ICentral, IDepandantMeteo, IWeatherObserver
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private float temperature;
        private float wind;
        private string sort;
        public List<string> connexionEolien = new List<string>();

        public CentralEolien(string z, int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
            this.sort = z;
        }

        public void Connected(string a)
        {
            connexionEolien.Add(a);
        }

        public string getSort()
        {
            return sort;
        }

        public void Update(float temperature, float wind)
        {
            this.temperature = temperature;
            this.wind = wind;

            if (wind <= 50 & wind >= 5)
            {
                MeteoFavorable();
            }
            else if (wind < 90 & wind > 50)
            {
                MeteoNoEff();
            }

            else
            {
                MeteoDefavorable();
            }
        }

        public int MeteoFavorable()
        {
            return production += 10;
        }

        public int MeteoDefavorable()
        {
            if (production <= 10)
            {
                return production;
            }
            else
            {
                return production -= 10;
            }
        }

        public int MeteoNoEff()
        {
            return production += 0;
        }


        public virtual String GetInfo()
        {
            return String.Format("Centrale Eolienne: produis {0} W/s , cout: {1} euro/W , polue: {2} co2/s ", production, coutProd, co2prod);
        }

        public string getInfo2()
        {
            string res = " ";
            foreach (var unElem in connexionEolien)
            {
                res += " - " + unElem +  " - ";
            }
            return ("La centrale Eolienne est connecté à" + res + "par cable de 750W/max");
        }
    }

    [Serializable]
    class CentralSolaire : ICentral, IWeatherObserver
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private float temperature;
        private float wind;
        private string sort;
        private List<string> connexionSolaire = new List<string>();

        public CentralSolaire(string z, int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
            this.sort = z;
        }

        public void Connected(string a)
        {
            connexionSolaire.Add(a);
        }

        public string getSort()
        {
            return sort;
        }

        public void Update(float temperature, float wind)
        {
            this.temperature = temperature;
            this.wind = wind;

            if (temperature <= 50 & temperature >= 5)
            {
                MeteoFavorable();
            }
            else if (temperature < 90 & temperature > 50)
            {
                MeteoNoEff();
            }

            else
            {
                MeteoDefavorable();
            }
        }

        public int MeteoFavorable()
        {
            return production += 10;
        }
        public int MeteoDefavorable()
        {
            if (production <= 10)
            {
                return production;
            }
            else
            {
                return production -= 10;
            }
        }
        public int MeteoNoEff()
        {
            return production += 0;
        }

        public virtual String GetInfo()
        {
            return String.Format("Centrale Solaire: produis {0} W/s , cout: {1} euro/W , polue: {2} co2/s ", production, coutProd, co2prod);
        }
        public string getInfo2()
        {
            string res = " ";
            foreach (var unElem in connexionSolaire)
            {
                res += " - " + unElem + " - ";
            }
            return ("La centrale Solaire est connecté à" + res + "par cable de 750W/max");
        }
    }

    [Serializable]
    class CentralAcheteur : ICentral
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private string sort;
        private List<string> connexionAcheteur = new List<string>();

        public CentralAcheteur(string z, int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
            this.sort = z;

        }

        public void Connected(string a)
        {
            connexionAcheteur.Add(a);
        }

        public string getSort()
        {
            return sort;
        }

        public virtual String GetInfo()
        {
            return String.Format("Centrale Acheteur: produis {0} W/s , cout: {1} euro/W , polue: {2} co2/s ", production, coutProd, co2prod);
        }

        public string getInfo2()
        {
            string res = " ";
            foreach (var unElem in connexionAcheteur)
            {
                res += " - " + unElem + " - ";
            }
            return ("Les acheteurs sont est connecté à" + res + "par cable de 750W/max");
        }
    }

    [Serializable]
    class CentralNucl : ICentral
    {
        private int production;
        private int coutProd;
        private int co2prod;
        private string sort;
        private List<string> connexionNucl = new List<string>();

        public CentralNucl(string z, int a, int b, int c)
        {
            this.production = a;
            this.coutProd = b;
            this.co2prod = c;
            this.sort = z;
        }
        public void Connected(string a)
        {
            connexionNucl.Add(a);
        }

        public string getSort()
        {
            return sort;
        }

        public virtual String GetInfo()
        {
            return String.Format("Centrale Nuclaire: produis {0} W/s , cout: {1} euro/W , polue: {2} co2/s ", production, coutProd, co2prod);
        }

        public string getInfo2()
        {
            string res = " ";
            foreach (var unElem in connexionNucl)
            {
                res += " - " + unElem + " - ";
            }
            return ("La centrale Nuclaire est connecté à" + res + "par cable de 750W/max");
        }
    }

    public class CentralFactory
    {
        public static ICentral Build(string res, int a, int b, int c)
        {

            switch (res.ToLower())
            {
                case "gaz":
                    return new CentralGaz(res,a, b, c);
                case "nuclaire":
                    return new CentralNucl(res,a,b,c);
                case "eolien":
                    return new CentralEolien(res,a, b, c);
                case "solaire":
                    return new CentralSolaire(res,a,b,c);
                default:
                    return new CentralAcheteur(res,a,b,c);

            }
        }
    }
    public interface IConsumer
    {
        String GetElectricalConsommation();
    }

    public class ConsumerFactory
    {
        public static IConsumer Build(string t, string name, int conso)
        {
            switch (t.ToLower())
            {
                case "city":
                    return new ConsumerCity(name, conso);
                case "country":
                    return new ConsumerCountry(name, conso);
                case "entreprise":
                    return new ConsumerEntreprise(name, conso);
                case "dissipator":
                    return new ConsumerDissipator(name, conso);
                default:
                    return new ConsumerForeign(name, conso);

            }
        }

    }

    [Serializable]
    class ConsumerCity : IConsumer
    {
        private string cityName;
        private int ElectricConsommation;

        public ConsumerCity(string city, int consom)
        {
            this.cityName = city;
            this.ElectricConsommation = consom;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La ville est : {0} , elle a une consommation électrique de {1}", cityName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerCountry : IConsumer
    {
        private string countryName;
        private int ElectricConsommation;
        public ConsumerCountry(string name, int conso)
        {
            this.countryName = name;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", countryName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerDissipator : IConsumer
    {
        private string securityMachine;
        private int maxConsommation;
        public ConsumerDissipator(string name, int conso)
        {
            this.securityMachine = name;
            this.maxConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", securityMachine, maxConsommation);
        }
    }

    [Serializable]
    class ConsumerEntreprise : IConsumer
    {
        private string entrepriseName;
        private int ElectricConsommation;
        public ConsumerEntreprise(string entreprise, int conso)
        {
            this.entrepriseName = entreprise;
            this.ElectricConsommation = conso;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("L'entreprise {0} a une consommation électrique de {1}", entrepriseName, ElectricConsommation);
        }
    }

    [Serializable]
    class ConsumerForeign : IConsumer
    {
        private string name;
        private int ElectricDemand;
        public ConsumerForeign(string n, int e)
        {
            this.name = n;
            this.ElectricDemand = e;
        }
        public virtual String GetElectricalConsommation()
        {
            return String.Format("La  {0} a une consommation électrique de {1}", name, ElectricDemand);
        }
    }




}
