# IO.Swagger.Api.AccountsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditLimitDecrease**](AccountsApi.md#creditlimitdecrease) | **PUT** /v1/creditCards/creditLimits/decrease | Decrease Credit Limit
[**CreditLimitDecreaseConsent**](AccountsApi.md#creditlimitdecreaseconsent) | **PUT** /v1/creditCards/creditLimits/decrease/consents | Decrease Credit Limit with Consent

<a name="creditlimitdecrease"></a>
# **CreditLimitDecrease**
> CreditLimitDecreaseResponse CreditLimitDecrease (CreditLimitDecreaseRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Decrease Credit Limit

This API allows the customer to submit a request for the credit limit decrease.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreditLimitDecreaseExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new CreditLimitDecreaseRequest(); // CreditLimitDecreaseRequest | CreditLimitDecreaseRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer on-boarding
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Decrease Credit Limit
                CreditLimitDecreaseResponse result = apiInstance.CreditLimitDecrease(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreditLimitDecrease: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitDecreaseRequest**](CreditLimitDecreaseRequest.md)| CreditLimitDecreaseRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer on-boarding | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CreditLimitDecreaseResponse**](CreditLimitDecreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="creditlimitdecreaseconsent"></a>
# **CreditLimitDecreaseConsent**
> CreditLimitDecreaseConsentResponse CreditLimitDecreaseConsent (CreditLimitDecreaseConsentRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Decrease Credit Limit with Consent

This API allows the customer to submit a request for the credit limit decrease with consent.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CreditLimitDecreaseConsentExample
    {
        public void main()
        {
            var apiInstance = new AccountsApi();
            var body = new CreditLimitDecreaseConsentRequest(); // CreditLimitDecreaseConsentRequest | CreditLimitDecreaseConsentRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer on-boarding
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Decrease Credit Limit with Consent
                CreditLimitDecreaseConsentResponse result = apiInstance.CreditLimitDecreaseConsent(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling AccountsApi.CreditLimitDecreaseConsent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitDecreaseConsentRequest**](CreditLimitDecreaseConsentRequest.md)| CreditLimitDecreaseConsentRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer on-boarding | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CreditLimitDecreaseConsentResponse**](CreditLimitDecreaseConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
