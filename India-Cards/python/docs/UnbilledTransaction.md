# UnbilledTransaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transaction_date** | **date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transaction_description** | **str** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**transaction_reference_id** | **str** | Reference Id to uniquely identify the transaction.This is applicable for successful transactions.  | [optional] 
**transaction_amount** | **float** | Transaction amount in local currency. | 
**currency_code** | **str** | The currency code in ISO 4217 format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

