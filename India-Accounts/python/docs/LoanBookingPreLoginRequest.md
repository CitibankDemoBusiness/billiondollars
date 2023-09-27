# LoanBookingPreLoginRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loan_amount** | **float** | Requested Loan Amount | 
**tenor** | **int** | Tenure of loan. | 
**disbursement_option** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **str** | The account Id of the account to which Loan amount is to be disbursed. | [optional] 
**payee_id** | **str** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**birth_year** | **float** | Year of birth of customer | [optional] 
**purpose_of_loan** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{PurposeOfLoan} resource to get valid value of this field with description. | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

