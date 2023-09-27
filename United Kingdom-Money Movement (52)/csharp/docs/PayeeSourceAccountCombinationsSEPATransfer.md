# IO.Swagger.Model.PayeeSourceAccountCombinationsSEPATransfer
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeId** | **string** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | 
**DisplayPayeeAccountNumber** | **string** | The display account number of the destination account. | 
**PayeeAccountCurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | [optional] 
**PayeeNickName** | **string** | Payee account nick name | [optional] 
**BankDetails** | [**BankDetailsSEPATransfer**](BankDetailsSEPATransfer.md) |  | [optional] 
**PayeeAddress** | [**PayeeAddress**](PayeeAddress.md) |  | [optional] 
**TransferPurpose** | **string** | Purpose of transfer. Applicable if paymentMethod is GIRO, FAST. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 
**SourceAccountIds** | [**List&lt;SourceAccountIds&gt;**](SourceAccountIds.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

