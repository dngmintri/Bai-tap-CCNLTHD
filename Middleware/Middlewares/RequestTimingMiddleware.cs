using System.Diagnostics;

namespace Middleware.Middlewares
{
    public class RequestTimingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<RequestTimingMiddleware> _logger;

        public RequestTimingMiddleware(RequestDelegate next, ILogger<RequestTimingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            await _next(context);

            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            _logger.LogInformation($"Thời gian xử lý: {elapsed.TotalMilliseconds} ms");
        }
    }
}
