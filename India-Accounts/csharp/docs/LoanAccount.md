# IO.Swagger.Model.LoanAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**OriginalPrincipalAmount** | **double?** | The amount borrowed | [optional] 
**CurrentPrincipalAmount** | **double?** | The remaining principal amount | [optional] 
**OutstandingBalance** | **double?** | The amount of money owed. | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 
**MaturityDate** | **DateTime?** | Loan maturity date in ISO 8601 date format YYYY-MM-DD | [optional] 
**OpeningDate** | **DateTime?** | Loan account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**LastPaymentDate** | **DateTime?** | The date of the last payment in ISO 8601 format YYYY-MM-DD | [optional] 
**LastPaymentAmount** | **double?** | The amount of the last payment made | [optional] 
**InterestAmount** | **double?** | Interest amount paid for the mentioned period | [optional] 
**InterestAccumulationPeriod** | **string** | The period of interest accumulation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestAccumulationPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**NextPaymentAmount** | **double?** | The next payment amount due | [optional] 
**NextPaymentDate** | **DateTime?** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**PaymentFrequency** | **string** | The payment frequency | [optional] 
**InterestType** | **string** | The interest type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**InterestRate** | **double?** | Loan interest rate. | [optional] 
**EffectiveInterestRate** | **double?** | Loan effective interest rate | [optional] 
**InstallmentAmount** | **double?** | Installment loan payment amount | [optional] 
**RemainingTermNumber** | [**decimal?**](BigDecimal.md) | Term remaining. | [optional] 
**PastDueAmount** | **double?** | Past due is a loan payment that has not been made as of its due date | [optional] 
**PaidPrincipalAmount** | **double?** | The amount of principal returned to the bank | [optional] 
**LateChargeAmount** | **double?** | Late charge amount applicable when amount is not paid by the due date | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

