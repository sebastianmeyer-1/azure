using Azure.Identity;
using Azure.Security.KeyVault.Secrets;

string tenantId = "<TENANT ID>";
string clientId = "<CLIENT ID>";
string clientSecret = "<CLIENT SECRET>";
Uri vaultUri = new Uri("https://<key vault name>.vault.azure.net/");
var credentials = new ClientSecretCredential(tenantId, clientId, clientSecret);

var secretClient = new SecretClient(vaultUri, credentials);
var secret = secretClient.GetSecret("<SECRET NAME>");
var keyVaultSecret = secret.Value;
Console.WriteLine(keyVaultSecret.Value);
