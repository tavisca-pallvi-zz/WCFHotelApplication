using HotelClientMain.HotelServiceReference;
using HotelData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelClientMain
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelClient hotelClient = new HotelClient("BasicHttpBinding_IHotel");
            List<HotelServiceReference.HotelModel> hotels;
            
            hotels = hotelClient.GetAllHotels().ToList();
            foreach (var res in hotels)
            {
                Console.WriteLine(res.Id);
                Console.WriteLine(res.Name);
                Console.WriteLine(res.Location);
                Console.WriteLine(res.HotelRating);
                Console.WriteLine(" ");

            }

            int n = Int32.Parse(Console.ReadLine());

            HotelServiceReference.HotelModel hotel = hotelClient.GetHotelById(n);
            Console.WriteLine(hotel.Id);
            Console.WriteLine(hotel.Name);
            Console.WriteLine(hotel.Location);
            Console.WriteLine(hotel.HotelRating);
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }
    }
