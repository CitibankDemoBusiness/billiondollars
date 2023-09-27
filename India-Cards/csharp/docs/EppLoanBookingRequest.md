# IO.Swagger.Model.EppLoanBookingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EppLoanBookingType** | **string** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**Tenor** | [**decimal?**](BigDecimal.md) | Tenure of loan in months. | 
**EppLoanBooking** | [**List&lt;EppLoanBooking&gt;**](EppLoanBooking.md) | EPP Loan Booking Pre-process | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

