using MIST353GroupProjectFranticFroggyFirms.Entities;

namespace MIST353GroupProjectFranticFroggyFirms.Repositiories
{
    public interface IRatingService
    {
        public Task<List<HotelRatings>> ReturnRatings(int hotelid);
    }
}