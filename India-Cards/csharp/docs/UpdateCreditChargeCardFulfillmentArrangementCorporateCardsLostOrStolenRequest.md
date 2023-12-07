# IO.Swagger.Model.UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenizedCardNumber** | **string** | Tokenized card number | 
**CorporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**EmbossedName** | **string** | Customer Name embossed on the card | 
**ServiceRequestType** | **string** | This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions | 
**StolenDate** | **DateTime?** | Cards Lost or Stolen date | [optional] 
**LastCardUsedDate** | **DateTime?** | Latest date when the card was used | [optional] 
**LastTransactionAmount** | **double?** | Latest Transaction amount on the card | [optional] 
**CardLossType** | **string** | Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions | [optional] 
**LostCountry** | **string** | Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions | [optional] 
**CustomerRemarks** | **string** | Remarks to be mentioned by customer (120 Bytes max length) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

