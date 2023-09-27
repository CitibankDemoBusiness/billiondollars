# RetrieveCreditChargeCardCorporateCardsPendingAndIntradayAuthorizationTransactionsRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **string** | Tokenized card number | 
**corporate_officer_details** | [**\Swagger\Client\Model\CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**transaction_type** | **string** | transactionType. This is a reference data field. Please use /v1/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions | 
**pending_authorization_transaction** | [**\Swagger\Client\Model\PendingAuthorizationTransaction**](PendingAuthorizationTransaction.md) |  | [optional] 
**history_and_intraday_transaction** | [**\Swagger\Client\Model\HistoryAndIntradayTransaction**](HistoryAndIntradayTransaction.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

