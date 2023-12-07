# IO.Swagger.Model.PreprocessFundTransferRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. | 
**DestinationAccountId** | **string** | The destination account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**ChargeBearer** | **string** | Field to identify charge bearer.The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. | 
**FxDealReferenceNumber** | **string** | Fx deal reference number | [optional] 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

