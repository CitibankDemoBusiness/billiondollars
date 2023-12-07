# IO.Swagger.Model.InternalDomesticDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format. | 
**TransferCurrencyIndicator** | **string** | The indicator to determine if transfer is to be settled in source of benefciary currency | 
**TransactionAmount** | **double?** | The transaction amount | 
**PayeeAccountDetails** | [**PayeeAccountDetails**](PayeeAccountDetails.md) |  | [optional] 
**Remarks** | [**List&lt;Remarks&gt;**](Remarks.md) |  | [optional] 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/apac/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

