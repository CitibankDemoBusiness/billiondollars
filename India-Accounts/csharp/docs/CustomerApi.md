# IO.Swagger.Api.CustomerApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SufficiencyOfFunds**](CustomerApi.md#sufficiencyoffunds) | **GET** /v1/accounts/{accountId}/funds/sufficiencyCheck | Check Availability of Funds

<a name="sufficiencyoffunds"></a>
# **SufficiencyOfFunds**
> SufficiencyOfFundsResponse SufficiencyOfFunds (string authorization, string uuid, string accept, string clientId, double? sufficiencyCheckAmount, string accountId, string currencyCode, string clientDetails = null)

Check Availability of Funds

This API returns a yes or no, based on the availability of requested funds in the customer’s account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SufficiencyOfFundsExample
    {
        public void main()
        {
            var apiInstance = new CustomerApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var sufficiencyCheckAmount = 1.2;  // double? | Specifies amount to check account for sufficiency.
            var accountId = accountId_example;  // string | IBAN number of the customer.
            var currencyCode = currencyCode_example;  // string | Currency Code in ISO 4217 format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Check Availability of Funds
                SufficiencyOfFundsResponse result = apiInstance.SufficiencyOfFunds(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerApi.SufficiencyOfFunds: " + e.Message );
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
 **sufficiencyCheckAmount** | **double?**| Specifies amount to check account for sufficiency. | 
 **accountId** | **string**| IBAN number of the customer. | 
 **currencyCode** | **string**| Currency Code in ISO 4217 format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SufficiencyOfFundsResponse**](SufficiencyOfFundsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
