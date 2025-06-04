
using System;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using DotNetEnv;

namespace IO
{
    class GeminiSimple
    {
        
        
         static async Task Main()
        {
            Env.Load();

            string apiKey = Environment.GetEnvironmentVariable("gemini_api_key");
            // string apiKey = "AIzaSyDlij0LfiBR8rGOhpii0RveES4D2to3iCE";

            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key={apiKey}";

            HttpClient client = new HttpClient();

            string jsonBody = @"
                {
                  ""contents"": [{
                    ""parts"": [
                      { ""text"": ""Create a song about my awesome jewish software dev students"" }
                    ]
                  }]
                }";

            HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
            request.Content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.SendAsync(request);
            string responseContent = await response.Content.ReadAsStringAsync();

            JsonDocument doc = JsonDocument.Parse(responseContent);
            string resultText = doc.RootElement
                .GetProperty("candidates")[0]
                .GetProperty("content")
                .GetProperty("parts")[0]
                .GetProperty("text")
                .GetString();

            Console.WriteLine("Raw Text:\n" + resultText);
        }

    
    }

}
