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
    public interface IStoreApi : IApi
    {
        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;object&gt;&gt;</returns>
        Task<ApiResponse<object>> DeleteOrderAsync(string orderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Delete purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
        /// </remarks>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&gt;object&gt;&gt;</returns>
        Task<ApiResponse<object>> DeleteOrderOrDefaultAsync(string orderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Dictionary&lt;string, int&gt;&gt;&gt;</returns>
        Task<ApiResponse<Dictionary<string, int>>> GetInventoryAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Returns pet inventories by status
        /// </summary>
        /// <remarks>
        /// Returns a map of status codes to quantities
        /// </remarks>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&gt;Dictionary&lt;string, int&gt;&gt;&gt;</returns>
        Task<ApiResponse<Dictionary<string, int>>> GetInventoryOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Order&gt;&gt;</returns>
        Task<ApiResponse<Order>> GetOrderByIdAsync(long orderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Find purchase order by ID
        /// </summary>
        /// <remarks>
        /// For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions
        /// </remarks>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&gt;Order&gt;&gt;</returns>
        Task<ApiResponse<Order>> GetOrderByIdOrDefaultAsync(long orderId, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">order placed for purchasing the pet</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&lt;Order&gt;&gt;</returns>
        Task<ApiResponse<Order>> PlaceOrderAsync(Order order, System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Place an order for a pet
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="order">order placed for purchasing the pet</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task&lt;ApiResponse&gt;Order&gt;&gt;</returns>
        Task<ApiResponse<Order>> PlaceOrderOrDefaultAsync(Order order, System.Threading.CancellationToken cancellationToken = default);
    }
}

namespace Org.OpenAPITools.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public sealed partial class StoreApi : IApi.IStoreApi
    {
        private JsonSerializerOptions _jsonSerializerOptions;

        /// <summary>
        /// The logger
        /// </summary>
        public ILogger<StoreApi> Logger { get; }

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
        /// Initializes a new instance of the <see cref="StoreApi"/> class.
        /// </summary>
        /// <returns></returns>
        public StoreApi(ILogger<StoreApi> logger, HttpClient httpClient, JsonSerializerOptionsProvider jsonSerializerOptionsProvider,
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

        partial void FormatDeleteOrder(ref string orderId);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        private void ValidateDeleteOrder(string orderId)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (orderId == null)
                throw new ArgumentNullException(nameof(orderId));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="orderId"></param>
        private void AfterDeleteOrderDefaultImplementation(ApiResponse<object> apiResponseLocalVar, string orderId)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
            AfterDeleteOrder(apiResponseLocalVar, orderId);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="orderId"></param>
        partial void AfterDeleteOrder(ApiResponse<object> apiResponseLocalVar, string orderId);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="orderId"></param>
        private void OnErrorDeleteOrderDefaultImplementation(Exception exception, string pathFormat, string path, string orderId)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
            OnErrorDeleteOrder(exception, pathFormat, path, orderId);
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="orderId"></param>
        partial void OnErrorDeleteOrder(Exception exception, string pathFormat, string path, string orderId);

        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
        /// </summary>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public async Task<ApiResponse<object>> DeleteOrderOrDefaultAsync(string orderId, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await DeleteOrderAsync(orderId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Delete purchase order by ID For valid response try integer IDs with value &lt; 1000. Anything above 1000 or nonintegers will generate API errors
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of the order that needs to be deleted</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="object"/></returns>
        public async Task<ApiResponse<object>> DeleteOrderAsync(string orderId, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateDeleteOrder(orderId);

                FormatDeleteOrder(ref orderId);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/store/order/{order_id}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7Border_id%7D", Uri.EscapeDataString(orderId.ToString()));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;
                    httpRequestMessageLocalVar.Method = new HttpMethod("DELETE");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<object> apiResponseLocalVar = new ApiResponse<object>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/store/order/{order_id}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterDeleteOrderDefaultImplementation(apiResponseLocalVar, orderId);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorDeleteOrderDefaultImplementation(e, "/store/order/{order_id}", uriBuilderLocalVar.Path, orderId);
                throw;
            }
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        private void AfterGetInventoryDefaultImplementation(ApiResponse<Dictionary<string, int>> apiResponseLocalVar)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
            AfterGetInventory(apiResponseLocalVar);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        partial void AfterGetInventory(ApiResponse<Dictionary<string, int>> apiResponseLocalVar);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        private void OnErrorGetInventoryDefaultImplementation(Exception exception, string pathFormat, string path)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
            OnErrorGetInventory(exception, pathFormat, path);
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        partial void OnErrorGetInventory(Exception exception, string pathFormat, string path);

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Dictionary{TKey, TValue}"/></returns>
        public async Task<ApiResponse<Dictionary<string, int>>> GetInventoryOrDefaultAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetInventoryAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Returns pet inventories by status Returns a map of status codes to quantities
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Dictionary{TKey, TValue}"/></returns>
        public async Task<ApiResponse<Dictionary<string, int>>> GetInventoryAsync(System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/store/inventory";

                    List<TokenBase> tokenBaseLocalVars = new List<TokenBase>();

                    ApiKeyToken apiKeyTokenLocalVar = (ApiKeyToken) await ApiKeyProvider.GetAsync(cancellationToken).ConfigureAwait(false);

                    tokenBaseLocalVars.Add(apiKeyTokenLocalVar);

                    apiKeyTokenLocalVar.UseInHeader(httpRequestMessageLocalVar, "api_key");

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("GET");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<Dictionary<string, int>> apiResponseLocalVar = new ApiResponse<Dictionary<string, int>>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/store/inventory", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetInventoryDefaultImplementation(apiResponseLocalVar);

                        if (apiResponseLocalVar.StatusCode == (HttpStatusCode) 429)
                            foreach(TokenBase tokenBaseLocalVar in tokenBaseLocalVars)
                                tokenBaseLocalVar.BeginRateLimit();

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetInventoryDefaultImplementation(e, "/store/inventory", uriBuilderLocalVar.Path);
                throw;
            }
        }

        partial void FormatGetOrderById(ref long orderId);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        private void ValidateGetOrderById(long orderId)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (orderId == null)
                throw new ArgumentNullException(nameof(orderId));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="orderId"></param>
        private void AfterGetOrderByIdDefaultImplementation(ApiResponse<Order> apiResponseLocalVar, long orderId)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
            AfterGetOrderById(apiResponseLocalVar, orderId);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="orderId"></param>
        partial void AfterGetOrderById(ApiResponse<Order> apiResponseLocalVar, long orderId);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="orderId"></param>
        private void OnErrorGetOrderByIdDefaultImplementation(Exception exception, string pathFormat, string path, long orderId)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
            OnErrorGetOrderById(exception, pathFormat, path, orderId);
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="orderId"></param>
        partial void OnErrorGetOrderById(Exception exception, string pathFormat, string path, long orderId);

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions
        /// </summary>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Order"/></returns>
        public async Task<ApiResponse<Order>> GetOrderByIdOrDefaultAsync(long orderId, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await GetOrderByIdAsync(orderId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Find purchase order by ID For valid response try integer IDs with value &lt;&#x3D; 5 or &gt; 10. Other values will generate exceptions
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="orderId">ID of pet that needs to be fetched</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Order"/></returns>
        public async Task<ApiResponse<Order>> GetOrderByIdAsync(long orderId, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidateGetOrderById(orderId);

                FormatGetOrderById(ref orderId);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/store/order/{order_id}";
                    uriBuilderLocalVar.Path = uriBuilderLocalVar.Path.Replace("%7Border_id%7D", Uri.EscapeDataString(orderId.ToString()));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] acceptLocalVars = new string[] {
                        "application/xml",
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("GET");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<Order> apiResponseLocalVar = new ApiResponse<Order>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/store/order/{order_id}", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterGetOrderByIdDefaultImplementation(apiResponseLocalVar, orderId);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorGetOrderByIdDefaultImplementation(e, "/store/order/{order_id}", uriBuilderLocalVar.Path, orderId);
                throw;
            }
        }

        partial void FormatPlaceOrder(Order order);

        /// <summary>
        /// Validates the request parameters
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        private void ValidatePlaceOrder(Order order)
        {
            #pragma warning disable CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning disable CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'

            if (order == null)
                throw new ArgumentNullException(nameof(order));

            #pragma warning restore CS0472 // The result of the expression is always the same since a value of this type is never equal to 'null'
            #pragma warning restore CS8073 // The result of the expression is always the same since a value of this type is never equal to 'null'
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="order"></param>
        private void AfterPlaceOrderDefaultImplementation(ApiResponse<Order> apiResponseLocalVar, Order order)
        {
            Logger.LogInformation("{0,-9} | {1} | {3}", (apiResponseLocalVar.DownloadedAt - apiResponseLocalVar.RequestedAt).TotalSeconds, apiResponseLocalVar.StatusCode, apiResponseLocalVar.Path);
            AfterPlaceOrder(apiResponseLocalVar, order);
        }

        /// <summary>
        /// Processes the server response
        /// </summary>
        /// <param name="apiResponseLocalVar"></param>
        /// <param name="order"></param>
        partial void AfterPlaceOrder(ApiResponse<Order> apiResponseLocalVar, Order order);

        /// <summary>
        /// Logs exceptions that occur while retrieving the server response
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="order"></param>
        private void OnErrorPlaceOrderDefaultImplementation(Exception exception, string pathFormat, string path, Order order)
        {
            Logger.LogError(exception, "An error occurred while sending the request to the server.");
            OnErrorPlaceOrder(exception, pathFormat, path, order);
        }

        /// <summary>
        /// A partial method that gives developers a way to provide customized exception handling
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="pathFormat"></param>
        /// <param name="path"></param>
        /// <param name="order"></param>
        partial void OnErrorPlaceOrder(Exception exception, string pathFormat, string path, Order order);

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <param name="order">order placed for purchasing the pet</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Order"/></returns>
        public async Task<ApiResponse<Order>> PlaceOrderOrDefaultAsync(Order order, System.Threading.CancellationToken cancellationToken = default)
        {
            try
            {
                return await PlaceOrderAsync(order, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Place an order for a pet 
        /// </summary>
        /// <exception cref="ApiException">Thrown when fails to make API call</exception>
        /// <param name="order">order placed for purchasing the pet</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns><see cref="Task"/>&lt;<see cref="ApiResponse{T}"/>&gt; where T : <see cref="Order"/></returns>
        public async Task<ApiResponse<Order>> PlaceOrderAsync(Order order, System.Threading.CancellationToken cancellationToken = default)
        {
            UriBuilder uriBuilderLocalVar = new UriBuilder();

            try
            {
                ValidatePlaceOrder(order);

                FormatPlaceOrder(order);

                using (HttpRequestMessage httpRequestMessageLocalVar = new HttpRequestMessage())
                {
                    uriBuilderLocalVar.Host = HttpClient.BaseAddress.Host;
                    uriBuilderLocalVar.Port = HttpClient.BaseAddress.Port;
                    uriBuilderLocalVar.Scheme = HttpClient.BaseAddress.Scheme;
                    uriBuilderLocalVar.Path = ClientUtils.CONTEXT_PATH + "/store/order";

                    httpRequestMessageLocalVar.Content = (order as object) is System.IO.Stream stream
                        ? httpRequestMessageLocalVar.Content = new StreamContent(stream)
                        : httpRequestMessageLocalVar.Content = new StringContent(JsonSerializer.Serialize(order, _jsonSerializerOptions));

                    httpRequestMessageLocalVar.RequestUri = uriBuilderLocalVar.Uri;

                    string[] contentTypes = new string[] {
                        "application/json"
                    };

                    string contentTypeLocalVar = ClientUtils.SelectHeaderContentType(contentTypes);

                    if (contentTypeLocalVar != null)
                        httpRequestMessageLocalVar.Content.Headers.ContentType = new MediaTypeHeaderValue(contentTypeLocalVar);

                    string[] acceptLocalVars = new string[] {
                        "application/xml",
                        "application/json"
                    };

                    string acceptLocalVar = ClientUtils.SelectHeaderAccept(acceptLocalVars);

                    if (acceptLocalVar != null)
                        httpRequestMessageLocalVar.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue(acceptLocalVar));
                    httpRequestMessageLocalVar.Method = new HttpMethod("POST");

                    DateTime requestedAtLocalVar = DateTime.UtcNow;

                    using (HttpResponseMessage httpResponseMessageLocalVar = await HttpClient.SendAsync(httpRequestMessageLocalVar, cancellationToken).ConfigureAwait(false))
                    {
                        string responseContentLocalVar = await httpResponseMessageLocalVar.Content.ReadAsStringAsync().ConfigureAwait(false);

                        ApiResponse<Order> apiResponseLocalVar = new ApiResponse<Order>(httpRequestMessageLocalVar, httpResponseMessageLocalVar, responseContentLocalVar, "/store/order", requestedAtLocalVar, _jsonSerializerOptions);

                        AfterPlaceOrderDefaultImplementation(apiResponseLocalVar, order);

                        return apiResponseLocalVar;
                    }
                }
            }
            catch(Exception e)
            {
                OnErrorPlaceOrderDefaultImplementation(e, "/store/order", uriBuilderLocalVar.Path, order);
                throw;
            }
        }
    }
}
