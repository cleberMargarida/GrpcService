using Grpc.Core;

namespace GrpcService1.Services
{
    public class ClientService : Client.ClientBase
    {
        private readonly ILogger<ClientService> _logger;
     
        public ClientService(ILogger<ClientService> logger)
        {
            _logger = logger;
        }

        public override Task<ClientReply> Get(ClientRequest request, ServerCallContext context)
        {
            return Task.FromResult(new ClientReply
            {
                Message = "Hello from Client"
            });
        }
    }
}
