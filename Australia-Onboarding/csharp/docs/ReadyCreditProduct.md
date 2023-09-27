# IO.Swagger.Model.ReadyCreditProduct
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductCode** | **string** | A unique code that identifies the product | 
**SourceCode** | **string** | A source code to identify the product | 
**Organization** | **string** | Card issuing organization name | 
**Logo** | **string** | Product logo to identify the product | 
**RequestCreditShield** | **bool?** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**EmbossName** | **string** | Name to be embossed on card | [optional] 
**BillingAddress** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**CardDeliveryAddress** | **string** | Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**PinDeliveryAddress** | **string** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**GiftCode** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**CreditLimitIncreaseIndicator** | **bool?** | Option for to review the credit limit in the future.Valid values: true and false | [optional] 
**AtmRequiredFlag** | **bool?** | Option to get ATM card along with product. Valid values: true and false | [optional] 
**ChequeBookRequiredFlag** | **bool?** | Option to get cheque book along with product. Valid values: true and false | [optional] 
**BalanceTransferDetails** | [**List&lt;BalanceTransferDetails&gt;**](BalanceTransferDetails.md) |  | [optional] 
**LoanPurpose** | **string** | Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**RequestedCreditLimit** | **double?** | Credit limit requested by applicant for the product. | [optional] 
**EqualPaymentPlan** | [**List&lt;EqualPaymentPlan&gt;**](EqualPaymentPlan.md) |  | [optional] 
**AtmPinRegistrationFlag** | **bool?** | Flag to indicate if ATM PIN for the card is registered already by customer. | [optional] 
**CreditLimitAcceptedFlag** | **bool?** | Flag to indicate acceptance of customer for the ready credit limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

