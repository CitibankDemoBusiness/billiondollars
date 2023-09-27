# IO.Swagger.Api.CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LoanBookingConfirmationPreLogin**](CardsApi.md#loanbookingconfirmationprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings/confirmation | This API  is triggered after CMAMT interdiction in Loan Booking process.
[**LoanBookingPreLogin**](CardsApi.md#loanbookingprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings | This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
[**PartnerV1AccountsAccountIdLoansGet**](CardsApi.md#partnerv1accountsaccountidloansget) | **GET** /partner/v1/accounts/{accountId}/loans | This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidate) | **POST** /v1/creditChargeCard/creditPlans/{cardId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmation) | **POST** /v1/creditChargeCard/creditPlans/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmationprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanloansprelogin) | **GET** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/loans | This API is to fetch the list of booked loans on customer&#x27;s  credit cards.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanofferseppbookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepprepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersloanrepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/loans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**RetrieveDisbursementOptionsPreLogin**](CardsApi.md#retrievedisbursementoptionsprelogin) | **GET** /v1/creditCardServices/offers/{offerId}/prelogin/loans/disbursementOptions | Get the list of disbursement options and the details like bank details and billing address relevant to each option.
[**V1AccountsAccountIdLoansCreditCheckSearchPost**](CardsApi.md#v1accountsaccountidloanscreditchecksearchpost) | **POST** /v1/accounts/{accountId}/loans/creditCheck/search | Credit Check based on Debt Service Ratio

<a name="loanbookingconfirmationprelogin"></a>
# **LoanBookingConfirmationPreLogin**
> LoanBookingConfirmationPreLoginResponse LoanBookingConfirmationPreLogin (LoanBookingConfirmationPreLoginRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string offerId, string clientDetails = null)

This API  is triggered after CMAMT interdiction in Loan Booking process.

This API  is triggered after CMAMT interdiction in Loan Booking process.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoanBookingConfirmationPreLoginExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new LoanBookingConfirmationPreLoginRequest(); // LoanBookingConfirmationPreLoginRequest | LoanBookingConfirmationPreLoginRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API  is triggered after CMAMT interdiction in Loan Booking process.
                LoanBookingConfirmationPreLoginResponse result = apiInstance.LoanBookingConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.LoanBookingConfirmationPreLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingConfirmationPreLoginRequest**](LoanBookingConfirmationPreLoginRequest.md)| LoanBookingConfirmationPreLoginRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**LoanBookingConfirmationPreLoginResponse**](LoanBookingConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="loanbookingprelogin"></a>
# **LoanBookingPreLogin**
> LoanBookingPreLoginResponse LoanBookingPreLogin (LoanBookingPreLoginRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string offerId, string clientDetails = null)

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LoanBookingPreLoginExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new LoanBookingPreLoginRequest(); // LoanBookingPreLoginRequest | LoanBookingPreLoginRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
                LoanBookingPreLoginResponse result = apiInstance.LoanBookingPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.LoanBookingPreLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingPreLoginRequest**](LoanBookingPreLoginRequest.md)| LoanBookingPreLoginRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**LoanBookingPreLoginResponse**](LoanBookingPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="partnerv1accountsaccountidloansget"></a>
# **PartnerV1AccountsAccountIdLoansGet**
> LoanSummaryResponse PartnerV1AccountsAccountIdLoansGet (string authorization, string uuid, string accept, string clientId, string accountId, string clientDetails = null, string nextStartIndex = null, string loanStatus = null, string offerType = null, string offerIndicator = null)

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class PartnerV1AccountsAccountIdLoansGetExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var accountId = accountId_example;  // string | The account id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. (optional) 
            var loanStatus = loanStatus_example;  // string | This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description (optional) 
            var offerType = offerType_example;  // string | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description (optional) 
            var offerIndicator = offerIndicator_example;  // string | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description (optional) 

            try
            {
                // This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
                LoanSummaryResponse result = apiInstance.PartnerV1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex, loanStatus, offerType, offerIndicator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.PartnerV1AccountsAccountIdLoansGet: " + e.Message );
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
 **accountId** | **string**| The account id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional] 
 **loanStatus** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description | [optional] 
 **offerType** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional] 
 **offerIndicator** | **string**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional] 

### Return type

