# ApplicationAddUnsecuredLoanProduct

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productCode** | **String** | A unique code that identifies the product | 
**sourceCode** | **String** | A source code to identify the product | 
**organization** | **String** | Card issuing Organisation code | 
**logo** | **String** | Product logo to identify the product | 
**requestCreditShield** | **Boolean** | Insurance enrolment for outstanding balance on the card. Valid values: true and false |  [optional]
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use addressType field name as the referenceCode parameter to retrieve the values. |  [optional]
**giftCode** | **String** | A  unique code that identifies the gift offered along with the product |  [optional]
**requestedLoanAmount** | **Double** | Requested loan amount |  [optional]
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description. You can use tenor field name as the referenceCode parameter to retrieve the values. |  [optional]
