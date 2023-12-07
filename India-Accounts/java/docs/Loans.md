# Loans

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanReferenceId** | **String** | Reference Id to uniquely identify the loan.  | 
**displayAccountNumber** | **String** | Last 4 digits of account number.  |  [optional]
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**transactionDescription** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**installmentAmount** | **Double** | Installment loan payment amount | 
**nextInstallmentAmount** | **Double** | Next installment amount in local currency. |  [optional]
**outstandingBalanceAmount** | **Double** | The amount of money owed. | 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**outstandingTenor** | [**BigDecimal**](BigDecimal.md) | Number of months remaining for completion of loan. |  [optional]
**originalLoanAmount** | **Double** | Original loan amount borrowed by customer. | 
**annualPercentageRate** | **Double** | Interest rate for a whole year. This includes any fees or additional cost associated. | 
**effectiveInterestRate** | **Double** | Effective Percentage Rate |  [optional]
**processingChargeAmount** | **Double** | Charges levied on applicant by the bank to process the loan. |  [optional]
**outstandingInterestAmount** | **Double** | Total Outstanding Interest Amount. |  [optional]
**selfEarlyLoanClosureAllowedFlag** | **Boolean** | Flag to identify if the loan is allowed to be early self closed by customer or not.. |  [optional]
**installmentCycle** | **Integer** | Intallment Cycle |  [optional]
