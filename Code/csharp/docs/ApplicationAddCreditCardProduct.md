# IO.Swagger.Model.ApplicationAddCreditCardProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product. | 
**SourceCode** | **string** | A source code to identify the product | 
**Organization** | **string** | Card issuing organization name | 
**Logo** | **string** | Product logo to identify the product | 
**RequestCreditShield** | **bool?** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**EmbossName** | **string** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**BillingAddress** | **string** | Billing address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field as the referenceCode parameter to retrieve the values. | [optional] 
**CardDeliveryAddress** | **string** | Card delivery address of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**PinDeliveryAddress** | **string** | Delivery address  for card pin of the applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**GiftCode** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**CreditLimitIncreaseIndicator** | **bool?** | Option  to review the credit limit in the future.Valid values: true and false | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

