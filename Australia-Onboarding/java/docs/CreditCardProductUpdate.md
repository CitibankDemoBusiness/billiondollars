# CreditCardProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product. |  [optional]
**sourceCode** | **String** | A source code to identify the product |  [optional]
**organization** | **String** | Card issuing organization name |  [optional]
**logo** | **String** | Product logo to identify the product |  [optional]
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**requestedCreditLimit** | **Double** | Credit limit requested by applicant for the product. |  [optional]
**embossName** | **String** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**cardDeliveryBranch** | **String** | Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field. |  [optional]
**cardDeliveryOption** | **String** | Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option  to review the credit limit in the future.Valid values: true and false |  [optional]
**balanceTransferDetails** | [**List&lt;BalanceTransferDetails&gt;**](BalanceTransferDetails.md) |  |  [optional]
**creditLimitAcceptedFlag** | **Boolean** | Flag to indicate acceptance of customer for the credit card limit. |  [optional]
