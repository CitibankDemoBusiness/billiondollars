# DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1AccountsAccountIdGet**](DefaultApi.md#v1AccountsAccountIdGet) | **GET** /v1/accounts/{accountId} | Retrieve Account Details
[**v1AccountsAccountIdTransactionsGet**](DefaultApi.md#v1AccountsAccountIdTransactionsGet) | **GET** /v1/accounts/{accountId}/transactions | Retrieve Transactions for Specific Account
[**v1AccountsGet**](DefaultApi.md#v1AccountsGet) | **GET** /v1/accounts | Retrieve Summary of All Accounts

<a name="v1AccountsAccountIdGet"></a>
# **v1AccountsAccountIdGet**
> AccountDetailsResponse v1AccountsAccountIdGet(accountId, authorization, uuid, accept, clientId)

Retrieve Account Details

This API returns additional account details than what is provided in the summary of all accounts. To retrieve the details, simply pass the account id returned to you from the account summary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
try {
    AccountDetailsResponse result = apiInstance.v1AccountsAccountIdGet(accountId, authorization, uuid, accept, clientId);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1AccountsAccountIdGet");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **String**| Content-Type that are acceptable for the response. |
 **clientId** | **String**| client_id generated during consumer onboarding |

### Return type

[**AccountDetailsResponse**](AccountDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsAccountIdTransactionsGet"></a>
# **v1AccountsAccountIdTransactionsGet**
> TransactionDetailsResponse v1AccountsAccountIdTransactionsGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo)

Retrieve Transactions for Specific Account

This API returns an array of transactions for the specified account. For investment transactions such as buying or selling a stock, they will be returned in the array investment Transaction. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String accountId = "accountId_example"; // String | The account identifier in encrypted format.Typically, this is not displayed to the customer.
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
String transactionStatus = "transactionStatus_example"; // String | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
String requestSize = "requestSize_example"; // String | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported.
String transactionFromDate = "transactionFromDate_example"; // String | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
String transactionToDate = "transactionToDate_example"; // String | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
String amountFrom = "amountFrom_example"; // String | Starting range of transaction amount. Note: Applicable for Investment accounts
String amountTo = "amountTo_example"; // String | End range of transaction amount. Note: Applicable for Investment accounts
try {
    TransactionDetailsResponse result = apiInstance.v1AccountsAccountIdTransactionsGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1AccountsAccountIdTransactionsGet");
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
 **transactionStatus** | **String**| Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional]
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **requestSize** | **String**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional]
 **transactionFromDate** | **String**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **transactionToDate** | **String**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **amountFrom** | **String**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **amountTo** | **String**| End range of transaction amount. Note: Applicable for Investment accounts | [optional]

### Return type

[**TransactionDetailsResponse**](TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

<a name="v1AccountsGet"></a>
# **v1AccountsGet**
> AccountsGroupList v1AccountsGet(authorization, uuid, accept, clientId, nextStartIndex)

Retrieve Summary of All Accounts

This API returns a summary of all accounts held by a customer. If a customer has multiple but similar accounts, e.g. two savings accounts, the accounts will be returned in the array accountGroupSummary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```java
// Import classes:
//import io.swagger.client.ApiException;
//import io.swagger.client.api.DefaultApi;


DefaultApi apiInstance = new DefaultApi();
String authorization = "authorization_example"; // String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
String uuid = "uuid_example"; // String | 128 bit random UUID generated uniquely for every request.
String accept = "accept_example"; // String | Content-Type that are acceptable for the response.
String clientId = "clientId_example"; // String | client_id generated during consumer onboarding
String nextStartIndex = "nextStartIndex_example"; // String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
try {
    AccountsGroupList result = apiInstance.v1AccountsGet(authorization, uuid, accept, clientId, nextStartIndex);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling DefaultApi#v1AccountsGet");
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
 **nextStartIndex** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**AccountsGroupList**](AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

