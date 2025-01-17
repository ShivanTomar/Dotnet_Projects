﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    //DTO class that is used as return type for most of CountriesService method
    public class CountryResponse
    {
        public Guid CountryId { get; set; }
        public string? CountryName { get; set; }

    }
    public static class CountryExtensions
    { 
        public static CountryResponse ToCountryResponse(this Country country)
        {
            return new CountryResponse()
            { CountryId = country.CountryId, CountryName = country.CountryName };
        }
    }
}
