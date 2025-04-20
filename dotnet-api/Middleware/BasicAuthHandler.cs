using System.Text;

namespace dotnet_api.Middleware
{
    public class BasicAuthHandler
    {
        private readonly RequestDelegate _next;
        private readonly IConfiguration _configuration;

        public BasicAuthHandler(RequestDelegate next, IConfiguration configuration)
        {
            this._next = next;
            this._configuration = configuration;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                try
                {
                    if (!context.Request.Headers.ContainsKey("Authorization"))
                    {
                        await UnauthorizedAsync(context);
                        return;
                    }

                    var header = context.Request.Headers.Authorization.ToString();

                    if (!header.StartsWith("Basic "))
                    {
                        await UnauthorizedAsync(context);
                        return;
                    }

                    var encodedCreds = header.Substring(6);
                    var creds = Encoding.UTF8.GetString(Convert.FromBase64String(encodedCreds));
                    string[] userNpassW = creds.Split(":");

                    if (userNpassW.Length != 2)
                    {
                        await UnauthorizedAsync(context);
                        return;
                    }

                    string userN = userNpassW[0];
                    string passW = userNpassW[1];

                    var basicAuth = _configuration.GetSection("BasicAuth");

                    if (userN != basicAuth["Username"] || passW != basicAuth["Password"])
                    {
                        await UnauthorizedAsync(context);
                        return;
                    }
                }
                catch
                {
                    await UnauthorizedAsync(context);
                    return;
                }

                await _next(context);
            }
            catch
            {
                context.Response.StatusCode = 500;
                await context.Response.WriteAsync("Internal Server Error");
            }
        }

        static async Task UnauthorizedAsync(HttpContext context)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync("Unauthorized");
        }
    }
}
