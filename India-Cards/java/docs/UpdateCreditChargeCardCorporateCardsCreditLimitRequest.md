# UpdateCreditChargeCardCorporateCardsCreditLimitRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenizedCardNumber** | **String** | Tokenized card number | 
**corporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  |  [optional]
**creditLimitAmount** | **Double** | New Credit Limit Amount | 
**creditLimitIndicator** | **String** | To indicate whether the limit udpate is for account level or card level. This is a reference data field. Please use /v1/utilities/referenceData/{creditLimitIndicator} resource to get possible values of this field with descriptions | 
