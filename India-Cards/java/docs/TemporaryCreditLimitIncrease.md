# TemporaryCreditLimitIncrease

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | The card identifier in encrypted format. | 
**creditLimitIncreaseEndDate** | [**LocalDate**](LocalDate.md) | Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD. | 
**reasonCode** | **String** | Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**creditLimitIncreaseStartDate** | [**LocalDate**](LocalDate.md) | Credit limit increase start date in ISO 8601 date format YYYY-MM-DD. | 
**requestedCreditLimitAmount** | **Double** | Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer | 
