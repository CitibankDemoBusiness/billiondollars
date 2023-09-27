# SwaggerClient::BalanceTransferDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amount_to_transfer** | **Float** | Amount to Transfer | 
**issuing_organization_name** | **String** | Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description. | [optional] 
**account_name** | **String** | Customer&#x27;s account Name | [optional] 
**account_reference_number** | **String** | Customer&#x27;s account reference number with biller. | [optional] 
**biller_code** | **String** | It is a unique code to identify a BPAY biller | [optional] 
**campaign_id** | **String** | Campaign code of the balance transfer. | [optional] 
**payment_type** | **String** | Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values. | [optional] 
**bsb_code** | **String** | BSB Code for EFT payment mode. | [optional] 

