# SwaggerClient::ApplicationAddAdditionalData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**number_of_dependents** | [**BigDecimal**](BigDecimal.md) | Number of dependents | [optional] 
**staff_indicator** | **BOOLEAN** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**business_nature** | **String** | Business nature of the applicant This is a reference data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values. | [optional] 
**emergency_contact_name** | **String** | Emergency contact Name | [optional] 
**emergency_contact_phone_number** | **String** | Emergency contact Number. | [optional] 
**over_limit_consent_flag** | **BOOLEAN** | Customer consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**country_specific_group** | [**ApplicationAddCountrySpecificGroup**](ApplicationAddCountrySpecificGroup.md) |  | [optional] 
**primary_bank_details** | [**ApplicationAddPrimaryBankDetails**](ApplicationAddPrimaryBankDetails.md) |  | [optional] 
**referral_given_name** | **String** | Referral First Name. | [optional] 
**referral_surname** | **String** | Referral Surname/Last Name. | [optional] 
**related_to_citi_employee_flag** | **BOOLEAN** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**related_citi_employee_name** | **String** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**related_citi_employee_department** | **String** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**credit_card_usage_purpose** | **String** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 

