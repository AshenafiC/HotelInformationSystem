using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelInformationSystem.Models
{
    public class CreateCountryDTO
    {

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too Long")]
        public string Shortname { get; set; }
    }

    public class CountryDTO : CreateCountryDTO
    {
        public int id { get; set; }

        public IList<HotelDTO> Hotels { get; set; }
    }
}
