# SwaggerClient::AccountGroupSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_group** | **String** | Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**accounts** | [**Array&lt;AccountSummary&gt;**](AccountSummary.md) | Summarized list of each account type under a specific product group, held by customer | 
**insurance_policies** | [**Array&lt;InsurancePolicySummary&gt;**](InsurancePolicySummary.md) | Summarized list of every insurance policy held by the customer. | [optional] 
**total_current_balance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 
**total_available_balance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 
**total_outstanding_balance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 

