# SwaggerClient::DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**v1_accounts_account_id_get**](DefaultApi.md#v1_accounts_account_id_get) | **GET** /v1/accounts/{accountId} | Retrieve Account Details
[**v1_accounts_account_id_transactions_get**](DefaultApi.md#v1_accounts_account_id_transactions_get) | **GET** /v1/accounts/{accountId}/transactions | Retrieve Transactions for Specific Account
[**v1_accounts_get**](DefaultApi.md#v1_accounts_get) | **GET** /v1/accounts | Retrieve Summary of All Accounts

# **v1_accounts_account_id_get**
> AccountDetailsResponse v1_accounts_account_id_get(account_id, authorization, uuid, accept, client_id)

Retrieve Account Details

This API returns additional account details than what is provided in the summary of all accounts. To retrieve the details, simply pass the account id returned to you from the account summary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
account_id = 'account_id_example' # String | The account identifier in encrypted format.Typically, this is not displayed to the customer
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client_id generated during consumer onboarding


begin
  #Retrieve Account Details
  result = api_instance.v1_accounts_account_id_get(account_id, authorization, uuid, accept, client_id)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_accounts_account_id_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client_id generated during consumer onboarding | 

### Return type

[**AccountDetailsResponse**](AccountDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_accounts_account_id_transactions_get**
> TransactionDetailsResponse v1_accounts_account_id_transactions_get(account_id, authorization, uuid, accept, client_id, opts)

Retrieve Transactions for Specific Account

This API returns an array of transactions for the specified account. For investment transactions such as buying or selling a stock, they will be returned in the array investment Transaction. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
account_id = 'account_id_example' # String | The account identifier in encrypted format.Typically, this is not displayed to the customer.
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client_id generated during consumer onboarding
opts = { 
  transaction_status: 'transaction_status_example', # String | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
  next_start_index: 'next_start_index_example', # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
  request_size: 'request_size_example', # String | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported.
  transaction_from_date: 'transaction_from_date_example', # String | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
  transaction_to_date: 'transaction_to_date_example', # String | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products
  amount_from: 'amount_from_example', # String | Starting range of transaction amount. Note: Applicable for Investment accounts
  amount_to: 'amount_to_example' # String | End range of transaction amount. Note: Applicable for Investment accounts
}

begin
  #Retrieve Transactions for Specific Account
  result = api_instance.v1_accounts_account_id_transactions_get(account_id, authorization, uuid, accept, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_accounts_account_id_transactions_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **account_id** | **String**| The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client_id generated during consumer onboarding | 
 **transaction_status** | **String**| Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 
 **request_size** | **String**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional] 
 **transaction_from_date** | **String**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional] 
 **transaction_to_date** | **String**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional] 
 **amount_from** | **String**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional] 
 **amount_to** | **String**| End range of transaction amount. Note: Applicable for Investment accounts | [optional] 

### Return type

[**TransactionDetailsResponse**](TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



# **v1_accounts_get**
> AccountsGroupList v1_accounts_get(authorization, uuid, accept, client_id, opts)

Retrieve Summary of All Accounts

This API returns a summary of all accounts held by a customer. If a customer has multiple but similar accounts, e.g. two savings accounts, the accounts will be returned in the array accountGroupSummary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```ruby
# load the gem
require 'swagger_client'

api_instance = SwaggerClient::DefaultApi.new
authorization = 'authorization_example' # String | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
uuid = 'uuid_example' # String | 128 bit random UUID generated uniquely for every request.
accept = 'accept_example' # String | Content-Type that are acceptable for the response.
client_id = 'client_id_example' # String | client_id generated during consumer onboarding
opts = { 
  next_start_index: 'next_start_index_example' # String | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
}

begin
  #Retrieve Summary of All Accounts
  result = api_instance.v1_accounts_get(authorization, uuid, accept, client_id, opts)
  p result
rescue SwaggerClient::ApiError => e
  puts "Exception when calling DefaultApi->v1_accounts_get: #{e}"
end
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **authorization** | **String**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **String**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **String**| Content-Type that are acceptable for the response. | 
 **client_id** | **String**| client_id generated during consumer onboarding | 
 **next_start_index** | **String**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**AccountsGroupList**](AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



