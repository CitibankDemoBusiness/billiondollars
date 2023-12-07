# SwaggerClient::ApplicationInquiryBalanceTransferDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount_to_transfer** | **Float** | Amount to Transfer | 
**issuing_organization_name** | **String** | Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/apac/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description. You can use cardIssuingOrganization field name as the referenceCode parameter to retrieve the values. | [optional] 
**account_name** | **String** | Customer&#x27;s account Name | [optional] 
**account_reference_number** | **String** | Customer&#x27;s account reference number with biller. | [optional] 
**biller_code** | **String** | It is a unique code to identify a BPAY biller | 
**campaign_id** | **String** | Campaign code of the balance transfer. | [optional] 

