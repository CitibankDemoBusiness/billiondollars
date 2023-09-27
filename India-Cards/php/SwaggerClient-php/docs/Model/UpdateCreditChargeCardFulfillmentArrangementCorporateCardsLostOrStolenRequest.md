# UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **string** | Tokenized card number | 
**corporate_officer_details** | [**\Swagger\Client\Model\CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**embossed_name** | **string** | Customer Name embossed on the card | 
**service_request_type** | **string** | This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions | 
**stolen_date** | [**\DateTime**](\DateTime.md) | Cards Lost or Stolen date | [optional] 
**last_card_used_date** | [**\DateTime**](\DateTime.md) | Latest date when the card was used | [optional] 
**last_transaction_amount** | **double** | Latest Transaction amount on the card | [optional] 
**card_loss_type** | **string** | Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions | [optional] 
**lost_country** | **string** | Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions | [optional] 
**customer_remarks** | **string** | Remarks to be mentioned by customer (120 Bytes max length) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

