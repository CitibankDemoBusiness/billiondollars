# RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenizedCardNumber** | **String** | Tokenized card number | 
**corporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  |  [optional]
**transactionType** | **String** | transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions | 
**pendingAuthorizationTransaction** | [**PendingAuthorizationTransaction**](PendingAuthorizationTransaction.md) |  |  [optional]
**historyAndIntradayTransaction** | [**HistoryAndIntradayTransaction**](HistoryAndIntradayTransaction.md) |  |  [optional]
