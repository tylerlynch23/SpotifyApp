using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyAPI.Web; //Base Namespace
using SpotifyAPI.Web.Auth; //All Authentication-related classes
using SpotifyAPI.Web.Enums; //Enums
using SpotifyAPI.Web.Models; //Models for the JSON-responses

namespace SpotifyApp
{
    class Program
    {
        public static SpotifyWebAPI spotifyAPI;
        static void Main(string[] args)
        {
            spotifyAPI = new SpotifyWebAPI()
            {
                UseAuth = false,
            };
            UserAuthentication.Authenticate(spotifyAPI);
            Console.WriteLine("HEY");
            Console.ReadKey();



        }
    }
}
