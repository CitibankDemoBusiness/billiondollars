# IO.Swagger.Api.UsersApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SupplementaryCardApplicationStatusInquiry**](UsersApi.md#supplementarycardapplicationstatusinquiry) | **GET** /v1/onboarding/supplementary/applications/{applicationId}/status | Check Supplementary Application Status

<a name="supplementarycardapplicationstatusinquiry"></a>
# **SupplementaryCardApplicationStatusInquiry**
> SupplementaryCardApplicationStatusInquiryResponse SupplementaryCardApplicationStatusInquiry (string authorization, string uuid, string accept, string clientId, string applicationId, string dateOfBirth, string motherMaidenName, string clientDetails = null)

Check Supplementary Application Status

This API is used to check the status of the supplementary application.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class SupplementaryCardApplicationStatusInquiryExample
    {
        public void main()
        {
            var apiInstance = new UsersApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer on-boarding
            var applicationId = applicationId_example;  // string | This refers to Unique identifier for the application.
            var dateOfBirth = dateOfBirth_example;  // string | Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
            var motherMaidenName = motherMaidenName_example;  // string | Mother's maiden name
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Check Supplementary Application Status
                SupplementaryCardApplicationStatusInquiryResponse result = apiInstance.SupplementaryCardApplicationStatusInquiry(authorization, uuid, accept, clientId, applicationId, dateOfBirth, motherMaidenName, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling UsersApi.SupplementaryCardApplicationStatusInquiry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer on-boarding | 
 **applicationId** | **string**| This refers to Unique identifier for the application. | 
 **dateOfBirth** | **string**| Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD | 
 **motherMaidenName** | **string**| Mother&#x27;s maiden name | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**SupplementaryCardApplicationStatusInquiryResponse**](SupplementaryCardApplicationStatusInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
