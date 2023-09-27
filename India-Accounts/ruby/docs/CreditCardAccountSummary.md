# SwaggerClient::CreditCardAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**account_nickname** | **String** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **String** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **String** | The currency code in ISO 4217 format | [optional] 
**account_classification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_status** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**outstanding_balance** | **Float** | The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels) | [optional] 
**available_credit** | **Float** | Available Credit limit on the credit card | [optional] 
**credit_limit** | **Float** | The maximum amount of credit that extend to a customer | [optional] 
**minimum_due_amount** | **Float** | Minimum due amount for a payment cycle | [optional] 
**payment_due_date** | **Date** | The payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**alternate_currency** | **String** | The alternate currency | [optional] 
**alternate_currency_current_balance** | **Float** | The current balance in alternate currency | [optional] 
**card_holder_type** | **String** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 

