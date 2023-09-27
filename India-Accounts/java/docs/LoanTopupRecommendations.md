# LoanTopupRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tenor** | **String** | Tenor for the loan repayment.This is a reference data field. Please use /v1/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. |  [optional]
**loanTopupMiniumAmount** | **Double** | Recommended loan top-up Minim amount |  [optional]
**loanTopupMaxiumAmount** | **Double** | Recommended loan Topup Maxium amount |  [optional]
**annualPercentageRate** | **Double** | annualPercentageRate -APR |  [optional]
**loanAmount** | **Double** | Recommended loan amount. |  [optional]
**interestRate** | **Double** | The rate of interest applicable for the product |  [optional]
**handlingFee** | **Double** | One-time processing fee. |  [optional]
**installmentAmount** | **Double** | Instalment amount to be paid. |  [optional]
**totalPrincipalAmount** | **Double** | Total principal to be paid by customer |  [optional]
**totalInterestAmount** | **Double** | Total interest amount to be paid by applicant. |  [optional]
**totalInstallmentAmount** | **Double** | Total instalment amount to be paid by customer |  [optional]
**repaymentScheduleIssueDate** | [**LocalDate**](LocalDate.md) | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD |  [optional]
