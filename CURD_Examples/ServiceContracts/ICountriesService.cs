using ServiceContracts.DTO;

namespace ServiceContracts
{
    //Represents bussiness logic for manipulating Country entity
    public interface ICountriesService
    {
        //Add a county object to the list of countries
        //<param name="countryAddRequest"> Country object to add</params>
        //<return>Returns the county object after adding it (include newly generated country id)</return>
        CountryResponse AddCountry(CountryAddRequest? countryAddRequest);

        List<CountryResponse> GetAllCountries();
    }
}
