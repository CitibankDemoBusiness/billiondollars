# SwaggerClient::EqualPaymentPlan

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**bank_code** | **String** | This field is to indicate the bank code to which the amount will be disbursed. | [optional] 
**amount_to_transfer** | **Float** | Amount to Transfer | [optional] 
**account_name** | **String** | Account name to which the amount will be disbursed | [optional] 
**campaign_code** | **String** | Code of the campaign offered to the channel. | [optional] 
**disbursement_type** | **String** | DisbursementType . This is a reference data field. Please use /v1/utilities/referenceData/{DisbursementOption} resource to get valid value of this field with description. | [optional] 
**display_account_number** | **String** | Masked account number or reference to which the amount will be disbursed | [optional] 

