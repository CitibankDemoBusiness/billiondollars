/* 
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IAccountApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Closure of Account
        /// </summary>
        /// <remarks>
        /// This API allows the customer to close the account or credit card.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>AccountClosureResponse</returns>
        AccountClosureResponse AccountClosure (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null);

        /// <summary>
        /// Closure of Account
        /// </summary>
        /// <remarks>
        /// This API allows the customer to close the account or credit card.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>ApiResponse of AccountClosureResponse</returns>
        ApiResponse<AccountClosureResponse> AccountClosureWithHttpInfo (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Closure of Account
        /// </summary>
        /// <remarks>
        /// This API allows the customer to close the account or credit card.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>Task of AccountClosureResponse</returns>
        System.Threading.Tasks.Task<AccountClosureResponse> AccountClosureAsync (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null);

        /// <summary>
        /// Closure of Account
        /// </summary>
        /// <remarks>
        /// This API allows the customer to close the account or credit card.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>Task of ApiResponse (AccountClosureResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AccountClosureResponse>> AccountClosureAsyncWithHttpInfo (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class AccountApi : IAccountApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AccountApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class
        /// </summary>
        /// <returns></returns>
        public AccountApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AccountApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Closure of Account This API allows the customer to close the account or credit card.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>AccountClosureResponse</returns>
        public AccountClosureResponse AccountClosure (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)
        {
             ApiResponse<AccountClosureResponse> localVarResponse = AccountClosureWithHttpInfo(body, authorization, uuid, accept, clientId, contentType, clientDetails);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Closure of Account This API allows the customer to close the account or credit card.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>ApiResponse of AccountClosureResponse</returns>
        public ApiResponse< AccountClosureResponse > AccountClosureWithHttpInfo (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AccountApi->AccountClosure");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling AccountApi->AccountClosure");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling AccountApi->AccountClosure");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling AccountApi->AccountClosure");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AccountApi->AccountClosure");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling AccountApi->AccountClosure");

            var localVarPath = "/v1/accounts/closure";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountClosure", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountClosureResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountClosureResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountClosureResponse)));
        }

        /// <summary>
        /// Closure of Account This API allows the customer to close the account or credit card.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>Task of AccountClosureResponse</returns>
        public async System.Threading.Tasks.Task<AccountClosureResponse> AccountClosureAsync (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)
        {
             ApiResponse<AccountClosureResponse> localVarResponse = await AccountClosureAsyncWithHttpInfo(body, authorization, uuid, accept, clientId, contentType, clientDetails);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Closure of Account This API allows the customer to close the account or credit card.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">AccountClosureRequest</param>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="contentType">application/json</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <returns>Task of ApiResponse (AccountClosureResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AccountClosureResponse>> AccountClosureAsyncWithHttpInfo (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling AccountApi->AccountClosure");
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling AccountApi->AccountClosure");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling AccountApi->AccountClosure");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling AccountApi->AccountClosure");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling AccountApi->AccountClosure");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling AccountApi->AccountClosure");

            var localVarPath = "/v1/accounts/closure";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AccountClosure", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<AccountClosureResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (AccountClosureResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(AccountClosureResponse)));
        }

    }
}
