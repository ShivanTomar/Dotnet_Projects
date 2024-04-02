using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        //Private Field
        private readonly List<Country> _countries;

        //Constructor to inislize the field
        public CountriesService()
        { 
            _countries = new List<Country>();
        }
        public CountryResponse AddCountry(CountryAddRequest? countryAddRequest)
        {
            //VALIDATION: CountryAddRequest parameter can't be null;
            if(countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(countryAddRequest));
            }

            //VALIDATION: CountryName can't be null;
            if (countryAddRequest.CountryName == null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
                
            }

            //VALIDATION: CountryName can't be duplicate;
            if (_countries.Where(temp => temp.CountryName == countryAddRequest.CountryName).Count() > 0)
            {
                throw new ArgumentException("Given country name already exists");
            }

            //Convert Object from CountryAddRequest to Country type
            Country country = countryAddRequest.ToCountry();
            
            //Generate CountryId
            country.CountryId = Guid.NewGuid();

            //Add country object _countries
            _countries.Add(country);

            return country.ToCountryResponse();
        }

        public List<CountryResponse> GetAllCountries()
        {
            throw new NotImplementedException();
        }
    }
}
