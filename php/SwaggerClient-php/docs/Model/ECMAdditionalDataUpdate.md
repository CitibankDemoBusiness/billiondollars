# ECMAdditionalDataUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cash_pin_flag** | **bool** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**utility_bill_details** | [**\Swagger\Client\Model\UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**billing_cycle_day** | **string** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**application_reference_id** | **string** | Unique reference ID associated with the application | [optional] 
**printing_serial_number** | **string** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**account_fund_source** | **string** | Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**media_id** | **string** | The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application | [optional] 
**referral_tracking** | [**\Swagger\Client\Model\ReferralTracking**](ReferralTracking.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

