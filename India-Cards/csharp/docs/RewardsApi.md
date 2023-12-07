# IO.Swagger.Api.RewardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1CreditCardsRewardsPointBalanceSearchPost**](RewardsApi.md#v1creditcardsrewardspointbalancesearchpost) | **POST** /v1/creditCards/rewards/pointBalance/search | This API is used to retrieve reward points balance for multiple credit cards

<a name="v1creditcardsrewardspointbalancesearchpost"></a>
# **V1CreditCardsRewardsPointBalanceSearchPost**
> RewardsInquiryResponse V1CreditCardsRewardsPointBalanceSearchPost (RewardsInquiryRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to retrieve reward points balance for multiple credit cards

This API is used to retrieve reward points balance for multiple credit cards

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CreditCardsRewardsPointBalanceSearchPostExample
    {
        public void main()
        {
            var apiInstance = new RewardsApi();
            var body = new RewardsInquiryRequest(); // RewardsInquiryRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | The client ID  you received during application registration in the developer portal
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to retrieve reward points balance for multiple credit cards
                RewardsInquiryResponse result = apiInstance.V1CreditCardsRewardsPointBalanceSearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RewardsApi.V1CreditCardsRewardsPointBalanceSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RewardsInquiryRequest**](RewardsInquiryRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| The client ID  you received during application registration in the developer portal | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RewardsInquiryResponse**](RewardsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
