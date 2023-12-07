# BinaryData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**disbursement_option** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **str** | The account Id of the account to which Loan amount is to be disbursed. | [optional] 
**payee_id** | **str** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

