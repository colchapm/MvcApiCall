using System.Threading.Tasks; //allows us to use asynchronous Tasks
using RestSharp;

namespace MvcApiCall.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall(string apiKey)
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2"); //instantiate a RestSharp RestClient object and store the connection in variable called client
      RestRequest request = new RestRequest($"home.json?api-key={apiKey}", Method.GET); // create a RestRequest object. This is our actual request. home.json is our endpoint 
      var response = await client.ExecuteTaskAsync(request); // awaiting a result before we attempt to define response by calling RestClient's ExecuteTaskAsync method & pass in our request object
      return response.Content; //return the Content property of the response variable
    }
  }
}