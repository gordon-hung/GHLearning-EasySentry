using CorrelationId;

namespace GHLearning.EasySentry.WebApi.Middlewares;

public class SentryMiddleware(RequestDelegate next)
{
	private readonly RequestDelegate _next = next;

	public async Task InvokeAsync(HttpContext context)
	{
		await _next(context).ConfigureAwait(false);

		SentrySdk.ConfigureScope(
			scope => scope.SetTag(CorrelationIdOptions.DefaultHeader, context.Response.Headers[CorrelationIdOptions.DefaultHeader].FirstOrDefault() ?? string.Empty));
	}
}
