# Swagger\Client\CardsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**loanBookingConfirmationPreLogin**](CardsApi.md#loanbookingconfirmationprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings/confirmation | This API  is triggered after CMAMT interdiction in Loan Booking process.
[**loanBookingPreLogin**](CardsApi.md#loanbookingprelogin) | **POST** /v1/prelogin/creditCardServices/offers/{offerId}/loans/bookings | This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.
[**partnerV1AccountsAccountIdLoansGet**](CardsApi.md#partnerv1accountsaccountidloansget) | **GET** /partner/v1/accounts/{accountId}/loans | This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidate) | **POST** /v1/creditChargeCard/creditPlans/{cardId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmation) | **POST** /v1/creditChargeCard/creditPlans/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateconfirmationprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation/confirmation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanconsolidateprelogin) | **POST** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/consolidation | This API is used to merge the multiple LOPs in to single loan with top up amount added
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanloansprelogin) | **GET** /v1/preLogin/creditChargeCard/creditPlans/{offerId}/loans | This API is to fetch the list of booked loans on customer&#x27;s  credit cards.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepp) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans | This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanofferseppbookings) | **POST** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/bookings | This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersepprepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/easyPaymentPlans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**](CardsApi.md#retrievecreditchargecardfulfillmentarrangementcreditplanoffersloanrepaymentschedules) | **GET** /v1/prelogin/creditChargeCard/creditPlans/offers/{offerId}/loans/repaymentSchedules | To allow customers to view the payment breakdown details.
[**retrieveDisbursementOptionsPreLogin**](CardsApi.md#retrievedisbursementoptionsprelogin) | **GET** /v1/creditCardServices/offers/{offerId}/prelogin/loans/disbursementOptions | Get the list of disbursement options and the details like bank details and billing address relevant to each option.
[**v1AccountsAccountIdLoansCreditCheckSearchPost**](CardsApi.md#v1accountsaccountidloanscreditchecksearchpost) | **POST** /v1/accounts/{accountId}/loans/creditCheck/search | Credit Check based on Debt Service Ratio

# **loanBookingConfirmationPreLogin**
> \Swagger\Client\Model\LoanBookingConfirmationPreLoginResponse loanBookingConfirmationPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details)

This API  is triggered after CMAMT interdiction in Loan Booking process.

This API  is triggered after CMAMT interdiction in Loan Booking process.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\LoanBookingConfirmationPreLoginRequest(); // \Swagger\Client\Model\LoanBookingConfirmationPreLoginRequest | LoanBookingConfirmationPreLoginRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->loanBookingConfirmationPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->loanBookingConfirmationPreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\LoanBookingConfirmationPreLoginRequest**](../Model/LoanBookingConfirmationPreLoginRequest.md)| LoanBookingConfirmationPreLoginRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\LoanBookingConfirmationPreLoginResponse**](../Model/LoanBookingConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **loanBookingPreLogin**
> \Swagger\Client\Model\LoanBookingPreLoginResponse loanBookingPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details)

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

This API is triggered after the Loan Plan is selected and completes the Pre login Loan Booking. One of the responses to the execution of this API is the loan reference number.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\LoanBookingPreLoginRequest(); // \Swagger\Client\Model\LoanBookingPreLoginRequest | LoanBookingPreLoginRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->loanBookingPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->loanBookingPreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\LoanBookingPreLoginRequest**](../Model/LoanBookingPreLoginRequest.md)| LoanBookingPreLoginRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\LoanBookingPreLoginResponse**](../Model/LoanBookingPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **partnerV1AccountsAccountIdLoansGet**
> \Swagger\Client\Model\LoanSummaryResponse partnerV1AccountsAccountIdLoansGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details, $next_start_index, $loan_status, $offer_type, $offer_indicator)

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

This API is to retrieve the history details  of LOP/EPP -.If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
$loan_status = "loan_status_example"; // string | This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description
$offer_type = "offer_type_example"; // string | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
$offer_indicator = "offer_indicator_example"; // string | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description

try {
    $result = $apiInstance->partnerV1AccountsAccountIdLoansGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details, $next_start_index, $loan_status, $offer_type, $offer_indicator);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->partnerV1AccountsAccountIdLoansGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client id generated during consumer onboarding |
 **account_id** | **string**| The account id  in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional]
 **loan_status** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{loanStatus} resource to get valid value of this field with description | [optional]
 **offer_type** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional]
 **offer_indicator** | **string**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional]

### Return type

