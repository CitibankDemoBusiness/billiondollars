# LoanSpecificRecommendations

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanAmount** | **Double** | Eligible Loan amount. |  [optional]
**tenor** | **String** | Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. |  [optional]
**interestRate** | **Double** | The rate of interest applicable to product |  [optional]
**handlingFee** | **Double** | Handling fee to be paid. |  [optional]
**installmentAmount** | **Double** | Installment amount to be paid. |  [optional]
**annualPercentageRate** | **Double** | Applicable Annual Percentage Rate |  [optional]
**totalPrincipalAmount** | **Double** | Total principal to be paid by customer |  [optional]
**totalInterestAmount** | **Double** | Total interest to be paid by customer |  [optional]
**totalInstallmentAmount** | **Double** | Total installment amount to be paid by customer |  [optional]
**repaymentScheduleIssueDate** | [**LocalDate**](LocalDate.md) | Repayment schedule start date in ISO 8601 date format YYYY-MM-DD |  [optional]
**repaymentSchedule** | [**List&lt;RepaymentSchedule&gt;**](RepaymentSchedule.md) |  |  [optional]
