# IO.Swagger.Api.PaymentApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecutePaymentInitiationTransactionAdhocMultipleTransferAsync**](PaymentApi.md#executepaymentinitiationtransactionadhocmultipletransferasync) | **POST** /v1/paymentInitiation/adhoc/multipleTransfers/async | Execute Multiple Transfers for Adhoc Payees
[**ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsync**](PaymentApi.md#executepaymentinitiationtransactionadhocmultipletransferconfirmationasync) | **POST** /v1/paymentInitiation/adhoc/multipleTransfers/confirmation/async | Execute Multiple Transfers Confirmation for Adhoc Payees
[**RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility**](PaymentApi.md#retrievepaymentinitiationtransactionbulksourceaccountandpayeeeligibility) | **GET** /v1/paymentInitiation/bulk/sourceAccountAndPayees/eligibility | Bulk Source Account Payee Eligibility Inquiry
[**RetrievePaymentInitiationTransactionMultipleTransfersStatus**](PaymentApi.md#retrievepaymentinitiationtransactionmultipletransfersstatus) | **GET** /v1/paymentInitiation/multipleTransfers/{citiBundleId}/status | Retrieve the status of all transactions executed in one bundle

<a name="executepaymentinitiationtransactionadhocmultipletransferasync"></a>
# **ExecutePaymentInitiationTransactionAdhocMultipleTransferAsync**
> ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncResponse ExecutePaymentInitiationTransactionAdhocMultipleTransferAsync (ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null, string nextStartIndex = null)

Execute Multiple Transfers for Adhoc Payees

This API is used for Citi Business customers to process multiple payment requests for Adhoc payees.  In case authorization is required, this API will throw mfa Requried error.  Prerequisite: Retrieve the applicable payment types, eligible source accounts from RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncExample
    {
        public void main()
        {
            var apiInstance = new PaymentApi();
            var body = new ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest(); // ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest | ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // Execute Multiple Transfers for Adhoc Payees
                ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncResponse result = apiInstance.ExecutePaymentInitiationTransactionAdhocMultipleTransferAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.ExecutePaymentInitiationTransactionAdhocMultipleTransferAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest**](ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest.md)| ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncResponse**](ExecutePaymentInitiationTransactionAdhocMultipleTransferAsyncResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executepaymentinitiationtransactionadhocmultipletransferconfirmationasync"></a>
# **ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsync**
> ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncResponse ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsync (ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Execute Multiple Transfers Confirmation for Adhoc Payees

This API is used for confirmation of multiple transfers to adhoc payees In case authorization is required, customer will be redirected to authorization page. Once authorization is confirmed as successful, this API will be used to trigger confirmation of multiple payments.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncExample
    {
        public void main()
        {
            var apiInstance = new PaymentApi();
            var body = new ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest(); // ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest | ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Execute Multiple Transfers Confirmation for Adhoc Payees
                ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncResponse result = apiInstance.ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest**](ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest.md)| ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncResponse**](ExecutePaymentInitiationTransactionAdhocMultipleTransferConfirmationAsyncResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievepaymentinitiationtransactionbulksourceaccountandpayeeeligibility"></a>
# **RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility**
> RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibilityResponse RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility (string authorization, string uuid, string accept, string clientId, string clientDetails = null, string nextStartIndex = null)

Bulk Source Account Payee Eligibility Inquiry

This API is used to inquire the eligibility source accounts for specific payment types for an authenticated Citi Customer. This information can be used to prepare a valid source list for a selected destination, or vice versa.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibilityExample
    {
        public void main()
        {
            var apiInstance = new PaymentApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // Bulk Source Account Payee Eligibility Inquiry
                RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibilityResponse result = apiInstance.RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility(authorization, uuid, accept, clientId, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibilityResponse**](RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievepaymentinitiationtransactionmultipletransfersstatus"></a>
# **RetrievePaymentInitiationTransactionMultipleTransfersStatus**
> RetrievePaymentInitiationTransactionMultipleTransfersStatusResponse RetrievePaymentInitiationTransactionMultipleTransfersStatus (string authorization, string uuid, string accept, string clientId, string citiBundleId, string clientDetails = null, string startIndex = null)

Retrieve the status of all transactions executed in one bundle

This API is used to retrieve the status of all transactions executed in one bundle as part of ExecutePaymentInitiationTransactionMultipleTransfersAsync/ExecutePaymentInitiationTransactionAdhocMultipleTransfersAsync

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievePaymentInitiationTransactionMultipleTransfersStatusExample
    {
        public void main()
        {
            var apiInstance = new PaymentApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var citiBundleId = citiBundleId_example;  // string | This is bundle id or unique identifier for bulk transfers shared when the transactions order was taken
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var startIndex = startIndex_example;  // string | to request subsequent transactions in the bundle, the nextstartindex given in the previous call should be passed here (optional) 

            try
            {
                // Retrieve the status of all transactions executed in one bundle
                RetrievePaymentInitiationTransactionMultipleTransfersStatusResponse result = apiInstance.RetrievePaymentInitiationTransactionMultipleTransfersStatus(authorization, uuid, accept, clientId, citiBundleId, clientDetails, startIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentApi.RetrievePaymentInitiationTransactionMultipleTransfersStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **citiBundleId** | **string**| This is bundle id or unique identifier for bulk transfers shared when the transactions order was taken | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **startIndex** | **string**| to request subsequent transactions in the bundle, the nextstartindex given in the previous call should be passed here | [optional] 

### Return type

[**RetrievePaymentInitiationTransactionMultipleTransfersStatusResponse**](RetrievePaymentInitiationTransactionMultipleTransfersStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
