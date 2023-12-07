# IO.Swagger.Model.ECMAdditionalDataUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CashPinFlag** | **bool?** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**UtilityBillDetails** | [**UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**BillingCycleDay** | **string** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**ApplicationReferenceId** | **string** | Unique reference ID associated with the application | [optional] 
**PrintingSerialNumber** | **string** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**AccountFundSource** | **string** | Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**MediaId** | **string** | The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application | [optional] 
**ReferralTracking** | [**ReferralTracking**](ReferralTracking.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

