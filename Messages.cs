using System.Text.Json.Serialization;

namespace EjemploApiCSharp;

public class MessageBody
{
    public string to { get; set; } = "";
    public string message { get; set; } = "";
}



public class MessageResponse
{
    public int id {get; set;}
    
    public string to { get; set; } = "";

    public string message { get; set; } = "";

    public DateTime sent_date {get; set;}
}