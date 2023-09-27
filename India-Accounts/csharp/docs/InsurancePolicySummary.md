# IO.Swagger.Model.InsurancePolicySummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProductName** | **string** | The name of the product | [optional] 
**ProductCode** | **string** | A unique code that identifies the product | [optional] 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | [optional] 
**CurrencyCode** | **string** | The currency code in ISO 4217 format | [optional] 
**AccountClassification** | **string** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**AccountStatus** | **string** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**DisplayPolicyNumber** | **string** | A masked policy number that can be displayed to the customer. | 
**InsuranceApplicationId** | **string** | Insurance Application Number. This field is used to retrieve insurance policy details | 
**InsuranceSumAssuredAmount** | **double?** | Sum assured amount of the insurance | [optional] 
**TotalPremiumPaidAmount** | **double?** | Total premium paid for the insurance policy | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

