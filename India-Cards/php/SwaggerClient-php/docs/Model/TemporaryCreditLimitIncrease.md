# TemporaryCreditLimitIncrease

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **string** | The card identifier in encrypted format. | 
**credit_limit_increase_end_date** | [**\DateTime**](\DateTime.md) | Credit limit increase end  date in ISO 8601 date format YYYY-MM-DD. | 
**reason_code** | **string** | Reason for the credit limit increase.This is a reference data field. Please use /v1/apac/utilities/referenceData/{reasonCode} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**credit_limit_increase_start_date** | [**\DateTime**](\DateTime.md) | Credit limit increase start date in ISO 8601 date format YYYY-MM-DD. | 
**requested_credit_limit_amount** | **double** | Customer�€�s desired credit limit. This is the combined limit shared with all the existing credit cards of the customer | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

