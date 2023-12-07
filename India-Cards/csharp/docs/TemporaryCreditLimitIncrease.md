# IO.Swagger.Model.TemporaryCreditLimitIncrease
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | The card identifier in encrypted format. | 
**CreditLimitIncreaseEndDate** | **DateTime?** | Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD. | 
**ReasonCode** | **string** | Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**CreditLimitIncreaseStartDate** | **DateTime?** | Credit limit increase start date in ISO 8601 date format YYYY-MM-DD. | 
**RequestedCreditLimitAmount** | **double?** | Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

