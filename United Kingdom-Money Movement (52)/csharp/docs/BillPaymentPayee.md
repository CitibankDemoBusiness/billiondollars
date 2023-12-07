# IO.Swagger.Model.BillPaymentPayee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeType** | **string** | Identifies the type of payee based on the destination of the payee.This is a reference data field. Please use /v1/utilities/referenceData/{payeeType} resource to get valid value of this field with description.  | 
**PayeeStatus** | **string** | The payee status. This is a reference data field. Please use /v1/utilities/referenceData/{payeeStatus} resource to get valid value of this field with description. | [optional] 
**CurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | [optional] 
**PayeeNickName** | **string** | The nick name of the payee assigned by the customer. | 
**PaymentPriority** | **string** | Priority to the payment used to identify urgency. This is a reference data field. Please use /v1/utilities/referenceData/{paymentPriority} resource to get valid value of this field with description. | [optional] 
**PayeeNotes** | **string** | Free text that usually describes purpose of payment. | 
**MerchantName** | **string** |  The name of the merchant. | [optional] 
**MerchantNameLocal** | **string** |  The name of the merchant in local language. | [optional] 
**MerchantNumber** | **string** |  A string that uniquely identifies a merchant. | [optional] 
**MerchantInformation** | [**List&lt;MerchantInformation&gt;**](MerchantInformation.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

