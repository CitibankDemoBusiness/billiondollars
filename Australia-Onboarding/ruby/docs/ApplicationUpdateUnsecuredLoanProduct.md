# SwaggerClient::ApplicationUpdateUnsecuredLoanProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **String** | A unique code that identifies the product | [optional] 
**source_code** | **String** | A source code to identify the product | [optional] 
**organization** | **String** | Card issuing Organisation code | [optional] 
**logo** | **String** | Product logo to identify the product | [optional] 
**request_credit_shield** | **BOOLEAN** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**billing_address** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**gift_code** | **String** | A  unique code that identifies the gift offered along with the product | [optional] 
**requested_loan_amount** | **Float** | Requested loan amount | [optional] 
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values. | [optional] 

