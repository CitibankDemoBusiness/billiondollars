# IO.Swagger.Model.BillPaymentsPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. You can use transferCurrencyIndicator as the referenceCode parameter to retrieve the values. | 
**PayeeId** | **string** | The payee identifier in encrypted format.Typically, this is not displayed to the customer. | 
**BillTypeCode** | **string** | Bill Type Code is the sub category for the Merchant. Bill Payment Transaction  can be uniquely identified by the combination of the merchant number and billTypeCode | [optional] 
**Remarks** | **string** | Bill payment notes. Free text from screen. | [optional] 
**CustomerReferenceNumber** | **string** | This is the unique identifier against the biller assigned for each transaction. | [optional] 
**PaymentScheduleType** | **string** | The payment schedule type. This is a reference data. Please use /v1/utilities/referenceData/{paymentScheduleType} resource to get valid value of this field. | [optional] 
**PaymentMethod** | **string** | The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

