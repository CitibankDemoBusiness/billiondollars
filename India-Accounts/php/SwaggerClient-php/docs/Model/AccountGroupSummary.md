# AccountGroupSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_group** | **string** | Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**accounts** | [**\Swagger\Client\Model\AccountSummary[]**](AccountSummary.md) | Summarized list of each account type under a specific product group, held by customer | 
**insurance_policies** | [**\Swagger\Client\Model\InsurancePolicySummary[]**](InsurancePolicySummary.md) | Summarized list of every insurance policy held by the customer. | [optional] 
**total_current_balance** | [**\Swagger\Client\Model\GroupBalance**](GroupBalance.md) |  | [optional] 
**total_available_balance** | [**\Swagger\Client\Model\GroupBalance**](GroupBalance.md) |  | [optional] 
**total_outstanding_balance** | [**\Swagger\Client\Model\GroupBalance**](GroupBalance.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

