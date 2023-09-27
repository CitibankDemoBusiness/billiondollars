# IO.Swagger.Model.SepaTransferPayee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeName** | **string** | Name of the payee. | 
**PayeeNickName** | **string** | The nick name of the payee assigned by the customer. | 
**PayeeType** | **string** | Identifies the type of payee based on the destination of the payee.  | 
**PayeeStatus** | **string** | The payee status. This is a reference data field. Please use /v1/utilities/referenceData/{payeeStatus} resource to get valid value of this field with description. | [optional] 
**CurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | [optional] 
**PayeeCountryCode** | **string** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | 
**AccountId** | **string** | The payee account identifier in encrypted format. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | 
**BeneficiaryBankName** | **string** | Name of the bank. | [optional] 
**BeneficiaryBankCode** | **string** | The bank code of the external payee account. | [optional] 
**PayeeNotes** | **string** | Free text that usually describes purpose of payment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

