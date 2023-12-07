# ApplicationUpdateCreditCardProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product. |  [optional]
**sourceCode** | **String** | A source code to identify the product |  [optional]
**organization** | **String** | Card issuing organization name |  [optional]
**logo** | **String** | Product logo to identify the product |  [optional]
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**embossName** | **String** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option  to review the credit limit in the future.Valid values: true and false |  [optional]
**balanceTransferDetails** | [**List&lt;ApplicationUpdateBalanceTransferDetails&gt;**](ApplicationUpdateBalanceTransferDetails.md) |  |  [optional]
