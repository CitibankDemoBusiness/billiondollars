# RequestCreditChargeCardCorporateCardsSuspensionAndCashLimitAllowedRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenizedCardNumber** | **String** | Tokenized card number | 
**corporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  |  [optional]
**cashLimitUpdateAllowedFlag** | **Boolean** | This field is used to indicate whether cash withdrawal is allowed for the corporate card |  [optional]
**cardStatus** | **String** | This field is used to indicate whether to  suspend or unsuspend the corporate card.This is a reference data field. Please use /v1/utilities/referenceData/{cardStatus} resource to get possible values of this field with descriptions |  [optional]
