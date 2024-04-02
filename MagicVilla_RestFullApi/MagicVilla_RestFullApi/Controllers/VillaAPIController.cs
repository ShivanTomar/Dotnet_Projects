using MagicVilla_RestFullApi.Data;
using MagicVilla_RestFullApi.Models.Dto;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using MagicVilla_RestFullApi.Models;
using Microsoft.EntityFrameworkCore;
using MagicVilla_RestFullApi.Repository.IRepostiory;
using System.Net;
using System.Linq.Expressions;
using AutoMapper;
using MagicVilla_RestFullApi.Repository;


namespace MagicVilla_RestFullApi.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class VillaAPIController : Controller
    {
        //private readonly ApplicationDBContext _db;
        protected APIResponse _response;
        private readonly IMapper _mapper;
        private readonly IVillaRepository _dbVilla;
        public VillaAPIController(IVillaRepository dbVilla,IMapper mapper)
        {
            _dbVilla = dbVilla;
            _mapper = mapper;
            this._response = new();
        }


        //API'S
        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            try
            {
                //IEnumerable<Villa> villaList;

                _response.Result = await _dbVilla.GetAllAsync();
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;


        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        public async Task<ActionResult<APIResponse>> GetVillasById(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode=HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villa = await _dbVilla.GetAsync(x => x.Id == id);
                if (villa == null) 
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                _response.Result = villa;
                _response.StatusCode = HttpStatusCode.OK;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO villaDTO)
        {
            try
            {
                if (villaDTO == null)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }

                Villa model = new()
                {
                    Name = villaDTO.Name,
                    Details = villaDTO.Details,
                    ImageUrl = villaDTO.ImageUrl,
                    Occupancy = villaDTO.Occupancy,
                    Sqft = villaDTO.Occupancy,
                    Rate = villaDTO.Rate,
                    Amenity = villaDTO.Amenity,
                    CreateDate = DateTime.Now
                };
                await _dbVilla.CreateAsync(model);
                _response.Result = model;
                _response.StatusCode = HttpStatusCode.Created;
                return CreatedAtRoute("GetVilla", new { id = model.Id }, _response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }


        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            try
            {
                if (id == 0)
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    return BadRequest(_response);
                }
                var villa = await _dbVilla.GetAsync(x => x.Id == id);
                if (villa == null) 
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    return NotFound(_response);
                }
                await _dbVilla.RemoveAsync(villa);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO villaDTO)
        {

            try
            {
                Villa model = new()
                {
                    Id = villaDTO.Id,
                    Name = villaDTO.Name,
                    Details = villaDTO.Details,
                    ImageUrl = villaDTO.ImageUrl,
                    Occupancy = villaDTO.Occupancy,
                    Sqft = villaDTO.Occupancy,
                    Rate = villaDTO.Rate,
                    Amenity = villaDTO.Amenity
                };
                
                await _dbVilla.UpdateAsync(model);
                _response.StatusCode = HttpStatusCode.NoContent;
                _response.IsSuccess = true;
                return Ok(_response);

            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;

        }



        //PATCH_UPDATE
        /*     [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
            public IActionResult UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
             {
                 if (patchDTO == null || id == 0)
                 {
                     return BadRequest();
                 }
                 var villa =  _dbVilla.Get(x => x.Id == id);
                 VillaUpdateDTO villaDTO = new()
                 {
                     Id = villa.Id,
                     Name = villa.Name,
                     Details = villa.Details,
                     ImageUrl = villa.ImageUrl,
                     Occupancy = villa.Occupancy,
                     sqft = villa.Occupancy,
                     Rate = villa.Rate,
                     Amenity = villa.Amenity

                 };
                 if (villa==null) return BadRequest();

                 patchDTO.ApplyTo(villaDTO,ModelState);
                 Villa model = new Villa()
                 {
                     Id = villa.Id,
                     Name = villa.Name,
                     Details = villa.Details,
                     ImageUrl = villa.ImageUrl,
                     Occupancy = villa.Occupancy,
                     Sqft = villa.Occupancy,
                     Rate = villa.Rate,
                     Amenity = villa.Amenity

                 };
                 await _dbVilla.Update(model);

                 if (!ModelState.IsValid) return BadRequest(ModelState);
                 return NoContent();
             } */
    }  
}
