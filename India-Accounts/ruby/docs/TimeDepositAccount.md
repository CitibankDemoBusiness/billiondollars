# SwaggerClient::TimeDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**original_principal_amount** | **Float** | The original principal amount when account opened. | [optional] 
**currency_code** | **String** | The currency code of the account in ISO 4217 format | [optional] 
**interest_rate** | **Float** | The rate of interest applicable for the time deposit | [optional] 
**opening_date** | **Date** | The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD | [optional] 
**maturity_date** | **Date** | The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD | [optional] 
**next_interest_payment_date** | **Date** | The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD | [optional] 
**interest_amount_due** | **Float** | The accrued interest amount which has not yet been paid by Citibank | [optional] 
**renewal_instructions** | **String** | The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**tenor_term** | **Integer** | The tenor term for the deposit, expressed as a whole number | [optional] 
**tenor_period** | **String** | The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**base_currency_maturity_amount** | **Float** | The investment amount and accrued interest in base currency | [optional] 
**maturity_interest_amount** | **Float** | The accrued interest in base currency. | [optional] 
**last_interest_payment_amount** | **Float** | Last interest amount for the time deposit account | [optional] 

