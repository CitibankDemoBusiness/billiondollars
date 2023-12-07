# RewardAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | The card id  in encrypted format | 
**displayCardNumber** | **String** | A masked card number that can be displayed to the customer. | 
**availablePointBalance** | [**BigDecimal**](BigDecimal.md) | Number of rewards points or miles available. | 
**rewardCategoryCode** | **String** | Reward category code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{rewardCategoryCode} resource to get valid value of this field with description. |  [optional]
**lastStatementPointBalance** | **Double** | Number of rewards points or miles available since last statement balance. |  [optional]
**pointsEarned** | **Double** | Number of rewards points or miles earned since last statement date. |  [optional]
**rewardAccountErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  |  [optional]
