# IO.Swagger.Model.ExternalDomesticPayments
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionAmount** | **double?** | Transaction Amount | 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description.\&quot;, | 
**PayeeId** | **string** | The payee identifier in encrypted format.Typically, this is not displayed to the customer. | 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description.\&quot;, | 
**PaymentMethod** | **string** | The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{paymentMethod} resource to get valid value of this field with description.\&quot;, | 
**FxDealReferenceNumber** | **string** | Fx deal reference number | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen\&quot; | [optional] 
**TransferPurpose** | **string** | Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 
**TransferSubPurpose** | **string** | Sub Purpose Of Transfer | [optional] 
**PaymentScheduleType** | **string** | From various Option Support - CVT table. - Immediate -  FutureDated ( Date Selection ) - Future Dated Recurring ( Date Selection and Frequency - Last Date ) for Poland only Immediate and One Time Future Dated | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**AnticipatoryPaymentFlag** | **bool?** | anticipatory paymentFlag | [optional] 
**UniquePaymentId** | **string** | this is free text unique value. This is end to end identification ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

