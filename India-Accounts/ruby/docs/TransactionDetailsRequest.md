# SwaggerClient::TransactionDetailsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_id** | **String** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**currency_code** | **String** | The currency code of the destination account in ISO 4217 format | [optional] 
**transaction_from_date** | **Date** | Starting range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products | [optional] 
**transaction_to_date** | **Date** | End range for transaction date in ISO 8601 date format &#x27;YYYY-MM-DD&#x27;. Date Range: Upto last 12 months for CASA and last 3 Billing Cycle for credit card and ready credit accounts. Note :Applicable for advance search for  CASA / Ready Credt / Credit Card account products. | [optional] 
**amount_from** | **Float** | Starting range of transaction amount in the base currency. Note: Applicable for Investment accounts. | [optional] 
**amount_to** | **Float** | End range of transaction amount in the base currency. Note: Applicable for Investment accounts. | [optional] 
**transaction_status** | **String** | Applicable for credit cards only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible value of this field with description. | [optional] 
**transaction_indicator** | **String** | Indicates which card on an account was used for a transaction. Applicable only for credit cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionIndicator} resource to get possible value of this field with description. | [optional] 
**next_start_index** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

