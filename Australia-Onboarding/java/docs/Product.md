# Product

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product. | 
**productDescription** | **String** | Detailed information about offered product | 
**sourceCode** | **String** | A source code to identify the product. | 
**logo** | **String** | Logo to identify the product. |  [optional]
**organisation** | **String** | Card issuing organization name |  [optional]
**productType** | **String** | Type of the product.This is a reference data field. Please use /v1/apac/utilities/referenceData/{productType} resource to get valid values of this field with descriptions. | 
**minimumCreditLimitAmount** | **Double** | Minimum credit limit amount for the product type | 
**maximumCreditLimitAmount** | **Double** | Maximum credit limit amount for the product type | 
**annualFeeAmount** | **Double** | Annual fees for product type and source code |  [optional]
**currencyCode** | **String** | The currency code in ISO 4217 format | 
**interestRate** | **Double** | Annual interest rate | 
**latePaymentFee** | **Double** | Late payment fee for the product type and source code | 
**importantInformations** | **String** | Important informations to know about the product type | 
**termsAndConditions** | **String** | Fees, charges and credit criteria apply. Terms and conditions apply and are available upon request. Cards are offered, issued and administered by Citigroup Pty Limited.Allow up to 15 working days to process your Application subject to verification. | 
**agreementStartDate** | [**LocalDate**](LocalDate.md) | Product validity start date in ISO 8601 date format YYYY-MM-DD | 
**agreementExpiryDate** | [**LocalDate**](LocalDate.md) | Product validity expiry date in ISO 8601 date format YYYY-MM-DD | 
