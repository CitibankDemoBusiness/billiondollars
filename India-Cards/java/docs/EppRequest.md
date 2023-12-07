# EppRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**eppLoanBookingType** | **String** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. |  [optional]
**loanAmount** | **Double** | Eligible loan amount. Applicable only for EPP of type STATEMENT. |  [optional]
**transactionReferenceIds** | [**List&lt;TransactionReferenceId&gt;**](TransactionReferenceId.md) |  |  [optional]
**transactionAuthorizationCodes** | [**List&lt;TransactionAuthorizationCodes&gt;**](TransactionAuthorizationCodes.md) |  |  [optional]
