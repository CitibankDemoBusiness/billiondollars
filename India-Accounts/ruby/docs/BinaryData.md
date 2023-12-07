# SwaggerClient::BinaryData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**disbursement_option** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **String** | The account Id of the account to which Loan amount is to be disbursed. | [optional] 
**payee_id** | **String** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

