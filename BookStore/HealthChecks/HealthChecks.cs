using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace BookStore.HelpChecks
{
    public class HealthChecks : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(HealthCheckResult.Healthy("healthy"));
        }
    }
}
