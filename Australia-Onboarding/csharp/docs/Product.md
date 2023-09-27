# IO.Swagger.Model.Product
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product. | 
**ProductDescription** | **string** | Detailed information about offered product | 
**SourceCode** | **string** | A source code to identify the product. | 
**Logo** | **string** | Logo to identify the product. | [optional] 
**Organisation** | **string** | Card issuing organization name | [optional] 
**ProductType** | **string** | Type of the product.This is a reference data field. Please use /v1/apac/utilities/referenceData/{productType} resource to get valid values of this field with descriptions. | 
**MinimumCreditLimitAmount** | **double?** | Minimum credit limit amount for the product type | 
**MaximumCreditLimitAmount** | **double?** | Maximum credit limit amount for the product type | 
**AnnualFeeAmount** | **double?** | Annual fees for product type and source code | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | 
**InterestRate** | **double?** | Annual interest rate | 
**LatePaymentFee** | **double?** | Late payment fee for the product type and source code | 
**ImportantInformations** | **string** | Important informations to know about the product type | 
**TermsAndConditions** | **string** | Fees, charges and credit criteria apply. Terms and conditions apply and are available upon request. Cards are offered, issued and administered by Citigroup Pty Limited.Allow up to 15 working days to process your Application subject to verification. | 
**AgreementStartDate** | **DateTime?** | Product validity start date in ISO 8601 date format YYYY-MM-DD | 
**AgreementExpiryDate** | **DateTime?** | Product validity expiry date in ISO 8601 date format YYYY-MM-DD | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

