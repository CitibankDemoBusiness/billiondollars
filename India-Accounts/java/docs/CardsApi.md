# CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**loanBookingConfirmationPreLogin**](CardsApi.md#loanBookingConfirmationPreLogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings/confirmation | This API  is triggered after CMAMT interdiction in Loan Booking process.
[**loanBookingPreLogin**](CardsApi.md#loanBookingPreLogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings | This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
[**partnerV1AccountsAccountIdLoansGet**](CardsApi.md#partnerV1AccountsAccountIdLoansGet) | **GET** /partner/v1/accounts/{accountId}/loans | This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate) | **POST** /v1/creditChargeCard/creditPlans/{cardId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation) | **POST** /v1/creditChargeCard/creditPlans/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin) | **GET** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/loans | This API is to fetch the list of booked loans on customer&#x27;s  credit cards.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/loans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieveDisbursementOptionsPreLogin**](CardsApi.md#retrieveDisbursementOptionsPreLogin) | **GET** /v1/creditCardServices/offers/{offerId}/prelogin/loans/disbursementOptions | Get the list of disbursement options and the details like bank details and billing address relevant to each option.
[**v1AccountsAccountIdLoansCreditCheckSearchPost**](CardsApi.md#v1AccountsAccountIdLoansCreditCheckSearchPost) | **POST** /v1/accounts/{accountId}/loans/creditCheck/search | Credit Check based on Debt Service Ratio

<a name="loanBookingConfirmationPreLogin"></a>
# **loanBookingConfirmationPreLogin**
> LoanBookingConfirmationPreLoginResponse loanBookingConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails)

This API  is triggered after CMAMT interdiction in Loan Booking process.

This API  is triggered after CMAMT interdiction in Loan Booking process.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
LoanBookingConfirmationPreLoginRequest body = new LoanBookingConfirmationPreLoginRequest(); // LoanBookingConfirmationPreLoginRequest | LoanBookingConfirmationPreLoginRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    LoanBookingConfirmationPreLoginResponse result = apiInstance.loanBookingConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#loanBookingConfirmationPreLogin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingConfirmationPreLoginRequest**](LoanBookingConfirmationPreLoginRequest.md)| LoanBookingConfirmationPreLoginRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**LoanBookingConfirmationPreLoginResponse**](LoanBookingConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="loanBookingPreLogin"></a>
# **loanBookingPreLogin**
> LoanBookingPreLoginResponse loanBookingPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails)

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
LoanBookingPreLoginRequest body = new LoanBookingPreLoginRequest(); // LoanBookingPreLoginRequest | LoanBookingPreLoginRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    LoanBookingPreLoginResponse result = apiInstance.loanBookingPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#loanBookingPreLogin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingPreLoginRequest**](LoanBookingPreLoginRequest.md)| LoanBookingPreLoginRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**LoanBookingPreLoginResponse**](LoanBookingPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="partnerV1AccountsAccountIdLoansGet"></a>
# **partnerV1AccountsAccountIdLoansGet**
> LoanSummaryResponse partnerV1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex, loanStatus, offerType, offerIndicator)

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
String loanStatus = "loanStatus_example"; // String | This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description
String offerType = "offerType_example"; // String | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
String offerIndicator = "offerIndicator_example"; // String | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description
try {
    LoanSummaryResponse result = apiInstance.partnerV1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex, loanStatus, offerType, offerIndicator);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#partnerV1AccountsAccountIdLoansGet");
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
 **accountId** | **String**| The account id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional]
 **loanStatus** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description | [optional]
 **offerType** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional]
 **offerIndicator** | **String**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional]

### Return type

[**LoanSummaryResponse**](LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The card id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, offerType, offerIndicator)

This API is to fetch the list of booked loans on customer&#x27;s  credit cards.

This API is to fetch the list of booked loans on customer&#x27;s  credit cards.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String offerId = "offerId_example"; // String | his Refers to the unique id for the Pre login offer
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String offerType = "offerType_example"; // String | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
String offerIndicator = "offerIndicator_example"; // String | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, offerType, offerIndicator);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin");
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
 **offerId** | **String**| his Refers to the unique id for the Pre login offer |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **offerType** | **String**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional]
 **offerIndicator** | **String**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp(authorization, uuid, accept, clientId, offerId, clientDetails, productId, loanAmount)

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String productId = "productId_example"; // String | Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description.
BigDecimal loanAmount = new BigDecimal(); // BigDecimal | Loan amount for easy payment plan booking.
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp(authorization, uuid, accept, clientId, offerId, clientDetails, productId, loanAmount);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp");
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
 **productId** | **String**| Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description. | [optional]
 **loanAmount** | **BigDecimal**| Loan amount for easy payment plan booking. | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails)

This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

This API is triggered after the EPP Plan is selected and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **offerId** | **String**| This Refers to the unique id for the Pre login offer. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex, binaryDataFlag)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details for the selected time period for prelogin offer

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
BigDecimal loanAmount = new BigDecimal(); // BigDecimal | Loan amount for easy payment plan booking.
BigDecimal tenor = new BigDecimal(); // BigDecimal | Tenure of loan in months
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
Boolean binaryDataFlag = true; // Boolean | This refer to the flag in case of binary file is require.
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex, binaryDataFlag);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules");
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
 **loanAmount** | **BigDecimal**| Loan amount for easy payment plan booking. |
 **tenor** | **BigDecimal**| Tenure of loan in months |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **binaryDataFlag** | **Boolean**| This refer to the flag in case of binary file is require. | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String loanAmount = "loanAmount_example"; // String | Loan amount for easy payment plan booking.
Integer tenor = 56; // Integer | Tenure of loan.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules");
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
 **loanAmount** | **String**| Loan amount for easy payment plan booking. |
 **tenor** | **Integer**| Tenure of loan. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveDisbursementOptionsPreLogin"></a>
# **retrieveDisbursementOptionsPreLogin**
> RetrieveDisbursementOptionsPreLoginResponse retrieveDisbursementOptionsPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails)

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String offerId = "offerId_example"; // String | This Refers to the unique id for the Pre login offer.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveDisbursementOptionsPreLoginResponse result = apiInstance.retrieveDisbursementOptionsPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveDisbursementOptionsPreLogin");
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

### Return type

[**RetrieveDisbursementOptionsPreLoginResponse**](RetrieveDisbursementOptionsPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansCreditCheckSearchPost"></a>
# **v1AccountsAccountIdLoansCreditCheckSearchPost**
> CreditCheckResponse v1AccountsAccountIdLoansCreditCheckSearchPost(body, authorization, uuid, accept, clientId, accountId, clientDetails)

Credit Check based on Debt Service Ratio

This API is used to retrieve the eligible tenure options, the corresponding maximum eligible loan amount and the annual interest rate based on debt service ratio.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
CreditCheckRequest body = new CreditCheckRequest(); // CreditCheckRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CreditCheckResponse result = apiInstance.v1AccountsAccountIdLoansCreditCheckSearchPost(body, authorization, uuid, accept, clientId, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1AccountsAccountIdLoansCreditCheckSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditCheckRequest**](CreditCheckRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer onboarding |
 **accountId** | **String**| The account id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CreditCheckResponse**](CreditCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

