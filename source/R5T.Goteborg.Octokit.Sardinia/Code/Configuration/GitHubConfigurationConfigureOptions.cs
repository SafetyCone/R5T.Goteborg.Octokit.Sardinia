using System;

using Microsoft.Extensions.Options;

using RawGitHubConfiguration = R5T.Goteborg.Octokit.Sardinia.Configuration.Raw.GitHubConfiguration;


namespace R5T.Goteborg.Octokit.Sardinia.Configuration
{
    public class GitHubConfigurationConfigureOptions : IConfigureOptions<GitHubConfiguration>
    {
        private IOptions<RawGitHubConfiguration> RawGitHubConfiguration { get; }


        public GitHubConfigurationConfigureOptions(IOptions<RawGitHubConfiguration> rawGitHubConfiguration)
        {
            this.RawGitHubConfiguration = rawGitHubConfiguration;
        }

        public void Configure(GitHubConfiguration options)
        {
            var rawGitHubConfiguration = this.RawGitHubConfiguration.Value;

            options.ProductHeaderValue = rawGitHubConfiguration.ProductHeaderValue;
        }
    }
}
