# AccountCurrencyDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountId** | **String** | The customer account identifier in encrypted format |  [optional]
**newAccountOpenedFlag** | **Boolean** | This field is to indicate if the  account is newly opened or not. | 
**globalWalletAccountType** | **String** | Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions. |  [optional]
**enrollmentStatusFlag** | **Boolean** | Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet). |  [optional]