[**LoanSummaryResponse**](LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanconsolidate"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string cardId, string clientDetails = null)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var cardId = cardId_example;  // string | The card id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to merge the multiple LOPs in to single loan with top up amount added
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate(body, authorization, uuid, accept, clientId, contentType, cardId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **cardId** | **string**| The card id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmation"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string clientDetails = null)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to merge the multiple LOPs in to single loan with top up amount added
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation(body, authorization, uuid, accept, clientId, contentType, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmationprelogin"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string offerId, string clientDetails = null)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to merge the multiple LOPs in to single loan with top up amount added
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateprelogin"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin (RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest body, string authorization, string uuid, string accept, string clientId, string contentType, string offerId, string clientDetails = null)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest(); // RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var contentType = contentType_example;  // string | application/json
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // This API is used to merge the multiple LOPs in to single loan with top up amount added
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin(body, authorization, uuid, accept, clientId, contentType, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| Client ID generated during application registration. | 
 **contentType** | **string**| application/json | 
 **offerId** | **string**| This Refers to the unique id for the Pre login offer. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanloansprelogin"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null, string offerType = null, string offerIndicator = null)

This API is to fetch the list of booked loans on customer's  credit cards.

This API is to fetch the list of booked loans on customer's  credit cards.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLoginExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var offerId = offerId_example;  // string | his Refers to the unique id for the Pre login offer
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var offerType = offerType_example;  // string | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description (optional) 
            var offerIndicator = offerIndicator_example;  // string | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description (optional) 

            try
            {
                // This API is to fetch the list of booked loans on customer's  credit cards.
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails, offerType, offerIndicator);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin: " + e.Message );
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
 **offerId** | **string**| his Refers to the unique id for the Pre login offer | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **offerType** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional] 
 **offerIndicator** | **string**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)

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
<a name="retrievecreditchargecardfulfillmentarrangementcreditplanoffersloanrepaymentschedules"></a>
# **RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**
> RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules (string authorization, string uuid, string accept, string clientId, string offerId, string loanAmount, int? tenor, string clientDetails = null, string nextStartIndex = null)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | Client ID generated during application registration.
            var offerId = offerId_example;  // string | This Refers to the unique id for the Pre login offer.
            var loanAmount = loanAmount_example;  // string | Loan amount for easy payment plan booking.
            var tenor = 56;  // int? | Tenure of loan.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // To allow customers to view the payment breakdown details.
                RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse result = apiInstance.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules(authorization, uuid, accept, clientId, offerId, loanAmount, tenor, clientDetails, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules: " + e.Message );
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
 **loanAmount** | **string**| Loan amount for easy payment plan booking. | 
 **tenor** | **int?**| Tenure of loan. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse**](RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="retrievedisbursementoptionsprelogin"></a>
# **RetrieveDisbursementOptionsPreLogin**
> RetrieveDisbursementOptionsPreLoginResponse RetrieveDisbursementOptionsPreLogin (string authorization, string uuid, string accept, string clientId, string offerId, string clientDetails = null)

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RetrieveDisbursementOptionsPreLoginExample
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

            try
            {
                // Get the list of disbursement options and the details like bank details and billing address relevant to each option.
                RetrieveDisbursementOptionsPreLoginResponse result = apiInstance.RetrieveDisbursementOptionsPreLogin(authorization, uuid, accept, clientId, offerId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.RetrieveDisbursementOptionsPreLogin: " + e.Message );
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

### Return type

[**RetrieveDisbursementOptionsPreLoginResponse**](RetrieveDisbursementOptionsPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1accountsaccountidloanscreditchecksearchpost"></a>
# **V1AccountsAccountIdLoansCreditCheckSearchPost**
> CreditCheckResponse V1AccountsAccountIdLoansCreditCheckSearchPost (CreditCheckRequest body, string authorization, string uuid, string accept, string clientId, string accountId, string clientDetails = null)

Credit Check based on Debt Service Ratio

This API is used to retrieve the eligible tenure options, the corresponding maximum eligible loan amount and the annual interest rate based on debt service ratio.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AccountsAccountIdLoansCreditCheckSearchPostExample
    {
        public void main()
        {
            var apiInstance = new CardsApi();
            var body = new CreditCheckRequest(); // CreditCheckRequest | 
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client id generated during consumer onboarding
            var accountId = accountId_example;  // string | The account id  in encrypted format.
            var clientDetails = clientDetails_example;  // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId (optional) 

            try
            {
                // Credit Check based on Debt Service Ratio
                CreditCheckResponse result = apiInstance.V1AccountsAccountIdLoansCreditCheckSearchPost(body, authorization, uuid, accept, clientId, accountId, clientDetails);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CardsApi.V1AccountsAccountIdLoansCreditCheckSearchPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CreditCheckRequest**](CreditCheckRequest.md)|  | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client id generated during consumer onboarding | 
 **accountId** | **string**| The account id  in encrypted format. | 
 **clientDetails** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional] 

### Return type

[**CreditCheckResponse**](CreditCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
