# SwaggerClient::LoanAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_name** | **String** | The name of the product | [optional] 
**product_code** | **String** | A unique code that identifies the product | [optional] 
**display_account_number** | **String** | A masked account number that can be displayed to the customer | 
**original_principal_amount** | **Float** | The amount borrowed | [optional] 
**current_principal_amount** | **Float** | The remaining principal amount | [optional] 
**outstanding_balance** | **Float** | The amount of money owed. | [optional] 
**currency_code** | **String** | The currency code in ISO 4217 format | [optional] 
**maturity_date** | **Date** | Loan maturity date in ISO 8601 date format YYYY-MM-DD | [optional] 
**opening_date** | **Date** | Loan account opening date in ISO 8601 date format YYYY-MM-DD | [optional] 
**last_payment_date** | **Date** | The date of the last payment in ISO 8601 format YYYY-MM-DD | [optional] 
**last_payment_amount** | **Float** | The amount of the last payment made | [optional] 
**interest_amount** | **Float** | Interest amount paid for the mentioned period | [optional] 
**interest_accumulation_period** | **String** | The period of interest accumulation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestAccumulationPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**next_payment_amount** | **Float** | The next payment amount due | [optional] 
**next_payment_date** | **Date** | The date of the next payment in ISO 8601 date format YYYY-MM-DD | [optional] 
**payment_frequency** | **String** | The payment frequency | [optional] 
**interest_type** | **String** | The interest type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**interest_rate** | **Float** | Loan interest rate. | [optional] 
**effective_interest_rate** | **Float** | Loan effective interest rate | [optional] 
**installment_amount** | **Float** | Installment loan payment amount | [optional] 
**remaining_term_number** | [**BigDecimal**](BigDecimal.md) | Term remaining. | [optional] 
**past_due_amount** | **Float** | Past due is a loan payment that has not been made as of its due date | [optional] 
**paid_principal_amount** | **Float** | The amount of principal returned to the bank | [optional] 
**late_charge_amount** | **Float** | Late charge amount applicable when amount is not paid by the due date | [optional] 

