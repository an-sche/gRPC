using Grpc.Core;

namespace GrpcServer.Services;

public class GreeterService : Greeter.GreeterBase
{
    private readonly ILogger<GreeterService> _logger;
    public GreeterService(ILogger<GreeterService> logger)
    {
        _logger = logger;
    }

    public override Task<HelloResponse> SayHello(HelloRequest request, ServerCallContext context)
    {
        _logger.LogInformation("Received SayHello Message from: {name}", request.Name);
        return Task.FromResult(new HelloResponse
        {
            Message = "Hello " + request.Name + " from C# Server!"
        });
    }

    public override Task<HelloResponse> SayHelloAgain(HelloRequest request, ServerCallContext context) {
        _logger.LogInformation("Received SayHelloAgain Message from: {name}", request.Name);
        return Task.FromResult(new HelloResponse
        {
            Message = "Hello Again " + request.Name + " from C# Server!"
        });
    }
}
