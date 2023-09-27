# PartnerCardDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | The card id  in encrypted format | 
**displayCardNumber** | **String** | A masked card number that can be displayed to the customer. |  [optional]
**localCardActivationIndicator** | **String** | The card activation indicator for local usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{localCardActivationIndicator} resource to get valid value of this field with description. | 
**overseasCardActivationIndicator** | **String** | The card activation indicator for overseas usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardActivationIndicator} resource to get valid value of this field with description. |  [optional]
**perpetualActivationFlag** | **Boolean** | Flag to specify whether the card is activated perpetually, till card expiration |  [optional]
**overseasCardActivationStartDate** | [**LocalDate**](LocalDate.md) | Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. |  [optional]
**overseasCardActivationEndDate** | [**LocalDate**](LocalDate.md) | Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, value is card expiry date |  [optional]
**currentCreditLimitAmount** | **Double** | Current credit limit amount on the credit card | 
**maximumPermanentCreditLimitAmount** | **Double** | Maximum permanent credit limit amount allowed on the credit card |  [optional]
**maximumTemporaryCreditLimitAmount** | **Double** | Maximum temporary credit limit amount allowed on the credit card |  [optional]
**subCardType** | **String** | Type of the card. Debit or Credit.This is a reference data field. Please use /v1/apac/utilities/referenceData/{subCardType} resource to get valid value of this field with description. | 
**cardHolderType** | **String** | Indicator to specify whether the card is primary or supplementary. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardHolderType} resource to get valid value of this field with description. |  [optional]
**cardIssueReason** | **String** | Specifies the reason for the card issuance. Applicable only for recently issued cards. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssueReason} resource to get valid value of this field with description. |  [optional]
**cardFunctionsAllowed** | [**List&lt;CardFunctionsAllowed&gt;**](CardFunctionsAllowed.md) |  |  [optional]
**embossName** | **String** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. |  [optional]
**organization** | **String** | Card issuing organization name |  [optional]
**logo** | **String** | Product logo to identify the product |  [optional]
**productName** | **String** | The name of the product |  [optional]
**primaryCardId** | **String** | The primary card id in encrypted format. Applicable only for supplementary cards. |  [optional]
**displayPrimaryCardNumber** | **String** | A masked primary card number that can be displayed to the customer. Applicable only for supplementary cards. |  [optional]
**cardPlasticType** | **String** | Indicates the card plastic type used for embossing.This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardPlasticType} resource to get valid value of this field with description. |  [optional]
**currentContactlessWthoutPinPmtLimit** | **Double** | Current transaction limit for the contact less payments without pin set by the customer |  [optional]
**maxContactlessWithoutPinPmtLimit** | **Double** | Maximum transaction limit for the contact less payments without pin |  [optional]
