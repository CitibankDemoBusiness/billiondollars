# UpdateCreditChargeCardFulfillmentArrangementCorporateCardsLostOrStolenRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenizedCardNumber** | **String** | Tokenized card number | 
**corporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  |  [optional]
**embossedName** | **String** | Customer Name embossed on the card | 
**serviceRequestType** | **String** | This is a reference data field. Please use /v1/utilities/referenceData/{serviceRequestType} resource to get possible values of this field with descriptions | 
**stolenDate** | [**LocalDate**](LocalDate.md) | Cards Lost or Stolen date |  [optional]
**lastCardUsedDate** | [**LocalDate**](LocalDate.md) | Latest date when the card was used |  [optional]
**lastTransactionAmount** | **Double** | Latest Transaction amount on the card |  [optional]
**cardLossType** | **String** | Type of loss of the card. This is a reference data field. Please use /v1/utilities/referenceData/{typeOfLoss} resource to get possible values of this field with descriptions |  [optional]
**lostCountry** | **String** | Country where the card was lost. This is a reference data field. Please use /v1/utilities/referenceData/{lostCountry} resource to get possible values of this field with descriptions |  [optional]
**customerRemarks** | **String** | Remarks to be mentioned by customer (120 Bytes max length) |  [optional]
