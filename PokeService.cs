using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _11__Pokémon
{
    internal class PokeService
    {
        public HttpClient HttpClient { get; set; }
        //Method to get data from the API. Returns a ageResponse Task object
        public async Task<PokeResponse> GetData(string name)
        {
            var apiUrl = new UriBuilder(HttpClient.BaseAddress);
            
            //Assign result of API call to HttpResponseMessage object
            HttpResponseMessage response = await HttpClient.GetAsync(apiUrl.Uri + name);

            //Convert content of API response to a JSON string
            string content = await response.Content.ReadAsStringAsync();

            //Deserialize JSON string to an ageResponse object
            PokeResponse pokeResponse = JsonSerializer.Deserialize<PokeResponse>(content);

            //Return the object
            return pokeResponse;
        }
        //Constructor accepting http client
        public PokeService(HttpClient httpClient)
        {
            httpClient.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon/");
            HttpClient = httpClient;
        }
    }
}
