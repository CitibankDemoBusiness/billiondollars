# Swagger\Client\DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1AccountsAccountIdGet**](DefaultApi.md#v1accountsaccountidget) | **GET** /v1/accounts/{accountId} | Retrieve Account Details
[**v1AccountsAccountIdTransactionsGet**](DefaultApi.md#v1accountsaccountidtransactionsget) | **GET** /v1/accounts/{accountId}/transactions | Retrieve Transactions for Specific Account
[**v1AccountsGet**](DefaultApi.md#v1accountsget) | **GET** /v1/accounts | Retrieve Summary of All Accounts

# **v1AccountsAccountIdGet**
> \Swagger\Client\Model\AccountDetailsResponse v1AccountsAccountIdGet($account_id, $authorization, $uuid, $accept, $client_id)

Retrieve Account Details

This API returns additional account details than what is provided in the summary of all accounts. To retrieve the details, simply pass the account id returned to you from the account summary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client_id generated during consumer onboarding

try {
    $result = $apiInstance->v1AccountsAccountIdGet($account_id, $authorization, $uuid, $accept, $client_id);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1AccountsAccountIdGet: ', $e->getMessage(), PHP_EOL;
}
?>
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer |
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. |
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. |
 **accept** | **string**| Content-Type that are acceptable for the response. |
 **client_id** | **string**| client_id generated during consumer onboarding |

### Return type

[**\Swagger\Client\Model\AccountDetailsResponse**](../Model/AccountDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsAccountIdTransactionsGet**
> \Swagger\Client\Model\TransactionDetailsResponse v1AccountsAccountIdTransactionsGet($account_id, $authorization, $uuid, $accept, $client_id, $transaction_status, $next_start_index, $request_size, $transaction_from_date, $transaction_to_date, $amount_from, $amount_to)

Retrieve Transactions for Specific Account

This API returns an array of transactions for the specified account. For investment transactions such as buying or selling a stock, they will be returned in the array investment Transaction. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$account_id = "account_id_example"; // string | The account identifier in encrypted format.Typically, this is not displayed to the customer.
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client_id generated during consumer onboarding
$transaction_status = "transaction_status_example"; // string | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
$request_size = "request_size_example"; // string | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported.
$transaction_from_date = "transaction_from_date_example"; // string | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
$transaction_to_date = "transaction_to_date_example"; // string | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
$amount_from = "amount_from_example"; // string | Starting range of transaction amount. Note: Applicable for Investment accounts
$amount_to = "amount_to_example"; // string | End range of transaction amount. Note: Applicable for Investment accounts

try {
    $result = $apiInstance->v1AccountsAccountIdTransactionsGet($account_id, $authorization, $uuid, $accept, $client_id, $transaction_status, $next_start_index, $request_size, $transaction_from_date, $transaction_to_date, $amount_from, $amount_to);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1AccountsAccountIdTransactionsGet: ', $e->getMessage(), PHP_EOL;
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
 **transaction_status** | **string**| Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional]
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]
 **request_size** | **string**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional]
 **transaction_from_date** | **string**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **transaction_to_date** | **string**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional]
 **amount_from** | **string**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional]
 **amount_to** | **string**| End range of transaction amount. Note: Applicable for Investment accounts | [optional]

### Return type

[**\Swagger\Client\Model\TransactionDetailsResponse**](../Model/TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

# **v1AccountsGet**
> \Swagger\Client\Model\AccountsGroupList v1AccountsGet($authorization, $uuid, $accept, $client_id, $next_start_index)

Retrieve Summary of All Accounts

This API returns a summary of all accounts held by a customer. If a customer has multiple but similar accounts, e.g. two savings accounts, the accounts will be returned in the array accountGroupSummary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$apiInstance = new Swagger\Client\Api\DefaultApi(
    // If you want use custom http client, pass your client which implements `GuzzleHttp\ClientInterface`.
    // This is optional, `GuzzleHttp\Client` will be used as default.
    new GuzzleHttp\Client()
);
$authorization = "authorization_example"; // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
$uuid = "uuid_example"; // string | 128 bit random UUID generated uniquely for every request.
$accept = "accept_example"; // string | Content-Type that are acceptable for the response.
$client_id = "client_id_example"; // string | client_id generated during consumer onboarding
$next_start_index = "next_start_index_example"; // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.

try {
    $result = $apiInstance->v1AccountsGet($authorization, $uuid, $accept, $client_id, $next_start_index);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling DefaultApi->v1AccountsGet: ', $e->getMessage(), PHP_EOL;
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
 **next_start_index** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional]

### Return type

[**\Swagger\Client\Model\AccountsGroupList**](../Model/AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

