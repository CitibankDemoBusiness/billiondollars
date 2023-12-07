# TimeDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**original_principal_amount** | **float** | The original principal amount when account opened. | [optional] 
**currency_code** | **str** | The currency code of the account in ISO 4217 format | [optional] 
**interest_rate** | **float** | The rate of interest applicable for the time deposit | [optional] 
**opening_date** | **date** | The opening date of the time deposit, in ISO 8601 format YYYY-MM-DD | [optional] 
**maturity_date** | **date** | The date when the time deposit will mature, in ISO 8601 format YYYY-MM-DD | [optional] 
**next_interest_payment_date** | **date** | The date when interest will be paid by Citibank, in ISO8601 format YYYY-MM-DD | [optional] 
**interest_amount_due** | **float** | The accrued interest amount which has not yet been paid by Citibank | [optional] 
**renewal_instructions** | **str** | The instructions for time deposit renewal. This is a reference data field. Please use /v1/apac/utilities/referenceData/{renewalInstructions} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**tenor_term** | **int** | The tenor term for the deposit, expressed as a whole number | [optional] 
**tenor_period** | **str** | The unit of the tenor term. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**base_currency_maturity_amount** | **float** | The investment amount and accrued interest in base currency | [optional] 
**maturity_interest_amount** | **float** | The accrued interest in base currency. | [optional] 
**last_interest_payment_amount** | **float** | Last interest amount for the time deposit account | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

