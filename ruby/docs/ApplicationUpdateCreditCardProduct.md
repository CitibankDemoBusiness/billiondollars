# SwaggerClient::ApplicationUpdateCreditCardProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product. | [optional] 
**source_code** | **String** | A source code to identify the product | [optional] 
**organization** | **String** | Card issuing organization name | [optional] 
**logo** | **String** | Product logo to identify the product | [optional] 
**request_credit_shield** | **BOOLEAN** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**emboss_name** | **String** | Name to be embossed on card.If blank, bank will assign automatically based on the market norms. | [optional] 
**billing_address** | **String** | Billing address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**card_delivery_address** | **String** | Card delivery address of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**pin_delivery_address** | **String** | Delivery address  for card pin of applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**gift_code** | **String** | A  unique code that identifies the gift offered along with the product | [optional] 
**credit_limit_increase_indicator** | **BOOLEAN** | Option  to review the credit limit in the future.Valid values: true and false | [optional] 
**balance_transfer_details** | [**Array&lt;ApplicationUpdateBalanceTransferDetails&gt;**](ApplicationUpdateBalanceTransferDetails.md) |  | [optional] 

