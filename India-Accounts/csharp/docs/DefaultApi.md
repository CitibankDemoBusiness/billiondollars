# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://sandbox.apihub.citi.com/gcb//api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**V1AccountsAccountIdGet**](DefaultApi.md#v1accountsaccountidget) | **GET** /v1/accounts/{accountId} | Retrieve Account Details
[**V1AccountsAccountIdTransactionsGet**](DefaultApi.md#v1accountsaccountidtransactionsget) | **GET** /v1/accounts/{accountId}/transactions | Retrieve Transactions for Specific Account
[**V1AccountsGet**](DefaultApi.md#v1accountsget) | **GET** /v1/accounts | Retrieve Summary of All Accounts

<a name="v1accountsaccountidget"></a>
# **V1AccountsAccountIdGet**
> AccountDetailsResponse V1AccountsAccountIdGet (string accountId, string authorization, string uuid, string accept, string clientId)

Retrieve Account Details

This API returns additional account details than what is provided in the summary of all accounts. To retrieve the details, simply pass the account id returned to you from the account summary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AccountsAccountIdGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var accountId = accountId_example;  // string | The account identifier in encrypted format.Typically, this is not displayed to the customer
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client_id generated during consumer onboarding

            try
            {
                // Retrieve Account Details
                AccountDetailsResponse result = apiInstance.V1AccountsAccountIdGet(accountId, authorization, uuid, accept, clientId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1AccountsAccountIdGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client_id generated during consumer onboarding | 

### Return type

[**AccountDetailsResponse**](AccountDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1accountsaccountidtransactionsget"></a>
# **V1AccountsAccountIdTransactionsGet**
> TransactionDetailsResponse V1AccountsAccountIdTransactionsGet (string accountId, string authorization, string uuid, string accept, string clientId, string transactionStatus = null, string nextStartIndex = null, string requestSize = null, string transactionFromDate = null, string transactionToDate = null, string amountFrom = null, string amountTo = null)

Retrieve Transactions for Specific Account

This API returns an array of transactions for the specified account. For investment transactions such as buying or selling a stock, they will be returned in the array investment Transaction. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AccountsAccountIdTransactionsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var accountId = accountId_example;  // string | The account identifier in encrypted format.Typically, this is not displayed to the customer.
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client_id generated during consumer onboarding
            var transactionStatus = transactionStatus_example;  // string | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. (optional) 
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 
            var requestSize = requestSize_example;  // string | Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. (optional) 
            var transactionFromDate = transactionFromDate_example;  // string | Starting range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products (optional) 
            var transactionToDate = transactionToDate_example;  // string | End range for transaction date in ISO 8601 date format 'YYYY-MM-DD'. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products (optional) 
            var amountFrom = amountFrom_example;  // string | Starting range of transaction amount. Note: Applicable for Investment accounts (optional) 
            var amountTo = amountTo_example;  // string | End range of transaction amount. Note: Applicable for Investment accounts (optional) 

            try
            {
                // Retrieve Transactions for Specific Account
                TransactionDetailsResponse result = apiInstance.V1AccountsAccountIdTransactionsGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1AccountsAccountIdTransactionsGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountId** | **string**| The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
 **authorization** | **string**| The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ&#x3D;&#x3D;. | 
 **uuid** | **string**| 128 bit random UUID generated uniquely for every request. | 
 **accept** | **string**| Content-Type that are acceptable for the response. | 
 **clientId** | **string**| client_id generated during consumer onboarding | 
 **transactionStatus** | **string**| Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 
 **requestSize** | **string**| Requested number of transactions.The maximum we can provide in one response is 50. If nothing is specified, we will return 20. Currently this field is not supported. | [optional] 
 **transactionFromDate** | **string**| Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional] 
 **transactionToDate** | **string**| End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional] 
 **amountFrom** | **string**| Starting range of transaction amount. Note: Applicable for Investment accounts | [optional] 
 **amountTo** | **string**| End range of transaction amount. Note: Applicable for Investment accounts | [optional] 

### Return type

[**TransactionDetailsResponse**](TransactionDetailsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="v1accountsget"></a>
# **V1AccountsGet**
> AccountsGroupList V1AccountsGet (string authorization, string uuid, string accept, string clientId, string nextStartIndex = null)

Retrieve Summary of All Accounts

This API returns a summary of all accounts held by a customer. If a customer has multiple but similar accounts, e.g. two savings accounts, the accounts will be returned in the array accountGroupSummary. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class V1AccountsGetExample
    {
        public void main()
        {
            var apiInstance = new DefaultApi();
            var authorization = authorization_example;  // string | The most recent Authorization token. This will have the format Bearer + {space} + {accessToken}. Example: Bearer KGNsaWVudF9pZDpjbGllbnRfc2VjcmV0KQ==.
            var uuid = uuid_example;  // string | 128 bit random UUID generated uniquely for every request.
            var accept = accept_example;  // string | Content-Type that are acceptable for the response.
            var clientId = clientId_example;  // string | client_id generated during consumer onboarding
            var nextStartIndex = nextStartIndex_example;  // string | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. (optional) 

            try
            {
                // Retrieve Summary of All Accounts
                AccountsGroupList result = apiInstance.V1AccountsGet(authorization, uuid, accept, clientId, nextStartIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.V1AccountsGet: " + e.Message );
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
 **clientId** | **string**| client_id generated during consumer onboarding | 
 **nextStartIndex** | **string**| In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

### Return type

[**AccountsGroupList**](AccountsGroupList.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
