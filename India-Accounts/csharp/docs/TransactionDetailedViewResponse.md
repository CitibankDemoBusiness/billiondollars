# IO.Swagger.Model.TransactionDetailedViewResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplaySourceAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**PaymentType** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. | 
**TransactionDescription** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**TransactionAmount** | **double?** | Transaction amount in account currency. | 
**TransactionCurrencyCode** | **string** | The currency code for the transaction amount in ISO 4217 format. | 
**TransactionDate** | **DateTime?** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | 
**ForeignTransactionAmount** | [**decimal?**](BigDecimal.md) | The transaction amount in the foreign account current | [optional] 
**ForeignCurrencyCode** | **string** | The currency code for the foreign transaction amount in ISO 4217 format. | [optional] 
**ForeignExchangeRate** | [**decimal?**](BigDecimal.md) | The exchange rate at the time the foreign transaction was done | [optional] 
**TransactionStatus** | **string** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. | [optional] 
**TransactionPostingDate** | **DateTime?** | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. | [optional] 
**CustomerName** | [**CustomerName**](CustomerName.md) |  | [optional] 
**CustomerAddress** | [**CustomerAddress**](CustomerAddress.md) |  | [optional] 
**BeneficiaryBankDetails** | [**BeneficiaryBankDetails**](BeneficiaryBankDetails.md) |  | [optional] 
**CustomerMerchantReferenceDetails** | [**List&lt;CustomerMerchantReferenceDetails&gt;**](CustomerMerchantReferenceDetails.md) |  | [optional] 
**Remarks** | **string** | Payment notes. Free text from screen | [optional] 
**PaymentPriorityCode** | **string** | This code is used to indicate the priority payments | [optional] 
**MerchantCode** | **string** | The code to identify merchant | [optional] 
**MerchantName** | **string** | The name of the merchant | [optional] 
**TransactionReversalDescription** | **string** | Transaction reversal description as provided by the returnee | [optional] 
**OriginalTransactionDetails** | [**OriginalTransactionDetails**](OriginalTransactionDetails.md) |  | [optional] 
**EndToEndIdentification** | **string** | End to End Identification status | [optional] 
**CreditorDetails** | [**CreditorDetails**](CreditorDetails.md) |  | [optional] 
**DebtorDetails** | [**DebtorDetails**](DebtorDetails.md) |  | [optional] 
**SourceBankName** | **string** | Name of the bank. | [optional] 
**SourceBankCode** | **string** | The bank code of the payer account | [optional] 
**ClearingTimeStamp** | **string** | Clearing Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**SettlementTimeStamp** | **string** | Settlement Date time as reported by the central bank in ISO 8601 date format YYYY-MM-DDTHH:MM:SS | [optional] 
**CentralBankTransactionReferenceId** | **string** | Transaction ID identifying the transaction across banks | [optional] 
**OriginalCreditorDetails** | [**OriginalCreditorDetails**](OriginalCreditorDetails.md) |  | [optional] 
**OriginalCreditAccountDetails** | [**OriginalCreditAccountDetails**](OriginalCreditAccountDetails.md) |  | [optional] 
**OriginalDebtorName** | **string** | Original Debtor Name | [optional] 
**OriginalDebitAccountDetails** | [**OriginalDebitAccountDetails**](OriginalDebitAccountDetails.md) |  | [optional] 
**TransactionDebitFeeAmount** | **double?** | Fees charged for the debit. | [optional] 
**BankMemberId** | **string** | Bank Member ID | [optional] 
**BeneficiaryLegalName** | **string** | Legal Name of the Beneficiary | [optional] 
**BeneficiaryAddress** | [**List&lt;BeneficiaryAddress&gt;**](BeneficiaryAddress.md) |  | [optional] 
**BeneficiaryTaxId** | **string** | Beneficiary Tax ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

