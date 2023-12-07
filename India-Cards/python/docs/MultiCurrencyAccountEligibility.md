# MultiCurrencyAccountEligibility

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_card_number** | **str** | A masked card number that can be displayed to the customer. | 
**card_id** | **str** | The customer card identifier in encrypted format | 
**atm_card_flag** | **bool** | Flag to identify if the cardNumbre in response is ATM card. | [optional] 
**card_enrollment_status** | **str** | This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**eligible_for_currency_addition** | **str** | Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description. | [optional] 
**relationship_id** | **str** | The customer relationship identifier in encrypted format | [optional] 
**relationship_id_type** | **str** | The type of customer relationship | [optional] 
**account_details** | [**list[AccountDtls]**](AccountDtls.md) |  | [optional] 
**currency_details** | [**list[CurrencyDetails]**](CurrencyDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

