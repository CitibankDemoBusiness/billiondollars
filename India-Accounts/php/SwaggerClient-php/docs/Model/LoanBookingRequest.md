# LoanBookingRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payee_id** | **string** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**loan_amount** | **double** | This field is to indicate the loan amount for booking. | 
**disbursement_option** | **string** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **string** | The disbursement account identifier in encrypted format. Applicable only for HK. | [optional] 
**tenor** | **float** | Tenure of loan in months. | 
**bank_details** | [**\Swagger\Client\Model\BankDetails**](BankDetails.md) |  | [optional] 
**loan_purpose** | **string** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**remarks** | **string** | Payment notes. Free text from screen | [optional] 
**tax_id** | **string** | Unique Tax ID of the Customer,INN Taxpayer&#x27;s identification code applicable for Russia | [optional] 
**payment_reference_id** | **string** | Reference number to uniquely identify the payment, applicable for Russia | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

