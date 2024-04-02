using ServiceContracts;

namespace Services
{
    public class CitiesService : ICitiesService , IDisposable
    {
        private List<string> _cities;

        public CitiesService() { 
            _cities= new List<string>() { 
            "INDIA",
            "INDORE",
            "BHOPAL",
            "JABALPUR",
            "HARDA"
            };

            
        }

        public void Dispose()
        {
            //To Do: add logic to close db connection
        }

        public List<string> GetCities() { 
            return _cities;
        }
    }
}
