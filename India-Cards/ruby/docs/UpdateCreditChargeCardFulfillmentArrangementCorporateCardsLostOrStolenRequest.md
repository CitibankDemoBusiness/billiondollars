# SwaggerClient::UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenized_card_number** | **String** | Tokenized card number | 
**corporate_officer_details** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**embossed_name** | **String** | Customer Name embossed on the card | 
**service_request_type** | **String** | This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions | 
**stolen_date** | **Date** | Cards Lost or Stolen date | [optional] 
**last_card_used_date** | **Date** | Latest date when the card was used | [optional] 
**last_transaction_amount** | **Float** | Latest Transaction amount on the card | [optional] 
**card_loss_type** | **String** | Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions | [optional] 
**lost_country** | **String** | Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions | [optional] 
**customer_remarks** | **String** | Remarks to be mentioned by customer (120 Bytes max length) | [optional] 

