using System;

using Microsoft.Extensions.Options;

using Octokit;

using R5T.Goteborg.Octokit.Sardinia.Configuration;


namespace R5T.Goteborg.Octokit.Sardinia
{
    /// <summary>
    /// Uses <see cref="ProductHeaderValue.Parse(string)"/> in order to parse "foo" or "foo/1.0" GitHub configuration product header values.
    /// </summary>
    public class ConfigurationBasedProductHeaderValueProvider : IProductHeaderValueProvider
    {
        private IOptions<GitHubConfiguration> GitHubConfiguration { get; }


        public ConfigurationBasedProductHeaderValueProvider(IOptions<GitHubConfiguration> gitHubConfiguration)
        {
            this.GitHubConfiguration = gitHubConfiguration;
        }

        public ProductHeaderValue GetProductHeaderValue()
        {
            var gitHubConfiguration = this.GitHubConfiguration.Value;

            var productHeaderValue = ProductHeaderValue.Parse(gitHubConfiguration.ProductHeaderValue);
            return productHeaderValue;
        }
    }
}
