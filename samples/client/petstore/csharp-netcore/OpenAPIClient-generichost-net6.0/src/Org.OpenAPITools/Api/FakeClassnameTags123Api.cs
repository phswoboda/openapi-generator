// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.IApi
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// This class is registered as transient.
    /// </summary>
    public interface IFakeClassnameTags123Api : IApi
    {
        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;ModelClient&gt;&gt;</returns>
        Task<ApiResponse<ModelClient>> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// To test class name in snake case
        /// </summary>
        /// <remarks>
        /// To test class name in snake case
        /// </remarks>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&gt;ModelClient&gt;&gt;</returns>
        Task<ApiResponse<ModelClient>> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default);
    }
}

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FakeClassnameTags123Api : IApi.IFakeClassnameTags123Api
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<FakeClassnameTags123Api> Logger { get; }

        /// <summary>
        /// The HttpClient
        /// </summary>
        public HttpClient HttpClient { get; }

        /// <summary>
        /// A token provider of type <see cref="ApiKeyProvider"/>
        /// </summary>
        public TokenProvider<ApiKeyToken> ApiKeyProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BearerToken"/>
        /// </summary>
        public TokenProvider<BearerToken> BearerTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="BasicTokenProvider"/>
        /// </summary>
        public TokenProvider<BasicToken> BasicTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="HttpSignatureTokenProvider"/>
        /// </summary>
        public TokenProvider<HttpSignatureToken> HttpSignatureTokenProvider { get; }

        /// <summary>
        /// A token provider of type <see cref="OauthTokenProvider"/>
        /// </summary>
        public TokenProvider<OAuthToken> OauthTokenProvider { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FakeClassnameTags123Api"/> class.
        /// </summary>
        /// <returns></returns>
        public FakeClassnameTags123Api(ILogger<FakeClassnameTags123Api> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
            TokenProvider<ApiKeyToken> apiKeyProvider,
            TokenProvider<BearerToken> bearerTokenProvider,
            TokenProvider<BasicToken> basicTokenProvider,
            TokenProvider<HttpSignatureToken> httpSignatureTokenProvider,
            TokenProvider<OAuthToken> oauthTokenProvider)
        {
            _jsonSerializerOptions = jsonSerializerOptionsProvider.Options;
            Logger = logger;
            HttpClient = httpClient;
            ApiKeyProvider = apiKeyProvider;
            BearerTokenProvider = bearerTokenProvider;
            BasicTokenProvider = basicTokenProvider;
            HttpSignatureTokenProvider = httpSignatureTokenProvider;
            OauthTokenProvider = oauthTokenProvider;
        }

        /// <summary>
        /// Logs the api response
        /// </summary>
        /// <param name="args"></param>
        protected virtual void OnApiResponded(ApiResponseEventArgs args)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (args.ReceivedAt - args.RequestedAt).TotalSeconds, args.HttpStatus, args.Path);
        }

        partial void FormatTestClassname(ModelClient modelClient);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="modelClient"></param>
        /// <returns></returns>
        private void ValidateTestClassname(ModelClient modelClient)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (modelClient == null)
                throw new ArgumentNullException(nameof(modelClient));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="modelClient"></param>
        protected virtual void AfterTestClassname(ApiResponse<ModelClient> apiResponseLocalVar, ModelClient modelClient)
        {
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="modelClient"></param>
        protected virtual void OnErrorTestClassname(Exception exception, string pathFormat, string path, ModelClient modelClient)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ModelClient"/></returns>
        public async Task<ApiResponse<ModelClient>> TestClassnameOrDefaultAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await TestClassnameAsync(modelClient, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// To test class name in snake case To test class name in snake case
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="modelClient">client model</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="ModelClient"/></returns>
        public async Task<ApiResponse<ModelClient>> TestClassnameAsync(ModelClient modelClient, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateTestClassname(modelClient);

                FormatTestClassname(modelClient);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/fake_classname_test";



                    System.Collections.Specialized.NameValueCollection parseQueryStringLocalVar = System.Web.HttpUtility.ParseQueryString(string.Empty);                    httpRequestMessageLocalVar.Content = (modelClient as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(modelClient, _jsonSerializerOptions));

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();

                    ApiKeyToken apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);

                    apiKeyTokenLocalVar.UseInQuery(httpRequestMessageLocalVar, uriBuilderLocalVar, parseQueryStringLocalVar, "api_key_query");

                    uriBuilderLocalVar.Query = parseQueryStringLocalVar.ToString();

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json" 
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] { 
                        "application/json" 
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));

                    httpRequestMessageLocalVar.Method = HttpMethod.Patch;

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        OnApiResponded(new ApiResponseEventArgs(requestedAtLocalVar, DateTime.UtcNow, httpResponseMessageLocalVar.StatusCode, "/fake_classname_test", uriBuilderLocalVar.Path));

                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        ApiResponse<ModelClient> apiResponseLocalVar = new ApiResponse<ModelClient>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, _jsonSerializerOptions);

                        AfterTestClassname(apiResponseLocalVar, modelClient);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorTestClassname(e, "/fake_classname_test", uriBuilderLocalVar.Path, modelClient);
                throw;
            }
        }
    }
}
