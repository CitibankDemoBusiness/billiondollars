# CustomerFoundationalApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**evaluateCustomerEligibilityAssessmentCheckPreLogin**](CustomerFoundationalApi.md#evaluateCustomerEligibilityAssessmentCheckPreLogin) | **GET** /v1/preLogin/customerProductServiceEligibility/check/offers/{offerId} | This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

<a name="evaluateCustomerEligibilityAssessmentCheckPreLogin"></a>
# **evaluateCustomerEligibilityAssessmentCheckPreLogin**
> EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse evaluateCustomerEligibilityAssessmentCheckPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount)

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

This API lists the options for pre login loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees.

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
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
BigDecimal loanAmount = new BigDecimal(); // BigDecimal | Loan amount for easy payment plan booking.
try {
    EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse result = apiInstance.evaluateCustomerEligibilityAssessmentCheckPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, loanAmount);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CustomerFoundationalApi#evaluateCustomerEligibilityAssessmentCheckPreLogin");
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
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **loanAmount** | **BigDecimal**| Loan amount for easy payment plan booking. | [optional]

### Return type

[**EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse**](EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

