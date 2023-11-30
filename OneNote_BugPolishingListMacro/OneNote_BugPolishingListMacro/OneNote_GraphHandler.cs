using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Graph.Models.ExternalConnectors;
using System.ComponentModel.Design;

namespace GraphBasics;

public class GraphHandler
{
    public GraphServiceClient GraphClient { get; set; }  

    public GraphHandler(string tenantId, string clientId,  string clientSecret)
    {
        GraphClient = CreateGraphClient(tenantId, clientId, clientSecret);
    }

    public GraphServiceClient CreateGraphClient(string tenantId, string clientId, string clientSecret)
    {
        var options = new TokenCredentialOptions
        {
            AuthorityHost = AzureAuthorityHosts.AzurePublicCloud
        };

        var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret, options);
        var scopes = new[] { "https://graph.microsoft.com/.default" };

        return new GraphServiceClient(clientSecretCredential, scopes);
    }

    public async Task<NotebookCollectionResponse> GetNotebook(string userPrincipalName)
    {
        return await GraphClient.Users[userPrincipalName].Onenote.Notebooks.GetAsync();
    }
}
