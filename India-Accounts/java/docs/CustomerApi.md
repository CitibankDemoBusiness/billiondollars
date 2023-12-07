# CustomerApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**sufficiencyOfFunds**](CustomerApi.md#sufficiencyOfFunds) | **GET** /v1/accounts/{accountId}/funds/sufficiencyCheck | Check Availability of Funds

<a name="sufficiencyOfFunds"></a>
# **sufficiencyOfFunds**
> SufficiencyOfFundsResponse sufficiencyOfFunds(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails)

Check Availability of Funds

This API returns a yes or no, based on the availability of requested funds in the customer’s account.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CustomerApi;


CustomerApi apiInstance = new CustomerApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
Double sufficiencyCheckAmount = 3.4D; // Double | Specifies amount to check account for sufficiency.
String accountId = "accountId_example"; // String | IBAN number of the customer.
String currencyCode = "currencyCode_example"; // String | Currency Code in ISO 4217 format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    SufficiencyOfFundsResponse result = apiInstance.sufficiencyOfFunds(authorization, uuid, accept, clientId, sufficiencyCheckAmount, accountId, currencyCode, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CustomerApi#sufficiencyOfFunds");
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
 **sufficiencyCheckAmount** | **Double**| Specifies amount to check account for sufficiency. |
 **accountId** | **String**| IBAN number of the customer. |
 **currencyCode** | **String**| Currency Code in ISO 4217 format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**SufficiencyOfFundsResponse**](SufficiencyOfFundsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

