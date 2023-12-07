# CrossProductUtilitiesApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**activateCard**](CrossProductUtilitiesApi.md#activateCard) | **PUT** /v1/prelogin/cards/{cardId}/activations | This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.
[**changeAtmPin**](CrossProductUtilitiesApi.md#changeAtmPin) | **PUT** /v1/prelogin/cards/atmPin/change | This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.
[**updateIssuedDeviceAllocationDevicePfid**](CrossProductUtilitiesApi.md#updateIssuedDeviceAllocationDevicePfid) | **POST** /v1/issuedDeviceAdministration/device/pfid | This API is used to receive the PFID from partner and maintain across the respective card.

<a name="activateCard"></a>
# **activateCard**
> activateCard(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.

This API is used to activate the credit or debit card in pre login scenario.This API will not be published in CITI&#x27;s developer portal. In case this API is exposed to external party, TISO review will be required.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CrossProductUtilitiesApi;


CrossProductUtilitiesApi apiInstance = new CrossProductUtilitiesApi();
ActivateCardRequest body = new ActivateCardRequest(); // ActivateCardRequest | ActivateCardRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | Hashed card number of the customer
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.activateCard(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CrossProductUtilitiesApi#activateCard");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ActivateCardRequest**](ActivateCardRequest.md)| ActivateCardRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| Hashed card number of the customer |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="changeAtmPin"></a>
# **changeAtmPin**
> changeAtmPin(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal. In  case this API is exposed to external party, TISO review will be required.

This API is used to change the pin of a debit or credit card in pre-login scenario. This API will not be published in CITI&#x27;s developer portal.  In case this API is exposed to external party, TISO review will be required.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CrossProductUtilitiesApi;


CrossProductUtilitiesApi apiInstance = new CrossProductUtilitiesApi();
ChangeAtmPinRequest body = new ChangeAtmPinRequest(); // ChangeAtmPinRequest | ChangeAtmPinRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.changeAtmPin(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CrossProductUtilitiesApi#changeAtmPin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ChangeAtmPinRequest**](ChangeAtmPinRequest.md)| ChangeAtmPinRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer  KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields  which will be passed as part of the header  devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifi MacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitu de,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateIssuedDeviceAllocationDevicePfid"></a>
# **updateIssuedDeviceAllocationDevicePfid**
> UpdateIssuedDeviceAllocationDevicePfidResponse updateIssuedDeviceAllocationDevicePfid(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is used to receive the PFID from partner and maintain across the respective card.

This API is used to receive the PFID from partner and maintain across the respective card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CrossProductUtilitiesApi;


CrossProductUtilitiesApi apiInstance = new CrossProductUtilitiesApi();
UpdateIssuedDeviceAllocationDevicePfidRequest body = new UpdateIssuedDeviceAllocationDevicePfidRequest(); // UpdateIssuedDeviceAllocationDevicePfidRequest | UpdateIssuedDeviceAllocationDevicePfidRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UpdateIssuedDeviceAllocationDevicePfidResponse result = apiInstance.updateIssuedDeviceAllocationDevicePfid(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CrossProductUtilitiesApi#updateIssuedDeviceAllocationDevicePfid");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateIssuedDeviceAllocationDevicePfidRequest**](UpdateIssuedDeviceAllocationDevicePfidRequest.md)| UpdateIssuedDeviceAllocationDevicePfidRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UpdateIssuedDeviceAllocationDevicePfidResponse**](UpdateIssuedDeviceAllocationDevicePfidResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

