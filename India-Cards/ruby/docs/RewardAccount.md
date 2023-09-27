# SwaggerClient::RewardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**card_id** | **String** | The card id  in encrypted format | 
**display_card_number** | **String** | A masked card number that can be displayed to the customer. | 
**available_point_balance** | [**BigDecimal**](BigDecimal.md) | Number of rewards points or miles available. | 
**reward_category_code** | **String** | Reward category code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{rewardCategoryCode} resource to get valid value of this field with description. | [optional] 
**last_statement_point_balance** | **Float** | Number of rewards points or miles available since last statement balance. | [optional] 
**points_earned** | **Float** | Number of rewards points or miles earned since last statement date. | [optional] 
**reward_account_error_details** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 

