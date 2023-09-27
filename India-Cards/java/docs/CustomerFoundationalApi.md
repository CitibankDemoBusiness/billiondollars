# CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](CustomerFoundationalApi.md#retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact) | **POST** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts/retrieve | This API is used to inquire the Customer contact details.
[**updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**](CustomerFoundationalApi.md#updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact) | **PUT** /partner/v1/customerReferenceDataManagement/corporateCardCustomer/contacts | This API is used to update customer contact details

<a name="retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact"></a>
# **retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**
> RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to inquire the Customer contact details.

This API is used to inquire the Customer contact details.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CustomerFoundationalApi;


CustomerFoundationalApi apiInstance = new CustomerFoundationalApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse result = apiInstance.retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CustomerFoundationalApi#retrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse**](RetrieveCustomerReferenceDataDirectoryEntryCorporateCardCustomerContactResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact"></a>
# **updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact**
> updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to update customer contact details

This API is used to update customer contact details

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CustomerFoundationalApi;


CustomerFoundationalApi apiInstance = new CustomerFoundationalApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact(authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CustomerFoundationalApi#updateCustomerReferenceDataDirectoryEntryCorporateCardCustomerContact");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

