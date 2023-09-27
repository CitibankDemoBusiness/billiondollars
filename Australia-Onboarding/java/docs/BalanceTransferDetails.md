# BalanceTransferDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**amountToTransfer** | **Double** | Amount to Transfer | 
**issuingOrganizationName** | **String** | Name of the Organization to which the fund has to be transferred. This is a reference data field. Please use /v1/utilities/referenceData/{cardIssuingOrganization} resource to get valid value of this field with description. |  [optional]
**accountName** | **String** | Customer&#x27;s account Name |  [optional]
**accountReferenceNumber** | **String** | Customer&#x27;s account reference number with biller. |  [optional]
**billerCode** | **String** | It is a unique code to identify a BPAY biller |  [optional]
**campaignId** | **String** | Campaign code of the balance transfer. |  [optional]
**paymentType** | **String** | Mode of payment.This is a reference data field. Please use /v1/apac/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType field name as the referenceCode parameter to retrieve the values. |  [optional]
**bsbCode** | **String** | BSB Code for EFT payment mode. |  [optional]
