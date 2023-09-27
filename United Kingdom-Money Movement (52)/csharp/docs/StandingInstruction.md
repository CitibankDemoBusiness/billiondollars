# IO.Swagger.Model.StandingInstruction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StandingInstructionStartDate** | **DateTime?** | Standing instruction start date in ISO 8601 format YYYY-MM-DD. | 
**PaymentFrequency** | **string** | The frequency of payment. This is a reference data. Please use /v1/utilities/referenceData/{paymentFrequency} resource to get valid value of this field. | 
**PerpetualFlag** | **bool?** | Flag to indicate if the standing instruction will be continued until cancellation. | [optional] 
**StandingInstructionEndDate** | **DateTime?** | Standing instruction end date in ISO 8601 date format YYYY-MM-DD. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

