# CreditSpecificSelection

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**embossName** | **String** | Name to be embossed on card |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use billingAddress field as the referenceCode parameter to retrieve the values. |  [optional]
**cardDeliveryAddress** | **String** | Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use cardDeliveryAddress field name as the referenceCode parameter to retrieve the values. |  [optional]
**pinDeliveryAddress** | **String** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. You can use pinDeliveryAddress field name as the referenceCode parameter to retrieve the values. |  [optional]
**requestedCreditLimit** | **Double** | Credit limit accepted by customer |  [optional]
**offeredCreditLimitAcceptedFlag** | **Boolean** | Consent to offered credit limit and If the customer has not accepted Bankâ€™s approved credit limit then requestedCreditLimit is mandatory. Valid values: true and false |  [optional]
**atmRequiredFlag** | **Boolean** | Option to get ATM card along with product. Valid values: true and false |  [optional]
**chequeBookRequiredFlag** | **Boolean** | Option to get cheque book along with product. Valid values: true and false |  [optional]
**creditLimitIncreaseIndicator** | **Boolean** | Option  to increase credit limit. Valid values: true and false |  [optional]
