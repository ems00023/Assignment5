using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Tokens;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositiories;
using MIST353GroupProjectFranticFroggyFirms.Repositories;


namespace MIST353GroupProjectFranticFroggyFirms.Controllers
{
    [Route("api[controller]")]
    [ApiController]
    public class HotelRatingsController : ControllerBase
    {
        private readonly IRatingService _RatingService;
        public HotelRatingsController(IRatingService RatingService)
        {
            _RatingService = RatingService;
        }
        [HttpGet("{hotelid}")]
        public async Task<ActionResult<List<HotelRatings>>> ReturnRatings(int hotelid)
        {
            var hotelRatings = await _RatingService.ReturnRatings(hotelid);
            return hotelRatings;
        }
    }
}

