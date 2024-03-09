# EqualPaymentPlan

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **str** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**bank_code** | **str** | This field is to indicate the bank code to which the amount will be disbursed. | [optional] 
**amount_to_transfer** | **float** | Amount to Transfer | [optional] 
**account_name** | **str** | Account name to which the amount will be disbursed | [optional] 
**campaign_code** | **str** | Code of the campaign offered to the channel. | [optional] 
**disbursement_type** | **str** | DisbursementType . This is a reference data field. Please use /v1/utilities/referenceData/{DisbursementOption} resource to get valid value of this field with description. | [optional] 
**display_account_number** | **str** | Masked account number or reference to which the amount will be disbursed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

