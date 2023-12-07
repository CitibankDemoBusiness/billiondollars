# IO.Swagger.Api.CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](CustomerFoundationalApi.md#retrievecustomerreferencedatadirectoryentrycorporatecardcustomercontact) | **POST** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts/retrieve | This API is used to inquire the Customer contact details.
[**UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](CustomerFoundationalApi.md#updatecustomerreferencedatadirectoryentrycorporatecardcustomercontact) | **PUT** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts | This API is used to update customer contact details

<a name="retrievecustomerreferencedatadirectoryentrycorporatecardcustomercontact"></a>
# **RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**
> RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact (string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to inquire the Customer contact details.

This API is used to inquire the Customer contact details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactExample
    {
        public void main()
        {
            var apiInstance = new CustomerFoundationalApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to inquire the Customer contact details.
                RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse result = apiInstance.RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFoundationalApi.RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact: " + e.Message );
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
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse**](RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomerreferencedatadirectoryentrycorporatecardcustomercontact"></a>
# **UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**
> void UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact (string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to update customer contact details

This API is used to update customer contact details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactExample
    {
        public void main()
        {
            var apiInstance = new CustomerFoundationalApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to update customer contact details
                apiInstance.UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomerFoundationalApi.UpdateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact: " + e.Message );
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
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
