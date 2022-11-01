using RestSharp;

namespace API_LAB.Models
{
    public class RedditDAL
    {
       public Rootobject GetPost() 
       { 
        var client = new RestClient($"https://www.reddit.com/r/aww/.json");
        var request = new RestRequest();
        var response = client.GetAsync<Rootobject>(request);
        Rootobject rp = response.Result;

        return rp; 
       } 
    }
}
