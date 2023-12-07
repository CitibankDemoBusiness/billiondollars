# ApplicationAddAdditionalData

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**number_of_dependents** | **float** | Number of dependents | [optional] 
**staff_indicator** | **bool** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**business_nature** | **string** | Business nature of the applicant This is a reference data field. Please use /v1/apac/utilities/referenceData/{businessNature} resource to get valid value of this field with description. You can use businessNature field name as the referenceCode parameter to retrieve the values. | [optional] 
**emergency_contact_name** | **string** | Emergency contact Name | [optional] 
**emergency_contact_phone_number** | **string** | Emergency contact Number. | [optional] 
**over_limit_consent_flag** | **bool** | Customer consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**country_specific_group** | [**\Swagger\Client\Model\ApplicationAddCountrySpecificGroup**](ApplicationAddCountrySpecificGroup.md) |  | [optional] 
**primary_bank_details** | [**\Swagger\Client\Model\ApplicationAddPrimaryBankDetails**](ApplicationAddPrimaryBankDetails.md) |  | [optional] 
**referral_given_name** | **string** | Referral First Name. | [optional] 
**referral_surname** | **string** | Referral Surname/Last Name. | [optional] 
**related_to_citi_employee_flag** | **bool** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**related_citi_employee_name** | **string** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**related_citi_employee_department** | **string** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**credit_card_usage_purpose** | **string** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/apac/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

