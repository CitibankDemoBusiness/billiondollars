# SuggestedDisbursementAccount

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer |  [optional]
**accountReferenceKey** | **String** | Account reference key for linking account in a customer session. |  [optional]
**accountType** | **String** | Type of the account. This is a reference data field. Please use /v1/utilities/referenceData/{accountType} resource to get valid value of this field with description. |  [optional]
**bankName** | **String** | bank name to be displayed to customer |  [optional]
**currentDdaFlag** | **Boolean** | Identifies whether account is current direct disbursement account or not. Valid values: true and false |  [optional]
