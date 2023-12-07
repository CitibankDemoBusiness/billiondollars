# CreditCardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**companionCardApplication**](CreditCardsApi.md#companionCardApplication) | **POST** /v1/creditCards/{cardId}/companion/applications | Issuance of Companion Card
[**easyPaymentPlansTransactionEligibility**](CreditCardsApi.md#easyPaymentPlansTransactionEligibility) | **GET** /v1/creditCards/{cardId}/transactions/eligibility/easyPaymentPlan | Transaction Eligibility and Easy Payment Plans
[**v1CreditCardsCardIdEasyPaymentPlansBookingsPost**](CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansBookingsPost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings | Book Easy Payment Plan
[**v1CreditCardsCardIdEasyPaymentPlansEligibilityGet**](CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansEligibilityGet) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/eligibility | Check Easy Payment Plan Eligibility
[**v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet**](CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet) | **GET** /v1/creditCards/{cardId}/easyPaymentPlans/repaymentSchedules | Easy Payment Plan Repayment Schedule
[**v1CreditCardsCardIdEasyPaymentPlansSearchPost**](CreditCardsApi.md#v1CreditCardsCardIdEasyPaymentPlansSearchPost) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/search | Retrieve Easy Payment Plans Options
[**v1CreditCardsCardIdSupplementaryCardsGet**](CreditCardsApi.md#v1CreditCardsCardIdSupplementaryCardsGet) | **GET** /v1/creditCards/{cardId}/supplementaryCards | List Supplementary Cards
[**v1CreditCardsStatementsSummarySearchPost**](CreditCardsApi.md#v1CreditCardsStatementsSummarySearchPost) | **POST** /v1/creditCards/statements/summary/search | Retrieve Composite Credit Cards Statement Summary

<a name="companionCardApplication"></a>
# **companionCardApplication**
> CompanionCardApplicationResponse companionCardApplication(authorization, uuid, accept, contentType, clientId, cardId, body, clientDetails)

Issuance of Companion Card

This API is used to issue a new companion card for primary credit card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String contentType = "contentType_example"; // String | The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String cardId = "cardId_example"; // String | Card Id in encrypted format
CompanionCardApplicationRequest body = new CompanionCardApplicationRequest(); // CompanionCardApplicationRequest | CompanionCardApplicationRequest
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CompanionCardApplicationResponse result = apiInstance.companionCardApplication(authorization, uuid, accept, contentType, clientId, cardId, body, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#companionCardApplication");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **contentType** | **String**| The MIME type of the body of the request (used with POST and PUT requests). Always pass application/json. |
 **clientId** | **String**| Client ID generated during application registration. |
 **cardId** | **String**| Card Id in encrypted format |
 **body** | [**CompanionCardApplicationRequest**](CompanionCardApplicationRequest.md)| CompanionCardApplicationRequest | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CompanionCardApplicationResponse**](CompanionCardApplicationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="easyPaymentPlansTransactionEligibility"></a>
# **easyPaymentPlansTransactionEligibility**
> EasyPaymentPlansTransactionEligibilityResponse easyPaymentPlansTransactionEligibility(authorization, uuid, accept, clientId, cardId, eligbleLoanAmount, clientDetails)

Transaction Eligibility and Easy Payment Plans

This API is used to check the Easy Payment Plans eligibility for a card and the available Payment Plans details.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String cardId = "cardId_example"; // String | The card id in encrypted format.
Double eligbleLoanAmount = 3.4D; // Double | Elligible loan amount for easy payment plan booking..
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    EasyPaymentPlansTransactionEligibilityResponse result = apiInstance.easyPaymentPlansTransactionEligibility(authorization, uuid, accept, clientId, cardId, eligbleLoanAmount, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#easyPaymentPlansTransactionEligibility");
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
 **cardId** | **String**| The card id in encrypted format. |
 **eligbleLoanAmount** | **Double**| Elligible loan amount for easy payment plan booking.. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**EasyPaymentPlansTransactionEligibilityResponse**](EasyPaymentPlansTransactionEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CreditCardsCardIdEasyPaymentPlansBookingsPost"></a>
# **v1CreditCardsCardIdEasyPaymentPlansBookingsPost**
> EppLoanBookingResponse v1CreditCardsCardIdEasyPaymentPlansBookingsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

Book Easy Payment Plan

This API is triggered after the EPP plan selection and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
EppLoanBookingRequest body = new EppLoanBookingRequest(); // EppLoanBookingRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    EppLoanBookingResponse result = apiInstance.v1CreditCardsCardIdEasyPaymentPlansBookingsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsCardIdEasyPaymentPlansBookingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingRequest**](EppLoanBookingRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The card id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**EppLoanBookingResponse**](EppLoanBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CreditCardsCardIdEasyPaymentPlansEligibilityGet"></a>
# **v1CreditCardsCardIdEasyPaymentPlansEligibilityGet**
> EasyPaymentPlansEligibilityInquiryResponse v1CreditCardsCardIdEasyPaymentPlansEligibilityGet(authorization, uuid, accept, clientId, cardId, eppLoanBookingType, clientDetails, nextStartIndex)

Check Easy Payment Plan Eligibility

This API is used to validate the transaction eligibility for EPP conversion.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
String cardId = "cardId_example"; // String | Card Id in encrypted format.
String eppLoanBookingType = "eppLoanBookingType_example"; // String | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    EasyPaymentPlansEligibilityInquiryResponse result = apiInstance.v1CreditCardsCardIdEasyPaymentPlansEligibilityGet(authorization, uuid, accept, clientId, cardId, eppLoanBookingType, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsCardIdEasyPaymentPlansEligibilityGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client_id generated during consumer onboarding |
 **cardId** | **String**| Card Id in encrypted format. |
 **eppLoanBookingType** | **String**| Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**EasyPaymentPlansEligibilityInquiryResponse**](EasyPaymentPlansEligibilityInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet"></a>
# **v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet**
> EppRepaymentScheuleResponse v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet(authorization, uuid, accept, clientId, cardId, loanAmount, tenor, clientDetails, nextStartIndex)

Easy Payment Plan Repayment Schedule

This API allows the customer to view the payment breakdown details and the repayment schedule for the Easy Payment Plan selected.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String cardId = "cardId_example"; // String | The card id  in encrypted format.
Double loanAmount = 3.4D; // Double | Loan amount for easy payment plan booking.
BigDecimal tenor = new BigDecimal(); // BigDecimal | Tenure of loan in months.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    EppRepaymentScheuleResponse result = apiInstance.v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet(authorization, uuid, accept, clientId, cardId, loanAmount, tenor, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsCardIdEasyPaymentPlansRepaymentSchedulesGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer onboarding |
 **cardId** | **String**| The card id  in encrypted format. |
 **loanAmount** | **Double**| Loan amount for easy payment plan booking. |
 **tenor** | **BigDecimal**| Tenure of loan in months. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**EppRepaymentScheuleResponse**](EppRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CreditCardsCardIdEasyPaymentPlansSearchPost"></a>
# **v1CreditCardsCardIdEasyPaymentPlansSearchPost**
> EppResponse v1CreditCardsCardIdEasyPaymentPlansSearchPost(body, authorization, uuid, accept, clientId, cardId, clientDetails)

Retrieve Easy Payment Plans Options

This API retrieves the available Easy Payment Plans to be used by the customer for the repayment of his/her loans.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
EppRequest body = new EppRequest(); // EppRequest | Easy payment plan Request
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String cardId = "cardId_example"; // String | The card id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    EppResponse result = apiInstance.v1CreditCardsCardIdEasyPaymentPlansSearchPost(body, authorization, uuid, accept, clientId, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsCardIdEasyPaymentPlansSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppRequest**](EppRequest.md)| Easy payment plan Request |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer onboarding |
 **cardId** | **String**| The card id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**EppResponse**](EppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CreditCardsCardIdSupplementaryCardsGet"></a>
# **v1CreditCardsCardIdSupplementaryCardsGet**
> SupplementaryCardListingResponse v1CreditCardsCardIdSupplementaryCardsGet(authorization, uuid, accept, clientId, cardId, clientDetails)

List Supplementary Cards

This API retrieves the details of all the supplementary cards associated with the primary card id in the request.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String cardId = "cardId_example"; // String | The primary card id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    SupplementaryCardListingResponse result = apiInstance.v1CreditCardsCardIdSupplementaryCardsGet(authorization, uuid, accept, clientId, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsCardIdSupplementaryCardsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer onboarding |
 **cardId** | **String**| The primary card id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**SupplementaryCardListingResponse**](SupplementaryCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CreditCardsStatementsSummarySearchPost"></a>
# **v1CreditCardsStatementsSummarySearchPost**
> CardStatementSummaryResponse v1CreditCardsStatementsSummarySearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Retrieve Composite Credit Cards Statement Summary

This API is used to retrieve the statement summary for multiple credit cards in a single request.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CreditCardsApi;


CreditCardsApi apiInstance = new CreditCardsApi();
CardStatementSummaryRequest body = new CardStatementSummaryRequest(); // CardStatementSummaryRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CardStatementSummaryResponse result = apiInstance.v1CreditCardsStatementsSummarySearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CreditCardsApi#v1CreditCardsStatementsSummarySearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardStatementSummaryRequest**](CardStatementSummaryRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CardStatementSummaryResponse**](CardStatementSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

