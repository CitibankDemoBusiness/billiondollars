# IO.Swagger.Model.CreditSpecificSelection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestCreditShield** | **bool?** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**EmbossName** | **string** | Name to be embossed on card | [optional] 
**BillingAddress** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use billingAddress field as the referenceCode parameter to retrieve the values. | [optional] 
**CardDeliveryAddress** | **string** | Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use cardDeliveryAddress field name as the referenceCode parameter to retrieve the values. | [optional] 
**PinDeliveryAddress** | **string** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. You can use pinDeliveryAddress field name as the referenceCode parameter to retrieve the values. | [optional] 
**RequestedCreditLimit** | **double?** | Credit limit accepted by customer | [optional] 
**OfferedCreditLimitAcceptedFlag** | **bool?** | Consent to offered credit limit and If the customer has not accepted Bankâ€™s approved credit limit then requestedCreditLimit is mandatory. Valid values: true and false | [optional] 
**AtmRequiredFlag** | **bool?** | Option to get ATM card along with product. Valid values: true and false | [optional] 
**ChequeBookRequiredFlag** | **bool?** | Option to get cheque book along with product. Valid values: true and false | [optional] 
**CreditLimitIncreaseIndicator** | **bool?** | Option  to increase credit limit. Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

