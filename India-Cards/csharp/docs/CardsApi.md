# IO.Swagger.Api.CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BNMOAPIBankingDigitalRegulatory**](CardsApi.md#bnmoapibankingdigitalregulatory) | **GET** /v1/my/bnm/cards | Retrieve the detail of card products
[**EppLoanBookingConfirmation**](CardsApi.md#epploanbookingconfirmation) | **POST** /v1/creditCards/{cardId}/easyPaymentPlans/bookings/confirmation | Confirm Easy Payment Plan Booking
[**InitiateCreditChargeCardCorporateCardsClosure**](CardsApi.md#initiatecreditchargecardcorporatecardsclosure) | **POST** /partner/v1/creditChargeCard/corporateCards/closure | This API is used to close the corporate Credit Card or Ready credit Account.
[**MultiCurrencyAccountEnrollment**](CardsApi.md#multicurrencyaccountenrollment) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**MultiCurrencyAccountEnrollmentWithCurrency**](CardsApi.md#multicurrencyaccountenrollmentwithcurrency) | **POST** /v2/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**PartnerCardListing**](CardsApi.md#partnercardlisting) | **GET** /partner/v1/cards | Partner Card List
[**RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed**](CardsApi.md#requestcreditchargecardcorporatecardssuspensionandcashlimitallowed) | **POST** /partner/v1/creditChargeCard/corporateCards/suspensionAndCashLimitAllowed | This API is used to Suspend and Unsuspend corporate card.
[**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement**](CardsApi.md#requestcreditchargecardfulfillmentarrangementcorporatecardsdamagereplacement) | **POST** /partner/v1/creditChargeCard/corporateCards/cardReplacement | This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
[**RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund**](CardsApi.md#requestcreditchargecardfulfillmentarrangementcreditplanepprefund) | **POST** /v1/creditChargeCard/creditPlan/epp/refund | This API is used for EPP Refund in Open Loop
[**RetrieveCreditChargeCardCorporateCardsCashLimit**](CardsApi.md#retrievecreditchargecardcorporatecardscashlimit) | **POST** /partner/v1/creditChargeCard/corporateCards/cashLimit/retrieve | This API is used to retrieve the corporate card cash limit
[**RetrieveCreditChargeCardCorporateCardsDetail**](CardsApi.md#retrievecreditchargecardcorporatecardsdetail) | **POST** /partner/v1/creditChargeCard/corporateCards/details/retrieve | This API is used to retrieve the corporate card details
[**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions**](CardsApi.md#retrievecreditchargecardcorporatecardspendingandintradayauthorizationtransactions) | **POST** /partner/v1/creditChargeCard/corporateCards/pendingAndIntradayAuthorizationTransactions/retrieve | This API used to retrieve the pending Authorization refund and intraday and history transactions
[**RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatus**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditcardstatus) | **GET** /v1/creditChargeCard/cardStatus | Retrieve Credit Card Status
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanofferseppbookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepprepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**UpdateCreditChargeCardCorporateCardsCashLimit**](CardsApi.md#updatecreditchargecardcorporatecardscashlimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/cashLimit | This API is used to update the corporate card cash limit
[**UpdateCreditChargeCardCorporateCardsCreditLimit**](CardsApi.md#updatecreditchargecardcorporatecardscreditlimit) | **PUT** /partner/v1/creditChargeCard/corporateCards/creditLimit | This API is used to update the corportate card credit limit
[**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen**](CardsApi.md#updatecreditchargecardfulfillmentarrangementcorporatecardslostorstolen) | **PUT** /partner/v1/creditChargeCard/corporateCards/lostOrStolen | This API is to report lost or stolen card and to apply for Replacement
[**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl**](CardsApi.md#updatecreditchargecardfulfillmentarrangementcorporatecardsspendcontrol) | **PUT** /partner/v1/creditChargeCard/corporateCards/spendControl | This API will help corporate user to update purchases for specific merchants coming in the API request
[**V1CardsCardIdLimitsAndEnrollmentsPut**](CardsApi.md#v1cardscardidlimitsandenrollmentsput) | **PUT** /v1/cards/{cardId}/limitsAndEnrollments | Enroll for Transaction Limit Setup
[**V1CardsCardIdMultiCurrencyAccountsDelete**](CardsApi.md#v1cardscardidmulticurrencyaccountsdelete) | **DELETE** /v1/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost**](CardsApi.md#v1cardscardidmulticurrencyaccountsenrollmentscurrencypost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments/currency | This API is to generate/enroll new FCY Accounts to Multi Currency Account
[**V1CardsCardIdMultiCurrencyAccountsEnrollmentsPost**](CardsApi.md#v1cardscardidmulticurrencyaccountsenrollmentspost) | **POST** /v1/cards/{cardId}/multiCurrencyAccounts/enrollments | This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
[**V1CardsCardIdOverseasTravelPlansDelete**](CardsApi.md#v1cardscardidoverseastravelplansdelete) | **DELETE** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to delete an existing travel plan 
[**V1CardsCardIdOverseasTravelPlansPost**](CardsApi.md#v1cardscardidoverseastravelplanspost) | **POST** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to add a new travel plan
[**V1CardsCardIdOverseasTravelPlansPut**](CardsApi.md#v1cardscardidoverseastravelplansput) | **PUT** /v1/cards/{cardId}/overseasTravelPlans | This API enables customer to update an existing travel plan
[**V1CardsCvvVerificationPost**](CardsApi.md#v1cardscvvverificationpost) | **POST** /v1/cards/cvv/verification | Verify CVV for Debit or Credit Card
[**V1CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](CardsApi.md#v1cardsmulticurrencyaccountsenrollmenteligibilityget) | **GET** /v1/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
[**V1CardsOverseasTravelPlansGet**](CardsApi.md#v1cardsoverseastravelplansget) | **GET** /v1/cards/overseasTravelPlans | This API enables customer to inquire current travel plan
[**V2CardsCardIdMultiCurrencyAccountsDelete**](CardsApi.md#v2cardscardidmulticurrencyaccountsdelete) | **DELETE** /v2/cards/{cardId}/multiCurrencyAccounts | This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
[**V2CardsMultiCurrencyAccountsEnrollmentEligibilityGet**](CardsApi.md#v2cardsmulticurrencyaccountsenrollmenteligibilityget) | **GET** /v2/cards/multiCurrencyAccounts/enrollment/eligibility | This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

<a name="bnmoapibankingdigitalregulatory"></a>
# **BNMOAPIBankingDigitalRegulatory**
> ProductResponse BNMOAPIBankingDigitalRegulatory (string authorization, string uuid, string accept, string clientId, string contentType, string cardType = null, string clientDetails = null)

Retrieve the detail of card products

This API is designed basing on Bank Negara Malaysia (BNM) Open API Product Information Specification to provide Citibank’s Malaysia Credit card product information that are currently offered in the Market.<br/>API specs for Swagger download and the API details displayed are for illustration purpose only. For actual specification please refer to the BNM website.<br/><b>Note</b> :To get the details of the API specification , please refer to the BNM link below to extract the exact specifications.<br/>BNM Link  :https://github.com/BankNegaraMY

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class BNMOAPIBankingDigitalRegulatoryExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardType = cardType_example;  // string | Type of card (optional)  (default to credit_card)
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve the detail of card products
                ProductResponse result = apiInstance.BNMOAPIBankingDigitalRegulatory(authorization, uuid, accept, clientId, contentType, cardType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.BNMOAPIBankingDigitalRegulatory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardType** | **string**| Type of card | [optional] [default to credit_card]
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="epploanbookingconfirmation"></a>
# **EppLoanBookingConfirmation**
> EppLoanBookingConfirmationResponse EppLoanBookingConfirmation (EppLoanBookingConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

Confirm Easy Payment Plan Booking

This API is triggered after the EPP plan is selected and completes the EPP booking. On successful booking, it returns transaction reference in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class EppLoanBookingConfirmationExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new EppLoanBookingConfirmationRequest(); // EppLoanBookingConfirmationRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Confirm Easy Payment Plan Booking
                EppLoanBookingConfirmationResponse result = apiInstance.EppLoanBookingConfirmation(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.EppLoanBookingConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**EppLoanBookingConfirmationRequest**](EppLoanBookingConfirmationRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**EppLoanBookingConfirmationResponse**](EppLoanBookingConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="initiatecreditchargecardcorporatecardsclosure"></a>
# **InitiateCreditChargeCardCorporateCardsClosure**
> InitiateCreditChargeCardCorporateCardsClosureResponse InitiateCreditChargeCardCorporateCardsClosure (InitiateCreditChargeCardCorporateCardsClosureRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to close the corporate Credit Card or Ready credit Account.

This API is used to close the corporate Credit Card or Ready credit Account.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class InitiateCreditChargeCardCorporateCardsClosureExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new InitiateCreditChargeCardCorporateCardsClosureRequest(); // InitiateCreditChargeCardCorporateCardsClosureRequest | InitiateCreditChargeCardCorporateCardsClosureRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to close the corporate Credit Card or Ready credit Account.
                InitiateCreditChargeCardCorporateCardsClosureResponse result = apiInstance.InitiateCreditChargeCardCorporateCardsClosure(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.InitiateCreditChargeCardCorporateCardsClosure: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**InitiateCreditChargeCardCorporateCardsClosureRequest**](InitiateCreditChargeCardCorporateCardsClosureRequest.md)| InitiateCreditChargeCardCorporateCardsClosureRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**InitiateCreditChargeCardCorporateCardsClosureResponse**](InitiateCreditChargeCardCorporateCardsClosureResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="multicurrencyaccountenrollment"></a>
# **MultiCurrencyAccountEnrollment**
> MultiCurrencyAccountEnrollmentResponse MultiCurrencyAccountEnrollment (MultiCurrencyAccountEnrollmentRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MultiCurrencyAccountEnrollmentExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new MultiCurrencyAccountEnrollmentRequest(); // MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
                MultiCurrencyAccountEnrollmentResponse result = apiInstance.MultiCurrencyAccountEnrollment(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.MultiCurrencyAccountEnrollment: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="multicurrencyaccountenrollmentwithcurrency"></a>
# **MultiCurrencyAccountEnrollmentWithCurrency**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse MultiCurrencyAccountEnrollmentWithCurrency (MultiCurrencyAccountEnrollmentWithCurrencyRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class MultiCurrencyAccountEnrollmentWithCurrencyExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new MultiCurrencyAccountEnrollmentWithCurrencyRequest(); // MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to generate/enroll new FCY Accounts to Multi Currency Account
                MultiCurrencyAccountEnrollmentWithCurrencyResponse result = apiInstance.MultiCurrencyAccountEnrollmentWithCurrency(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.MultiCurrencyAccountEnrollmentWithCurrency: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnercardlisting"></a>
# **PartnerCardListing**
> PartnerCardListingResponse PartnerCardListing (string authorization, string uuid, string accept, string clientId, string cardFunction, bool? linkedSupplementaryCardFlag = null, string clientDetails = null)

Partner Card List

This API is used to list all the cards held by a customer with Citi partner.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerCardListingExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var cardFunction = cardFunction_example;  // string | Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description.
            var linkedSupplementaryCardFlag = true;  // bool? | Flag to identify linked supplementary information to be retrieved. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Partner Card List
                PartnerCardListingResponse result = apiInstance.PartnerCardListing(authorization, uuid, accept, clientId, cardFunction, linkedSupplementaryCardFlag, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.PartnerCardListing: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **cardFunction** | **string**| Card function. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardFunction} resource to get valid value of this field with description. | 
 **linkedSupplementaryCardFlag** | **bool?**| Flag to identify linked supplementary information to be retrieved. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**PartnerCardListingResponse**](PartnerCardListingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestcreditchargecardcorporatecardssuspensionandcashlimitallowed"></a>
# **RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed**
> void RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed (RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to Suspend and Unsuspend corporate card.

This API is used to Suspend and Unsuspend corporate card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest(); // RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest | RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to Suspend and Unsuspend corporate card.
                apiInstance.RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowed: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest**](RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest.md)| RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestcreditchargecardfulfillmentarrangementcorporatecardsdamagereplacement"></a>
# **RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement**
> RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement (RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

This API is to do the replacement of credit card for Damage/Lost/Stolen reasons

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest(); // RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest | RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to do the replacement of credit card for Damage/Lost/Stolen reasons
                RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse result = apiInstance.RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest.md)| RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse**](RequestCreditChargeCardFulfillmentArrangementCorporateCardsDamageReplacementResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="requestcreditchargecardfulfillmentarrangementcreditplanepprefund"></a>
# **RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund**
> void RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund (RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used for EPP Refund in Open Loop

This API is used for EPP Refund in Open Loop

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest(); // RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest | RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used for EPP Refund in Open Loop
                apiInstance.RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest**](RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest.md)| RequestCreditChargeCardFulfillmentArrangementCreditPlanEppRefundRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardcorporatecardscashlimit"></a>
# **RetrieveCreditChargeCardCorporateCardsCashLimit**
> RetrieveCreditChargeCardCorporateCardsCashLimitResponse RetrieveCreditChargeCardCorporateCardsCashLimit (RetrieveCreditChargeCardCorporateCardsCashLimitRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to retrieve the corporate card cash limit

This API is used to retrieve the corporate card cash limit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardCorporateCardsCashLimitExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardCorporateCardsCashLimitRequest(); // RetrieveCreditChargeCardCorporateCardsCashLimitRequest | RetrieveCreditChargeCardCorporateCardsCashLimitRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to retrieve the corporate card cash limit
                RetrieveCreditChargeCardCorporateCardsCashLimitResponse result = apiInstance.RetrieveCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardCorporateCardsCashLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsCashLimitRequest**](RetrieveCreditChargeCardCorporateCardsCashLimitRequest.md)| RetrieveCreditChargeCardCorporateCardsCashLimitRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsCashLimitResponse**](RetrieveCreditChargeCardCorporateCardsCashLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardcorporatecardsdetail"></a>
# **RetrieveCreditChargeCardCorporateCardsDetail**
> RetrieveCreditChargeCardCorporateCardsDetailResponse RetrieveCreditChargeCardCorporateCardsDetail (RetrieveCreditChargeCardCorporateCardsDetailRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to retrieve the corporate card details

This API is used to retrieve the corporate card details

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardCorporateCardsDetailExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardCorporateCardsDetailRequest(); // RetrieveCreditChargeCardCorporateCardsDetailRequest | RetrieveCreditChargeCardCorporateCardsDetailRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to retrieve the corporate card details
                RetrieveCreditChargeCardCorporateCardsDetailResponse result = apiInstance.RetrieveCreditChargeCardCorporateCardsDetail(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardCorporateCardsDetail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsDetailRequest**](RetrieveCreditChargeCardCorporateCardsDetailRequest.md)| RetrieveCreditChargeCardCorporateCardsDetailRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsDetailResponse**](RetrieveCreditChargeCardCorporateCardsDetailResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardcorporatecardspendingandintradayauthorizationtransactions"></a>
# **RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions**
> RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions (RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API used to retrieve the pending Authorization refund and intraday and history transactions

This API used to retrieve the pending Authorization refund and intraday and history transactions

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest(); // RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest | RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API used to retrieve the pending Authorization refund and intraday and history transactions
                RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse result = apiInstance.RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest.md)| RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse**](RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditcardstatus"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatus**
> RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatus (string authorization, string uuid, string accept, string clientId, string cardId, string transactionReferenceId, string clientDetails = null)

Retrieve Credit Card Status

This API is used to return the credit card status.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | The customer Card identifier in encrypted format.
            var transactionReferenceId = transactionReferenceId_example;  // string | This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Retrieve Credit Card Status
                RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatus(authorization, uuid, accept, clientId, cardId, transactionReferenceId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| The customer Card identifier in encrypted format. | 
 **transactionReferenceId** | **string**| This refers to Unique ID assigned by the message initiator that uniquely identifies a cardholder transaction. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditCardStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanoffersepp"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, string productId = null, decimal? loanAmount = null)

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var productId = productId_example;  // string | Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description. (optional) 
            var loanAmount = 1.2;  // decimal? | Loan amount for easy payment plan booking. (optional) 

            try
            {
                // This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp(authorization, uuid, accept, clientId, offerId, clientDetails, productId, loanAmount);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **productId** | **string**| Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description. | [optional] 
 **loanAmount** | **decimal?**| Loan amount for easy payment plan booking. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanofferseppbookings"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string offerId, string clientDetails = null)

This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

This API is triggered after the EPP Plan is selected and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanoffersepprepaymentschedules"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules (string authorization, string uuid, string accept, string clientId, string offerId, decimal? loanAmount, decimal? tenor, string clientDetails = null, string nextStartIndex = null, bool? binaryDataFlag = null)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details for the selected time period for prelogin offer

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var loanAmount = 1.2;  // decimal? | Loan amount for easy payment plan booking.
            var tenor = 1.2;  // decimal? | Tenure of loan in months
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 
            var binaryDataFlag = true;  // bool? | This refer to the flag in case of binary file is require. (optional) 

            try
            {
                // To allow customers to view the payment breakdown details.
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex, binaryDataFlag);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **loanAmount** | **decimal?**| Loan amount for easy payment plan booking. | 
 **tenor** | **decimal?**| Tenure of loan in months | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 
 **binaryDataFlag** | **bool?**| This refer to the flag in case of binary file is require. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecreditchargecardcorporatecardscashlimit"></a>
# **UpdateCreditChargeCardCorporateCardsCashLimit**
> void UpdateCreditChargeCardCorporateCardsCashLimit (UpdateCreditChargeCardCorporateCardsCashLimitRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to update the corporate card cash limit

This API is used to update the corporate card cash limit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCreditChargeCardCorporateCardsCashLimitExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new UpdateCreditChargeCardCorporateCardsCashLimitRequest(); // UpdateCreditChargeCardCorporateCardsCashLimitRequest | UpdateCreditChargeCardCorporateCardsCashLimitRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to update the corporate card cash limit
                apiInstance.UpdateCreditChargeCardCorporateCardsCashLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.UpdateCreditChargeCardCorporateCardsCashLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCashLimitRequest**](UpdateCreditChargeCardCorporateCardsCashLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCashLimitRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecreditchargecardcorporatecardscreditlimit"></a>
# **UpdateCreditChargeCardCorporateCardsCreditLimit**
> UpdateCreditChargeCardCorporateCardsCreditLimitResponse UpdateCreditChargeCardCorporateCardsCreditLimit (UpdateCreditChargeCardCorporateCardsCreditLimitRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string acceptLanguage = null, string clientDetails = null)

This API is used to update the corportate card credit limit

This API is used to update the corportate card credit limit

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCreditChargeCardCorporateCardsCreditLimitExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new UpdateCreditChargeCardCorporateCardsCreditLimitRequest(); // UpdateCreditChargeCardCorporateCardsCreditLimitRequest | UpdateCreditChargeCardCorporateCardsCreditLimitRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var acceptLanguage = acceptLanguage_example;  // string | List of acceptable human languages for response. (optional) 
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to update the corportate card credit limit
                UpdateCreditChargeCardCorporateCardsCreditLimitResponse result = apiInstance.UpdateCreditChargeCardCorporateCardsCreditLimit(body, authorization, uuid, accept, clientId, contentType, acceptLanguage, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.UpdateCreditChargeCardCorporateCardsCreditLimit: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardCorporateCardsCreditLimitRequest**](UpdateCreditChargeCardCorporateCardsCreditLimitRequest.md)| UpdateCreditChargeCardCorporateCardsCreditLimitRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **acceptLanguage** | **string**| List of acceptable human languages for response. | [optional] 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateCreditChargeCardCorporateCardsCreditLimitResponse**](UpdateCreditChargeCardCorporateCardsCreditLimitResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecreditchargecardfulfillmentarrangementcorporatecardslostorstolen"></a>
# **UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen**
> UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen (UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is to report lost or stolen card and to apply for Replacement

This API is to report lost or stolen card and to apply for Replacement

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest(); // UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to report lost or stolen card and to apply for Replacement
                UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse result = apiInstance.UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolen: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecreditchargecardfulfillmentarrangementcorporatecardsspendcontrol"></a>
# **UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl**
> void UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl (UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API will help corporate user to update purchases for specific merchants coming in the API request

This API will help corporate user to update purchases for specific merchants coming in the API request

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest(); // UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest | UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API will help corporate user to update purchases for specific merchants coming in the API request
                apiInstance.UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControl: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest**](UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest.md)| UpdateCreditChargeCardFulfillmentArrangementCorporateCardsSpendControlRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidlimitsandenrollmentsput"></a>
# **V1CardsCardIdLimitsAndEnrollmentsPut**
> void V1CardsCardIdLimitsAndEnrollmentsPut (CardsLimitsAndEnrollmentsUpdateRequest body, string uuid, string accept, string clientId, string contentType, string authorization, string cardId, string clientDetails = null)

Enroll for Transaction Limit Setup

This API is used to update the limits (daily and transaction level) and the enrollments applicable for the credit/debit card of a customer.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdLimitsAndEnrollmentsPutExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new CardsLimitsAndEnrollmentsUpdateRequest(); // CardsLimitsAndEnrollmentsUpdateRequest | CardsLimitsAndEnrollmentsUpdateRequest
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var cardId = cardId_example;  // string | Card Id in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Enroll for Transaction Limit Setup
                apiInstance.V1CardsCardIdLimitsAndEnrollmentsPut(body, uuid, accept, clientId, contentType, authorization, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdLimitsAndEnrollmentsPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CardsLimitsAndEnrollmentsUpdateRequest**](CardsLimitsAndEnrollmentsUpdateRequest.md)| CardsLimitsAndEnrollmentsUpdateRequest | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **cardId** | **string**| Card Id in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidmulticurrencyaccountsdelete"></a>
# **V1CardsCardIdMultiCurrencyAccountsDelete**
> void V1CardsCardIdMultiCurrencyAccountsDelete (string authorization, string uuid, string accept, string clientId, string cardId, string clientDetails = null)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdMultiCurrencyAccountsDeleteExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
                apiInstance.V1CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdMultiCurrencyAccountsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| The customer card identifier in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidmulticurrencyaccountsenrollmentscurrencypost"></a>
# **V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost**
> MultiCurrencyAccountEnrollmentWithCurrencyResponse V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost (MultiCurrencyAccountEnrollmentWithCurrencyRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is to generate/enroll new FCY Accounts to Multi Currency Account

This API is to create new account for a foreign currency and enroll it to Multi Currency Account (Global Wallet)

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPostExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new MultiCurrencyAccountEnrollmentWithCurrencyRequest(); // MultiCurrencyAccountEnrollmentWithCurrencyRequest | MultiCurrencyAccountEnrollmentWithCurrencyRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to generate/enroll new FCY Accounts to Multi Currency Account
                MultiCurrencyAccountEnrollmentWithCurrencyResponse result = apiInstance.V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdMultiCurrencyAccountsEnrollmentsCurrencyPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentWithCurrencyRequest**](MultiCurrencyAccountEnrollmentWithCurrencyRequest.md)| MultiCurrencyAccountEnrollmentWithCurrencyRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentWithCurrencyResponse**](MultiCurrencyAccountEnrollmentWithCurrencyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidmulticurrencyaccountsenrollmentspost"></a>
# **V1CardsCardIdMultiCurrencyAccountsEnrollmentsPost**
> MultiCurrencyAccountEnrollmentResponse V1CardsCardIdMultiCurrencyAccountsEnrollmentsPost (MultiCurrencyAccountEnrollmentRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdMultiCurrencyAccountsEnrollmentsPostExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new MultiCurrencyAccountEnrollmentRequest(); // MultiCurrencyAccountEnrollmentRequest | MultiCurrencyAccountEnrollmentRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to enroll the Debit Card and FCY Accounts to Multi Currency Account
                MultiCurrencyAccountEnrollmentResponse result = apiInstance.V1CardsCardIdMultiCurrencyAccountsEnrollmentsPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdMultiCurrencyAccountsEnrollmentsPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MultiCurrencyAccountEnrollmentRequest**](MultiCurrencyAccountEnrollmentRequest.md)| MultiCurrencyAccountEnrollmentRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The customer card identifier in encrypted format, that needs to be enrolled to multi currency accounts | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEnrollmentResponse**](MultiCurrencyAccountEnrollmentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidoverseastravelplansdelete"></a>
# **V1CardsCardIdOverseasTravelPlansDelete**
> void V1CardsCardIdOverseasTravelPlansDelete (string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API enables customer to delete an existing travel plan 

This API enables customer to delete an existing travel plan 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdOverseasTravelPlansDeleteExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API enables customer to delete an existing travel plan 
                apiInstance.V1CardsCardIdOverseasTravelPlansDelete(authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdOverseasTravelPlansDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidoverseastravelplanspost"></a>
# **V1CardsCardIdOverseasTravelPlansPost**
> void V1CardsCardIdOverseasTravelPlansPost (OverseasTravelPlanAddRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API enables customer to add a new travel plan

This API enables customer to add a new travel plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdOverseasTravelPlansPostExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new OverseasTravelPlanAddRequest(); // OverseasTravelPlanAddRequest | OverseasTravelPlanAddRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API enables customer to add a new travel plan
                apiInstance.V1CardsCardIdOverseasTravelPlansPost(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdOverseasTravelPlansPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanAddRequest**](OverseasTravelPlanAddRequest.md)| OverseasTravelPlanAddRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscardidoverseastravelplansput"></a>
# **V1CardsCardIdOverseasTravelPlansPut**
> void V1CardsCardIdOverseasTravelPlansPut (OverseasTravelPlanUpdateRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API enables customer to update an existing travel plan

This API enables customer to update an existing travel plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCardIdOverseasTravelPlansPutExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new OverseasTravelPlanUpdateRequest(); // OverseasTravelPlanUpdateRequest | OverseasTravelPlanUpdateRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API enables customer to update an existing travel plan
                apiInstance.V1CardsCardIdOverseasTravelPlansPut(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCardIdOverseasTravelPlansPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OverseasTravelPlanUpdateRequest**](OverseasTravelPlanUpdateRequest.md)| OverseasTravelPlanUpdateRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardscvvverificationpost"></a>
# **V1CardsCvvVerificationPost**
> void V1CardsCvvVerificationPost (CvvVerificationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

Verify CVV for Debit or Credit Card

This API is used to verify the CVV of a debit or a credit card.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsCvvVerificationPostExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new CvvVerificationRequest(); // CvvVerificationRequest | CvvVerificationRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Verify CVV for Debit or Credit Card
                apiInstance.V1CardsCvvVerificationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsCvvVerificationPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CvvVerificationRequest**](CvvVerificationRequest.md)| CvvVerificationRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardsmulticurrencyaccountsenrollmenteligibilityget"></a>
# **V1CardsMultiCurrencyAccountsEnrollmentEligibilityGet**
> MultiCurrencyAccountEligibilityResponse V1CardsMultiCurrencyAccountsEnrollmentEligibilityGet (string authorization, string uuid, string accept, string clientId, string clientDetails = null)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsMultiCurrencyAccountsEnrollmentEligibilityGetExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
                MultiCurrencyAccountEligibilityResponse result = apiInstance.V1CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsMultiCurrencyAccountsEnrollmentEligibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1cardsoverseastravelplansget"></a>
# **V1CardsOverseasTravelPlansGet**
> OverseasTravelPlanInquiryResponse V1CardsOverseasTravelPlansGet (string authorization, string uuid, string accept, string clientId, string clientDetails = null, string cardId = null)

This API enables customer to inquire current travel plan

This API enables customer to inquire current travel plan

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1CardsOverseasTravelPlansGetExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var cardId = cardId_example;  // string | The card id  in encrypted format (optional) 

            try
            {
                // This API enables customer to inquire current travel plan
                OverseasTravelPlanInquiryResponse result = apiInstance.V1CardsOverseasTravelPlansGet(authorization, uuid, accept, clientId, clientDetails, cardId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1CardsOverseasTravelPlansGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **cardId** | **string**| The card id  in encrypted format | [optional] 

### Return type

[**OverseasTravelPlanInquiryResponse**](OverseasTravelPlanInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v2cardscardidmulticurrencyaccountsdelete"></a>
# **V2CardsCardIdMultiCurrencyAccountsDelete**
> void V2CardsCardIdMultiCurrencyAccountsDelete (string authorization, string uuid, string accept, string clientId, string cardId, string clientDetails = null)

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2CardsCardIdMultiCurrencyAccountsDeleteExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var cardId = cardId_example;  // string | The customer card identifier in encrypted format
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is to disenroll the Debit Card and FCY Accounts from Multi Currency Account
                apiInstance.V2CardsCardIdMultiCurrencyAccountsDelete(authorization, uuid, accept, clientId, cardId, clientDetails);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V2CardsCardIdMultiCurrencyAccountsDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **cardId** | **string**| The customer card identifier in encrypted format | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v2cardsmulticurrencyaccountsenrollmenteligibilityget"></a>
# **V2CardsMultiCurrencyAccountsEnrollmentEligibilityGet**
> MultiCurrencyAccountEligibilityResponse V2CardsMultiCurrencyAccountsEnrollmentEligibilityGet (string authorization, string uuid, string accept, string clientId, string clientDetails = null)

This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account

To get the needed account and currency details for Multi Currency Account

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V2CardsMultiCurrencyAccountsEnrollmentEligibilityGetExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API request is to get the Debit Card, account details and list of foreign currencies that can be enrolled to Multi Currency Account
                MultiCurrencyAccountEligibilityResponse result = apiInstance.V2CardsMultiCurrencyAccountsEnrollmentEligibilityGet(authorization, uuid, accept, clientId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V2CardsMultiCurrencyAccountsEnrollmentEligibilityGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**MultiCurrencyAccountEligibilityResponse**](MultiCurrencyAccountEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
