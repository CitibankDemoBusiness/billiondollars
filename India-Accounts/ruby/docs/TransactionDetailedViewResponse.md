# SwaggerClient::TransactionDetailedViewResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_source_account_number** | **String** | A masked account number that can be displayed to the customer | [optional] 
**payment_type** | **String** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | 
**transaction_description** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**transaction_amount** | **Float** | Transaction amount in account currency. | 
**transaction_currency_code** | **String** | The currency code for the transaction amount in ISO 4217 format. | 
**transaction_date** | **Date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**foreign_transaction_amount** | [**BigDecimal**](BigDecimal.md) | The transaction amount in the foreign account current | [optional] 
**foreign_currency_code** | **String** | The currency code for the foreign transaction amount in ISO 4217 format. | [optional] 
**foreign_exchange_rate** | [**BigDecimal**](BigDecimal.md) | The exchange rate at the time the foreign transaction was done | [optional] 
**transaction_status** | **String** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**transaction_posting_date** | **Date** | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. | [optional] 
**customer_name** | [**CustomerName**](CustomerName.md) |  | [optional] 
**customer_address** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**beneficiary_bank_details** | [**BeneficiaryBankDetails**](BeneficiaryBankDetails.md) |  | [optional] 
**customer_merchant_reference_details** | [**Array&lt;CustomerMerchantReferenceDetails&gt;**](CustomerMerchantReferenceDetails.md) |  | [optional] 
**remarks** | **String** | Payment notes. Free text from screen | [optional] 
**payment_priority_code** | **String** | This code is used to indicate the priority payments | [optional] 
**merchant_code** | **String** | The code to identify merchant | [optional] 
**merchant_name** | **String** | The name of the merchant | [optional] 
**transaction_reversal_description** | **String** | Transaction reversal description as provided by the returnee | [optional] 
**original_transaction_details** | [**OriginalTransactionDetails**](OriginalTransactionDetails.md) |  | [optional] 
**end_to_end_identification** | **String** | End to End Identification status | [optional] 
**creditor_details** | [**CreditorDetails**](CreditorDetails.md) |  | [optional] 
**debtor_details** | [**DebtorDetails**](DebtorDetails.md) |  | [optional] 
**source_bank_name** | **String** | Name of the bank. | [optional] 
**source_bank_code** | **String** | The bank code of the payer account | [optional] 
**clearing_time_stamp** | **String** | Clearing Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**settlement_time_stamp** | **String** | Settlement Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**central_bank_transaction_reference_id** | **String** | Transaction ID identifying the transaction across banks | [optional] 
**original_creditor_details** | [**OriginalCreditorDetails**](OriginalCreditorDetails.md) |  | [optional] 
**original_credit_account_details** | [**OriginalCreditAccountDetails**](OriginalCreditAccountDetails.md) |  | [optional] 
**original_debtor_name** | **String** | Original Debtor Name | [optional] 
**original_debit_account_details** | [**OriginalDebitAccountDetails**](OriginalDebitAccountDetails.md) |  | [optional] 
**transaction_debit_fee_amount** | **Float** | Fees charged for the debit. | [optional] 
**bank_member_id** | **String** | Bank Member ID | [optional] 
**beneficiary_legal_name** | **String** | Legal Name of the Beneficiary | [optional] 
**beneficiary_address** | [**Array&lt;BeneficiaryAddress&gt;**](BeneficiaryAddress.md) |  | [optional] 
**beneficiary_tax_id** | **String** | Beneficiary Tax ID | [optional] 

