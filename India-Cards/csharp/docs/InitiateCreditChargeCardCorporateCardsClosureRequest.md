# IO.Swagger.Model.InitiateCreditChargeCardCorporateCardsClosureRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenizedCardNumber** | **string** | Tokenized card number | 
**CorporateOfficerDetails** | [**CorporateOfficerDetails**](CorporateOfficerDetails.md) |  | [optional] 
**CancellationReasonCode** | **string** | cancellationReasonCode. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationReasonCode} resource to get possible values of this field with descriptions | [optional] 
**CancellationType** | **string** | cancellationReasonDescription. This is a reference data field. Please use /v1/utilities/referenceData/{cancellationType} resource to get possible values of this field with descriptions | [optional] 
**EffectiveCancelDate** | **DateTime?** | Cancellation date in ISO 8601 date format YYYY-MM-DD | [optional] 
**PostalMailCode** | **string** | Mail letter code if business opt to send letter to customer. This is a reference data field. Please use /v1/utilities/referenceData/{postalMailCode} resource to get possible values of this field with descriptions. | [optional] 
**PermenantAccountClosureFlag** | **bool?** | Permanent Account Closure Flag | [optional] 
**ConsentGivenFlag** | **bool?** | This is consent flag from the customer to pay back if any outstanding on that account while closure | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

