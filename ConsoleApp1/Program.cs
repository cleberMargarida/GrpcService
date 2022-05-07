using Grpc.Net.Client;
using GrpcService1;

using var channel = GrpcChannel.ForAddress("https://localhost:7135");
var client = new Client.ClientClient(channel);
var reply = await client.GetAsync(
                  new ClientRequest { Name = "1"});
Console.WriteLine("Client: " + reply.Message);
Console.WriteLine("Press any key to exit...");
Console.ReadKey();
Console.WriteLine();