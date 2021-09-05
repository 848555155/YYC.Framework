public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }
    public async Task Invoke(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            httpContext.Response.ContentType = "application/problem+json";

            var title = ex.Message;
            var details = ex.ToString();

            await httpContext.Response.WriteAsJsonAsync(new {
                title,
                details
            });
        }
    }
}