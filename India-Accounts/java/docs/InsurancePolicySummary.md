# InsurancePolicySummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**productName** | **String** | The name of the product |  [optional]
**productCode** | **String** | A unique code that identifies the product |  [optional]
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**currencyCode** | **String** | The currency code in ISO 4217 format |  [optional]
**accountClassification** | **String** | Classification of account either as ASSET or LIABILITY. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClassification} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**accountStatus** | **String** | Status of the account. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. |  [optional]
**displayPolicyNumber** | **String** | A masked policy number that can be displayed to the customer. | 
**insuranceApplicationId** | **String** | Insurance Application Number. This field is used to retrieve insurance policy details | 
**insuranceSumAssuredAmount** | **Double** | Sum assured amount of the insurance |  [optional]
**totalPremiumPaidAmount** | **Double** | Total premium paid for the insurance policy |  [optional]
