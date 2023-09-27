# InitiateCreditChargeCardCorporateCardsClosureRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**tokenizedCardNumber** | **String** | Tokenized card number | 
**corporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  |  [optional]
**cancellationReasonCode** | **String** | cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions |  [optional]
**cancellationType** | **String** | cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions |  [optional]
**effectiveCancelDate** | [**LocalDate**](LocalDate.md) | Cancellation date in ISO 8601 date format YYYY-MM-DD |  [optional]
**postalMailCode** | **String** | Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions. |  [optional]
**permenantAccountClosureFlag** | **Boolean** | Permanent Account Closure Flag |  [optional]
**consentGivenFlag** | **Boolean** | This is consent flag from the customer to pay back if any outstanding on that account while closure |  [optional]
