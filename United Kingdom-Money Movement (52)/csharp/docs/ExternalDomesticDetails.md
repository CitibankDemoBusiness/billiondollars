# IO.Swagger.Model.ExternalDomesticDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format. | 
**TransferCurrencyIndicator** | **string** | The indicator to determine if transfer is to be settled in source of benefciary currency | 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. | 
**PaymentMethod** | **string** | The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description. | 
**TransactionAmount** | **double?** | The transaction amount | 
**PaymentType** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
**ForeignExchangeReferenceNumber** | **string** | Fx deal reference number | [optional] 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 
**PayeeAccountDetails** | [**PayeeAccountDetails**](PayeeAccountDetails.md) |  | [optional] 
**Remarks** | [**List&lt;Remarks&gt;**](Remarks.md) |  | [optional] 
**TransferPurpose** | **string** | Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

