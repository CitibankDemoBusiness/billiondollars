# IO.Swagger.Model.Sepa
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | 
**TransactionCurrencyCode** | **string** | This is an indicator if transfer is to be done in source or destination currency, this is CVT field transferCurrencyIndicator | 
**TransactionAmount** | **double?** | Transaction Amount | [optional] 
**PayeeAccountDetails** | [**PayeeAccountDetails**](PayeeAccountDetails.md) |  | [optional] 
**PayeeAddress** | [**PayeeAddress**](PayeeAddress.md) |  | [optional] 
**PayeeBankDetails** | [**PayeeBankDetails**](PayeeBankDetails.md) |  | [optional] 
**Remarks** | [**List&lt;Remarks&gt;**](Remarks.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

