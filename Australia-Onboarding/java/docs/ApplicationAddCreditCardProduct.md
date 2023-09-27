# ApplicationAddCreditCardProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product. | 
**sourceCode** | **String** | A source code to identify the product | 
**organization** | **String** | Card issuing organization name | 
**logo** | **String** | Product logo to identify the product | 
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**embossName** | **String** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. |  [optional]
**billingAddress** | **String** | Billing address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option  to review the credit limit in the future.Valid values: true and false |  [optional]
