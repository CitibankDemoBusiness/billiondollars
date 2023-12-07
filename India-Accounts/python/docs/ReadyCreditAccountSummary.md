# ReadyCreditAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**account_nickname** | **str** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **str** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **str** | The currency code in ISO 4217 format | [optional] 
**account_status** | **str** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_classification** | **str** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**outstanding_balance** | **float** | The amount of money owed. | [optional] 
**available_credit** | **float** | Available Credit for the ready credit account. It is the amount that is available to be charged to a ready credit account | [optional] 
**next_payment_amount** | **float** | The next payment amount due | [optional] 
**next_payment_date** | **date** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

