using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HotelData
    {

      public  class HotelData : IHotel
        {
            List<HotelModel> hotels = new List<HotelModel>();

            string sJSONdata = "";

            public List<HotelModel> GetAllHotels()
            {
                var result = "";
                JObject json;
                List<HotelModel> hotels;
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "hotel.json";
                using (StreamReader reader = new StreamReader(path))
                {
                    sJSONdata = reader.ReadToEnd();

                    hotels = JsonConvert.DeserializeObject<List<HotelModel>>(sJSONdata);

                }
                return hotels;

            }
            public HotelModel GetHotelById(int id)
            {
                HotelModel hotel;
                using (StreamReader reader = new StreamReader(@"C:\Users\pgoel\Desktop\hotel.json"))
                {

                    sJSONdata = reader.ReadToEnd();
                    List<HotelModel> hotels = GetAllHotels();
                    hotel = hotels.Find(h => h.Id == id);


                }
                return hotel;

            }

        }


    }


