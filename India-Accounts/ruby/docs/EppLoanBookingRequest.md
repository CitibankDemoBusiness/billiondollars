# SwaggerClient::EppLoanBookingRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**epp_loan_booking_type** | **String** | Type of the easy payment plan loan booking.This is a reference data field. Please use /v1/apac/utilities/referenceData/{eppLoanBookingType} resource to get possible value of this field with description. | 
**tenor** | [**BigDecimal**](BigDecimal.md) | Tenure of loan in months. | 
**epp_loan_booking** | [**Array&lt;EppLoanBooking&gt;**](EppLoanBooking.md) | EPP Loan Booking Pre-process | 

