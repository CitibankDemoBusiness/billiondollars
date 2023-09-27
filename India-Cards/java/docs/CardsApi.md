# CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**bNMOAPIBankingDigitalRegulatory**](CardsApi.md#bNMOAPIBankingDigitalRegulatory) | **GET** /v1/my/bnm/cards | Retrieve the detail of card products
[**eppLoanBookingConfirmation**](CardsApi.md#eppLoanBookingConfirmation) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings/confirmation | Confirm Easy Payment Plan Booking
[**initiateCreditChargeCardCorporateCardsClosure**](CardsApi.md#initiateCreditChargeCardCorporateCardsClosure) | **POST** /partner/v1/creditChargeCard/corporateCards/closure | This API is used to close the corporate Credit Card or Ready credit Account.
[**multiCurrencyAccountEnrollment**](CardsApi.md#multiCurrencyAccountEnrollment) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**multiCurrencyAccountEnrollmentWithCurrency**](CardsApi.md#multiCurrencyAccountEnrollmentWithCurrency) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**](CardsApi.md#notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction) | **POST** /partner/v1/creditChargeCard/transaction/authorised/notify | This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.
[**partnerCardListing**](CardsApi.md#partnerCardListing) | **GET** /partner/v1/cards | Partner Card List
[**requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed**](CardsApi.md#requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed) | **POST** /partner/v1/creditChargeCard/corporateCards/suspensionAndCashLimitAllowed | This API is used to Suspend and Unsuspend corporate card.
[**requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement**](CardsApi.md#requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement) | **POST** /partner/v1/creditChargeCard/corporateCards/cardReplacement | This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
[**requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund**](CardsApi.md#requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund) | **POST** /v1/creditChargeCard/creditPlan/epp/refund | This API is used for EPP Refund in Open Loop
[**retrieveCreditChargeCardCorporateCardsCashLimit**](CardsApi.md#retrieveCreditChargeCardCorporateCardsCashLimit) | **POST** /partner/v1/creditChargeCard/corporateCards/cashLimit/retrieve | This API is used to retrieve the corporate card cash limit
[**retrieveCreditChargeCardCorporateCardsDetail**](CardsApi.md#retrieveCreditChargeCardCorporateCardsDetail) | **POST** /partner/v1/creditChargeCard/corporateCards/details/retrieve | This API is used to retrieve the corporate card details
[**retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions**](CardsApi.md#retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions) | **POST** /partner/v1/creditChargeCard/corporateCards/pendingAndIntradayAuthorizationTransactions/retrieve | This API used to retrieve the pending Authorization refund and intraday and history transactions
[**retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus) | **GET** /v1/creditChargeCard/cardStatus | Retrieve Credit Card Status
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](CardsApi.md#retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**updateCreditChargeCardCorporateCardsCashLimit**](CardsApi.md#updateCreditChargeCardCorporateCardsCashLimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/cashLimit | This API is used to update the corporate card cash limit
[**updateCreditChargeCardCorporateCardsCreditLimit**](CardsApi.md#updateCreditChargeCardCorporateCardsCreditLimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/creditLimit | This API is used to update the corportate card credit limit
[**updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen**](CardsApi.md#updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen) | **PUT** /partner/v1/creditChargeCard/corporateCards/lostOrStolen | This API is to report lost or stolen card and to apply for Replacement
[**updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl**](CardsApi.md#updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl) | **PUT** /partner/v1/creditChargeCard/corporateCards/spendControl | This API will help corporate user to update purchases for specific merchants coming in the API request
[**v1CardsCardIdLimitsAndEnrollmentsPut**](CardsApi.md#v1CardsCardIdLimitsAndEnrollmentsPut) | **PUT** /v1/cards/{cardId}/limitsAndEnrollments | Enroll for Transaction Limit Setup
[**v1CardsCardIdMultiCurrencyAccountsDelete**](CardsApi.md#v1CardsCardIdMultiCurrencyAccountsDelete) | **DELETE** /v1/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost**](CardsApi.md#v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost**](CardsApi.md#v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**v1CardsCardIdOverseasTravelPlansDelete**](CardsApi.md#v1CardsCardIdOverseasTravelPlansDelete) | **DELETE** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to delete an existing travel plan 
[**v1CardsCardIdOverseasTravelPlansPost**](CardsApi.md#v1CardsCardIdOverseasTravelPlansPost) | **POST** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to add a new travel plan
[**v1CardsCardIdOverseasTravelPlansPut**](CardsApi.md#v1CardsCardIdOverseasTravelPlansPut) | **PUT** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to update an existing travel plan
[**v1CardsCvvVerificationPost**](CardsApi.md#v1CardsCvvVerificationPost) | **POST** /v1/cards/cvv/verification | Verify CVV for Debit or Credit Card
[**v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](CardsApi.md#v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet) | **GET** /v1/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
[**v1CardsOverseasTravelPlansGet**](CardsApi.md#v1CardsOverseasTravelPlansGet) | **GET** /v1/cards/overseasTravelPlans | This API enables customer to inquire current travel plan
[**v2CardsCardIdMultiCurrencyAccountsDelete**](CardsApi.md#v2CardsCardIdMultiCurrencyAccountsDelete) | **DELETE** /v2/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](CardsApi.md#v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet) | **GET** /v2/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

<a name="bNMOAPIBankingDigitalRegulatory"></a>
# **bNMOAPIBankingDigitalRegulatory**
> ProductResponse bNMOAPIBankingDigitalRegulatory(authorization, uuid, accept, clientId, contentType, cardType, clientDetails)

Retrieve the detail of card products

This API is designed basing on Bank Negara Malaysia (BNM) Open API Product Information Specification to provide Citibank’s Malaysia Credit card product information that are currently offered in the Market.&lt;br/&gt;API specs for Swagger download and the API details displayed are for illustration purpose only. For actual specification please refer to the BNM website.&lt;br/&gt;&lt;b&gt;Note&lt;/b&gt; :To get the details of the API specification , please refer to the BNM link below to extract the exact specifications.&lt;br/&gt;BNM Link  :https://github.com/BankNegaraMY

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
String contentType = "contentType_example"; // String | application/json
String cardType = "credit_card"; // String | Type of card
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    ProductResponse result = apiInstance.bNMOAPIBankingDigitalRegulatory(authorization, uuid, accept, clientId, contentType, cardType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#bNMOAPIBankingDigitalRegulatory");
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
 **cardType** | **String**| Type of card | [optional] [default to credit_card] [enum: all, charge_card, credit_card, debit_card, prepaid_card]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="eppLoanBookingConfirmation"></a>
# **eppLoanBookingConfirmation**
> EppLoanBookingConfirmationResponse eppLoanBookingConfirmation(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

Confirm Easy Payment Plan Booking

This API is triggered after the EPP plan is selected and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
EppLoanBookingConfirmationRequest body = new EppLoanBookingConfirmationRequest(); // EppLoanBookingConfirmationRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    EppLoanBookingConfirmationResponse result = apiInstance.eppLoanBookingConfirmation(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#eppLoanBookingConfirmation");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingConfirmationRequest**](EppLoanBookingConfirmationRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The card id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**EppLoanBookingConfirmationResponse**](EppLoanBookingConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="initiateCreditChargeCardCorporateCardsClosure"></a>
# **initiateCreditChargeCardCorporateCardsClosure**
> InitiateCreditChargeCardCorporateCardsClosureResponse initiateCreditChargeCardCorporateCardsClosure(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to close the corporate Credit Card or Ready credit Account.

This API is used to close the corporate Credit Card or Ready credit Account.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
InitiateCreditChargeCardCorporateCardsClosureRequest body = new InitiateCreditChargeCardCorporateCardsClosureRequest(); // InitiateCreditChargeCardCorporateCardsClosureRequest | InitiateCreditChargeCardCorporateCardsClosureRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    InitiateCreditChargeCardCorporateCardsClosureResponse result = apiInstance.initiateCreditChargeCardCorporateCardsClosure(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#initiateCreditChargeCardCorporateCardsClosure");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateCreditChargeCardCorporateCardsClosureRequest**](InitiateCreditChargeCardCorporateCardsClosureRequest.md)| InitiateCreditChargeCardCorporateCardsClosureRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**InitiateCreditChargeCardCorporateCardsClosureResponse**](InitiateCreditChargeCardCorporateCardsClosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="multiCurrencyAccountEnrollment"></a>
# **multiCurrencyAccountEnrollment**
> MultiCurrencyAccountEnrollmentResponse multiCurrencyAccountEnrollment(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
MultiCurrencyAccountEnrollmentRequest body = new MultiCurrencyAccountEnrollmentRequest(); // MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEnrollmentResponse result = apiInstance.multiCurrencyAccountEnrollment(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#multiCurrencyAccountEnrollment");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="multiCurrencyAccountEnrollmentWithCurrency"></a>
# **multiCurrencyAccountEnrollmentWithCurrency**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse multiCurrencyAccountEnrollmentWithCurrency(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
MultiCurrencyAccountEnrollmentWithCurrencyRequest body = new MultiCurrencyAccountEnrollmentWithCurrencyRequest(); // MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEnrollmentWithCurrencyResponse result = apiInstance.multiCurrencyAccountEnrollmentWithCurrency(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#multiCurrencyAccountEnrollmentWithCurrency");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction"></a>
# **notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction**
> notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature)

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

This API will be triggered by partner(VISA) to notify the cardholder about authorisation transaction.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest body = new NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest(); // NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest | NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest
String authorization = "authorization_example"; // String | HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String contentType = "contentType_example"; // String | application/json
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String xJwsSignature = "xJwsSignature_example"; // String | This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB
try {
    apiInstance.notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction(body, authorization, uuid, accept, contentType, clientId, clientDetails, acceptLanguage, xJwsSignature);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#notifyCreditChargeCardFulfillmentArrangementAuthorisedTransaction");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest**](NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest.md)| NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest |
 **authorization** | **String**| HTTP Basic authentication by passing base64 encoded value of the client id and client secret separated by colon (:).Example: Base64(client_id:client_secret) will be passed as Basic KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **contentType** | **String**| application/json |
 **clientId** | **String**| Client ID generated during application registration. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **xJwsSignature** | **String**| This field is signature generated when partner sign API payload.This signature will be used to validate that the call is coming from a valid partner. This signature is a JWT token, which will be validated with partner’s JWK stored in DB | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="partnerCardListing"></a>
# **partnerCardListing**
> PartnerCardListingResponse partnerCardListing(authorization, uuid, accept, clientId, cardFunction, linkedSupplementaryCardFlag, clientDetails)

Partner Card List

This API is used to list all the cards held by a customer with Citi partner.

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
String cardFunction = "cardFunction_example"; // String | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description.
Boolean linkedSupplementaryCardFlag = true; // Boolean | Flag to identify linked supplementary information to be retrieved.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    PartnerCardListingResponse result = apiInstance.partnerCardListing(authorization, uuid, accept, clientId, cardFunction, linkedSupplementaryCardFlag, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#partnerCardListing");
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
 **cardFunction** | **String**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. |
 **linkedSupplementaryCardFlag** | **Boolean**| Flag to identify linked supplementary information to be retrieved. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**PartnerCardListingResponse**](PartnerCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed"></a>
# **requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed**
> requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to Suspend and Unsuspend corporate card.

This API is used to Suspend and Unsuspend corporate card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest body = new RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest(); // RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest | RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#requestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest**](RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest.md)| RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest |
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

<a name="requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement"></a>
# **requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement**
> RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest body = new RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest(); // RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest | RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse result = apiInstance.requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#requestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.md)| RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund"></a>
# **requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund**
> requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is used for EPP Refund in Open Loop

This API is used for EPP Refund in Open Loop

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest body = new RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest(); // RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest | RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#requestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest**](RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.md)| RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest |
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

<a name="retrieveCreditChargeCardCorporateCardsCashLimit"></a>
# **retrieveCreditChargeCardCorporateCardsCashLimit**
> RetrieveCreditChargeCardCorporateCardsCashLimitResponse retrieveCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to retrieve the corporate card cash limit

This API is used to retrieve the corporate card cash limit

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardCorporateCardsCashLimitRequest body = new RetrieveCreditChargeCardCorporateCardsCashLimitRequest(); // RetrieveCreditChargeCardCorporateCardsCashLimitRequest | RetrieveCreditChargeCardCorporateCardsCashLimitRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardCorporateCardsCashLimitResponse result = apiInstance.retrieveCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardCorporateCardsCashLimit");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsCashLimitRequest**](RetrieveCreditChargeCardCorporateCardsCashLimitRequest.md)| RetrieveCreditChargeCardCorporateCardsCashLimitRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardCorporateCardsCashLimitResponse**](RetrieveCreditChargeCardCorporateCardsCashLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardCorporateCardsDetail"></a>
# **retrieveCreditChargeCardCorporateCardsDetail**
> RetrieveCreditChargeCardCorporateCardsDetailResponse retrieveCreditChargeCardCorporateCardsDetail(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to retrieve the corporate card details

This API is used to retrieve the corporate card details

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardCorporateCardsDetailRequest body = new RetrieveCreditChargeCardCorporateCardsDetailRequest(); // RetrieveCreditChargeCardCorporateCardsDetailRequest | RetrieveCreditChargeCardCorporateCardsDetailRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardCorporateCardsDetailResponse result = apiInstance.retrieveCreditChargeCardCorporateCardsDetail(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardCorporateCardsDetail");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsDetailRequest**](RetrieveCreditChargeCardCorporateCardsDetailRequest.md)| RetrieveCreditChargeCardCorporateCardsDetailRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardCorporateCardsDetailResponse**](RetrieveCreditChargeCardCorporateCardsDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions"></a>
# **retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions**
> RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API used to retrieve the pending Authorization refund and intraday and history transactions

This API used to retrieve the pending Authorization refund and intraday and history transactions

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest body = new RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest(); // RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest | RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse result = apiInstance.retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.md)| RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus"></a>
# **retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus**
> RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus(authorization, uuid, accept, clientId, cardId, transactionReferenceId, clientDetails)

Retrieve Credit Card Status

This API is used to return the credit card status.

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
String cardId = "cardId_example"; // String | The customer Card identifier in encrypted format.
String transactionReferenceId = "transactionReferenceId_example"; // String | This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse result = apiInstance.retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus(authorization, uuid, accept, clientId, cardId, transactionReferenceId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#retrieveCreditChargeCardFulfillmentArrangementCreditCardStatus");
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
 **cardId** | **String**| The customer Card identifier in encrypted format. |
 **transactionReferenceId** | **String**| This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse.md)

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

<a name="updateCreditChargeCardCorporateCardsCashLimit"></a>
# **updateCreditChargeCardCorporateCardsCashLimit**
> updateCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to update the corporate card cash limit

This API is used to update the corporate card cash limit

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
UpdateCreditChargeCardCorporateCardsCashLimitRequest body = new UpdateCreditChargeCardCorporateCardsCashLimitRequest(); // UpdateCreditChargeCardCorporateCardsCashLimitRequest | UpdateCreditChargeCardCorporateCardsCashLimitRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.updateCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#updateCreditChargeCardCorporateCardsCashLimit");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCashLimitRequest**](UpdateCreditChargeCardCorporateCardsCashLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCashLimitRequest |
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

<a name="updateCreditChargeCardCorporateCardsCreditLimit"></a>
# **updateCreditChargeCardCorporateCardsCreditLimit**
> UpdateCreditChargeCardCorporateCardsCreditLimitResponse updateCreditChargeCardCorporateCardsCreditLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails)

This API is used to update the corportate card credit limit

This API is used to update the corportate card credit limit

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
UpdateCreditChargeCardCorporateCardsCreditLimitRequest body = new UpdateCreditChargeCardCorporateCardsCreditLimitRequest(); // UpdateCreditChargeCardCorporateCardsCreditLimitRequest | UpdateCreditChargeCardCorporateCardsCreditLimitRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String acceptLanguage = "acceptLanguage_example"; // String | List of acceptable human languages for response.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UpdateCreditChargeCardCorporateCardsCreditLimitResponse result = apiInstance.updateCreditChargeCardCorporateCardsCreditLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#updateCreditChargeCardCorporateCardsCreditLimit");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCreditLimitRequest**](UpdateCreditChargeCardCorporateCardsCreditLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCreditLimitRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **acceptLanguage** | **String**| List of acceptable human languages for response. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UpdateCreditChargeCardCorporateCardsCreditLimitResponse**](UpdateCreditChargeCardCorporateCardsCreditLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen"></a>
# **updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen**
> UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API is to report lost or stolen card and to apply for Replacement

This API is to report lost or stolen card and to apply for Replacement

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest body = new UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest(); // UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse result = apiInstance.updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#updateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl"></a>
# **updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl**
> updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API will help corporate user to update purchases for specific merchants coming in the API request

This API will help corporate user to update purchases for specific merchants coming in the API request

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest body = new UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest(); // UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#updateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest |
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

<a name="v1CardsCardIdLimitsAndEnrollmentsPut"></a>
# **v1CardsCardIdLimitsAndEnrollmentsPut**
> v1CardsCardIdLimitsAndEnrollmentsPut(body, uuid, accept, clientId, contentType, authorization, cardId, clientDetails)

Enroll for Transaction Limit Setup

This API is used to update the limits (daily and transaction level) and the enrollments applicable for the credit/debit card of a customer.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
CardsLimitsAndEnrollmentsUpdateRequest body = new CardsLimitsAndEnrollmentsUpdateRequest(); // CardsLimitsAndEnrollmentsUpdateRequest | CardsLimitsAndEnrollmentsUpdateRequest
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String cardId = "cardId_example"; // String | Card Id in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCardIdLimitsAndEnrollmentsPut(body, uuid, accept, clientId, contentType, authorization, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdLimitsAndEnrollmentsPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardsLimitsAndEnrollmentsUpdateRequest**](CardsLimitsAndEnrollmentsUpdateRequest.md)| CardsLimitsAndEnrollmentsUpdateRequest |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **cardId** | **String**| Card Id in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdMultiCurrencyAccountsDelete"></a>
# **v1CardsCardIdMultiCurrencyAccountsDelete**
> v1CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

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
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdMultiCurrencyAccountsDelete");
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
 **cardId** | **String**| The customer card identifier in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost"></a>
# **v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
MultiCurrencyAccountEnrollmentWithCurrencyRequest body = new MultiCurrencyAccountEnrollmentWithCurrencyRequest(); // MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEnrollmentWithCurrencyResponse result = apiInstance.v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost"></a>
# **v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost**
> MultiCurrencyAccountEnrollmentResponse v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
MultiCurrencyAccountEnrollmentRequest body = new MultiCurrencyAccountEnrollmentRequest(); // MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEnrollmentResponse result = apiInstance.v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdMultiCurrencyAccountsEnrollmentsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdOverseasTravelPlansDelete"></a>
# **v1CardsCardIdOverseasTravelPlansDelete**
> v1CardsCardIdOverseasTravelPlansDelete(authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API enables customer to delete an existing travel plan 

This API enables customer to delete an existing travel plan 

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
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCardIdOverseasTravelPlansDelete(authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdOverseasTravelPlansDelete");
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
 **cardId** | **String**| The card id  in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CardsCardIdOverseasTravelPlansPost"></a>
# **v1CardsCardIdOverseasTravelPlansPost**
> v1CardsCardIdOverseasTravelPlansPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API enables customer to add a new travel plan

This API enables customer to add a new travel plan

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
OverseasTravelPlanAddRequest body = new OverseasTravelPlanAddRequest(); // OverseasTravelPlanAddRequest | OverseasTravelPlanAddRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCardIdOverseasTravelPlansPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdOverseasTravelPlansPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanAddRequest**](OverseasTravelPlanAddRequest.md)| OverseasTravelPlanAddRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The card id  in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCardIdOverseasTravelPlansPut"></a>
# **v1CardsCardIdOverseasTravelPlansPut**
> v1CardsCardIdOverseasTravelPlansPut(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails)

This API enables customer to update an existing travel plan

This API enables customer to update an existing travel plan

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
OverseasTravelPlanUpdateRequest body = new OverseasTravelPlanUpdateRequest(); // OverseasTravelPlanUpdateRequest | OverseasTravelPlanUpdateRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String cardId = "cardId_example"; // String | The card id  in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCardIdOverseasTravelPlansPut(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCardIdOverseasTravelPlansPut");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanUpdateRequest**](OverseasTravelPlanUpdateRequest.md)| OverseasTravelPlanUpdateRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **cardId** | **String**| The card id  in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1CardsCvvVerificationPost"></a>
# **v1CardsCvvVerificationPost**
> v1CardsCvvVerificationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Verify CVV for Debit or Credit Card

This API is used to verify the CVV of a debit or a credit card.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.CardsApi;


CardsApi apiInstance = new CardsApi();
CvvVerificationRequest body = new CvvVerificationRequest(); // CvvVerificationRequest | CvvVerificationRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v1CardsCvvVerificationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsCvvVerificationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CvvVerificationRequest**](CvvVerificationRequest.md)| CvvVerificationRequest |
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

<a name="v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet"></a>
# **v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet**
> MultiCurrencyAccountEligibilityResponse v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

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
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEligibilityResponse result = apiInstance.v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsMultiCurrencyAccountsEnrollmentEligibilityGet");
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
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1CardsOverseasTravelPlansGet"></a>
# **v1CardsOverseasTravelPlansGet**
> OverseasTravelPlanInquiryResponse v1CardsOverseasTravelPlansGet(authorization, uuid, accept, clientId, clientDetails, cardId)

This API enables customer to inquire current travel plan

This API enables customer to inquire current travel plan

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
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String cardId = "cardId_example"; // String | The card id  in encrypted format
try {
    OverseasTravelPlanInquiryResponse result = apiInstance.v1CardsOverseasTravelPlansGet(authorization, uuid, accept, clientId, clientDetails, cardId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v1CardsOverseasTravelPlansGet");
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
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **cardId** | **String**| The card id  in encrypted format | [optional]

### Return type

[**OverseasTravelPlanInquiryResponse**](OverseasTravelPlanInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v2CardsCardIdMultiCurrencyAccountsDelete"></a>
# **v2CardsCardIdMultiCurrencyAccountsDelete**
> v2CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

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
String cardId = "cardId_example"; // String | The customer card identifier in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.v2CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v2CardsCardIdMultiCurrencyAccountsDelete");
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
 **cardId** | **String**| The customer card identifier in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet"></a>
# **v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet**
> MultiCurrencyAccountEligibilityResponse v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

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
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    MultiCurrencyAccountEligibilityResponse result = apiInstance.v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling CardsApi#v2CardsMultiCurrencyAccountsEnrollmentEligibilityGet");
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
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

