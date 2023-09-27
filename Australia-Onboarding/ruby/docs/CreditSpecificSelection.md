# SwaggerClient::CreditSpecificSelection

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**request_credit_shield** | **BOOLEAN** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**emboss_name** | **String** | Name to be embossed on card | [optional] 
**billing_address** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use billingAddress field as the referenceCode parameter to retrieve the values. | [optional] 
**card_delivery_address** | **String** | Card delivery address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use cardDeliveryAddress field name as the referenceCode parameter to retrieve the values. | [optional] 
**pin_delivery_address** | **String** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. You can use pinDeliveryAddress field name as the referenceCode parameter to retrieve the values. | [optional] 
**requested_credit_limit** | **Float** | Credit limit accepted by customer | [optional] 
**offered_credit_limit_accepted_flag** | **BOOLEAN** | Consent to offered credit limit and If the customer has not accepted Bankâ€™s approved credit limit then requestedCreditLimit is mandatory. Valid values: true and false | [optional] 
**atm_required_flag** | **BOOLEAN** | Option to get ATM card along with product. Valid values: true and false | [optional] 
**cheque_book_required_flag** | **BOOLEAN** | Option to get cheque book along with product. Valid values: true and false | [optional] 
**credit_limit_increase_indicator** | **BOOLEAN** | Option  to increase credit limit. Valid values: true and false | [optional] 

