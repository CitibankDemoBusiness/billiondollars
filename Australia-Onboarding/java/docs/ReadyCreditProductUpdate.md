# ReadyCreditProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product |  [optional]
**sourceCode** | **String** | A source code to identify the product |  [optional]
**organization** | **String** | Card issuing organization name |  [optional]
**logo** | **String** | Product logo to identify the product |  [optional]
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**embossName** | **String** | Name to be embossed on card |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**requestedCreditLimit** | **Double** | Credit limit requested by applicant for the product. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option for to review the credit limit in the future.Valid values: true and false |  [optional]
**atmRequiredFlag** | **Boolean** | Option to get ATM card along with product. Valid values: true and false |  [optional]
**chequeBookRequiredFlag** | **Boolean** | Option to get cheque book along with product. Valid values: true and false |  [optional]
**balanceTransferDetails** | [**List&lt;BalanceTransferDetails&gt;**](BalanceTransferDetails.md) |  |  [optional]
**loanPurpose** | **String** | Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. |  [optional]
**equalPaymentPlan** | [**List&lt;EqualPaymentPlanUpdate&gt;**](EqualPaymentPlanUpdate.md) |  |  [optional]
**creditLimitAcceptedFlag** | **Boolean** | Flag to indicate acceptance of customer for the ready credit limit. |  [optional]
