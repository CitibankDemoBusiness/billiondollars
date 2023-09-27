# ApplicationUpdateAdditionalData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**number_of_dependents** | **float** | Number of dependants | [optional] 
**staff_indicator** | **bool** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**business_nature** | **str** | Business nature of the applicant. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values. | [optional] 
**emergency_contact_name** | **str** | Emergency Contact Name | [optional] 
**emergency_contact_phone_number** | **str** | Emergency Contact Number. | [optional] 
**over_limit_consent_flag** | **bool** | Customer Consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**country_specific_group** | [**ApplicationUpdateCountrySpecificGroup**](ApplicationUpdateCountrySpecificGroup.md) |  | [optional] 
**primary_bank_details** | [**ApplicationUpdatePrimaryBankDetails**](ApplicationUpdatePrimaryBankDetails.md) |  | [optional] 
**referral_given_name** | **str** | Referral First Name. | [optional] 
**referral_surname** | **str** | Referral Surname/Last Name. | [optional] 
**related_to_citi_employee_flag** | **bool** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**related_citi_employee_name** | **str** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**related_citi_employee_department** | **str** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**credit_card_usage_purpose** | **str** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

