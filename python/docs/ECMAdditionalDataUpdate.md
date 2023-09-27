# ECMAdditionalDataUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cash_pin_flag** | **bool** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**utility_bill_details** | [**UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**billing_cycle_day** | **str** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**application_reference_id** | **str** | Unique reference ID associated with the application | [optional] 
**printing_serial_number** | **str** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**account_fund_source** | **str** | Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**media_id** | **str** | The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application | [optional] 
**referral_tracking** | [**ReferralTracking**](ReferralTracking.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

