# TransactionDetailsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **String** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**currencyCode** | **String** | The currency code of the destination account in ISO 4217 format |  [optional]
**transactionFromDate** | [**LocalDate**](LocalDate.md) | Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products |  [optional]
**transactionToDate** | [**LocalDate**](LocalDate.md) | End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products. |  [optional]
**amountFrom** | **Double** | Starting range of transaction amount in the base currency. Note: Applicable for Investment accounts. |  [optional]
**amountTo** | **Double** | End range of transaction amount in the base currency. Note: Applicable for Investment accounts. |  [optional]
**transactionStatus** | **String** | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. |  [optional]
**transactionIndicator** | **String** | Indicates which card on an account was used for a transaction. Applicable only for credit cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionIndicator} resource to get possible value of this field with description. |  [optional]
**nextStartIndex** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. |  [optional]
