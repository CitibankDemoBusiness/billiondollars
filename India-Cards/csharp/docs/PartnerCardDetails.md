# IO.Swagger.Model.PartnerCardDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | The card id  in encrypted format | 
**DisplayCardNumber** | **string** | A masked card number that can be displayed to the customer. | [optional] 
**LocalCardActivationIndicator** | **string** | The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. | 
**OverseasCardActivationIndicator** | **string** | The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. | [optional] 
**PerpetualActivationFlag** | **bool?** | Flag to specify whether the card is activated perpetually, till card expiration | [optional] 
**OverseasCardActivationStartDate** | **DateTime?** | Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. | [optional] 
**OverseasCardActivationEndDate** | **DateTime?** | Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date | [optional] 
**CurrentCreditLimitAmount** | **double?** | Current credit limit amount on the credit card | 
**MaximumPermanentCreditLimitAmount** | **double?** | Maximum permanent credit limit amount allowed on the credit card | [optional] 
**MaximumTemporaryCreditLimitAmount** | **double?** | Maximum temporary credit limit amount allowed on the credit card | [optional] 
**SubCardType** | **string** | Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. | 
**CardHolderType** | **string** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. | [optional] 
**CardIssueReason** | **string** | Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description. | [optional] 
**CardFunctionsAllowed** | [**List&lt;CardFunctionsAllowed&gt;**](CardFunctionsAllowed.md) |  | [optional] 
**EmbossName** | **string** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**Organization** | **string** | Card issuing organization name | [optional] 
**Logo** | **string** | Product logo to identify the product | [optional] 
**ProductName** | **string** | The name of the product | [optional] 
**PrimaryCardId** | **string** | The primary card id in encrypted format. Applicable only for supplementary cards. | [optional] 
**DisplayPrimaryCardNumber** | **string** | A masked primary card number that can be displayed to the customer. Applicable only for supplementary cards. | [optional] 
**CardPlasticType** | **string** | Indicates the card plastic type used for embossing.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardPlasticType} resource to get valid value of this field with description. | [optional] 
**CurrentContactlessWthoutPinPmtLimit** | **double?** | Current transaction limit for the contact less payments without pin set by the customer | [optional] 
**MaxContactlessWithoutPinPmtLimit** | **double?** | Maximum transaction limit for the contact less payments without pin | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

