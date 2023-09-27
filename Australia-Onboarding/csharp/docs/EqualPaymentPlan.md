# IO.Swagger.Model.EqualPaymentPlan
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tenor** | **string** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**BankCode** | **string** | This field is to indicate the bank code to which the amount will be disbursed. | [optional] 
**AmountToTransfer** | **double?** | Amount to Transfer | [optional] 
**AccountName** | **string** | Account name to which the amount will be disbursed | [optional] 
**CampaignCode** | **string** | Code of the campaign offered to the channel. | [optional] 
**DisbursementType** | **string** | DisbursementType . This is a reference data field. Please use /v1/utilities/referenceData/{DisbursementOption} resource to get valid value of this field with description. | [optional] 
**DisplayAccountNumber** | **string** | Masked account number or reference to which the amount will be disbursed | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

