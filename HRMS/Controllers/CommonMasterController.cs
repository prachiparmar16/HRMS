using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HRMS.WebAPI.Controllers
{
    using HRMS.Models.ModelClasses;
    using HRMS.WebAPI.Repositories;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("api/[controller]")]
    public class CommonMasterController : ControllerBase
    {
        private readonly ICountryRepository _country;
        private readonly IStateRepository _state;
        private readonly ICityRepository _city;
        private readonly ICurrencyRepository _currency;
        private readonly ILanguageRepository _language;
        private readonly IGenderRepository _gender;
        private readonly IBloodGroupRepository _bloodGroup;
        private readonly IMaritalStatusRepository _maritalStatus;
        private readonly IDocumentTypeRepository _documentType;
        private readonly IRelationshipTypeRepository _relationshipType;

        public CommonMasterController(
            ICountryRepository country,
            IStateRepository state,
            ICityRepository city,
            ICurrencyRepository currency,
            ILanguageRepository language,
            IGenderRepository gender,
            IBloodGroupRepository bloodGroup,
            IMaritalStatusRepository maritalStatus,
            IDocumentTypeRepository documentType,
            IRelationshipTypeRepository relationshipType)
        {
            _country = country;
            _state = state;
            _city = city;
            _currency = currency;
            _language = language;
            _gender = gender;
            _bloodGroup = bloodGroup;
            _maritalStatus = maritalStatus;
            _documentType = documentType;
            _relationshipType = relationshipType;
        }

        // ================= COUNTRY =================

        [HttpGet("countries")]
        public async Task<IActionResult> GetCountries()
            => Ok(await _country.GetCountries());

        [HttpPost("countries")]
        public async Task<IActionResult> AddCountry(Country country)
            => Ok(await _country.AddCountry(country));

        [HttpPut("countries")]
        public async Task<IActionResult> UpdateCountry(Country country)
        {
            var result = await _country.UpdateCountry(country);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("countries/{id}")]
        public async Task<IActionResult> DeleteCountry(int id)
        {
            var result = await _country.DeleteCountry(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= STATE =================

        [HttpGet("states")]
        public async Task<IActionResult> GetStates()
            => Ok(await _state.GetStates());

        [HttpPost("states")]
        public async Task<IActionResult> AddState(State state)
            => Ok(await _state.AddState(state));

        [HttpPut("states")]
        public async Task<IActionResult> UpdateState(State state)
        {
            var result = await _state.UpdateState(state);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("states/{id}")]
        public async Task<IActionResult> DeleteState(int id)
        {
            var result = await _state.DeleteState(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= CITY =================

        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
            => Ok(await _city.GetCities());

        [HttpPost("cities")]
        public async Task<IActionResult> AddCity(City city)
            => Ok(await _city.AddCity(city));

        [HttpPut("cities")]
        public async Task<IActionResult> UpdateCity(City city)
        {
            var result = await _city.UpdateCity(city);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("cities/{id}")]
        public async Task<IActionResult> DeleteCity(int id)
        {
            var result = await _city.DeleteCity(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= CURRENCY =================

        [HttpGet("currencies")]
        public async Task<IActionResult> GetCurrencies()
            => Ok(await _currency.GetCurrencies());

        [HttpPost("currencies")]
        public async Task<IActionResult> AddCurrency(Currency currency)
            => Ok(await _currency.AddCurrency(currency));

        [HttpPut("currencies")]
        public async Task<IActionResult> UpdateCurrency(Currency currency)
        {
            var result = await _currency.UpdateCurrency(currency);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("currencies/{id}")]
        public async Task<IActionResult> DeleteCurrency(int id)
        {
            var result = await _currency.DeleteCurrency(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= LANGUAGE =================

        [HttpGet("languages")]
        public async Task<IActionResult> GetLanguages()
            => Ok(await _language.GetLanguages());

        [HttpPost("languages")]
        public async Task<IActionResult> AddLanguage(Language language)
            => Ok(await _language.AddLanguage(language));

        [HttpPut("languages")]
        public async Task<IActionResult> UpdateLanguage(Language language)
        {
            var result = await _language.UpdateLanguage(language);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("languages/{id}")]
        public async Task<IActionResult> DeleteLanguage(int id)
        {
            var result = await _language.DeleteLanguage(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= GENDER =================

        [HttpGet("genders")]
        public async Task<IActionResult> GetGenders()
            => Ok(await _gender.GetGenders());

        [HttpPost("genders")]
        public async Task<IActionResult> AddGender(Gender gender)
            => Ok(await _gender.AddGender(gender));

        [HttpPut("genders")]
        public async Task<IActionResult> UpdateGender(Gender gender)
        {
            var result = await _gender.UpdateGender(gender);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("genders/{id}")]
        public async Task<IActionResult> DeleteGender(int id)
        {
            var result = await _gender.DeleteGender(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= BLOOD GROUP =================

        [HttpGet("blood-groups")]
        public async Task<IActionResult> GetBloodGroups()
            => Ok(await _bloodGroup.GetBloodGroups());

        [HttpPost("blood-groups")]
        public async Task<IActionResult> AddBloodGroup(BloodGroup bloodGroup)
            => Ok(await _bloodGroup.AddBloodGroup(bloodGroup));

        [HttpPut("blood-groups")]
        public async Task<IActionResult> UpdateBloodGroup(BloodGroup bloodGroup)
        {
            var result = await _bloodGroup.UpdateBloodGroup(bloodGroup);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("blood-groups/{id}")]
        public async Task<IActionResult> DeleteBloodGroup(int id)
        {
            var result = await _bloodGroup.DeleteBloodGroup(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= MARITAL STATUS =================

        [HttpGet("marital-statuses")]
        public async Task<IActionResult> GetMaritalStatuses()
            => Ok(await _maritalStatus.GetMaritalStatuses());

        [HttpPost("marital-statuses")]
        public async Task<IActionResult> AddMaritalStatus(
            MaritalStatus maritalStatus)
            => Ok(await _maritalStatus.AddMaritalStatus(maritalStatus));

        [HttpPut("marital-statuses")]
        public async Task<IActionResult> UpdateMaritalStatus(
            MaritalStatus maritalStatus)
        {
            var result =
                await _maritalStatus.UpdateMaritalStatus(maritalStatus);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("marital-statuses/{id}")]
        public async Task<IActionResult> DeleteMaritalStatus(int id)
        {
            var result =
                await _maritalStatus.DeleteMaritalStatus(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= DOCUMENT TYPE =================

        [HttpGet("document-types")]
        public async Task<IActionResult> GetDocumentTypes()
            => Ok(await _documentType.GetDocumentTypes());

        [HttpPost("document-types")]
        public async Task<IActionResult> AddDocumentType(
            DocumentType documentType)
            => Ok(await _documentType.AddDocumentType(documentType));

        [HttpPut("document-types")]
        public async Task<IActionResult> UpdateDocumentType(
            DocumentType documentType)
        {
            var result =
                await _documentType.UpdateDocumentType(documentType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("document-types/{id}")]
        public async Task<IActionResult> DeleteDocumentType(int id)
        {
            var result =
                await _documentType.DeleteDocumentType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }


        // ================= RELATIONSHIP TYPE =================

        [HttpGet("relationship-types")]
        public async Task<IActionResult> GetRelationshipTypes()
            => Ok(await _relationshipType.GetRelationshipTypes());

        [HttpPost("relationship-types")]
        public async Task<IActionResult> AddRelationshipType(
            RelationshipType relationshipType)
            => Ok(await _relationshipType.AddRelationshipType(relationshipType));

        [HttpPut("relationship-types")]
        public async Task<IActionResult> UpdateRelationshipType(
            RelationshipType relationshipType)
        {
            var result =
                await _relationshipType.UpdateRelationshipType(relationshipType);

            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("relationship-types/{id}")]
        public async Task<IActionResult> DeleteRelationshipType(int id)
        {
            var result =
                await _relationshipType.DeleteRelationshipType(id);

            if (!result)
                return NotFound();

            return Ok(result);
        }
    }
}
