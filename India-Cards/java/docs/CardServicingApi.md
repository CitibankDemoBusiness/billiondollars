# CardServicingApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1CardsActivationsConfirmationPost**](CardServicingApi.md#v1CardsActivationsConfirmationPost) | **POST** /v1/cards/activations/confirmation | Confirm Card Activation Deactivation
[**v1CardsAtmPinResetConfirmationPost**](CardServicingApi.md#v1CardsAtmPinResetConfirmationPost) | **POST** /v1/cards/atmPin/reset/confirmation | Confirm ATM Pin Request
[**v1CardsAtmPinResetPut**](CardServicingApi.md#v1CardsAtmPinResetPut) | **PUT** /v1/cards/atmPin/reset | Reset ATM Pin
[**v1CardsOverseasUsageConfirmationPost**](CardServicingApi.md#v1CardsOverseasUsageConfirmationPost) | **POST** /v1/cards/overseasUsage/confirmation | Confirm Card Overseas Activation Deactivation

<a name="v1CardsActivationsConfirmationPost"></a>
# **v1CardsActivationsConfirmationPost**
> v1CardsActivationsConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Confirm Card Activation Deactivation

This API is triggered after initiating the Card activation/de-activation request  and completes card activation/de-activation post successful multifactor authentication.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardServicingApi;


CardServicingApi apiInstance = new CardServicingApi();
CardUsageConfirmationRequest body = new CardUsageConfirmationRequest(); // CardUsageConfirmationRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsActivationsConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardServicingApi#v1CardsActivationsConfirmationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardUsageConfirmationRequest**](CardUsageConfirmationRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsAtmPinResetConfirmationPost"></a>
# **v1CardsAtmPinResetConfirmationPost**
> ResetAtmPinConfirmationResponse v1CardsAtmPinResetConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Confirm ATM Pin Request

This API is triggered after the reset ATM Pin request and completes ATM Pin reset post successful multifactor authentication.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardServicingApi;


CardServicingApi apiInstance = new CardServicingApi();
ResetAtmPinConfirmationRequest body = new ResetAtmPinConfirmationRequest(); // ResetAtmPinConfirmationRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    ResetAtmPinConfirmationResponse result = apiInstance.v1CardsAtmPinResetConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardServicingApi#v1CardsAtmPinResetConfirmationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetAtmPinConfirmationRequest**](ResetAtmPinConfirmationRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**ResetAtmPinConfirmationResponse**](ResetAtmPinConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsAtmPinResetPut"></a>
# **v1CardsAtmPinResetPut**
> v1CardsAtmPinResetPut(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Reset ATM Pin

This API is used to reset the ATM Pin of the cards.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardServicingApi;


CardServicingApi apiInstance = new CardServicingApi();
ResetAtmPinRequest body = new ResetAtmPinRequest(); // ResetAtmPinRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsAtmPinResetPut(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardServicingApi#v1CardsAtmPinResetPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ResetAtmPinRequest**](ResetAtmPinRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsOverseasUsageConfirmationPost"></a>
# **v1CardsOverseasUsageConfirmationPost**
> v1CardsOverseasUsageConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Confirm Card Overseas Activation Deactivation

This API is triggered after initiating the Card Overseas usage activation/deactivation request and completes the overseas usage activation/deactivation post successful multifactor authentication

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardServicingApi;


CardServicingApi apiInstance = new CardServicingApi();
CardOverseasUsageConfirmationRequest body = new CardOverseasUsageConfirmationRequest(); // CardOverseasUsageConfirmationRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsOverseasUsageConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardServicingApi#v1CardsOverseasUsageConfirmationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardOverseasUsageConfirmationRequest**](CardOverseasUsageConfirmationRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

