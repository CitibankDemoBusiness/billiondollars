# EppRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**epp_loan_booking_type** | **str** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**tenor** | **float** | Tenure of loan in months. | [optional] 
**loan_amount** | **float** | Eligible loan amount. Applicable only for EPP of type STATEMENT. | [optional] 
**transaction_reference_ids** | [**list[TransactionReferenceId]**](TransactionReferenceId.md) |  | [optional] 
**transaction_authorization_codes** | [**list[TransactionAuthorizationCodes]**](TransactionAuthorizationCodes.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

