# SwaggerClient::MultiCurrencyAccountEligibilityResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_card_number** | **String** | A masked card number that can be displayed to the customer. | 
**card_id** | **String** | The customer card identifier in encrypted format | 
**atm_card_flag** | **BOOLEAN** | Flag to identify if the cardNumbre in response is ATM card. | [optional] 
**card_enrollment_status** | **String** | This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | 
**eligible_for_currency_addition** | **String** | Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description. | [optional] 
**account_details** | [**Array&lt;AccountDetails&gt;**](AccountDetails.md) |  | [optional] 
**currency_details** | [**Array&lt;CurrencyDetails&gt;**](CurrencyDetails.md) |  | [optional] 

