# RewardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **string** | The card id  in encrypted format | 
**display_card_number** | **string** | A masked card number that can be displayed to the customer. | 
**available_point_balance** | **float** | Number of rewards points or miles available. | 
**reward_category_code** | **string** | Reward category code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{rewardCategoryCode} resource to get valid value of this field with description. | [optional] 
**last_statement_point_balance** | **double** | Number of rewards points or miles available since last statement balance. | [optional] 
**points_earned** | **double** | Number of rewards points or miles earned since last statement date. | [optional] 
**reward_account_error_details** | [**\Swagger\Client\Model\ErrorResponse**](ErrorResponse.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

