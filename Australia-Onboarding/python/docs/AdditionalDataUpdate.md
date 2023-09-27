# AdditionalDataUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_fund_source** | **str** | This field is to indicates the primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**number_of_dependents** | **float** | Number of dependants | [optional] 
**staff_indicator** | **bool** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**otp_authentication_success_flag** | **bool** | Flag to indicate if customer is authenticated successfully | [optional] 
**bureau_data_pre_populate_consent_flag** | **bool** | Flag to capture applicant&#x27;s consent for Bureau Data Prepopulation | [optional] 
**business_nature** | **str** | Business nature of the applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{businessNature} resource to get valid value of this field with description. | [optional] 
**emergency_contact_name** | **str** | Emergency contact given name | [optional] 
**emergency_contact_surname** | **str** | Emergency contact surname | [optional] 
**emergency_contact_relationship** | **str** | Applicant&#x27;s relationship with the emergency contact.This is a reference data. Please use /v1/utilities/referenceData/{emergencyContactRelationship} resource to get valid value of this field | [optional] 
**emergency_contact_phone_number** | **str** | Emergency Contact Number. | [optional] 
**over_limit_consent_flag** | **bool** | Customer Consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**country_specific_group** | [**CountrySpecificGroup**](CountrySpecificGroup.md) |  | [optional] 
**primary_bank_details** | [**PrimaryBankDetails**](PrimaryBankDetails.md) |  | [optional] 
**referral_given_name** | **str** | Referral First Name. | [optional] 
**referral_surname** | **str** | Referral Surname/Last Name. | [optional] 
**introducer_id** | **str** | Unique identifier associated with the introducer who had referred the applicant. | [optional] 
**related_to_citi_employee_flag** | **bool** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**related_citi_employee_name** | **str** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**related_citi_employee_department** | **str** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**credit_card_usage_purpose** | **str** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 
**cash_pin_flag** | **bool** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**media_id** | **str** | The media ID will be used to determine which offer / campaign banner was clicked when the customer made his application  | [optional] 
**referral_code** | **str** | Referral Code used for the customer | [optional] 
**referral_tracking** | [**ReferralTracking**](ReferralTracking.md) |  | [optional] 
**utility_bill_details** | [**UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**fee_code** | **str** | Fee code that applied to the requested product | [optional] 
**billing_cycle_day** | **str** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**application_reference_id** | **str** | Unique reference ID associated with the application | [optional] 
**customer_segment** | **str** | Customer segment decides each applicant’s interest rate  Different customer target will be subjected to different interest rate..This is a reference data field. Please use /v1/utilities/referenceData/{customerSegment} resource to get valid value of this field with description.  | [optional] 
**printing_serial_number** | **str** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**additional_information** | **str** | This field refers to the additional comments given by the customer which is to be noted-down during the application process. | [optional] 
**trade_reference_details** | [**TradeReferenceDetails**](TradeReferenceDetails.md) |  | [optional] 
**bureau_session_id_** | **str** | Session ID that is generated from the session / interaction of channel with bureau. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

