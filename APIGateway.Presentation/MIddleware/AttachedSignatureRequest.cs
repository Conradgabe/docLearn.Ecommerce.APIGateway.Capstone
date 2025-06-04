namespace APIGateway.Presentation.MIddleware
{
    public class AttachedSignatureRequest(RequestDelegate next)
    {
        public async Task InvokeAsync(HttpContext context)
        {
            context.Request.Headers["API-Gateway"] = "Signed";
            await next(context);
        }
    }
}
