# IO.Swagger.Model.LoanBookingPreLoginRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAmount** | **double?** | Requested Loan Amount | 
**Tenor** | **int?** | Tenure of loan. | 
**DisbursementOption** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**DisbursementAccountId** | **string** | The account Id of the account to which Loan amount is to be disbursed. | [optional] 
**PayeeId** | **string** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**BirthYear** | [**decimal?**](BigDecimal.md) | Year of birth of customer | [optional] 
**PurposeOfLoan** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description. | [optional] 
**BankDetails** | [**BankDetails**](BankDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

