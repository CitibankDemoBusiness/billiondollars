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
        public interface ICustomerFoundationalApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <remarks>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse EvaluateCustomerEligibilityAssessmentCheckPreLogin (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null);

        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <remarks>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>ApiResponse of EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> EvaluateCustomerEligibilityAssessmentCheckPreLoginWithHttpInfo (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <remarks>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>Task of EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        System.Threading.Tasks.Task<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> EvaluateCustomerEligibilityAssessmentCheckPreLoginAsync (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null);

        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <remarks>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>Task of ApiResponse (EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse>> EvaluateCustomerEligibilityAssessmentCheckPreLoginAsyncWithHttpInfo (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CustomerFoundationalApi : ICustomerFoundationalApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFoundationalApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CustomerFoundationalApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFoundationalApi"/> class
        /// </summary>
        /// <returns></returns>
        public CustomerFoundationalApi()
        {
            this.Configuration = IO.Swagger.Client.Configuration.Default;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerFoundationalApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CustomerFoundationalApi(IO.Swagger.Client.Configuration configuration = null)
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
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees. This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        public EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse EvaluateCustomerEligibilityAssessmentCheckPreLogin (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null)
        {
             ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> localVarResponse = EvaluateCustomerEligibilityAssessmentCheckPreLoginWithHttpInfo(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount);
             return localVarResponse.Data;
        }

        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees. This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>ApiResponse of EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        public ApiResponse< EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse > EvaluateCustomerEligibilityAssessmentCheckPreLoginWithHttpInfo (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'offerId' is set
            if (offerId == null)
                throw new ApiException(400, "Missing required parameter 'offerId' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");

            var localVarPath = "/v1/preLogin/customerProductServiceEligibility/check/offers/{offerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (offerId != null) localVarPathParams.Add("offerId", this.Configuration.ApiClient.ParameterToString(offerId)); // path parameter
            if (loanAmount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "loanAmount", loanAmount)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EvaluateCustomerEligibilityAssessmentCheckPreLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse)));
        }

        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees. This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>Task of EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse</returns>
        public async System.Threading.Tasks.Task<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> EvaluateCustomerEligibilityAssessmentCheckPreLoginAsync (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null)
        {
             ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse> localVarResponse = await EvaluateCustomerEligibilityAssessmentCheckPreLoginAsyncWithHttpInfo(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount);
             return localVarResponse.Data;

        }

        /// <summary>
        /// This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees. This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="authorization">The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;.</param>
        /// <param name="uuid">128 bit random UUID generated uniquely for every request.</param>
        /// <param name="accept">Content-Type that are acceptable for the response.</param>
        /// <param name="clientId">Client ID generated during application registration.</param>
        /// <param name="offerId">This Refers to the unique id for the Pre login offer.</param>
        /// <param name="clientDetails">This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional)</param>
        /// <param name="loanAmount">Loan amount for easy payment plan booking. (optional)</param>
        /// <returns>Task of ApiResponse (EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse>> EvaluateCustomerEligibilityAssessmentCheckPreLoginAsyncWithHttpInfo (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, decimal? loanAmount = null)
        {
            // verify the required parameter 'authorization' is set
            if (authorization == null)
                throw new ApiException(400, "Missing required parameter 'authorization' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'uuid' is set
            if (uuid == null)
                throw new ApiException(400, "Missing required parameter 'uuid' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");
            // verify the required parameter 'offerId' is set
            if (offerId == null)
                throw new ApiException(400, "Missing required parameter 'offerId' when calling CustomerFoundationalApi->EvaluateCustomerEligibilityAssessmentCheckPreLogin");

            var localVarPath = "/v1/preLogin/customerProductServiceEligibility/check/offers/{offerId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (offerId != null) localVarPathParams.Add("offerId", this.Configuration.ApiClient.ParameterToString(offerId)); // path parameter
            if (loanAmount != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "loanAmount", loanAmount)); // query parameter
            if (authorization != null) localVarHeaderParams.Add("Authorization", this.Configuration.ApiClient.ParameterToString(authorization)); // header parameter
            if (uuid != null) localVarHeaderParams.Add("uuid", this.Configuration.ApiClient.ParameterToString(uuid)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (clientId != null) localVarHeaderParams.Add("client_id", this.Configuration.ApiClient.ParameterToString(clientId)); // header parameter
            if (clientDetails != null) localVarHeaderParams.Add("clientDetails", this.Configuration.ApiClient.ParameterToString(clientDetails)); // header parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EvaluateCustomerEligibilityAssessmentCheckPreLogin", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse)));
        }

    }
}
