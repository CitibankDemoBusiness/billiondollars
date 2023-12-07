# SwaggerClient::TimeDepositAccountSummary

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
**current_balance** | **Float** | The account balance on the time deposit account | [optional] 
**original_principal_amount** | **Float** | The amount invested | [optional] 
**maturity_date** | **Date** | The date when the time deposit will mature in ISO8601 date format YYYY-MM-DD | [optional] 

