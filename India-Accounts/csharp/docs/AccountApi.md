# IO.Swagger.Api.AccountApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountClosure**](AccountApi.md#accountclosure) | **POST** /v1/accounts/closure | Closure of Account

<a name="accountclosure"></a>
# **AccountClosure**
> AccountClosureResponse AccountClosure (AccountClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Closure of Account

This API allows the customer to close the account or credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class AccountClosureExample
    {
        public void main()
        {
            var apiInstance = new AccountApi();
            var body = new AccountClosureRequest(); // AccountClosureRequest | AccountClosureRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Closure of Account
                AccountClosureResponse result = apiInstance.AccountClosure(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountApi.AccountClosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**AccountClosureRequest**](AccountClosureRequest.md)| AccountClosureRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**AccountClosureResponse**](AccountClosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
