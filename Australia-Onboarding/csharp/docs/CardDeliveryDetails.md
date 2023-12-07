# IO.Swagger.Model.CardDeliveryDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardDeliveryStatus** | **string** | Cd delivery status.  This is a reference data field. Please use /v1/utilities/referenceData/{cardDeliveryStatus} resource to get possible values of this field with descriptions. | [optional] 
**AirwayBillNumber** | **string** | New Field in EPCDFIL. This field denotes the Airway Bill Number or reference number provided by the courier company for the dispatch. | [optional] 
**DeliveryMethod** | **string** | New Field in EPCDFIL. This field denotes the mode through which the card was disptached. Valid Values :  &#x27;Courier&#x27; or &#x27;Post&#x27;  | [optional] 
**CardDeliveryDate** | **string** | New Field in EPCDFIL This field denotes the date of card delivery. | [optional] 
**ReceivedBy** | **string** | New Field in EPCDFIL. This field denotes the Name and Relationship of the individual who has received the card on behalf of the cardholder. If the card holder has received the card, then this field will have the value as ‘Self’. | [optional] 
**DisplayCardNumber** | **string** | Card last four Digit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