[**\Swagger\Client\Model\LoanSummaryResponse**](../Model/LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate($body, $authorization, $uuid, $accept, $client_id, $content_type, $card_id, $client_details)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest(); // \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$card_id = "card_id_example"; // string | The card id  in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate($body, $authorization, $uuid, $accept, $client_id, $content_type, $card_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **card_id** | **string**| The card id  in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest(); // \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmation: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest(); // \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details)

This API is used to merge the multiple LOPs in to single loan with top up amount added

This API is used to merge the multiple LOPs in to single loan with top up amount added

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest(); // \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin($authorization, $uuid, $accept, $client_id, $offer_id, $client_details, $offer_type, $offer_indicator)

This API is to fetch the list of booked loans on customer's  credit cards.

This API is to fetch the list of booked loans on customer's  credit cards.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$offer_id = "offer_id_example"; // string | his Refers to the unique id for the Pre login offer
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$offer_type = "offer_type_example"; // string | This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description
$offer_indicator = "offer_indicator_example"; // string | This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin($authorization, $uuid, $accept, $client_id, $offer_id, $client_details, $offer_type, $offer_indicator);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansPreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **offer_id** | **string**| his Refers to the unique id for the Pre login offer |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **offer_type** | **string**| This is a reference data field.  Please use /v1/utilities/referenceData/{offerType} resource to get valid value of this field with description | [optional]
 **offer_indicator** | **string**| This is a reference data field. Please use /v1/utilities/referenceData/{offerIndicator} resource to get valid value of this field with description | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp($authorization, $uuid, $accept, $client_id, $offer_id, $client_details, $product_id, $loan_amount)

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

This API list the Options for Pre Login EPP offers that the customer can avail. It provides the applicable interest rate and tenors.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$product_id = "product_id_example"; // string | Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description.
$loan_amount = 1.2; // float | Loan amount for easy payment plan booking.

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp($authorization, $uuid, $accept, $client_id, $offer_id, $client_details, $product_id, $loan_amount);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEpp: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **product_id** | **string**| Product ID.This is a reference data field. Please use /v1/utilities/referenceData/{productId} resource to get valid value of this field with description. | [optional]
 **loan_amount** | **float**| Loan amount for easy payment plan booking. | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details)

This API is triggered after the EPP plan is selected  and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

This API is triggered after the EPP Plan is selected and completes the EPP Booking. One of the responses to the execution of this API is the transaction reference/confirmation number.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest(); // \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest | RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings($body, $authorization, $uuid, $accept, $client_id, $content_type, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookings: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest.md)| RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules($authorization, $uuid, $accept, $client_id, $offer_id, $loan_amount, $tenor, $client_details, $next_start_index, $binary_data_flag)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details for the selected time period for prelogin offer

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$loan_amount = 1.2; // float | Loan amount for easy payment plan booking.
$tenor = 1.2; // float | Tenure of loan in months
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
$binary_data_flag = true; // bool | This refer to the flag in case of binary file is require.

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules($authorization, $uuid, $accept, $client_id, $offer_id, $loan_amount, $tenor, $client_details, $next_start_index, $binary_data_flag);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedules: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **loan_amount** | **float**| Loan amount for easy payment plan booking. |
 **tenor** | **float**| Tenure of loan in months |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **binary_data_flag** | **bool**| This refer to the flag in case of binary file is require. | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules**
> \Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules($authorization, $uuid, $accept, $client_id, $offer_id, $loan_amount, $tenor, $client_details, $next_start_index)

To allow customers to view the payment breakdown details.

This API allows the customer to view the payment breakdown details.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$loan_amount = "loan_amount_example"; // string | Loan amount for easy payment plan booking.
$tenor = 56; // int | Tenure of loan.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules($authorization, $uuid, $accept, $client_id, $offer_id, $loan_amount, $tenor, $client_details, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedules: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **loan_amount** | **string**| Loan amount for easy payment plan booking. |
 **tenor** | **int**| Tenure of loan. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse**](../Model/RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveDisbursementOptionsPreLogin**
> \Swagger\Client\Model\RetrieveDisbursementOptionsPreLoginResponse retrieveDisbursementOptionsPreLogin($authorization, $uuid, $accept, $client_id, $offer_id, $client_details)

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

Get the list of disbursement options and the details like bank details and billing address relevant to each option.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$offer_id = "offer_id_example"; // string | This Refers to the unique id for the Pre login offer.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->retrieveDisbursementOptionsPreLogin($authorization, $uuid, $accept, $client_id, $offer_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->retrieveDisbursementOptionsPreLogin: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **offer_id** | **string**| This Refers to the unique id for the Pre login offer. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveDisbursementOptionsPreLoginResponse**](../Model/RetrieveDisbursementOptionsPreLoginResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansCreditCheckSearchPost**
> \Swagger\Client\Model\CreditCheckResponse v1AccountsAccountIdLoansCreditCheckSearchPost($body, $authorization, $uuid, $accept, $client_id, $account_id, $client_details)

Credit Check based on Debt Service Ratio

This API is used to retrieve the eligible tenure options, the corresponding maximum eligible loan amount and the annual interest rate based on debt service ratio.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\CardsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CreditCheckRequest(); // \Swagger\Client\Model\CreditCheckRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdLoansCreditCheckSearchPost($body, $authorization, $uuid, $accept, $client_id, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling CardsApi->v1AccountsAccountIdLoansCreditCheckSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CreditCheckRequest**](../Model/CreditCheckRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client id generated during consumer onboarding |
 **account_id** | **string**| The account id  in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\CreditCheckResponse**](../Model/CreditCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

