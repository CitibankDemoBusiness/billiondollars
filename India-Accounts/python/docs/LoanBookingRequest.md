# LoanBookingRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payee_id** | **str** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**loan_amount** | **float** | This field is to indicate the loan amount for booking. | 
**disbursement_option** | **str** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **str** | The disbursement account identifier in encrypted format. Applicable only for HK. | [optional] 
**tenor** | **float** | Tenure of loan in months. | 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 
**loan_purpose** | **str** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**remarks** | **str** | Payment notes. Free text from screen | [optional] 
**tax_id** | **str** | Unique Tax ID of the Customer,INN Taxpayer&#x27;s identification code applicable for Russia | [optional] 
**payment_reference_id** | **str** | Reference number to uniquely identify the payment, applicable for Russia | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

