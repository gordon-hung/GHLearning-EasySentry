using CorrelationId;

using CorrelationId.Abstractions;

namespace GHLearning.EasySentry.WebApi.Correlations;

internal sealed class CustomCorrelationIdProvider() : ICorrelationIdProvider
{
	public string GenerateCorrelationId(HttpContext context)
		=> context.Request.Headers[CorrelationIdOptions.DefaultHeader].FirstOrDefault()
		?? context.Items[CorrelationIdOptions.DefaultHeader]?.ToString()
		?? SequentialGuid.SequentialGuidGenerator.Instance.NewGuid().ToString();
}
