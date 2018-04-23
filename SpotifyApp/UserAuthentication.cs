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
    class UserAuthentication
    {
        CommandHandler commandHandler = new CommandHandler();
        public static async void Authenticate(SpotifyWebAPI spotifyAPI)
        {
            WebAPIFactory webApiFactory = new WebAPIFactory(
                 "http://localhost:8000",
                 8000,
                 "87a1fe44c407454f9b466def737c236a",
                 Scope.UserReadPrivate,
                 TimeSpan.FromSeconds(20)
            );

            try
            {
                //This will open the user's browser and returns once
                //the user is authorized.
                spotifyAPI = await webApiFactory.GetWebApi();
        }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            if (spotifyAPI == null)
                return;
        }
        



    }
}
