# IO.Swagger.Model.ApplicationUpdateBalanceTransferDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountToTransfer** | **double?** | Amount to Transfer | 
**IssuingOrganizationName** | **string** | Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description. You can use cardIssuingOrganization field name as the referenceCode parameter to retrieve the values. | [optional] 
**AccountName** | **string** | Customer&#x27;s account Name | [optional] 
**AccountReferenceNumber** | **string** | Customer&#x27;s account reference number with biller. | [optional] 
**BillerCode** | **string** | It is a unique code to identify a BPAY biller | 
**CampaignId** | **string** | Campaign code of the balance transfer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

