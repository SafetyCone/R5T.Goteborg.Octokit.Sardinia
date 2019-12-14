using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Sardinia;

using R5T.Goteborg.Octokit.Sardinia.Configuration;

using RawGitHubConfiguration = R5T.Goteborg.Octokit.Sardinia.Configuration.Raw.GitHubConfiguration;


namespace R5T.Goteborg.Octokit.Sardinia
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddGitHubConfiguration(this IServiceCollection services)
        {
            services
                .AddOptions()
                .Configure<RawGitHubConfiguration>()
                .ConfigureOptions<GitHubConfigurationConfigureOptions>()
                .AddSingleton<IProductHeaderValueProvider, ConfigurationBasedProductHeaderValueProvider>();
                ;

            return services;
        }
    }
}
