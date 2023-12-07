# IO.Swagger.Api.CrossProductUtilitiesApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateCard**](CrossProductUtilitiesApi.md#activatecard) | **PUT** /v1/prelogin/cards/{cardId}/activations | This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.
[**ChangeAtmPin**](CrossProductUtilitiesApi.md#changeatmpin) | **PUT** /v1/prelogin/cards/atmPin/change | This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.

<a name="activatecard"></a>
# **ActivateCard**
> void ActivateCard (ActivateCardRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ActivateCardExample
    {
        public void main()
        {
            var apiInstance = new CrossProductUtilitiesApi();
            var body = new ActivateCardRequest(); // ActivateCardRequest | ActivateCardRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | Hashed card number of the customer
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI's developer portal. In case this API is exposed to external party, TISO review will be required.
                apiInstance.ActivateCard(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrossProductUtilitiesApi.ActivateCard: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActivateCardRequest**](ActivateCardRequest.md)| ActivateCardRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| Hashed card number of the customer | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="changeatmpin"></a>
# **ChangeAtmPin**
> void ChangeAtmPin (ChangeAtmPinRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal. In  case this API is exposed to external party, TISO review will be required.

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal.  In case this API is exposed to external party, TISO review will be required.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ChangeAtmPinExample
    {
        public void main()
        {
            var apiInstance = new CrossProductUtilitiesApi();
            var body = new ChangeAtmPinRequest(); // ChangeAtmPinRequest | ChangeAtmPinRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI's developer portal. In  case this API is exposed to external party, TISO review will be required.
                apiInstance.ChangeAtmPin(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CrossProductUtilitiesApi.ChangeAtmPin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeAtmPinRequest**](ChangeAtmPinRequest.md)| ChangeAtmPinRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
