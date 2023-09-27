# IO.Swagger.Model.Loans
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanReferenceId** | **string** | Reference Id to uniquely identify the loan.  | 
**DisplayAccountNumber** | **string** | Last 4 digits of account number.  | [optional] 
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. | 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | 
**InstallmentAmount** | **double?** | Installment loan payment amount | 
**NextInstallmentAmount** | **double?** | Next installment amount in local currency. | [optional] 
**OutstandingBalanceAmount** | **double?** | The amount of money owed. | 
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | 
**OutstandingTenor** | [**decimal?**](BigDecimal.md) | Number of months remaining for completion of loan. | [optional] 
**OriginalLoanAmount** | **double?** | Original loan amount borrowed by customer. | 
**AnnualPercentageRate** | **double?** | Interest rate for a whole year. This includes any fees or additional cost associated. | 
**EffectiveInterestRate** | **double?** | Effective Percentage Rate | [optional] 
**ProcessingChargeAmount** | **double?** | Charges levied on applicant by the bank to process the loan. | [optional] 
**OutstandingInterestAmount** | **double?** | Total Outstanding Interest Amount. | [optional] 
**SelfEarlyLoanClosureAllowedFlag** | **bool?** | Flag to identify if the loan is allowed to be early self closed by customer or not.. | [optional] 
**InstallmentCycle** | **int?** | Intallment Cycle | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

