# UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **str** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**embossed_name** | **str** | Customer Name embossed on the card | 
**service_request_type** | **str** | This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions | 
**stolen_date** | **date** | Cards Lost or Stolen date | [optional] 
**last_card_used_date** | **date** | Latest date when the card was used | [optional] 
**last_transaction_amount** | **float** | Latest Transaction amount on the card | [optional] 
**card_loss_type** | **str** | Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions | [optional] 
**lost_country** | **str** | Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions | [optional] 
**customer_remarks** | **str** | Remarks to be mentioned by customer (120 Bytes max length) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

