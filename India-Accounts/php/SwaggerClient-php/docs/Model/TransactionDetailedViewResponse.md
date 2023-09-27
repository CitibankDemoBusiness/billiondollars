# TransactionDetailedViewResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_source_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**payment_type** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | 
**transaction_description** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**transaction_amount** | **double** | Transaction amount in account currency. | 
**transaction_currency_code** | **string** | The currency code for the transaction amount in ISO 4217 format. | 
**transaction_date** | [**\DateTime**](\DateTime.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**foreign_transaction_amount** | **float** | The transaction amount in the foreign account current | [optional] 
**foreign_currency_code** | **string** | The currency code for the foreign transaction amount in ISO 4217 format. | [optional] 
**foreign_exchange_rate** | **float** | The exchange rate at the time the foreign transaction was done | [optional] 
**transaction_status** | **string** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**transaction_posting_date** | [**\DateTime**](\DateTime.md) | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. | [optional] 
**customer_name** | [**\Swagger\Client\Model\CustomerName**](CustomerName.md) |  | [optional] 
**customer_address** | [**\Swagger\Client\Model\CustomerAddress**](CustomerAddress.md) |  | [optional] 
**beneficiary_bank_details** | [**\Swagger\Client\Model\BeneficiaryBankDetails**](BeneficiaryBankDetails.md) |  | [optional] 
**customer_merchant_reference_details** | [**\Swagger\Client\Model\CustomerMerchantReferenceDetails[]**](CustomerMerchantReferenceDetails.md) |  | [optional] 
**remarks** | **string** | Payment notes. Free text from screen | [optional] 
**payment_priority_code** | **string** | This code is used to indicate the priority payments | [optional] 
**merchant_code** | **string** | The code to identify merchant | [optional] 
**merchant_name** | **string** | The name of the merchant | [optional] 
**transaction_reversal_description** | **string** | Transaction reversal description as provided by the returnee | [optional] 
**original_transaction_details** | [**\Swagger\Client\Model\OriginalTransactionDetails**](OriginalTransactionDetails.md) |  | [optional] 
**end_to_end_identification** | **string** | End to End Identification status | [optional] 
**creditor_details** | [**\Swagger\Client\Model\CreditorDetails**](CreditorDetails.md) |  | [optional] 
**debtor_details** | [**\Swagger\Client\Model\DebtorDetails**](DebtorDetails.md) |  | [optional] 
**source_bank_name** | **string** | Name of the bank. | [optional] 
**source_bank_code** | **string** | The bank code of the payer account | [optional] 
**clearing_time_stamp** | **string** | Clearing Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**settlement_time_stamp** | **string** | Settlement Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**central_bank_transaction_reference_id** | **string** | Transaction ID identifying the transaction across banks | [optional] 
**original_creditor_details** | [**\Swagger\Client\Model\OriginalCreditorDetails**](OriginalCreditorDetails.md) |  | [optional] 
**original_credit_account_details** | [**\Swagger\Client\Model\OriginalCreditAccountDetails**](OriginalCreditAccountDetails.md) |  | [optional] 
**original_debtor_name** | **string** | Original Debtor Name | [optional] 
**original_debit_account_details** | [**\Swagger\Client\Model\OriginalDebitAccountDetails**](OriginalDebitAccountDetails.md) |  | [optional] 
**transaction_debit_fee_amount** | **double** | Fees charged for the debit. | [optional] 
**bank_member_id** | **string** | Bank Member ID | [optional] 
**beneficiary_legal_name** | **string** | Legal Name of the Beneficiary | [optional] 
**beneficiary_address** | [**\Swagger\Client\Model\BeneficiaryAddress[]**](BeneficiaryAddress.md) |  | [optional] 
**beneficiary_tax_id** | **string** | Beneficiary Tax ID | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

