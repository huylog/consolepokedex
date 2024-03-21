namespace _11__Pokémon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PokeResponse> responseList = new List<PokeResponse>(); //list of answers
            while (true)
            {
                Console.WriteLine("Enter your Pokemon's name or Pokedex ID:"); //asking user for a pokemon name
                var userInput = Console.ReadLine();
                try
                {
                    //Create HTTPClient object to access the GetAsync method to do API Call
                    using HttpClient client = new HttpClient();

                    PokeService agifyService = new PokeService(client);
                    //Add the resulting object to the response list

                    responseList.Add(agifyService.GetData(userInput).Result);

                    responseList[responseList.Count - 1].Display();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }   
        }
    }
}
