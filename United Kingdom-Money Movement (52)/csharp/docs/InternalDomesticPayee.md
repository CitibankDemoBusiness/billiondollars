# IO.Swagger.Model.InternalDomesticPayee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeType** | **string** | Identifies the type of payee based on the destination of the payee.This is a reference data field. Please use /v1/utilities/referenceData/{payeeType} resource to get valid value of this field with description. | 
**PayeeStatus** | **string** | The payee status. This is a reference data field. Please use /v1/utilities/referenceData/{payeeStatus} resource to get valid value of this field with description. | [optional] 
**CurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | [optional] 
**PayeeName** | **string** | Name of the payee. | 
**PayeeNickName** | **string** | The nick name of the payee assigned by the customer. | 
**PaymentPriority** | **string** | Priority to the payment used to identify urgency. This is a reference data field. Please use /v1/utilities/referenceData/{paymentPriority} resource to get valid value of this field with description. | [optional] 
**PayeeNotes** | **string** | Free text that usually describes purpose of payment. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | [optional] 
**AccountId** | **string** | The account identifier of the payee in encrypted format. | [optional] 
**DisplayCardNumber** | **string** | A masked card number that can be displayed to the customer. | [optional] 
**CardId** | **string** | The card id  in encrypted format | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

