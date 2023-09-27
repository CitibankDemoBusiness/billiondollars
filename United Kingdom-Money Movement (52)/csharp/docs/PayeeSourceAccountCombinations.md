# IO.Swagger.Model.PayeeSourceAccountCombinations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeId** | **string** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | 
**DisplayPayeeAccountNumber** | **string** | The display account number of the destination account | [optional] 
**PayeeAccountCurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | 
**PayeeNickName** | **string** | Payee account nick name | 
**BankDetails** | [**BankDetails**](BankDetails.md) |  | [optional] 
**PaymentType** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | [optional] 
**PaymentMethods** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | 
**MerchantNumber** | **string** | Unique identifier associated with the merchant. Applicable only for Australia. | [optional] 
**PayeeName** | **string** | Name of the payee.Applicable only for Australia. | [optional] 
**PayeeAddress** | [**PayeeAddress**](PayeeAddress.md) |  | [optional] 
**SourceAccountIds** | [**List&lt;SourceAccountIds&gt;**](SourceAccountIds.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

