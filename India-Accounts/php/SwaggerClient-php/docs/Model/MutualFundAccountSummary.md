# MutualFundAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**account_nickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **string** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **string** | The currency code in ISO 4217 format | [optional] 
**account_status** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_classification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**current_balance** | **double** | Total fund value for the Investment mutual fund account. It is the current market worth of investment | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

