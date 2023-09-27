# LoanBookingPreLoginRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanAmount** | **Double** | Requested Loan Amount | 
**tenor** | **Integer** | Tenure of loan. | 
**disbursementOption** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursementAccountId** | **String** | The account Id of the account to which Loan amount is to be disbursed. |  [optional]
**payeeId** | **String** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. |  [optional]
**birthYear** | [**BigDecimal**](BigDecimal.md) | Year of birth of customer |  [optional]
**purposeOfLoan** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description. |  [optional]
**bankDetails** | [**BankDetails**](BankDetails.md) |  |  [optional]
