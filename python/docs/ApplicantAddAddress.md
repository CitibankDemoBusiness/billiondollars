# ApplicantAddAddress

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**address_type** | **str** | Type of the address. This is a reference data field. Please use /utilities/referenceData/{addressType} resource to get valid values of this field with descriptions. You can use addressType as the referenceCode parameter to retrieve the values. | [optional] 
**address_line1** | **str** | Address line 1 | [optional] 
**address_line2** | **str** | Address line 2 | [optional] 
**address_line3** | **str** | Address line 3 | [optional] 
**address_line4** | **str** | Address line 4 | [optional] 
**city_name** | **str** | City | [optional] 
**state** | **str** | State.This is a reference data field. Please use /v1/apac/utilities/referenceData/{addressState} resource to get valid value of this field with description. You can use addressState field name as the referenceCode parameter to retrieve the values. | [optional] 
**postal_code** | **str** | Postal/ZIP code | [optional] 
**country_code** | **str** | ISO country code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{country} resource to get valid value of this field with description. You can use countryCode field name as the referenceCode parameter to retrieve the values. | [optional] 
**residence_duration_in_years** | **int** | Applicant&#x27;s residence duration in the current address in years | [optional] 
**residence_duration_in_months** | **int** | Applicant&#x27;s residence duration in the current address in months | [optional] 
**country_specific_address** | [**ApplicantAddCountrySpecificAddress**](ApplicantAddCountrySpecificAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

