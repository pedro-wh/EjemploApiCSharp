using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using EjemploApiCSharp;

var _httpClient = new HttpClient();
_httpClient.DefaultRequestHeaders.Add("Authorization", "Api-Key 7iYN6RPk.CZTfARM7lxD7oQXjwytgEqHuqSBZroqI");

var messageBody = new MessageBody
{
    to = "5555022555",
    message = "Hola Mundo!"
};
var content = new StringContent(JsonSerializer.Serialize(messageBody), Encoding.UTF8, "application/json");
var response = await _httpClient.PostAsync("http://empresa.ahkinwslocal.com:8000/api/devices/3/messages/", content);
var messageResponse = await response.Content.ReadFromJsonAsync<MessageResponse>();

Console.WriteLine("Se ha enviado el mensaje:");
Console.WriteLine($@"
Id: {messageResponse?.id}
To: {messageResponse?.to}
Message: {messageResponse?.message}
Sent_Date: {messageResponse?.sent_date}
");