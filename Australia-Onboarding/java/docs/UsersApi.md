# UsersApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**supplementaryCardApplicationStatusInquiry**](UsersApi.md#supplementaryCardApplicationStatusInquiry) | **GET** /v1/onboarding/supplementary/applications/{applicationId}/status | Check Supplementary Application Status

<a name="supplementaryCardApplicationStatusInquiry"></a>
# **supplementaryCardApplicationStatusInquiry**
> SupplementaryCardApplicationStatusInquiryResponse supplementaryCardApplicationStatusInquiry(authorization, uuid, accept, clientId, applicationId, dateOfBirth, motherMaidenName, clientDetails)

Check Supplementary Application Status

This API is used to check the status of the supplementary application.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.UsersApi;


UsersApi apiInstance = new UsersApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
String applicationId = "applicationId_example"; // String | This refers to Unique identifier for the application.
String dateOfBirth = "dateOfBirth_example"; // String | Applicant's date of birth in  ISO 8601 date format YYYY-MM-DD
String motherMaidenName = "motherMaidenName_example"; // String | Mother's maiden name
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    SupplementaryCardApplicationStatusInquiryResponse result = apiInstance.supplementaryCardApplicationStatusInquiry(authorization, uuid, accept, clientId, applicationId, dateOfBirth, motherMaidenName, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling UsersApi#supplementaryCardApplicationStatusInquiry");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer on-boarding |
 **applicationId** | **String**| This refers to Unique identifier for the application. |
 **dateOfBirth** | **String**| Applicant&#x27;s date of birth in  ISO 8601 date format YYYY-MM-DD |
 **motherMaidenName** | **String**| Mother&#x27;s maiden name |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**SupplementaryCardApplicationStatusInquiryResponse**](SupplementaryCardApplicationStatusInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

