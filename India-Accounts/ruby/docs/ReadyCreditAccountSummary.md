# SwaggerClient::ReadyCreditAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**account_nickname** | **String** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **String** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **String** | The currency code in ISO 4217 format | [optional] 
**account_status** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_classification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**outstanding_balance** | **Float** | The amount of money owed. | [optional] 
**available_credit** | **Float** | Available Credit for the ready credit account. It is the amount that is available to be charged to a ready credit account | [optional] 
**next_payment_amount** | **Float** | The next payment amount due | [optional] 
**next_payment_date** | **Date** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 

