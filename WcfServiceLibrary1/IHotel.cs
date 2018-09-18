using System.Collections.Generic;
using System.ServiceModel;

namespace HotelData
{

    [ServiceContract]

   public interface IHotel
    {
        [OperationContract]
        List<HotelModel> GetAllHotels();

        [OperationContract]

        HotelModel GetHotelById(int id);
    }
}