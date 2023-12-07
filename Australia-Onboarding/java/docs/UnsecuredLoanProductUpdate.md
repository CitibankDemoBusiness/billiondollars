# UnsecuredLoanProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product |  [optional]
**sourceCode** | **String** | A source code to identify the product |  [optional]
**organization** | **String** | Card issuing Organisation code |  [optional]
**logo** | **String** | Product logo to identify the product |  [optional]
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**requestedLoanAmount** | **Double** | Requested loan amount |  [optional]
**disbursementOption** | **String** | Provide the list of the options available to receive the disbursement of loan amount. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description. |  [optional]
**loanPurpose** | **String** | This field is to indicate the purpose of loan. This is a reference data field.This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. |  [optional]
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description. |  [optional]
**tenor1** | **String** | This refers to the number of months of the 1st tenor. For Tiered-rate UPL , customer enjoys/ endure lower/ higher rate in the first few months.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid value of this field with description.  |  [optional]
**penaltyScheme** | **String** | This field is used to determine the penalty that will be applied to customer who do early principal repayment/loan closure.It is to be selected by the customer. This is a reference data field. Please use /v1/utilities/referenceData/{penaltyScheme} resource to get valid value of this field with description. |  [optional]
**loanRepaymentDetails** | [**LoanRepaymentDetails**](LoanRepaymentDetails.md) |  |  [optional]
**loanPaymentAccountDetails** | [**List&lt;LoanPaymentAccountDetails&gt;**](LoanPaymentAccountDetails.md) |  |  [optional]
