# IO.Swagger.Model.CrossBorderWireTransfersPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**PayeeId** | **string** | The payee identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransactionCurrencyCode** | **string** | The currency code for the transaction amount in ISO 4217 format. | [optional] 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. | 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**Remarks** | [**List&lt;Remarks&gt;**](Remarks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

