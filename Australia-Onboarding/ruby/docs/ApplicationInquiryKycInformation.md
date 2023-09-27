# SwaggerClient::ApplicationInquiryKycInformation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**self_public_figure_declaration_flag** | **BOOLEAN** | Flag for self declaration if applicant is public figure. Valid values: true and false | [optional] 
**public_figure_office_status** | **String** | Flag for status of public office if applicant is public figure | [optional] 
**public_figure_office_details** | **String** | Office details if applicant is public figure | [optional] 
**public_figure_office_start_date** | **Date** | Public figure office start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**public_figure_office_end_date** | **Date** | Public figure office end date in ISO 8601 date format YYYY-MM-DD | [optional] 
**is_related_to_senior_public_figure** | **BOOLEAN** | Self declaration if applicant has any relation with senior public figure. Valid values: true and false | [optional] 
**related_senior_public_figure_name** | **String** | Senior Public Figure Name | [optional] 
**related_senior_public_figure_designation** | **String** | Public figure designation. | [optional] 
**related_spf_country_of_government** | **String** | Senior Public Figure Country of Government | [optional] 
**related_senior_public_figure_department** | **String** | Department Senior Public Figure belongs to | [optional] 
**relationship_with_senior_public_figure** | **String** | Senior Public Figure relationship with applicant | [optional] 
**related_senior_public_figure_last_name** | **String** | Senior Public Figure Last Name | [optional] 
**us_tax_status** | **String** | US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values. | [optional] 
**us_tax_id** | **String** | US Tax ID | [optional] 

