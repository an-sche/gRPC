using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcServer;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var name = "C# Client";

using var channel = GrpcChannel.ForAddress("http://localhost:50051");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(new HelloRequest { Name = name });
Console.WriteLine("SayHello Response: " + reply.Message);

reply = await client.SayHelloAgainAsync(new HelloRequest { Name = name });
Console.WriteLine("SayHelloAgain Response: " + reply.Message);