# MultiCurrencyAccountEligibility

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayCardNumber** | **String** | A masked card number that can be displayed to the customer. | 
**cardId** | **String** | The customer card identifier in encrypted format | 
**atmCardFlag** | **Boolean** | Flag to identify if the cardNumbre in response is ATM card. |  [optional]
**cardEnrollmentStatus** | **String** | This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**eligibleForCurrencyAddition** | **String** | Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description. |  [optional]
**relationshipId** | **String** | The customer relationship identifier in encrypted format |  [optional]
**relationshipIdType** | **String** | The type of customer relationship |  [optional]
**accountDetails** | [**List&lt;AccountDtls&gt;**](AccountDtls.md) |  |  [optional]
**currencyDetails** | [**List&lt;CurrencyDetails&gt;**](CurrencyDetails.md) |  |  [optional]
