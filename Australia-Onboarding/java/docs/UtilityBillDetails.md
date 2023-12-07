# UtilityBillDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**utilityCode** | **String** | Utility service provider codes. Please use /v1/utilities/referenceData/{utilityCode} resource to get valid value of this field with description. You can use utilityCode as the referenceCode parameter to retrieve the values |  [optional]
**telephoneIndicator** | **String** | Type of the telephone to be enrolled for bill payment.Please use /v1/utilities/referenceData/{telephoneIndicator} resource to get valid value of this field with description. |  [optional]
**telecomOperatorName** | **String** | Telecom operator name. |  [optional]
**phoneBillingCycleDay** | **String** | Day of each month for the phone bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{phoneBillingCycleDay} resource to get valid value of this field with description. |  [optional]
