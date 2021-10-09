using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientNS; 
namespace COnsoleClient
{
	class Program
	{
		static async Task Main(string[] args)
		{
			HttpClient client = new HttpClient();
			RequestClient apiClient = new RequestClient("https://localhost:44304/", client);
			var res = await apiClient.GetallAllAsync();
			Console.WriteLine($"Result = {JsonSerializer.Serialize(res)}");
			Console.ReadLine();
		}
	}
}
