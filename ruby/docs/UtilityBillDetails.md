# SwaggerClient::UtilityBillDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**utility_code** | **String** | Utility service provider codes. Please use /v1/utilities/referenceData/{utilityCode} resource to get valid value of this field with description. You can use utilityCode as the referenceCode parameter to retrieve the values | [optional] 
**telephone_indicator** | **String** | Type of the telephone to be enrolled for bill payment.Please use /v1/utilities/referenceData/{telephoneIndicator} resource to get valid value of this field with description. | [optional] 
**telecom_operator_name** | **String** | Telecom operator name. | [optional] 
**phone_billing_cycle_day** | **String** | Day of each month for the phone bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{phoneBillingCycleDay} resource to get valid value of this field with description. | [optional] 

