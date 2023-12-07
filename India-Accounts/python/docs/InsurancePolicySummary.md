# InsurancePolicySummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | [optional] 
**currency_code** | **str** | The currency code in ISO 4217 format | [optional] 
**account_classification** | **str** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_status** | **str** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**display_policy_number** | **str** | A masked policy number that can be displayed to the customer. | 
**insurance_application_id** | **str** | Insurance Application Number. This field is used to retrieve insurance policy details | 
**insurance_sum_assured_amount** | **float** | Sum assured amount of the insurance | [optional] 
**total_premium_paid_amount** | **float** | Total premium paid for the insurance policy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

