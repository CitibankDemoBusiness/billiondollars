# IO.Swagger.Model.LoanBookingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeId** | **string** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**LoanAmount** | **double?** | This field is to indicate the loan amount for booking. | 
**DisbursementOption** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**DisbursementAccountId** | **string** | The disbursement account identifier in encrypted format. Applicable only for HK. | [optional] 
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | 
**BankDetails** | [**BankDetails**](BankDetails.md) |  | [optional] 
**LoanPurpose** | **string** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen | [optional] 
**TaxId** | **string** | Unique Tax ID of the Customer,INN Taxpayer&#x27;s identification code applicable for Russia | [optional] 
**PaymentReferenceId** | **string** | Reference number to uniquely identify the payment, applicable for Russia | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

