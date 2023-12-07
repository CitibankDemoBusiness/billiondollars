# ApplicationInquiryUnsecuredLoanProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **string** | A unique code that identifies the product | 
**source_code** | **string** | A source code to identify the product | 
**organization** | **string** | Card issuing Organisation code | 
**logo** | **string** | Product logo to identify the product | 
**request_credit_shield** | **bool** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**billing_address** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. | [optional] 
**gift_code** | **string** | A  unique code that identifies the gift offered along with the product | [optional] 
**requested_loan_amount** | **double** | Requested loan amount | [optional] 
**tenor** | **string** | Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

