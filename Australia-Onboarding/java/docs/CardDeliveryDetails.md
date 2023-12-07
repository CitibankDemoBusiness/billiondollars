# CardDeliveryDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardDeliveryStatus** | **String** | Cd delivery status.  This is a reference data field. Please use /v1/utilities/referenceData/{cardDeliveryStatus} resource to get possible values of this field with descriptions. |  [optional]
**airwayBillNumber** | **String** | New Field in EPCDFIL. This field denotes the Airway Bill Number or reference number provided by the courier company for the dispatch. |  [optional]
**deliveryMethod** | **String** | New Field in EPCDFIL. This field denotes the mode through which the card was disptached. Valid Values :  &#x27;Courier&#x27; or &#x27;Post&#x27;  |  [optional]
**cardDeliveryDate** | **String** | New Field in EPCDFIL This field denotes the date of card delivery. |  [optional]
**receivedBy** | **String** | New Field in EPCDFIL. This field denotes the Name and Relationship of the individual who has received the card on behalf of the cardholder. If the card holder has received the card, then this field will have the value as ‘Self’. |  [optional]
**displayCardNumber** | **String** | Card last four Digit. |  [optional]
