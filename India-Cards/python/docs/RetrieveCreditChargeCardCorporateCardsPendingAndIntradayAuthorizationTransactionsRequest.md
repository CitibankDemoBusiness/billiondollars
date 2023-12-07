# RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **str** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**transaction_type** | **str** | transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions | 
**pending_authorization_transaction** | [**PendingAuthorizationTransaction**](PendingAuthorizationTransaction.md) |  | [optional] 
**history_and_intraday_transaction** | [**HistoryAndIntradayTransaction**](HistoryAndIntradayTransaction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

