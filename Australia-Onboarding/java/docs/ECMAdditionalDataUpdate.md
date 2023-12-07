# ECMAdditionalDataUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cashPinFlag** | **Boolean** | Indicates whether the customer wants a separate cash PIN. |  [optional]
**utilityBillDetails** | [**UtilityBillDetails**](UtilityBillDetails.md) |  |  [optional]
**billingCycleDay** | **String** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. |  [optional]
**applicationReferenceId** | **String** | Unique reference ID associated with the application |  [optional]
**printingSerialNumber** | **String** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between |  [optional]
**accountFundSource** | **String** | Primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. |  [optional]
**mediaId** | **String** | The media ID will be used to determine which offer/campaign banner was clicked when the customer has submitted the application |  [optional]
**referralTracking** | [**ReferralTracking**](ReferralTracking.md) |  |  [optional]
