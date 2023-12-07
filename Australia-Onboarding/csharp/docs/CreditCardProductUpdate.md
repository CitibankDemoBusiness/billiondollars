# IO.Swagger.Model.CreditCardProductUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product. | [optional] 
**SourceCode** | **string** | A source code to identify the product | [optional] 
**Organization** | **string** | Card issuing organization name | [optional] 
**Logo** | **string** | Product logo to identify the product | [optional] 
**RequestCreditShield** | **bool?** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**RequestedCreditLimit** | **double?** | Credit limit requested by applicant for the product. | [optional] 
**EmbossName** | **string** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**BillingAddress** | **string** | Billing address of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**CardDeliveryAddress** | **string** | Card delivery address of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**PinDeliveryAddress** | **string** | Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**CardDeliveryBranch** | **string** | Pick-up branch detail of the Citi bank for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryBranch} resource to get valid value of this field. | [optional] 
**CardDeliveryOption** | **string** | Pick-up option for card collection. This is a reference data. Please use /v1/utilities/referenceData/{cardDeliveryOption} resource to get valid value of this field. | [optional] 
**GiftCode** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**CreditLimitIncreaseIndicator** | **bool?** | Option  to review the credit limit in the future.Valid values: true and false | [optional] 
**BalanceTransferDetails** | [**List&lt;BalanceTransferDetails&gt;**](BalanceTransferDetails.md) |  | [optional] 
**CreditLimitAcceptedFlag** | **bool?** | Flag to indicate acceptance of customer for the credit card limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

