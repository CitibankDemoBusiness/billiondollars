# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveUnmaskedAccountData**](AccountsApi.md#retrieveunmaskedaccountdata) | **POST** /v1/accounts/clearData/retrieve | This API provides unmasked account number for the requested account Id.

<a name="retrieveunmaskedaccountdata"></a>
# **RetrieveUnmaskedAccountData**
> RetrieveUnmaskedAccountDataResponse RetrieveUnmaskedAccountData (RetrieveUnmaskedAccountDataRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API provides unmasked account number for the requested account Id.

This API returns unmasked account number for the requested account Id. To retrieve the unmasked account number, simply pass the account id parameter, which you can get from the ‘Account Summary’ API for Accounts (AIS) and Source account eligibility API for Money Movement (PIS).Note: This API works for both Accounts (AIS) and Money Movement (PIS) APIs.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveUnmaskedAccountDataExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new RetrieveUnmaskedAccountDataRequest(); // RetrieveUnmaskedAccountDataRequest | RetrieveUnmaskedAccountDataRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random universally unique identifier (UUID) generated for every request.
            var accept = accept_example;  // string | Content-Types that are acceptable for the response. Always pass application/json.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId. (optional) 

            try
            {
                // This API provides unmasked account number for the requested account Id.
                RetrieveUnmaskedAccountDataResponse result = apiInstance.RetrieveUnmaskedAccountData(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.RetrieveUnmaskedAccountData: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveUnmaskedAccountDataRequest**](RetrieveUnmaskedAccountDataRequest.md)| RetrieveUnmaskedAccountDataRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random universally unique identifier (UUID) generated for every request. | 
 **accept** | **string**| Content-Types that are acceptable for the response. Always pass application/json. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId. | [optional] 

### Return type

[**RetrieveUnmaskedAccountDataResponse**](RetrieveUnmaskedAccountDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
