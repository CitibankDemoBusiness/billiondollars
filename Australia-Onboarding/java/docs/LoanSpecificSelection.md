# LoanSpecificSelection

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**loanAmount** | **Double** | Loan Amount accepted by customer | 
**tenor** | **String** | Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. You can use tenor field name as the referenceCode parameter to retrieve the values. | 
**interestRate** | **Double** | Interest rate applicable for the loan | 
**billingAddress** | **String** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use billingAddress field as the referenceCode parameter to retrieve the values. |  [optional]
