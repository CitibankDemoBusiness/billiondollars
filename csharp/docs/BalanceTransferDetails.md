# IO.Swagger.Model.BalanceTransferDetails
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AmountToTransfer** | **double?** | Amount to Transfer | 
**IssuingOrganizationName** | **string** | Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description. | [optional] 
**AccountName** | **string** | Customer&#x27;s account Name | [optional] 
**AccountReferenceNumber** | **string** | Customer&#x27;s account reference number with biller. | [optional] 
**BillerCode** | **string** | It is a unique code to identify a BPAY biller | [optional] 
**CampaignId** | **string** | Campaign code of the balance transfer. | [optional] 
**PaymentType** | **string** | Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values. | [optional] 
**BsbCode** | **string** | BSB Code for EFT payment mode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

