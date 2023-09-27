# SwaggerClient::PremiumDepositAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**base_currency_principal_amount** | **Float** | The investment amount in base currency | [optional] 
**base_currency_code** | **String** | The base currency code in ISO 4217 format | [optional] 
**alternate_currency_principal_amount** | **Float** | The investment amount in alternate currency | [optional] 
**opening_date** | **Date** | Premium deposit open date in ISO 8601 date format YYYY-MM-DD | [optional] 
**alternate_currency_code** | **String** | The alternate currency code in ISO 4217 format | [optional] 
**base_currency_disposal_account** | **String** | The account number to deposit returns of base currency, upon maturity | [optional] 
**alternate_currency_disposal_account** | **String** | The account number to deposit returns of alternate currency, upon maturity | [optional] 
**base_currency_interest_amount** | **Float** | The accrued interest amount in base currency | [optional] 
**alternate_currency_interest_amount** | **Float** | The accrued interest amount in alternate currency | [optional] 
**base_currency_maturity_amount** | **Float** | The investment amount and accrued interest in base currency | [optional] 
**alternate_currency_maturity_amount** | **Float** | The investment amount and accrued interest in alternate currency | [optional] 
**base_currency_premium_amount** | **Float** | A part or all of the interest the customer earns on the Premium Account represents the premium that the bank pays the customer for the currency option | [optional] 
**maturity_date** | **Date** | The date when the premium deposit will mature, in ISO8601 date format YYYY-MM-DD | [optional] 
**strike_price** | **Float** | The Pre-agreed exchange rate | [optional] 
**customer_interest_rate** | **Float** | The customer interest rate applicable for the premium deposit | [optional] 
**accrued_interest_rate** | **Float** | The accrued interest rate applicable for the premium deposit | [optional] 
**benchmark_interest_rate** | **Float** | The benchmark interest rate applicable for the premium deposit | [optional] 
**deal_status** | **String** | The deal status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{dealStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**expiry_date** | **Date** | The date when the premium deposit deal will expire, in ISO8601 date format YYYY-MM-DD | [optional] 
**tenor_term** | **Integer** | The tenor term for deposit | [optional] 
**tenor_period** | **String** | This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenorPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**relationship** | [**Relationship**](Relationship.md) |  | [optional] 

