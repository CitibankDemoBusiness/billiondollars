# IO.Swagger.Model.UnsecuredLoanProductAdd
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product | 
**SourceCode** | **string** | A source code to identify the product | 
**Organization** | **string** | Card issuing Organisation code | 
**Logo** | **string** | Product logo to identify the product | 
**RequestCreditShield** | **bool?** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**BillingAddress** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**GiftCode** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**RequestedLoanAmount** | **double?** | Requested loan amount | [optional] 
**DisbursementOption** | **string** | Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. | [optional] 
**LoanPurpose** | **string** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**Tenor** | **string** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. | [optional] 
**Tenor1** | **string** | This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.  | [optional] 
**PenaltyScheme** | **string** | This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description. | [optional] 
**LoanRepaymentDetails** | [**LoanRepaymentDetails**](LoanRepaymentDetails.md) |  | [optional] 
**LoanPaymentAccountDetails** | [**List&lt;LoanPaymentAccountDetailsAdd&gt;**](LoanPaymentAccountDetailsAdd.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

