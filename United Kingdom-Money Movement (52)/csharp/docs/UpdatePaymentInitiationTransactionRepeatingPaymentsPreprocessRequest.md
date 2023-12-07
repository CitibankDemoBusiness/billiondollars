# IO.Swagger.Model.UpdatePaymentInitiationTransactionRepeatingPaymentsPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | The account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**PaymentMethod** | **string** | The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description | 
**BankSortCode** | **string** | This is specific to UK | [optional] 
**TransactionReferenceId** | **string** | The unique SI reference Id used to identify the payee type/ transfer from all the other transfers | 
**TransactionAmount** | **double?** | Transaction amount in local currency. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**Remarks** | **string** | Bill payment notes. Free text from screen. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

