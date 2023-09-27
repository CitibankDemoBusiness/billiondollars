# CreditCardAccountSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **string** | The name of the product | [optional] 
**product_code** | **string** | A unique code that identifies the product | [optional] 
**account_nickname** | **string** | The nickname of the account assigned by the customer | [optional] 
**display_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**account_id** | **string** | The customer account identifier in encrypted format. | [optional] 
**currency_code** | **string** | The currency code in ISO 4217 format | [optional] 
**account_classification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_status** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**outstanding_balance** | **double** | The amount of money owed on the credit account. It is the outstanding balance in applicable level (either card, account or relationship levels) | [optional] 
**available_credit** | **double** | Available Credit limit on the credit card | [optional] 
**credit_limit** | **double** | The maximum amount of credit that extend to a customer | [optional] 
**minimum_due_amount** | **double** | Minimum due amount for a payment cycle | [optional] 
**payment_due_date** | [**\DateTime**](\DateTime.md) | The payment due date in ISO 8601 date format YYYY-MM-DD | [optional] 
**alternate_currency** | **string** | The alternate currency | [optional] 
**alternate_currency_current_balance** | **double** | The current balance in alternate currency | [optional] 
**card_holder_type** | **string** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

