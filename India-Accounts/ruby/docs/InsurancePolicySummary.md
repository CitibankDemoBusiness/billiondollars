# SwaggerClient::InsurancePolicySummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**currency_code** | **String** | The currency code in ISO 4217 format | [optional] 
**account_classification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_status** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**display_policy_number** | **String** | A masked policy number that can be displayed to the customer. | 
**insurance_application_id** | **String** | Insurance Application Number. This field is used to retrieve insurance policy details | 
**insurance_sum_assured_amount** | **Float** | Sum assured amount of the insurance | [optional] 
**total_premium_paid_amount** | **Float** | Total premium paid for the insurance policy | [optional] 

