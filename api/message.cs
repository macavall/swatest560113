using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace swatest560113func;

public class message
{
    private readonly ILogger<message> _logger;

    public message(ILogger<message> logger)
    {
        _logger = logger;
    }

    [Function("message")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = new { value = "Thing1" };

        return new OkObjectResult(response);
    }
}

public class message2
{
    private readonly ILogger<message2> _logger;

    public message2(ILogger<message2> logger)
    {
        _logger = logger;
    }

    [Function("message2")]
    public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");

        var response = new { value = "Thing2" };

        return new OkObjectResult(response);
    }
}