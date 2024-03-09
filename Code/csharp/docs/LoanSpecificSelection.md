# IO.Swagger.Model.LoanSpecificSelection
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoanAmount** | **double?** | Loan Amount accepted by customer | 
**Tenor** | **string** | Tenure of loan. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid values of this field with descriptions. You can use tenor field name as the referenceCode parameter to retrieve the values. | 
**InterestRate** | **double?** | Interest rate applicable for the loan | 
**BillingAddress** | **string** | Billing address of applicant. This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressType} resource to get valid value of this field with description. You can use billingAddress field as the referenceCode parameter to retrieve the values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

