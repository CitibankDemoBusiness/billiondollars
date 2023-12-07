# RewardPoints

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**reward_category_code** | **string** | Reward category code. This is a reference data field. Please use /v1/utilities/referenceData/{rewardCategoryCode} resource to get valid value of this field with description. | [optional] 
**base_point_balance** | **float** | Points or Miles accumulated by the user at the start of the statement period | [optional] 
**earned_reward_points** | **float** | Points or Miles earned by the user for the statement period. | [optional] 
**bonus_reward_points** | **float** | Bonus Points or Miles  earned by a user for the statement period. Bonus programs operate under the umbrella of a specific reward program since multiple bonus programs can be defined for one reward program. | [optional] 
**adjusted_reward_points** | **float** | Number of rewards points or miles adjusted for the user in the statement period. It will contain the value of adjusted points as a result of incorrect addition/redemption. | [optional] 
**redeemed_reward_points** | **float** | Bonus Points or Miles  redeemed  by a user for the statement period. | [optional] 
**available_point_balance** | **float** | This field indicate the reward points or miles currently available to the user. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

