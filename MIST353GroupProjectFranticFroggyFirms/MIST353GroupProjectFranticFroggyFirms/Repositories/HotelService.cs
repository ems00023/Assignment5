using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using MIST353GroupProjectFranticFroggyFirms.Data;
using MIST353GroupProjectFranticFroggyFirms.Entities;
using MIST353GroupProjectFranticFroggyFirms.Repositories;

namespace TravelSiteBETAPI.Repositories
{
    public class HotelService : IHotelService
    {
        private readonly DbContextClass _dBContextClass;
        public HotelService(DbContextClass dbContextClass)
        {
            _dBContextClass = dbContextClass;
        }
        public async Task<List<Hotel>> ReturnHotelDetails(int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelDetails = await Task.Run(() => _dBContextClass.Hotel.FromSqlRaw("exec spReturnHotelDetails @hotelid", param).ToListAsync());
            return hotelDetails;
        }

        public async Task<List<Hotel>> ReturnRatings(int rating, int hotelid)
        {
            var param = new SqlParameter("@hotelid", hotelid);
            var hotelRatings = await Task.Run(() => _dBContextClass.Hotel.FromSqlRaw("exec spReturnRatings @hotelratings", param).ToListAsync());
            return hotelRatings;
        }

        public Task<List<Hotel>> ReturnRatings(int hotelid)
        {
            throw new NotImplementedException();
        }
    }
}