# UnsecuredLoanProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **string** | A unique code that identifies the product | [optional] 
**source_code** | **string** | A source code to identify the product | [optional] 
**organization** | **string** | Card issuing Organisation code | [optional] 
**logo** | **string** | Product logo to identify the product | [optional] 
**request_credit_shield** | **bool** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**billing_address** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**gift_code** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**requested_loan_amount** | **double** | Requested loan amount | [optional] 
**disbursement_option** | **string** | Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**loan_purpose** | **string** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**tenor** | **string** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**tenor1** | **string** | This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**penalty_scheme** | **string** | This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description. | [optional] 
**loan_repayment_details** | [**\Swagger\Client\Model\LoanRepaymentDetails**](LoanRepaymentDetails.md) |  | [optional] 
**loan_payment_account_details** | [**\Swagger\Client\Model\LoanPaymentAccountDetails[]**](LoanPaymentAccountDetails.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

