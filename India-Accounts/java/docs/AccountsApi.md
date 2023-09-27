# AccountsApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**accountBalancesSummaryInquiry**](AccountsApi.md#accountBalancesSummaryInquiry) | **GET** /v1/accounts/{accountId}/closure/balances | Retrieve Account Balance Summary
[**balanceTransferBooking**](AccountsApi.md#balanceTransferBooking) | **POST** /v1/accounts/{accountId}/loans/balanceTransfers/bookings | Book Balance Transfer
[**balanceTransferEligibility**](AccountsApi.md#balanceTransferEligibility) | **GET** /v1/accounts/loans/balanceTransfers | Check Eligibility for Balance Transfer Offer
[**consentsDetailsInquiry**](AccountsApi.md#consentsDetailsInquiry) | **GET** /v1/accounts/{accountId}/consents | Retrieve Consents based on Account Number
[**consentsDetailsUpdate**](AccountsApi.md#consentsDetailsUpdate) | **POST** /v1/accounts/{accountId}/consents | This API is used to update the consent for an account
[**partnerV1AccountsAccountIdAccessCodesGet**](AccountsApi.md#partnerV1AccountsAccountIdAccessCodesGet) | **GET** /partner/v1/accounts/{accountId}/accessCodes | This API will retrieve the Access Code which will be used to see the clear account number
[**partnerV1PartnerAccountsGet**](AccountsApi.md#partnerV1PartnerAccountsGet) | **GET** /partner/v1/partnerAccounts | Retrieve Partner Account Summary
[**retrieveUnmaskedAccountData**](AccountsApi.md#retrieveUnmaskedAccountData) | **POST** /v1/accounts/clearData/retrieve | This API provides unmasked IBAN (International bank account number) for the requested account Id.
[**v1AccountsAccountIdLoansBookingsPost**](AccountsApi.md#v1AccountsAccountIdLoansBookingsPost) | **POST** /v1/accounts/{accountId}/loans/bookings | Book Loan Over Phone
[**v1AccountsAccountIdLoansDisbursementOptionsGet**](AccountsApi.md#v1AccountsAccountIdLoansDisbursementOptionsGet) | **GET** /v1/accounts/{accountId}/loans/disbursementOptions | Retrieve Disbursement Options
[**v1AccountsAccountIdLoansGet**](AccountsApi.md#v1AccountsAccountIdLoansGet) | **GET** /v1/accounts/{accountId}/loans | Retrieve Loan Summary
[**v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet**](AccountsApi.md#v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet) | **GET** /v1/accounts/{accountId}/loans/{loanAmount}/paymentsPlans | Retrieve Loan Booking Plans
[**v1AccountsAccountIdLoansRepaymentSchedulesGet**](AccountsApi.md#v1AccountsAccountIdLoansRepaymentSchedulesGet) | **GET** /v1/accounts/{accountId}/loans/repaymentSchedules | Retrieve Repayment Schedules
[**v1AccountsAccountIdStatementsGet**](AccountsApi.md#v1AccountsAccountIdStatementsGet) | **GET** /v1/accounts/{accountId}/statements | Retrieve list of available statements.
[**v1AccountsAccountIdStatementsStatementIdGet**](AccountsApi.md#v1AccountsAccountIdStatementsStatementIdGet) | **GET** /v1/accounts/{accountId}/statements/{statementId} | Retrieve Statements Summary and Transaction
[**v1AccountsAccountIdTransactionsConfirmationPost**](AccountsApi.md#v1AccountsAccountIdTransactionsConfirmationPost) | **POST** /v1/accounts/{accountId}/transactions/confirmation | Confirm Transaction Details
[**v1AccountsAccountIdTransactionsLimitedDayRangeGet**](AccountsApi.md#v1AccountsAccountIdTransactionsLimitedDayRangeGet) | **GET** /v1/accounts/{accountId}/transactions/limited/dayRange | Retrieve Transaction Details for Limited Period
[**v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet**](AccountsApi.md#v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet) | **GET** /v1/accounts/{accountId}/transactions/{transactionReferenceId}/details | Retrieve Additional Transaction Details By Transaction Reference Id
[**v1AccountsLoansBookingsConfirmationPost**](AccountsApi.md#v1AccountsLoansBookingsConfirmationPost) | **POST** /v1/accounts/loans/bookings/confirmation | Loan Booking Confirmation
[**v1AccountsLoansEligibilityGet**](AccountsApi.md#v1AccountsLoansEligibilityGet) | **GET** /v1/accounts/loans/eligibility | Check Eligibility for Loan Offer
[**v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet**](AccountsApi.md#v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet) | **GET** /v1/accounts/loans/{loanReferenceId}/repaymentSchedules | Retrieve Repayment Schedule of Booked LOP/EPP Loan
[**v1AccountsTransactionsSearchPost**](AccountsApi.md#v1AccountsTransactionsSearchPost) | **POST** /v1/accounts/transactions/search | Retrieve Multiple Accounts Transaction Details
[**viewTransactionDetailsDocument_**](AccountsApi.md#viewTransactionDetailsDocument_) | **GET** /v1/accounts/{accountId}/transactions/documents | Download Transaction Details

<a name="accountBalancesSummaryInquiry"></a>
# **accountBalancesSummaryInquiry**
> AccountBalancesSummaryInquiryResponse accountBalancesSummaryInquiry(authorization, uuid, accept, clientId, accountId, clientDetails)

Retrieve Account Balance Summary

This API allows the customers to retrieve the outstanding balance at the time of their account closure.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer on-boarding
String accountId = "accountId_example"; // String | The customer account identifier in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    AccountBalancesSummaryInquiryResponse result = apiInstance.accountBalancesSummaryInquiry(authorization, uuid, accept, clientId, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#accountBalancesSummaryInquiry");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client id generated during consumer on-boarding |
 **accountId** | **String**| The customer account identifier in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**AccountBalancesSummaryInquiryResponse**](AccountBalancesSummaryInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="balanceTransferBooking"></a>
# **balanceTransferBooking**
> BalanceTransferBookingResponse balanceTransferBooking(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails)

Book Balance Transfer

This API is used to book the Balance Transfer selected by the customer. After the successful Balance Transfer booking, a reference number is sent to the customer.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
BalanceTransferBookingRequest body = new BalanceTransferBookingRequest(); // BalanceTransferBookingRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    BalanceTransferBookingResponse result = apiInstance.balanceTransferBooking(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#balanceTransferBooking");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BalanceTransferBookingRequest**](BalanceTransferBookingRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **accountId** | **String**| The account id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**BalanceTransferBookingResponse**](BalanceTransferBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="balanceTransferEligibility"></a>
# **balanceTransferEligibility**
> BalanceTransferEligibilityResponse balanceTransferEligibility(authorization, uuid, accept, clientId, clientDetails, btSupportedAccountGroup)

Check Eligibility for Balance Transfer Offer

This API is triggered to check eligibility for Balance Transfer Offer.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String btSupportedAccountGroup = "btSupportedAccountGroup_example"; // String | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description.
try {
    BalanceTransferEligibilityResponse result = apiInstance.balanceTransferEligibility(authorization, uuid, accept, clientId, clientDetails, btSupportedAccountGroup);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#balanceTransferEligibility");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **btSupportedAccountGroup** | **String**| This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. | [optional]

### Return type

[**BalanceTransferEligibilityResponse**](BalanceTransferEligibilityResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="consentsDetailsInquiry"></a>
# **consentsDetailsInquiry**
> ConsentsDetailsInquiryResponse consentsDetailsInquiry(authorization, uuid, accept, clientId, accountId, consentType, clientDetails)

Retrieve Consents based on Account Number

This API is used to retrieve the consents based on account number.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer
String consentType = "consentType_example"; // String | Consent Type
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    ConsentsDetailsInquiryResponse result = apiInstance.consentsDetailsInquiry(authorization, uuid, accept, clientId, accountId, consentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#consentsDetailsInquiry");
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
 **accountId** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **consentType** | **String**| Consent Type |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**ConsentsDetailsInquiryResponse**](ConsentsDetailsInquiryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="consentsDetailsUpdate"></a>
# **consentsDetailsUpdate**
> consentsDetailsUpdate(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails)

This API is used to update the consent for an account

This API is used to update the consent for an account

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
ConsentsDetailsUpdateRequest body = new ConsentsDetailsUpdateRequest(); // ConsentsDetailsUpdateRequest | ConsentsDetailsUpdateRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String accountId = "accountId_example"; // String | The account identifier in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    apiInstance.consentsDetailsUpdate(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#consentsDetailsUpdate");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ConsentsDetailsUpdateRequest**](ConsentsDetailsUpdateRequest.md)| ConsentsDetailsUpdateRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **accountId** | **String**| The account identifier in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

null (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="partnerV1AccountsAccountIdAccessCodesGet"></a>
# **partnerV1AccountsAccountIdAccessCodesGet**
> AccountAccessCodeGenerationResponse partnerV1AccountsAccountIdAccessCodesGet(authorization, uuid, accept, clientId, accountId, clientDetails)

This API will retrieve the Access Code which will be used to see the clear account number

This API will retrieve the Access Code which will be used to see the clear account number

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String accountId = "accountId_example"; // String | The customer account identifier in encrypted format
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    AccountAccessCodeGenerationResponse result = apiInstance.partnerV1AccountsAccountIdAccessCodesGet(authorization, uuid, accept, clientId, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#partnerV1AccountsAccountIdAccessCodesGet");
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
 **accountId** | **String**| The customer account identifier in encrypted format |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**AccountAccessCodeGenerationResponse**](AccountAccessCodeGenerationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="partnerV1PartnerAccountsGet"></a>
# **partnerV1PartnerAccountsGet**
> AccountsGroupList partnerV1PartnerAccountsGet(authorization, uuid, accept, clientId, clientDetails, nextStartIndex)

Retrieve Partner Account Summary

This API is used to retrieve a summary of a customer&#x27;s partner account such as Savings Account,Checking Account,Credit Card Account,Loan Account,Ready Credit Account,Securities Brokerage Account,Mutual Fund Account,Call Deposit Account,Premium Deposit Account,Time Deposit Account,Insurance Account, etc.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    AccountsGroupList result = apiInstance.partnerV1PartnerAccountsGet(authorization, uuid, accept, clientId, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#partnerV1PartnerAccountsGet");
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
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**AccountsGroupList**](AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="retrieveUnmaskedAccountData"></a>
# **retrieveUnmaskedAccountData**
> RetrieveUnmaskedAccountDataResponse retrieveUnmaskedAccountData(body, authorization, uuid, accept, clientId, contentType, clientDetails)

This API provides unmasked IBAN (International bank account number) for the requested account Id.

This API returns unmasked IBAN (International bank account number) for the requested account Id. To retrieve the unmasked account number, simply pass the account id parameter, which you can get from the ‘Account Summary’ API for Accounts (AIS) and Source account eligibility API for Money Movement (PIS).Note: This API works for both Accounts (AIS) and Money Movement (PIS) APIs.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
RetrieveUnmaskedAccountDataRequest body = new RetrieveUnmaskedAccountDataRequest(); // RetrieveUnmaskedAccountDataRequest | RetrieveUnmaskedAccountDataRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random universally unique identifier (UUID) generated for every request.
String accept = "accept_example"; // String | Content-Types that are acceptable for the response. Always pass application/json.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId.
try {
    RetrieveUnmaskedAccountDataResponse result = apiInstance.retrieveUnmaskedAccountData(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#retrieveUnmaskedAccountData");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RetrieveUnmaskedAccountDataRequest**](RetrieveUnmaskedAccountDataRequest.md)| RetrieveUnmaskedAccountDataRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random universally unique identifier (UUID) generated for every request. |
 **accept** | **String**| Content-Types that are acceptable for the response. Always pass application/json. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId. | [optional]

### Return type

[**RetrieveUnmaskedAccountDataResponse**](RetrieveUnmaskedAccountDataResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansBookingsPost"></a>
# **v1AccountsAccountIdLoansBookingsPost**
> LoanBookingResponse v1AccountsAccountIdLoansBookingsPost(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails)

Book Loan Over Phone

This API is used to book the loan with the plan selected by the customer. After the successful loan booking, a reference number is sent to the customer.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
LoanBookingRequest body = new LoanBookingRequest(); // LoanBookingRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    LoanBookingResponse result = apiInstance.v1AccountsAccountIdLoansBookingsPost(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdLoansBookingsPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingRequest**](LoanBookingRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **accountId** | **String**| The account id  in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**LoanBookingResponse**](LoanBookingResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansDisbursementOptionsGet"></a>
# **v1AccountsAccountIdLoansDisbursementOptionsGet**
> DisbursementOptionsResponse v1AccountsAccountIdLoansDisbursementOptionsGet(authorization, uuid, accept, clientId, accountId, clientDetails)

Retrieve Disbursement Options

This API is used to get the list of eligible disbursement options like cheque, personal account and external bank account etc.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    DisbursementOptionsResponse result = apiInstance.v1AccountsAccountIdLoansDisbursementOptionsGet(authorization, uuid, accept, clientId, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdLoansDisbursementOptionsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **accountId** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**DisbursementOptionsResponse**](DisbursementOptionsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansGet"></a>
# **v1AccountsAccountIdLoansGet**
> LoanSummaryResponse v1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex)

Retrieve Loan Summary

This API is used to retrieve the summary of the Loan Over Phone (LOP) or Easy Payment Plan (EPP) loans availed on a particular account id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
try {
    LoanSummaryResponse result = apiInstance.v1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdLoansGet");
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

### Return type

[**LoanSummaryResponse**](LoanSummaryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet"></a>
# **v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet**
> LoanBookingPlanResponse v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails)

Retrieve Loan Booking Plans

This API lists the loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees etc

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account id  in encrypted format.
String loanAmount = "loanAmount_example"; // String | Eligible loan amount.
String tenor = "tenor_example"; // String | Tenure of loan in months.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    LoanBookingPlanResponse result = apiInstance.v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet");
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
 **loanAmount** | **String**| Eligible loan amount. |
 **tenor** | **String**| Tenure of loan in months. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**LoanBookingPlanResponse**](LoanBookingPlanResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdLoansRepaymentSchedulesGet"></a>
# **v1AccountsAccountIdLoansRepaymentSchedulesGet**
> LoanRepaymentScheuleResponse v1AccountsAccountIdLoansRepaymentSchedulesGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails, nextStartIndex)

Retrieve Repayment Schedules

This API allows the customer to view the payment breakdown details.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account id  in encrypted format.
Double loanAmount = 3.4D; // Double | Loan amount for easy payment plan booking.
BigDecimal tenor = new BigDecimal(); // BigDecimal | Tenure of loan in months.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    LoanRepaymentScheuleResponse result = apiInstance.v1AccountsAccountIdLoansRepaymentSchedulesGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdLoansRepaymentSchedulesGet");
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
 **loanAmount** | **Double**| Loan amount for easy payment plan booking. |
 **tenor** | **BigDecimal**| Tenure of loan in months. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**LoanRepaymentScheuleResponse**](LoanRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdStatementsGet"></a>
# **v1AccountsAccountIdStatementsGet**
> AccountStatementListResponse v1AccountsAccountIdStatementsGet(authorization, uuid, accept, clientId, accountId, nextStartIndex, clientDetails)

Retrieve list of available statements.

This API is used to retrieve list of available statements. Currently support statements for credit card accounts only.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account identifier in encrypted format.
String nextStartIndex = "nextStartIndex_example"; // String | The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    AccountStatementListResponse result = apiInstance.v1AccountsAccountIdStatementsGet(authorization, uuid, accept, clientId, accountId, nextStartIndex, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdStatementsGet");
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
 **accountId** | **String**| The account identifier in encrypted format. |
 **nextStartIndex** | **String**| The next start index that indicates the next set of records to be fetched, if there are available. Typically, this value should be populated if the first response has the value of nextStartIndex.It is not applicable for the first iteration. | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**AccountStatementListResponse**](AccountStatementListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdStatementsStatementIdGet"></a>
# **v1AccountsAccountIdStatementsStatementIdGet**
> StatementsResponse v1AccountsAccountIdStatementsStatementIdGet(authorization, uuid, accept, clientId, accountId, statementId, clientDetails, currencyCode, nextStartIndex, statementDate)

Retrieve Statements Summary and Transaction

This API is used to retrieve the summary of transactions for a statement of cards held by a customer including primary and supplementary cards.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String accountId = "accountId_example"; // String | The account identifier in encrypted format.
String statementId = "statementId_example"; // String | Unique identifier for the statement.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String currencyCode = "currencyCode_example"; // String | The currency code  in ISO 4217 format
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
String statementDate = "statementDate_example"; // String | Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD.
try {
    StatementsResponse result = apiInstance.v1AccountsAccountIdStatementsStatementIdGet(authorization, uuid, accept, clientId, accountId, statementId, clientDetails, currencyCode, nextStartIndex, statementDate);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdStatementsStatementIdGet");
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
 **accountId** | **String**| The account identifier in encrypted format. |
 **statementId** | **String**| Unique identifier for the statement. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **currencyCode** | **String**| The currency code  in ISO 4217 format | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **statementDate** | **String**| Date on which the account statement has been generated in ISO 8601 date format YYYY-MM-DD. | [optional]

### Return type

[**StatementsResponse**](StatementsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdTransactionsConfirmationPost"></a>
# **v1AccountsAccountIdTransactionsConfirmationPost**
> TransactionDetailsConfirmationResponse v1AccountsAccountIdTransactionsConfirmationPost(body, authorization, uuid, accept, clientId, controlFlowId, accountId, clientDetails)

Confirm Transaction Details

This API is used to retrieve transaction details for a single account based on the controlflowId generated after successful OTP validation. This API is used to confirm successful OTP validation.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
TransactionDetailsConfirmationRequest body = new TransactionDetailsConfirmationRequest(); // TransactionDetailsConfirmationRequest | TransactionDetailsConfirmationRequest
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String controlFlowId = "controlFlowId_example"; // String | It is used to control the flow for subsequent requests in the session.
String accountId = "accountId_example"; // String | The account identifier in encrypted format.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    TransactionDetailsConfirmationResponse result = apiInstance.v1AccountsAccountIdTransactionsConfirmationPost(body, authorization, uuid, accept, clientId, controlFlowId, accountId, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdTransactionsConfirmationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**TransactionDetailsConfirmationRequest**](TransactionDetailsConfirmationRequest.md)| TransactionDetailsConfirmationRequest |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **controlFlowId** | **String**| It is used to control the flow for subsequent requests in the session. |
 **accountId** | **String**| The account identifier in encrypted format. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**TransactionDetailsConfirmationResponse**](TransactionDetailsConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1AccountsAccountIdTransactionsLimitedDayRangeGet"></a>
# **v1AccountsAccountIdTransactionsLimitedDayRangeGet**
> TransactionDetailsResponse v1AccountsAccountIdTransactionsLimitedDayRangeGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo, clientDetails)

Retrieve Transaction Details for Limited Period

This API is used to retrieve transactions for the specified account with maximum allowable period of 90 days. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
String transactionStatus = "transactionStatus_example"; // String | Applicable for credit cards only. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description.
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
BigDecimal requestSize = new BigDecimal(); // BigDecimal | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported.
String transactionFromDate = "transactionFromDate_example"; // String | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
String transactionToDate = "transactionToDate_example"; // String | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
String amountFrom = "amountFrom_example"; // String | Starting range of transaction amount. Note: Applicable for Investment accounts
String amountTo = "amountTo_example"; // String | End range of transaction amount. Note: Applicable for Investment accounts
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    TransactionDetailsResponse result = apiInstance.v1AccountsAccountIdTransactionsLimitedDayRangeGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdTransactionsLimitedDayRangeGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client_id generated during consumer onboarding |
 **transactionStatus** | **String**| Applicable for credit cards only. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **requestSize** | **BigDecimal**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional]
 **transactionFromDate** | **String**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **transactionToDate** | **String**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **amountFrom** | **String**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **amountTo** | **String**| End range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**TransactionDetailsResponse**](TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet"></a>
# **v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet**
> TransactionDetailedViewResponse v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet(authorization, uuid, accept, clientId, accountId, transactionReferenceId, transactionCode, clientDetails)

Retrieve Additional Transaction Details By Transaction Reference Id

This API allows you to retrieve additional transaction details data associated with a transaction reference id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String accountId = "accountId_example"; // String | The account identifier in encrypted format.
String transactionReferenceId = "transactionReferenceId_example"; // String | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.
String transactionCode = "transactionCode_example"; // String | Transaction Code specific to the transaction
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    TransactionDetailedViewResponse result = apiInstance.v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet(authorization, uuid, accept, clientId, accountId, transactionReferenceId, transactionCode, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **accountId** | **String**| The account identifier in encrypted format. |
 **transactionReferenceId** | **String**| Reference Id to uniquely identify the transaction.This is applicable for successful transactions. |
 **transactionCode** | **String**| Transaction Code specific to the transaction | [optional]
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**TransactionDetailedViewResponse**](TransactionDetailedViewResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsLoansBookingsConfirmationPost"></a>
# **v1AccountsLoansBookingsConfirmationPost**
> LoanBookingConfirmationResponse v1AccountsLoansBookingsConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Loan Booking Confirmation

This API is triggered after CMAMT interdiction in Loan Booking process.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
LoanBookingConfirmationRequest body = new LoanBookingConfirmationRequest(); // LoanBookingConfirmationRequest | 
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    LoanBookingConfirmationResponse result = apiInstance.v1AccountsLoansBookingsConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsLoansBookingsConfirmationPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**LoanBookingConfirmationRequest**](LoanBookingConfirmationRequest.md)|  |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**LoanBookingConfirmationResponse**](LoanBookingConfirmationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="v1AccountsLoansEligibilityGet"></a>
# **v1AccountsLoansEligibilityGet**
> LoanEligibilityCheckResponse v1AccountsLoansEligibilityGet(authorization, uuid, accept, clientId, clientDetails, lopSupportedAccountGroup)

Check Eligibility for Loan Offer

This API is triggered to check eligibility for Loan Offer for a customer.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String lopSupportedAccountGroup = "lopSupportedAccountGroup_example"; // String | This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description.
try {
    LoanEligibilityCheckResponse result = apiInstance.v1AccountsLoansEligibilityGet(authorization, uuid, accept, clientId, clientDetails, lopSupportedAccountGroup);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsLoansEligibilityGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D; |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **lopSupportedAccountGroup** | **String**| This field refers the account group supported by Loan over phone. This is a reference data field. Please use /v1/utilities/referenceData/{lopSupportedAccountGroup} resource to get valid value of this field with description. | [optional]

### Return type

[**LoanEligibilityCheckResponse**](LoanEligibilityCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet"></a>
# **v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet**
> LoanRepaymentScheuleResponse v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet(authorization, uuid, accept, clientId, loanReferenceId, clientDetails, nextStartIndex)

Retrieve Repayment Schedule of Booked LOP/EPP Loan

This API is used to retrieve the list of remaining repayment schedule of booked LOP/EPP loan by sending loan reference id.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client id generated during consumer onboarding
String loanReferenceId = "loanReferenceId_example"; // String | Reference Id to uniquely identify the loan.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    LoanRepaymentScheuleResponse result = apiInstance.v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet(authorization, uuid, accept, clientId, loanReferenceId, clientDetails, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet");
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
 **loanReferenceId** | **String**| Reference Id to uniquely identify the loan. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**LoanRepaymentScheuleResponse**](LoanRepaymentScheuleResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsTransactionsSearchPost"></a>
# **v1AccountsTransactionsSearchPost**
> CompositeTransactionDetailsResponse v1AccountsTransactionsSearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails)

Retrieve Multiple Accounts Transaction Details

This API is to retrieve transactions details &amp; history for multiple accounts in one request .If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
CompositeTransactionDetailsRequest body = new CompositeTransactionDetailsRequest(); // CompositeTransactionDetailsRequest | Get Transaction details.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String contentType = "contentType_example"; // String | application/json
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
try {
    CompositeTransactionDetailsResponse result = apiInstance.v1AccountsTransactionsSearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#v1AccountsTransactionsSearchPost");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CompositeTransactionDetailsRequest**](CompositeTransactionDetailsRequest.md)| Get Transaction details. |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| Client ID generated during application registration. |
 **contentType** | **String**| application/json |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]

### Return type

[**CompositeTransactionDetailsResponse**](CompositeTransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

<a name="viewTransactionDetailsDocument_"></a>
# **viewTransactionDetailsDocument_**
> ViewTransactionDetailsDocumentResponse viewTransactionDetailsDocument_(authorization, uuid, accept, clientId, accountId, downloadFormat, clientDetails, transactionStartDate, transactionEndDate, nextStartIndex)

Download Transaction Details

This API is used to check the customer&#x27;s eligibility for availing Balance Transfer. It is also used to provide eligible payment plans.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.AccountsApi;


AccountsApi apiInstance = new AccountsApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | Client ID generated during application registration.
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer.
String downloadFormat = "downloadFormat_example"; // String | This field refer to the fomat in which transaction detials is require to be downloaded. This is a reference data field. Please use /v1/utilities/referenceData/{downloadFormat} resource to get valid value of this field with description.
String clientDetails = "clientDetails_example"; // String | This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId
LocalDate transactionStartDate = new LocalDate(); // LocalDate | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'.
LocalDate transactionEndDate = new LocalDate(); // LocalDate | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'.
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    ViewTransactionDetailsDocumentResponse result = apiInstance.viewTransactionDetailsDocument_(authorization, uuid, accept, clientId, accountId, downloadFormat, clientDetails, transactionStartDate, transactionEndDate, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling AccountsApi#viewTransactionDetailsDocument_");
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
 **accountId** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer. |
 **downloadFormat** | **String**| This field refer to the fomat in which transaction detials is require to be downloaded. This is a reference data field. Please use /v1/utilities/referenceData/{downloadFormat} resource to get valid value of this field with description. |
 **clientDetails** | **String**| This field is used to capture device,browser and network information. Refer the developer portal for more information.These are the fields which will be passed as part of the header devicePrint,deviceTokenCookie,userIpAddress,userAgent,hardwareId,simId,deviceModel,deviceName,deviceOsName,deviceOsVersion,multitaskingSupportFlag,languageSupport,wifiMacAddress,cellTowerId,locationAreaCode,rsaApplicationKey,wapClientId,mobileCarrierCode,mobileCountryCode,osId,geoLongitude,geoLatitude,geoHorizontalAccuracy,geoAltitude,geoAltitudeAccuracy,geoSpeed,geoTimestamp,geoStatus,basicServiceSetId,signalStrength,wifiChannel,serviceSetId | [optional]
 **transactionStartDate** | **LocalDate**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. | [optional]
 **transactionEndDate** | **LocalDate**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**ViewTransactionDetailsDocumentResponse**](ViewTransactionDetailsDocumentResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

