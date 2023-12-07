# IO.Swagger.Model.AdhocInternalDmstcTransferPreprocessWithAddPayeeRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**PayeeAccountDetails** | [**PayeeAccountDetails**](PayeeAccountDetails.md) |  | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. | 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. | [optional] 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**TransferPurpose** | **string** | This is to indicate the purpose of transfer. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 
**TransferSubPurpose** | **string** | Sub-purpose of transfer. | [optional] 
**Remarks** | **string** | Free text that usually describes purpose of payment. | [optional] 
**PaymentPriority** | **string** | Priority to the payment used to identify urgency. This is a reference data field. Please use /v1/utilities/referenceData/{paymentPriority} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

