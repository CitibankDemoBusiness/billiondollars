# ApplicationUpdateKycInformation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**self_public_figure_declaration_flag** | **bool** | Flag for self declaration if applicant is public figure. Valid values: true and false | [optional] 
**public_figure_office_status** | **string** | Flag for status of public office if applicant is public figure | [optional] 
**public_figure_office_details** | **string** | Office details if applicant is public figure | [optional] 
**public_figure_office_start_date** | [**\DateTime**](\DateTime.md) | Public figure office start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**public_figure_office_end_date** | [**\DateTime**](\DateTime.md) | Public figure office end date in ISO 8601 date format YYYY-MM-DD | [optional] 
**is_related_to_senior_public_figure** | **bool** | Self declaration if applicant has any relation with senior public figure. Valid values: true and false | [optional] 
**related_senior_public_figure_name** | **string** | Senior Public Figure Name | [optional] 
**related_spf_country_of_government** | **string** | Senior Public Figure Country of Government | [optional] 
**related_senior_public_figure_department** | **string** | Department Senior Public Figure belongs to | [optional] 
**relationship_with_senior_public_figure** | **string** | Senior Public Figure relationship with applicant | [optional] 
**related_senior_public_figure_last_name** | **string** | Senior Public Figure Last Name | [optional] 
**us_tax_status** | **string** | US Tax status. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values. | [optional] 
**us_tax_id** | **string** | US Tax ID | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

