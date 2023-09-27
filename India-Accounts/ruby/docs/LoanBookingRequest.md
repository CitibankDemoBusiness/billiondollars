# SwaggerClient::LoanBookingRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payee_id** | **String** | Unique identifier associated with the payee.Typically, this is not displayed to the customer. | [optional] 
**loan_amount** | **Float** | This field is to indicate the loan amount for booking. | 
**disbursement_option** | **String** | This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | 
**disbursement_account_id** | **String** | The disbursement account identifier in encrypted format. Applicable only for HK. | [optional] 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**bank_details** | [**BankDetails**](BankDetails.md) |  | [optional] 
**loan_purpose** | **String** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**remarks** | **String** | Payment notes. Free text from screen | [optional] 
**tax_id** | **String** | Unique Tax ID of the Customer,INN Taxpayer&#x27;s identification code applicable for Russia | [optional] 
**payment_reference_id** | **String** | Reference number to uniquely identify the payment, applicable for Russia | [optional] 

