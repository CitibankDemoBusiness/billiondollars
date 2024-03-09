# SwaggerClient::ReadyCreditProductAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product | 
**source_code** | **String** | A source code to identify the product | 
**organization** | **String** | Card issuing organization name | 
**logo** | **String** | Product logo to identify the product | 
**request_credit_shield** | **BOOLEAN** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**emboss_name** | **String** | Name to be embossed on card | [optional] 
**billing_address** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**card_delivery_address** | **String** | Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**pin_delivery_address** | **String** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**gift_code** | **String** | A  unique code that identifies the gift offered along with the product | [optional] 
**credit_limit_increase_indicator** | **BOOLEAN** | Option for to review the credit limit in the future.Valid values: true and false | [optional] 
**atm_required_flag** | **BOOLEAN** | Option to get ATM card along with product. Valid values: true and false | [optional] 
**cheque_book_required_flag** | **BOOLEAN** | Option to get cheque book along with product. Valid values: true and false | [optional] 
**loan_purpose** | **String** | Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**requested_credit_limit** | **Float** | Credit limit requested by applicant for the product. | [optional] 
**equal_payment_plan** | [**Array&lt;EqualPaymentPlan&gt;**](EqualPaymentPlan.md) |  | [optional] 

