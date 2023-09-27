# ReadyCreditProductAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product | 
**sourceCode** | **String** | A source code to identify the product | 
**organization** | **String** | Card issuing organization name | 
**logo** | **String** | Product logo to identify the product | 
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**embossName** | **String** | Name to be embossed on card |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option for to review the credit limit in the future.Valid values: true and false |  [optional]
**atmRequiredFlag** | **Boolean** | Option to get ATM card along with product. Valid values: true and false |  [optional]
**chequeBookRequiredFlag** | **Boolean** | Option to get cheque book along with product. Valid values: true and false |  [optional]
**loanPurpose** | **String** | Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. |  [optional]
**requestedCreditLimit** | **Double** | Credit limit requested by applicant for the product. |  [optional]
**equalPaymentPlan** | [**List&lt;EqualPaymentPlan&gt;**](EqualPaymentPlan.md) |  |  [optional]
