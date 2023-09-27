# UnsecuredLoanProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **str** | A unique code that identifies the product | [optional] 
**source_code** | **str** | A source code to identify the product | [optional] 
**organization** | **str** | Card issuing Organisation code | [optional] 
**logo** | **str** | Product logo to identify the product | [optional] 
**request_credit_shield** | **bool** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**billing_address** | **str** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**gift_code** | **str** | A  unique code that identifies the gift offered along with the product | [optional] 
**requested_loan_amount** | **float** | Requested loan amount | [optional] 
**disbursement_option** | **str** | Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**loan_purpose** | **str** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**tenor** | **str** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**tenor1** | **str** | This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.  | [optional] 
**penalty_scheme** | **str** | This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description. | [optional] 
**loan_repayment_details** | [**LoanRepaymentDetails**](LoanRepaymentDetails.md) |  | [optional] 
**loan_payment_account_details** | [**list[LoanPaymentAccountDetails]**](LoanPaymentAccountDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

