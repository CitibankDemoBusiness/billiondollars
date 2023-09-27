# ApplicationAddAdditionalData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**numberOfDependents** | [**BigDecimal**](BigDecimal.md) | Number of dependents |  [optional]
**staffIndicator** | **Boolean** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false |  [optional]
**businessNature** | **String** | Business nature of the applicant This is a reference data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values. |  [optional]
**emergencyContactName** | **String** | Emergency contact Name |  [optional]
**emergencyContactPhoneNumber** | **String** | Emergency contact Number. |  [optional]
**overLimitConsentFlag** | **Boolean** | Customer consent on spending more than the limit assigned to him. Valid values: true and false |  [optional]
**countrySpecificGroup** | [**ApplicationAddCountrySpecificGroup**](ApplicationAddCountrySpecificGroup.md) |  |  [optional]
**primaryBankDetails** | [**ApplicationAddPrimaryBankDetails**](ApplicationAddPrimaryBankDetails.md) |  |  [optional]
**referralGivenName** | **String** | Referral First Name. |  [optional]
**referralSurname** | **String** | Referral Surname/Last Name. |  [optional]
**relatedToCitiEmployeeFlag** | **Boolean** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false |  [optional]
**relatedCitiEmployeeName** | **String** | Name of the citi employee if applicant has any relation with citi bank employee. |  [optional]
**relatedCitiEmployeeDepartment** | **String** | Department of citi employee if applicant has any relation with citi bank employee. |  [optional]
**creditCardUsagePurpose** | **String** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. |  [optional]
