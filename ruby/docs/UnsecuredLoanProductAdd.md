# SwaggerClient::UnsecuredLoanProductAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product | 
**source_code** | **String** | A source code to identify the product | 
**organization** | **String** | Card issuing Organisation code | 
**logo** | **String** | Product logo to identify the product | 
**request_credit_shield** | **BOOLEAN** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**billing_address** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**gift_code** | **String** | A  unique code that identifies the gift offered along with the product | [optional] 
**requested_loan_amount** | **Float** | Requested loan amount | [optional] 
**disbursement_option** | **String** | Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**loan_purpose** | **String** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**tenor1** | **String** | This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.  | [optional] 
**penalty_scheme** | **String** | This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description. | [optional] 
**loan_repayment_details** | [**LoanRepaymentDetails**](LoanRepaymentDetails.md) |  | [optional] 
**loan_payment_account_details** | [**Array&lt;LoanPaymentAccountDetailsAdd&gt;**](LoanPaymentAccountDetailsAdd.md) |  | [optional] 

