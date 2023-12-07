# IO.Swagger.Api.PaymentsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ExecutePaymentInitiationTransactionMultipleTransfersAsync**](PaymentsApi.md#executepaymentinitiationtransactionmultipletransfersasync) | **POST** /v1/paymentInitiation/multipleTransfers/async | Execute Multiple Transfers
[**ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync**](PaymentsApi.md#executepaymentinitiationtransactionmultipletransfersconfirmationasync) | **POST** /v1/paymentInitiation/multipleTransfers/confirmation/async | Execute Multiple Transfers Confirmation
[**RetrievePaymentInitiationTransactionRepeatingPayments**](PaymentsApi.md#retrievepaymentinitiationtransactionrepeatingpayments) | **GET** /v1/paymentInitiation/repeatingPayments | Standing Instruction Inquiry for Specific Payment Type
[**TerminatePaymentInitiationTransactionRepeatingPayments**](PaymentsApi.md#terminatepaymentinitiationtransactionrepeatingpayments) | **DELETE** /v1/paymentInitiation/{accountId}/repeatingPayments/{transactionReferenceId} | Delete the Standing Instruction for a Specific Transfer Type
[**UpdatePaymentInitiationTransactionRepeatingPayments**](PaymentsApi.md#updatepaymentinitiationtransactionrepeatingpayments) | **PUT** /v1/paymentInitiation/repeatingPayments | Update Standing Instruction for Specific Transfer Type
[**UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation**](PaymentsApi.md#updatepaymentinitiationtransactionrepeatingpaymentsconfirmation) | **PUT** /v1/paymentInitiation/repeatingPayments/confirmation | Update Standing Instruction Confirmation
[**UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess**](PaymentsApi.md#updatepaymentinitiationtransactionrepeatingpaymentspreprocess) | **POST** /v1/paymentInitiation/repeatingPayments/preprocess | Pre Process for Standing Instruction Update

<a name="executepaymentinitiationtransactionmultipletransfersasync"></a>
# **ExecutePaymentInitiationTransactionMultipleTransfersAsync**
> ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse ExecutePaymentInitiationTransactionMultipleTransfersAsync (ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Execute Multiple Transfers

This API is used for retail Citi Customers to process multiple payment requests for predefined payees. In case authorization is required, this API will throw mfaRequried error.  Prerequisite: Retrieve the applicable payment types, eligible source accounts and payees combination from RetrievePaymentInitiationTransactionBulkSourceAccountAndPayeeEligibility API

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePaymentInitiationTransactionMultipleTransfersAsyncExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest(); // ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest | ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Execute Multiple Transfers
                ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse result = apiInstance.ExecutePaymentInitiationTransactionMultipleTransfersAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.ExecutePaymentInitiationTransactionMultipleTransfersAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest**](ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest.md)| ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse**](ExecutePaymentInitiationTransactionMultipleTransfersAsyncResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="executepaymentinitiationtransactionmultipletransfersconfirmationasync"></a>
# **ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync**
> ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync (ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Execute Multiple Transfers Confirmation

This API is a confirmation API of multiple transfer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest(); // ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest | ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Execute Multiple Transfers Confirmation
                ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse result = apiInstance.ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsync: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest**](ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest.md)| ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse**](ExecutePaymentInitiationTransactionMultipleTransfersConfirmationAsyncResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievepaymentinitiationtransactionrepeatingpayments"></a>
# **RetrievePaymentInitiationTransactionRepeatingPayments**
> RetrievePaymentInitiationTransactionRepeatingPaymentsResponse RetrievePaymentInitiationTransactionRepeatingPayments (string authorization, string uuid, string accept, string clientId, string paymentType = null, string nextStartIndex = null, string clientDetails = null)

Standing Instruction Inquiry for Specific Payment Type

This API makes an inquiry of Standing Instruction of specific payment transfer type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrievePaymentInitiationTransactionRepeatingPaymentsExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var paymentType = paymentType_example;  // string | This defines the type of payment made by customer for which SI needs to be enabled.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Standing Instruction Inquiry for Specific Payment Type
                RetrievePaymentInitiationTransactionRepeatingPaymentsResponse result = apiInstance.RetrievePaymentInitiationTransactionRepeatingPayments(authorization, uuid, accept, clientId, paymentType, nextStartIndex, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.RetrievePaymentInitiationTransactionRepeatingPayments: " + e.Message );
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
 **paymentType** | **string**| This defines the type of payment made by customer for which SI needs to be enabled.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrievePaymentInitiationTransactionRepeatingPaymentsResponse**](RetrievePaymentInitiationTransactionRepeatingPaymentsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="terminatepaymentinitiationtransactionrepeatingpayments"></a>
# **TerminatePaymentInitiationTransactionRepeatingPayments**
> void TerminatePaymentInitiationTransactionRepeatingPayments (string authorization, string uuid, string accept, string clientId, string contentType, string accountId, string transactionReferenceId, string clientDetails = null)

Delete the Standing Instruction for a Specific Transfer Type

This API lets the customer remove Standing instructions for a specific transfer type/ payee type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class TerminatePaymentInitiationTransactionRepeatingPaymentsExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var accountId = accountId_example;  // string | The account identifier in encrypted format.Typically, this is not displayed to the customer.
            var transactionReferenceId = transactionReferenceId_example;  // string | The unique SI reference Id used to identify the payee type/ transfer from all the other transfers
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Delete the Standing Instruction for a Specific Transfer Type
                apiInstance.TerminatePaymentInitiationTransactionRepeatingPayments(authorization, uuid, accept, clientId, contentType, accountId, transactionReferenceId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.TerminatePaymentInitiationTransactionRepeatingPayments: " + e.Message );
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
 **contentType** | **string**| application/json | 
 **accountId** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
 **transactionReferenceId** | **string**| The unique SI reference Id used to identify the payee type/ transfer from all the other transfers | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepaymentinitiationtransactionrepeatingpayments"></a>
# **UpdatePaymentInitiationTransactionRepeatingPayments**
> void UpdatePaymentInitiationTransactionRepeatingPayments (UpdatePaymentInitiationTransactionRepeatingPaymentsRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Update Standing Instruction for Specific Transfer Type

This API lets the customer update Standing instructions for a specific transfer type/ payee type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePaymentInitiationTransactionRepeatingPaymentsExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new UpdatePaymentInitiationTransactionRepeatingPaymentsRequest(); // UpdatePaymentInitiationTransactionRepeatingPaymentsRequest | UpdatePaymentInitiationTransactionRepeatingPaymentsRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Update Standing Instruction for Specific Transfer Type
                apiInstance.UpdatePaymentInitiationTransactionRepeatingPayments(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePaymentInitiationTransactionRepeatingPayments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdatePaymentInitiationTransactionRepeatingPaymentsRequest**](UpdatePaymentInitiationTransactionRepeatingPaymentsRequest.md)| UpdatePaymentInitiationTransactionRepeatingPaymentsRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepaymentinitiationtransactionrepeatingpaymentsconfirmation"></a>
# **UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation**
> UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation (UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Update Standing Instruction Confirmation

This API confirms the updated Standing instructions for a specific transfer type/ payee type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest(); // UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest | UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Update Standing Instruction Confirmation
                UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse result = apiInstance.UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest**](UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest.md)| UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse**](UpdatePaymentInitiationTransactionRepeatingPaymentsConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepaymentinitiationtransactionrepeatingpaymentspreprocess"></a>
# **UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess**
> UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess (UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Pre Process for Standing Instruction Update

This API shows the pre process page for customer to update Standing instructions for a specific transfer type/ payee type

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessExample
    {
        public void main()
        {
            var apiInstance = new PaymentsApi();
            var body = new UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest(); // UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest | UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Pre Process for Standing Instruction Update
                UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse result = apiInstance.UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PaymentsApi.UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest**](UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest.md)| UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse**](UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
