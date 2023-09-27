# IO.Swagger.Model.InternalDomesticPayments
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionAmount** | **double?** | The transaction amount. | [optional] 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/apac/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. You can use transferCurrencyIndicator as the referenceCode parameter to retrieve the values | 
**PayeeId** | **string** | The payee identifier in encrypted format.Typically, this is not displayed to the customer. | [optional] 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/apac/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. You can use chargeBearer as the referenceCode parameter to retrieve the values | [optional] 
**FxDealReferenceNumber** | **string** | Fx deal reference number | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen$$O | [optional] 
**TransferPurpose** | **string** | Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/apac/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. You can use transferPurpose as the referenceCode parameter to retrieve the values. | [optional] 
**FutureDatedTransaction** | [**FutureDatedTransaction**](FutureDatedTransaction.md) |  | [optional] 
**StandingInstruction** | [**StandingInstruction**](StandingInstruction.md) |  | [optional] 
**AnticipatoryPaymentFlag** | **bool?** | This indicator will be sent by channel and help differentiate if payment is normal or anticipatory | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

