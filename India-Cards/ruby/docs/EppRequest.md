# SwaggerClient::EppRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**epp_loan_booking_type** | **String** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | [optional] 
**loan_amount** | **Float** | Eligible loan amount. Applicable only for EPP of type STATEMENT. | [optional] 
**transaction_reference_ids** | [**Array&lt;TransactionReferenceId&gt;**](TransactionReferenceId.md) |  | [optional] 
**transaction_authorization_codes** | [**Array&lt;TransactionAuthorizationCodes&gt;**](TransactionAuthorizationCodes.md) |  | [optional] 

