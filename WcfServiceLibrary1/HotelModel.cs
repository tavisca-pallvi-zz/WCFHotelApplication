using System.Runtime.Serialization;

namespace HotelData
{

    [DataContract]

public class HotelModel
    {
        [DataMember]
        public string Name;

        [DataMember]
        public int Id;

        [DataMember]
        public string Location;

        [DataMember]
        public int HotelRating;

    }
}