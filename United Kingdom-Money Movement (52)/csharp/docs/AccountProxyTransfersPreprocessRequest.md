# IO.Swagger.Model.AccountProxyTransfersPreprocessRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProxyPaymentType** | **string** | The type of proxy payment.This is a reference data field. Please use /v1/utilities/referenceData/{proxyPaymentType} resource to get valid value of this field with description. | 
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionAmount** | **double?** | The transaction amount | 
**TransactionCurrencyCode** | **string** | The currency code for the transaction amount in ISO 4217 format. | [optional] 
**TransferCurrencyIndicator** | **string** | Indicator to specify whether the transfer is in source or destination account currency.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{transferCurrencyIndicator} resource to get valid value of this field with description. | 
**ProxyAccountId** | **string** | This field is used to refer the proxy account number. | 
**ProxyAccountIdType** | **string** | This field is used to refer the proxy account number. This is a reference data field. Please use /v1/utilities/referenceData/{proxyAccountIdType} resource to get valid value of this field with description. | 
**ChargeBearer** | **string** | Field to identify charge bearer.The acceptable forms of remittance for a given payments and transfer transaction.This is a reference data field. Please use /v1/utilities/referenceData/{chargeBearer} resource to get valid value of this field with description. | 
**BillReferenceNumber** | **string** | Bill payment reference number belongs to merchant. | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen | [optional] 
**TransferPurpose** | **string** | Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

