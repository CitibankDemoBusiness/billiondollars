# CreditCardAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**account_nickname** | **str** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **str** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **str** | The currency code in ISO 4217 format | [optional] 
**account_classification** | **str** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_status** | **str** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**outstanding_balance** | **float** | The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels) | [optional] 
**available_credit** | **float** | Available Credit limit on the credit card | [optional] 
**credit_limit** | **float** | The maximum amount of credit that extend to a customer | [optional] 
**minimum_due_amount** | **float** | Minimum due amount for a payment cycle | [optional] 
**payment_due_date** | **date** | The payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**alternate_currency** | **str** | The alternate currency | [optional] 
**alternate_currency_current_balance** | **float** | The current balance in alternate currency | [optional] 
**card_holder_type** | **str** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

