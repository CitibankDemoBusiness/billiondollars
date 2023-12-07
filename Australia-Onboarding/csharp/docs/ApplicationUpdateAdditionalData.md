# IO.Swagger.Model.ApplicationUpdateAdditionalData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NumberOfDependents** | [**decimal?**](BigDecimal.md) | Number of dependants | [optional] 
**StaffIndicator** | **bool?** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**BusinessNature** | **string** | Business nature of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values. | [optional] 
**EmergencyContactName** | **string** | Emergency Contact Name | [optional] 
**EmergencyContactPhoneNumber** | **string** | Emergency Contact Number. | [optional] 
**OverLimitConsentFlag** | **bool?** | Customer Consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**CountrySpecificGroup** | [**ApplicationUpdateCountrySpecificGroup**](ApplicationUpdateCountrySpecificGroup.md) |  | [optional] 
**PrimaryBankDetails** | [**ApplicationUpdatePrimaryBankDetails**](ApplicationUpdatePrimaryBankDetails.md) |  | [optional] 
**ReferralGivenName** | **string** | Referral First Name. | [optional] 
**ReferralSurname** | **string** | Referral Surname/Last Name. | [optional] 
**RelatedToCitiEmployeeFlag** | **bool?** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**RelatedCitiEmployeeName** | **string** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**RelatedCitiEmployeeDepartment** | **string** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**CreditCardUsagePurpose** | **string** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

