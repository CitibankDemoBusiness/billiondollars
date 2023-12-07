# LoanAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **str** | The name of the product | [optional] 
**product_code** | **str** | A unique code that identifies the product | [optional] 
**display_account_number** | **str** | A masked account number that can be displayed to the customer | 
**original_principal_amount** | **float** | The amount borrowed | [optional] 
**current_principal_amount** | **float** | The remaining principal amount | [optional] 
**outstanding_balance** | **float** | The amount of money owed. | [optional] 
**currency_code** | **str** | The currency code in ISO 4217 format | [optional] 
**maturity_date** | **date** | Loan maturity date in ISO 8601 date format YYYY-MM-DD | [optional] 
**opening_date** | **date** | Loan account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**last_payment_date** | **date** | The date of the last payment in ISO 8601 format YYYY-MM-DD | [optional] 
**last_payment_amount** | **float** | The amount of the last payment made | [optional] 
**interest_amount** | **float** | Interest amount paid for the mentioned period | [optional] 
**interest_accumulation_period** | **str** | The period of interest accumulation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestAccumulationPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**next_payment_amount** | **float** | The next payment amount due | [optional] 
**next_payment_date** | **date** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**payment_frequency** | **str** | The payment frequency | [optional] 
**interest_type** | **str** | The interest type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**interest_rate** | **float** | Loan interest rate. | [optional] 
**effective_interest_rate** | **float** | Loan effective interest rate | [optional] 
**installment_amount** | **float** | Installment loan payment amount | [optional] 
**remaining_term_number** | **float** | Term remaining. | [optional] 
**past_due_amount** | **float** | Past due is a loan payment that has not been made as of its due date | [optional] 
**paid_principal_amount** | **float** | The amount of principal returned to the bank | [optional] 
**late_charge_amount** | **float** | Late charge amount applicable when amount is not paid by the due date | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

