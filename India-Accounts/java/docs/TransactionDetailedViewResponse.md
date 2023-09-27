# TransactionDetailedViewResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displaySourceAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**paymentType** | **String** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | 
**transactionDescription** | **String** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. |  [optional]
**transactionAmount** | **Double** | Transaction amount in account currency. | 
**transactionCurrencyCode** | **String** | The currency code for the transaction amount in ISO 4217 format. | 
**transactionDate** | [**LocalDate**](LocalDate.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**foreignTransactionAmount** | [**BigDecimal**](BigDecimal.md) | The transaction amount in the foreign account current |  [optional]
**foreignCurrencyCode** | **String** | The currency code for the foreign transaction amount in ISO 4217 format. |  [optional]
**foreignExchangeRate** | [**BigDecimal**](BigDecimal.md) | The exchange rate at the time the foreign transaction was done |  [optional]
**transactionStatus** | **String** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. |  [optional]
**transactionPostingDate** | [**LocalDate**](LocalDate.md) | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. |  [optional]
**customerName** | [**CustomerName**](CustomerName.md) |  |  [optional]
**customerAddress** | [**CustomerAddress**](CustomerAddress.md) |  |  [optional]
**beneficiaryBankDetails** | [**BeneficiaryBankDetails**](BeneficiaryBankDetails.md) |  |  [optional]
**customerMerchantReferenceDetails** | [**List&lt;CustomerMerchantReferenceDetails&gt;**](CustomerMerchantReferenceDetails.md) |  |  [optional]
**remarks** | **String** | Payment notes. Free text from screen |  [optional]
**paymentPriorityCode** | **String** | This code is used to indicate the priority payments |  [optional]
**merchantCode** | **String** | The code to identify merchant |  [optional]
**merchantName** | **String** | The name of the merchant |  [optional]
**transactionReversalDescription** | **String** | Transaction reversal description as provided by the returnee |  [optional]
**originalTransactionDetails** | [**OriginalTransactionDetails**](OriginalTransactionDetails.md) |  |  [optional]
**endToEndIdentification** | **String** | End to End Identification status |  [optional]
**creditorDetails** | [**CreditorDetails**](CreditorDetails.md) |  |  [optional]
**debtorDetails** | [**DebtorDetails**](DebtorDetails.md) |  |  [optional]
**sourceBankName** | **String** | Name of the bank. |  [optional]
**sourceBankCode** | **String** | The bank code of the payer account |  [optional]
**clearingTimeStamp** | **String** | Clearing Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS |  [optional]
**settlementTimeStamp** | **String** | Settlement Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS |  [optional]
**centralBankTransactionReferenceId** | **String** | Transaction ID identifying the transaction across banks |  [optional]
**originalCreditorDetails** | [**OriginalCreditorDetails**](OriginalCreditorDetails.md) |  |  [optional]
**originalCreditAccountDetails** | [**OriginalCreditAccountDetails**](OriginalCreditAccountDetails.md) |  |  [optional]
**originalDebtorName** | **String** | Original Debtor Name |  [optional]
**originalDebitAccountDetails** | [**OriginalDebitAccountDetails**](OriginalDebitAccountDetails.md) |  |  [optional]
**transactionDebitFeeAmount** | **Double** | Fees charged for the debit. |  [optional]
**bankMemberId** | **String** | Bank Member ID |  [optional]
**beneficiaryLegalName** | **String** | Legal Name of the Beneficiary |  [optional]
**beneficiaryAddress** | [**List&lt;BeneficiaryAddress&gt;**](BeneficiaryAddress.md) |  |  [optional]
**beneficiaryTaxId** | **String** | Beneficiary Tax ID |  [optional]
