# Swagger\Client\AccountsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountBalancesSummaryInquiry**](AccountsApi.md#accountbalancessummaryinquiry) | **GET** /v1/accounts/{accountId}/closure/balances | Retrieve Account Balance Summary
[**balanceTransferBooking**](AccountsApi.md#balancetransferbooking) | **POST** /v1/accounts/{accountId}/loans/balanceTransfers/bookings | Book Balance Transfer
[**balanceTransferEligibility**](AccountsApi.md#balancetransfereligibility) | **GET** /v1/accounts/loans/balanceTransfers | Check Eligibility for Balance Transfer Offer
[**consentsDetailsInquiry**](AccountsApi.md#consentsdetailsinquiry) | **GET** /v1/accounts/{accountId}/consents | Retrieve Consents based on Account Number
[**consentsDetailsUpdate**](AccountsApi.md#consentsdetailsupdate) | **POST** /v1/accounts/{accountId}/consents | This API is used to update the consent for an account
[**partnerV1AccountsAccountIdAccessCodesGet**](AccountsApi.md#partnerv1accountsaccountidaccesscodesget) | **GET** /partner/v1/accounts/{accountId}/accessCodes | This API will retrieve the Access Code which will be used to see the clear account number
[**partnerV1PartnerAccountsGet**](AccountsApi.md#partnerv1partneraccountsget) | **GET** /partner/v1/partnerAccounts | Retrieve Partner Account Summary
[**retrieveUnmaskedAccountData**](AccountsApi.md#retrieveunmaskedaccountdata) | **POST** /v1/accounts/clearData/retrieve | This API provides unmasked IBAN (International bank account number) for the requested account Id.
[**v1AccountsAccountIdLoansBookingsPost**](AccountsApi.md#v1accountsaccountidloansbookingspost) | **POST** /v1/accounts/{accountId}/loans/bookings | Book Loan Over Phone
[**v1AccountsAccountIdLoansDisbursementOptionsGet**](AccountsApi.md#v1accountsaccountidloansdisbursementoptionsget) | **GET** /v1/accounts/{accountId}/loans/disbursementOptions | Retrieve Disbursement Options
[**v1AccountsAccountIdLoansGet**](AccountsApi.md#v1accountsaccountidloansget) | **GET** /v1/accounts/{accountId}/loans | Retrieve Loan Summary
[**v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet**](AccountsApi.md#v1accountsaccountidloansloanamountpaymentsplansget) | **GET** /v1/accounts/{accountId}/loans/{loanAmount}/paymentsPlans | Retrieve Loan Booking Plans
[**v1AccountsAccountIdLoansRepaymentSchedulesGet**](AccountsApi.md#v1accountsaccountidloansrepaymentschedulesget) | **GET** /v1/accounts/{accountId}/loans/repaymentSchedules | Retrieve Repayment Schedules
[**v1AccountsAccountIdStatementsGet**](AccountsApi.md#v1accountsaccountidstatementsget) | **GET** /v1/accounts/{accountId}/statements | Retrieve list of available statements.
[**v1AccountsAccountIdStatementsStatementIdGet**](AccountsApi.md#v1accountsaccountidstatementsstatementidget) | **GET** /v1/accounts/{accountId}/statements/{statementId} | Retrieve Statements Summary and Transaction
[**v1AccountsAccountIdTransactionsConfirmationPost**](AccountsApi.md#v1accountsaccountidtransactionsconfirmationpost) | **POST** /v1/accounts/{accountId}/transactions/confirmation | Confirm Transaction Details
[**v1AccountsAccountIdTransactionsLimitedDayRangeGet**](AccountsApi.md#v1accountsaccountidtransactionslimiteddayrangeget) | **GET** /v1/accounts/{accountId}/transactions/limited/dayRange | Retrieve Transaction Details for Limited Period
[**v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet**](AccountsApi.md#v1accountsaccountidtransactionstransactionreferenceiddetailsget) | **GET** /v1/accounts/{accountId}/transactions/{transactionReferenceId}/details | Retrieve Additional Transaction Details By Transaction Reference Id
[**v1AccountsLoansBookingsConfirmationPost**](AccountsApi.md#v1accountsloansbookingsconfirmationpost) | **POST** /v1/accounts/loans/bookings/confirmation | Loan Booking Confirmation
[**v1AccountsLoansEligibilityGet**](AccountsApi.md#v1accountsloanseligibilityget) | **GET** /v1/accounts/loans/eligibility | Check Eligibility for Loan Offer
[**v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet**](AccountsApi.md#v1accountsloansloanreferenceidrepaymentschedulesget) | **GET** /v1/accounts/loans/{loanReferenceId}/repaymentSchedules | Retrieve Repayment Schedule of Booked LOP/EPP Loan
[**v1AccountsTransactionsSearchPost**](AccountsApi.md#v1accountstransactionssearchpost) | **POST** /v1/accounts/transactions/search | Retrieve Multiple Accounts Transaction Details
[**viewTransactionDetailsDocument_**](AccountsApi.md#viewtransactiondetailsdocument_) | **GET** /v1/accounts/{accountId}/transactions/documents | Download Transaction Details

# **accountBalancesSummaryInquiry**
> \Swagger\Client\Model\AccountBalancesSummaryInquiryResponse accountBalancesSummaryInquiry($authorization, $uuid, $accept, $client_id, $account_id, $client_details)

Retrieve Account Balance Summary

This API allows the customers to retrieve the outstanding balance at the time of their account closure.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer on-boarding
$account_id = "account_id_example"; // string | The customer account identifier in encrypted format
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->accountBalancesSummaryInquiry($authorization, $uuid, $accept, $client_id, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->accountBalancesSummaryInquiry: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client id generated during consumer on-boarding |
 **account_id** | **string**| The customer account identifier in encrypted format |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\AccountBalancesSummaryInquiryResponse**](../Model/AccountBalancesSummaryInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **balanceTransferBooking**
> \Swagger\Client\Model\BalanceTransferBookingResponse balanceTransferBooking($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details)

Book Balance Transfer

This API is used to book the Balance Transfer selected by the customer. After the successful Balance Transfer booking, a reference number is sent to the customer.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\BalanceTransferBookingRequest(); // \Swagger\Client\Model\BalanceTransferBookingRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->balanceTransferBooking($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->balanceTransferBooking: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\BalanceTransferBookingRequest**](../Model/BalanceTransferBookingRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **account_id** | **string**| The account id  in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\BalanceTransferBookingResponse**](../Model/BalanceTransferBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **balanceTransferEligibility**
> \Swagger\Client\Model\BalanceTransferEligibilityResponse balanceTransferEligibility($authorization, $uuid, $accept, $client_id, $client_details, $bt_supported_account_group)

Check Eligibility for Balance Transfer Offer

This API is triggered to check eligibility for Balance Transfer Offer.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$bt_supported_account_group = "bt_supported_account_group_example"; // string | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description.

try {
    $result = $apiInstance->balanceTransferEligibility($authorization, $uuid, $accept, $client_id, $client_details, $bt_supported_account_group);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->balanceTransferEligibility: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **bt_supported_account_group** | **string**| This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. | [optional]

### Return type

[**\Swagger\Client\Model\BalanceTransferEligibilityResponse**](../Model/BalanceTransferEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **consentsDetailsInquiry**
> \Swagger\Client\Model\ConsentsDetailsInquiryResponse consentsDetailsInquiry($authorization, $uuid, $accept, $client_id, $account_id, $consent_type, $client_details)

Retrieve Consents based on Account Number

This API is used to retrieve the consents based on account number.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer
$consent_type = "consent_type_example"; // string | Consent Type
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->consentsDetailsInquiry($authorization, $uuid, $accept, $client_id, $account_id, $consent_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->consentsDetailsInquiry: ', $e->getMessage(), PHP_EOL;
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
 **account_id** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **consent_type** | **string**| Consent Type |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\ConsentsDetailsInquiryResponse**](../Model/ConsentsDetailsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **consentsDetailsUpdate**
> consentsDetailsUpdate($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details)

This API is used to update the consent for an account

This API is used to update the consent for an account

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\ConsentsDetailsUpdateRequest(); // \Swagger\Client\Model\ConsentsDetailsUpdateRequest | ConsentsDetailsUpdateRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$account_id = "account_id_example"; // string | The account identifier in encrypted format
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $apiInstance->consentsDetailsUpdate($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->consentsDetailsUpdate: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\ConsentsDetailsUpdateRequest**](../Model/ConsentsDetailsUpdateRequest.md)| ConsentsDetailsUpdateRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **account_id** | **string**| The account identifier in encrypted format |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **partnerV1AccountsAccountIdAccessCodesGet**
> \Swagger\Client\Model\AccountAccessCodeGenerationResponse partnerV1AccountsAccountIdAccessCodesGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details)

This API will retrieve the Access Code which will be used to see the clear account number

This API will retrieve the Access Code which will be used to see the clear account number

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$account_id = "account_id_example"; // string | The customer account identifier in encrypted format
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->partnerV1AccountsAccountIdAccessCodesGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->partnerV1AccountsAccountIdAccessCodesGet: ', $e->getMessage(), PHP_EOL;
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
 **account_id** | **string**| The customer account identifier in encrypted format |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\AccountAccessCodeGenerationResponse**](../Model/AccountAccessCodeGenerationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **partnerV1PartnerAccountsGet**
> \Swagger\Client\Model\AccountsGroupList partnerV1PartnerAccountsGet($authorization, $uuid, $accept, $client_id, $client_details, $next_start_index)

Retrieve Partner Account Summary

This API is used to retrieve a summary of a customer's partner account such as Savings Account,Checking Account,Credit Card Account,Loan Account,Ready Credit Account,Securities Brokerage Account,Mutual Fund Account,Call Deposit Account,Premium Deposit Account,Time Deposit Account,Insurance Account, etc.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client_id generated during consumer onboarding
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->partnerV1PartnerAccountsGet($authorization, $uuid, $accept, $client_id, $client_details, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->partnerV1PartnerAccountsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client_id generated during consumer onboarding |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\AccountsGroupList**](../Model/AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **retrieveUnmaskedAccountData**
> \Swagger\Client\Model\RetrieveUnmaskedAccountDataResponse retrieveUnmaskedAccountData($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

This API provides unmasked IBAN (International bank account number) for the requested account Id.

This API returns unmasked IBAN (International bank account number) for the requested account Id. To retrieve the unmasked account number, simply pass the account id parameter, which you can get from the ‘Account Summary’ API for Accounts (AIS) and Source account eligibility API for Money Movement (PIS).Note: This API works for both Accounts (AIS) and Money Movement (PIS) APIs.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\RetrieveUnmaskedAccountDataRequest(); // \Swagger\Client\Model\RetrieveUnmaskedAccountDataRequest | RetrieveUnmaskedAccountDataRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random universally unique identifier (UUID) generated for every request.
$accept = "accept_example"; // string | Content-Types that are acceptable for the response. Always pass application/json.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId.

try {
    $result = $apiInstance->retrieveUnmaskedAccountData($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->retrieveUnmaskedAccountData: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\RetrieveUnmaskedAccountDataRequest**](../Model/RetrieveUnmaskedAccountDataRequest.md)| RetrieveUnmaskedAccountDataRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random universally unique identifier (UUID) generated for every request. |
 **accept** | **string**| Content-Types that are acceptable for the response. Always pass application/json. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId. | [optional]

### Return type

[**\Swagger\Client\Model\RetrieveUnmaskedAccountDataResponse**](../Model/RetrieveUnmaskedAccountDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansBookingsPost**
> \Swagger\Client\Model\LoanBookingResponse v1AccountsAccountIdLoansBookingsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details)

Book Loan Over Phone

This API is used to book the loan with the plan selected by the customer. After the successful loan booking, a reference number is sent to the customer.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\LoanBookingRequest(); // \Swagger\Client\Model\LoanBookingRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdLoansBookingsPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdLoansBookingsPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\LoanBookingRequest**](../Model/LoanBookingRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **account_id** | **string**| The account id  in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\LoanBookingResponse**](../Model/LoanBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansDisbursementOptionsGet**
> \Swagger\Client\Model\DisbursementOptionsResponse v1AccountsAccountIdLoansDisbursementOptionsGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details)

Retrieve Disbursement Options

This API is used to get the list of eligible disbursement options like cheque, personal account and external bank account etc.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdLoansDisbursementOptionsGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdLoansDisbursementOptionsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **account_id** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\DisbursementOptionsResponse**](../Model/DisbursementOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansGet**
> \Swagger\Client\Model\LoanSummaryResponse v1AccountsAccountIdLoansGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details, $next_start_index)

Retrieve Loan Summary

This API is used to retrieve the summary of the Loan Over Phone (LOP) or Easy Payment Plan (EPP) loans availed on a particular account id.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
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

try {
    $result = $apiInstance->v1AccountsAccountIdLoansGet($authorization, $uuid, $accept, $client_id, $account_id, $client_details, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdLoansGet: ', $e->getMessage(), PHP_EOL;
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

### Return type

[**\Swagger\Client\Model\LoanSummaryResponse**](../Model/LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet**
> \Swagger\Client\Model\LoanBookingPlanResponse v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet($authorization, $uuid, $accept, $client_id, $account_id, $loan_amount, $tenor, $client_details)

Retrieve Loan Booking Plans

This API lists the loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees etc

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$loan_amount = "loan_amount_example"; // string | Eligible loan amount.
$tenor = "tenor_example"; // string | Tenure of loan in months.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet($authorization, $uuid, $accept, $client_id, $account_id, $loan_amount, $tenor, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet: ', $e->getMessage(), PHP_EOL;
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
 **loan_amount** | **string**| Eligible loan amount. |
 **tenor** | **string**| Tenure of loan in months. | [optional]
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\LoanBookingPlanResponse**](../Model/LoanBookingPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdLoansRepaymentSchedulesGet**
> \Swagger\Client\Model\LoanRepaymentScheuleResponse v1AccountsAccountIdLoansRepaymentSchedulesGet($authorization, $uuid, $accept, $client_id, $account_id, $loan_amount, $tenor, $client_details, $next_start_index)

Retrieve Repayment Schedules

This API allows the customer to view the payment breakdown details.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account id  in encrypted format.
$loan_amount = 1.2; // double | Loan amount for easy payment plan booking.
$tenor = 1.2; // float | Tenure of loan in months.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->v1AccountsAccountIdLoansRepaymentSchedulesGet($authorization, $uuid, $accept, $client_id, $account_id, $loan_amount, $tenor, $client_details, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdLoansRepaymentSchedulesGet: ', $e->getMessage(), PHP_EOL;
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
 **loan_amount** | **double**| Loan amount for easy payment plan booking. |
 **tenor** | **float**| Tenure of loan in months. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\LoanRepaymentScheuleResponse**](../Model/LoanRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdStatementsGet**
> \Swagger\Client\Model\AccountStatementListResponse v1AccountsAccountIdStatementsGet($authorization, $uuid, $accept, $client_id, $account_id, $next_start_index, $client_details)

Retrieve list of available statements.

This API is used to retrieve list of available statements. Currently support statements for credit card accounts only.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account identifier in encrypted format.
$next_start_index = "next_start_index_example"; // string | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdStatementsGet($authorization, $uuid, $accept, $client_id, $account_id, $next_start_index, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdStatementsGet: ', $e->getMessage(), PHP_EOL;
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
 **account_id** | **string**| The account identifier in encrypted format. |
 **next_start_index** | **string**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional]
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\AccountStatementListResponse**](../Model/AccountStatementListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdStatementsStatementIdGet**
> \Swagger\Client\Model\StatementsResponse v1AccountsAccountIdStatementsStatementIdGet($authorization, $uuid, $accept, $client_id, $account_id, $statement_id, $client_details, $currency_code, $next_start_index, $statement_date)

Retrieve Statements Summary and Transaction

This API is used to retrieve the summary of transactions for a statement of cards held by a customer including primary and supplementary cards.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$account_id = "account_id_example"; // string | The account identifier in encrypted format.
$statement_id = "statement_id_example"; // string | Unique identifier for the statement.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$currency_code = "currency_code_example"; // string | The currency code  in ISO 4217 format
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
$statement_date = "statement_date_example"; // string | Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD.

try {
    $result = $apiInstance->v1AccountsAccountIdStatementsStatementIdGet($authorization, $uuid, $accept, $client_id, $account_id, $statement_id, $client_details, $currency_code, $next_start_index, $statement_date);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdStatementsStatementIdGet: ', $e->getMessage(), PHP_EOL;
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
 **account_id** | **string**| The account identifier in encrypted format. |
 **statement_id** | **string**| Unique identifier for the statement. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **currency_code** | **string**| The currency code  in ISO 4217 format | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **statement_date** | **string**| Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD. | [optional]

### Return type

[**\Swagger\Client\Model\StatementsResponse**](../Model/StatementsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdTransactionsConfirmationPost**
> \Swagger\Client\Model\TransactionDetailsConfirmationResponse v1AccountsAccountIdTransactionsConfirmationPost($body, $authorization, $uuid, $accept, $client_id, $control_flow_id, $account_id, $client_details)

Confirm Transaction Details

This API is used to retrieve transaction details for a single account based on the controlflowId generated after successful OTP validation. This API is used to confirm successful OTP validation.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\TransactionDetailsConfirmationRequest(); // \Swagger\Client\Model\TransactionDetailsConfirmationRequest | TransactionDetailsConfirmationRequest
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$control_flow_id = "control_flow_id_example"; // string | It is used to control the flow for subsequent requests in the session.
$account_id = "account_id_example"; // string | The account identifier in encrypted format.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdTransactionsConfirmationPost($body, $authorization, $uuid, $accept, $client_id, $control_flow_id, $account_id, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdTransactionsConfirmationPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\TransactionDetailsConfirmationRequest**](../Model/TransactionDetailsConfirmationRequest.md)| TransactionDetailsConfirmationRequest |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **control_flow_id** | **string**| It is used to control the flow for subsequent requests in the session. |
 **account_id** | **string**| The account identifier in encrypted format. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\TransactionDetailsConfirmationResponse**](../Model/TransactionDetailsConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdTransactionsLimitedDayRangeGet**
> \Swagger\Client\Model\TransactionDetailsResponse v1AccountsAccountIdTransactionsLimitedDayRangeGet($account_id, $authorization, $uuid, $accept, $client_id, $transaction_status, $next_start_index, $request_size, $transaction_from_date, $transaction_to_date, $amount_from, $amount_to, $client_details)

Retrieve Transaction Details for Limited Period

This API is used to retrieve transactions for the specified account with maximum allowable period of 90 days. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client_id generated during consumer onboarding
$transaction_status = "transaction_status_example"; // string | Applicable for credit cards only. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description.
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
$request_size = 1.2; // float | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported.
$transaction_from_date = "transaction_from_date_example"; // string | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
$transaction_to_date = "transaction_to_date_example"; // string | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
$amount_from = "amount_from_example"; // string | Starting range of transaction amount. Note: Applicable for Investment accounts
$amount_to = "amount_to_example"; // string | End range of transaction amount. Note: Applicable for Investment accounts
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdTransactionsLimitedDayRangeGet($account_id, $authorization, $uuid, $accept, $client_id, $transaction_status, $next_start_index, $request_size, $transaction_from_date, $transaction_to_date, $amount_from, $amount_to, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdTransactionsLimitedDayRangeGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client_id generated during consumer onboarding |
 **transaction_status** | **string**| Applicable for credit cards only. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **request_size** | **float**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional]
 **transaction_from_date** | **string**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **transaction_to_date** | **string**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **amount_from** | **string**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **amount_to** | **string**| End range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\TransactionDetailsResponse**](../Model/TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet**
> \Swagger\Client\Model\TransactionDetailedViewResponse v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet($authorization, $uuid, $accept, $client_id, $account_id, $transaction_reference_id, $transaction_code, $client_details)

Retrieve Additional Transaction Details By Transaction Reference Id

This API allows you to retrieve additional transaction details data associated with a transaction reference id.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$account_id = "account_id_example"; // string | The account identifier in encrypted format.
$transaction_reference_id = "transaction_reference_id_example"; // string | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.
$transaction_code = "transaction_code_example"; // string | Transaction Code specific to the transaction
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet($authorization, $uuid, $accept, $client_id, $account_id, $transaction_reference_id, $transaction_code, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **account_id** | **string**| The account identifier in encrypted format. |
 **transaction_reference_id** | **string**| Reference Id to uniquely identify the transaction.This is applicable for successful transactions. |
 **transaction_code** | **string**| Transaction Code specific to the transaction | [optional]
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\TransactionDetailedViewResponse**](../Model/TransactionDetailedViewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsLoansBookingsConfirmationPost**
> \Swagger\Client\Model\LoanBookingConfirmationResponse v1AccountsLoansBookingsConfirmationPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

Loan Booking Confirmation

This API is triggered after CMAMT interdiction in Loan Booking process.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\LoanBookingConfirmationRequest(); // \Swagger\Client\Model\LoanBookingConfirmationRequest | 
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsLoansBookingsConfirmationPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsLoansBookingsConfirmationPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\LoanBookingConfirmationRequest**](../Model/LoanBookingConfirmationRequest.md)|  |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\LoanBookingConfirmationResponse**](../Model/LoanBookingConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsLoansEligibilityGet**
> \Swagger\Client\Model\LoanEligibilityCheckResponse v1AccountsLoansEligibilityGet($authorization, $uuid, $accept, $client_id, $client_details, $lop_supported_account_group)

Check Eligibility for Loan Offer

This API is triggered to check eligibility for Loan Offer for a customer.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$lop_supported_account_group = "lop_supported_account_group_example"; // string | This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description.

try {
    $result = $apiInstance->v1AccountsLoansEligibilityGet($authorization, $uuid, $accept, $client_id, $client_details, $lop_supported_account_group);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsLoansEligibilityGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **lop_supported_account_group** | **string**| This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description. | [optional]

### Return type

[**\Swagger\Client\Model\LoanEligibilityCheckResponse**](../Model/LoanEligibilityCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet**
> \Swagger\Client\Model\LoanRepaymentScheuleResponse v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet($authorization, $uuid, $accept, $client_id, $loan_reference_id, $client_details, $next_start_index)

Retrieve Repayment Schedule of Booked LOP/EPP Loan

This API is used to retrieve the list of remaining repayment schedule of booked LOP/EPP loan by sending loan reference id.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client id generated during consumer onboarding
$loan_reference_id = "loan_reference_id_example"; // string | Reference Id to uniquely identify the loan.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet($authorization, $uuid, $accept, $client_id, $loan_reference_id, $client_details, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet: ', $e->getMessage(), PHP_EOL;
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
 **loan_reference_id** | **string**| Reference Id to uniquely identify the loan. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\LoanRepaymentScheuleResponse**](../Model/LoanRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsTransactionsSearchPost**
> \Swagger\Client\Model\CompositeTransactionDetailsResponse v1AccountsTransactionsSearchPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details)

Retrieve Multiple Accounts Transaction Details

This API is to retrieve transactions details & history for multiple accounts in one request .If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$body = new \Swagger\Client\Model\CompositeTransactionDetailsRequest(); // \Swagger\Client\Model\CompositeTransactionDetailsRequest | Get Transaction details.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$content_type = "content_type_example"; // string | application/json
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId

try {
    $result = $apiInstance->v1AccountsTransactionsSearchPost($body, $authorization, $uuid, $accept, $client_id, $content_type, $client_details);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->v1AccountsTransactionsSearchPost: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**\Swagger\Client\Model\CompositeTransactionDetailsRequest**](../Model/CompositeTransactionDetailsRequest.md)| Get Transaction details. |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| Client ID generated during application registration. |
 **content_type** | **string**| application/json |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**\Swagger\Client\Model\CompositeTransactionDetailsResponse**](../Model/CompositeTransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **viewTransactionDetailsDocument_**
> \Swagger\Client\Model\ViewTransactionDetailsDocumentResponse viewTransactionDetailsDocument_($authorization, $uuid, $accept, $client_id, $account_id, $download_format, $client_details, $transaction_start_date, $transaction_end_date, $next_start_index)

Download Transaction Details

This API is used to check the customer's eligibility for availing Balance Transfer. It is also used to provide eligible payment plans.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\AccountsApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | Client ID generated during application registration.
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer.
$download_format = "download_format_example"; // string | This field refer to the fomat in which transaction detials is require to be downloaded. This is a reference data field. Please use /v1/utilities/referenceData/{downloadFormat} resource to get valid value of this field with description.
$client_details = "client_details_example"; // string | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
$transaction_start_date = new \DateTime("2013-10-20"); // \DateTime | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'.
$transaction_end_date = new \DateTime("2013-10-20"); // \DateTime | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'.
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->viewTransactionDetailsDocument_($authorization, $uuid, $accept, $client_id, $account_id, $download_format, $client_details, $transaction_start_date, $transaction_end_date, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountsApi->viewTransactionDetailsDocument_: ', $e->getMessage(), PHP_EOL;
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
 **account_id** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer. |
 **download_format** | **string**| This field refer to the fomat in which transaction detials is require to be downloaded. This is a reference data field. Please use /v1/utilities/referenceData/{downloadFormat} resource to get valid value of this field with description. |
 **client_details** | **string**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **transaction_start_date** | **\DateTime**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. | [optional]
 **transaction_end_date** | **\DateTime**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\ViewTransactionDetailsDocumentResponse**](../Model/ViewTransactionDetailsDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

