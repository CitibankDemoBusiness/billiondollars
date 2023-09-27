# IO.Swagger.Model.RewardAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | The card id  in encrypted format | 
**DisplayCardNumber** | **string** | A masked card number that can be displayed to the customer. | 
**AvailablePointBalance** | [**decimal?**](BigDecimal.md) | Number of rewards points or miles available. | 
**RewardCategoryCode** | **string** | Reward category code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{rewardCategoryCode} resource to get valid value of this field with description. | [optional] 
**LastStatementPointBalance** | **double?** | Number of rewards points or miles available since last statement balance. | [optional] 
**PointsEarned** | **double?** | Number of rewards points or miles earned since last statement date. | [optional] 
**RewardAccountErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

