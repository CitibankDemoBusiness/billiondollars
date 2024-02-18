# IO.Swagger.Model.ApplicationAddKycInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SelfPublicFigureDeclarationFlag** | **bool?** | Flag for self declaration if applicant is public figure. Valid values: true and false | [optional] 
**PublicFigureOfficeStatus** | **string** | Flag for status of public office if applicant is public figure | [optional] 
**PublicFigureOfficeDetails** | **string** | Office details if applicant is public figure | [optional] 
**PublicFigureOfficeStartDate** | **DateTime?** | Public figure office start date in ISO 8601 date format YYYY-MM-DD | [optional] 
**PublicFigureOfficeEndDate** | **DateTime?** | Public figure office end date in ISO 8601 date format YYYY-MM-DD | [optional] 
**IsRelatedToSeniorPublicFigure** | **bool?** | Self declaration if applicant has any relation with senior public figure. Valid values: true and false | [optional] 
**RelatedSeniorPublicFigureName** | **string** | Senior Public Figure Name | [optional] 
**RelatedSpfCountryOfGovernment** | **string** | Senior Public Figure Country of Government | [optional] 
**RelatedSeniorPublicFigureDepartment** | **string** | Department Senior Public Figure belongs to | [optional] 
**RelationshipWithSeniorPublicFigure** | **string** | Senior Public Figure relationship with applicant | [optional] 
**RelatedSeniorPublicFigureLastName** | **string** | Senior Public Figure Last Name | [optional] 
**UsTaxStatus** | **string** | US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values. | [optional] 
**UsTaxId** | **string** | US Tax ID | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

