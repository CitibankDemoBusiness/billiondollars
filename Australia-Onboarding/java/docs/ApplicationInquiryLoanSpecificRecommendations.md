# ApplicationInquiryLoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanAmount** | **Double** | Recommended loan amount. |  [optional]
**tenor** | **String** | Tenor for the loan repayment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. |  [optional]
**interestRate** | **Double** | The rate of interest applicable for the product |  [optional]
**handlingFee** | **Double** | One-time processing fee. |  [optional]
**installmentAmount** | **Double** | Instalment amount to be paid. |  [optional]
**annualPercentageRate** | **Double** | Applicable Annual Percentage Rate |  [optional]
**totalPrincipalAmount** | **Double** | Total principal to be paid by customer |  [optional]
**totalInterestAmount** | **Double** | Total interest amount to be paid by applicant. |  [optional]
**totalInstallmentAmount** | **Double** | Total instalment amount to be paid by customer |  [optional]
**repaymentScheduleIssueDate** | [**LocalDate**](LocalDate.md) | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD |  [optional]
**repaymentSchedule** | [**List&lt;ApplicationInquiryRepaymentSchedule&gt;**](ApplicationInquiryRepaymentSchedule.md) |  |  [optional]
