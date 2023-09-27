# AccountsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**creditLimitDecrease**](AccountsApi.md#creditLimitDecrease) | **PUT** /v1/creditCards/creditLimits/decrease | Decrease Credit Limit
[**creditLimitDecreaseConsent**](AccountsApi.md#creditLimitDecreaseConsent) | **PUT** /v1/creditCards/creditLimits/decrease/consents | Decrease Credit Limit with Consent

<a name="creditLimitDecrease"></a>
# **creditLimitDecrease**
> CreditLimitDecreaseResponse creditLimitDecrease(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Decrease Credit Limit

This API allows the customer to submit a request for the credit limit decrease.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
CreditLimitDecreaseRequest body = new CreditLimitDecreaseRequest(); // CreditLimitDecreaseRequest | CreditLimitDecreaseRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CreditLimitDecreaseResponse result = apiInstance.creditLimitDecrease(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#creditLimitDecrease");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitDecreaseRequest**](CreditLimitDecreaseRequest.md)| CreditLimitDecreaseRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer on-boarding |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CreditLimitDecreaseResponse**](CreditLimitDecreaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="creditLimitDecreaseConsent"></a>
# **creditLimitDecreaseConsent**
> CreditLimitDecreaseConsentResponse creditLimitDecreaseConsent(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Decrease Credit Limit with Consent

This API allows the customer to submit a request for the credit limit decrease with consent.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
CreditLimitDecreaseConsentRequest body = new CreditLimitDecreaseConsentRequest(); // CreditLimitDecreaseConsentRequest | CreditLimitDecreaseConsentRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CreditLimitDecreaseConsentResponse result = apiInstance.creditLimitDecreaseConsent(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#creditLimitDecreaseConsent");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditLimitDecreaseConsentRequest**](CreditLimitDecreaseConsentRequest.md)| CreditLimitDecreaseConsentRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer on-boarding |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CreditLimitDecreaseConsentResponse**](CreditLimitDecreaseConsentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

