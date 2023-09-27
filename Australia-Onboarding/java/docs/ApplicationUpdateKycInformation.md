# ApplicationUpdateKycInformation

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**selfPublicFigureDeclarationFlag** | **Boolean** | Flag for self declaration if applicant is public figure. Valid values: true and false |  [optional]
**publicFigureOfficeStatus** | **String** | Flag for status of public office if applicant is public figure |  [optional]
**publicFigureOfficeDetails** | **String** | Office details if applicant is public figure |  [optional]
**publicFigureOfficeStartDate** | [**LocalDate**](LocalDate.md) | Public figure office start date in ISO 8601 date format YYYY-MM-DD |  [optional]
**publicFigureOfficeEndDate** | [**LocalDate**](LocalDate.md) | Public figure office end date in ISO 8601 date format YYYY-MM-DD |  [optional]
**isRelatedToSeniorPublicFigure** | **Boolean** | Self declaration if applicant has any relation with senior public figure. Valid values: true and false |  [optional]
**relatedSeniorPublicFigureName** | **String** | Senior Public Figure Name |  [optional]
**relatedSpfCountryOfGovernment** | **String** | Senior Public Figure Country of Government |  [optional]
**relatedSeniorPublicFigureDepartment** | **String** | Department Senior Public Figure belongs to |  [optional]
**relationshipWithSeniorPublicFigure** | **String** | Senior Public Figure relationship with applicant |  [optional]
**relatedSeniorPublicFigureLastName** | **String** | Senior Public Figure Last Name |  [optional]
**usTaxStatus** | **String** | US Tax status. This is a reference data data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values. |  [optional]
**usTaxId** | **String** | US Tax ID |  [optional]
