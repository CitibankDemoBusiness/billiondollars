# IO.Swagger.Model.AccountGroupSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountGroup** | **string** | Account group is a classification of accounts according to their common characteristics. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountGroup} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**Accounts** | [**List&lt;AccountSummary&gt;**](AccountSummary.md) | Summarized list of each account type under a specific product group, held by customer | 
**InsurancePolicies** | [**List&lt;InsurancePolicySummary&gt;**](InsurancePolicySummary.md) | Summarized list of every insurance policy held by the customer. | [optional] 
**TotalCurrentBalance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 
**TotalAvailableBalance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 
**TotalOutstandingBalance** | [**GroupBalance**](GroupBalance.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

