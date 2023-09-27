# IO.Swagger.Model.CrossBorderWireTransferPayee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeName** | **string** | Name of the payee. | 
**PayeeNickName** | **string** | The nick name of the payee assigned by the customer. | 
**PayeeType** | **string** | Identifies the type of payee based on the destination of the payee.This is a reference data field. Please use /v1/utilities/referenceData/{payeeType} resource to get valid value of this field with description.  | 
**PayeeStatus** | **string** | The payee status. This is a reference data field. Please use /v1/utilities/referenceData/{payeeStatus} resource to get valid value of this field with description. | [optional] 
**TransferPurpose** | **string** | This is to indicate the purpose of transfer. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{transferPurpose} resource to get valid value of this field with description. | [optional] 
**CurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format | [optional] 
**LocalCurrencyCode** | **string** | This is the local currency code in ISO 4217 Format. | [optional] 
**PayeeCountryCode** | **string** | ISO country code. This is a reference data field. Please use /v1/utilities/referenceData/{country} resource to get valid value of this field with description. | 
**AccountId** | **string** | The payee account identifier in encrypted format. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | 
**BeneficiaryBankName** | **string** | Name of the bank. | 
**BeneficiaryBankCode** | **string** | The bank code of the external payee account. | 
**BankRoutingMethod** | **string** | Bank rounting method.This is a reference data field. Please use /utilities/referenceData/{bankRoutingMethod} resource to get valid values of this field with descriptions | [optional] 
**PayeeAddress** | [**PayeeAddress**](PayeeAddress.md) |  | [optional] 
**BankAddress** | [**BankAddress**](BankAddress.md) |  | [optional] 
**CrossBorderBeneficiaryDetails** | [**CrossBorderBeneficiaryDetails**](CrossBorderBeneficiaryDetails.md) |  | [optional] 
**PayeeNotes** | **string** | Free text that usually describes purpose of payment. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

