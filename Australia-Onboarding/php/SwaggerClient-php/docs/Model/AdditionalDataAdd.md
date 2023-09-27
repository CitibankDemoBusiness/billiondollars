# AdditionalDataAdd

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_fund_source** | **string** | This field is to indicates the primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**number_of_dependents** | **float** | Number of dependents | [optional] 
**staff_indicator** | **bool** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**business_nature** | **string** | Business nature of the applicant This is a reference data field. Please use /v1/utilities/referenceData/{businessNature} resource to get valid value of this field with description. | [optional] 
**emergency_contact_name** | **string** | Emergency contact given name | [optional] 
**emergency_contact_surname** | **string** | Emergency contact surname | [optional] 
**emergency_contact_relationship** | **string** | Applicant&#x27;s relationship with the emergency contact.This is a reference data. Please use /v1/utilities/referenceData/{emergencyContactRelationship} resource to get valid value of this field | [optional] 
**emergency_contact_phone_number** | **string** | Emergency contact Number. | [optional] 
**over_limit_consent_flag** | **bool** | Customer consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**country_specific_group** | [**\Swagger\Client\Model\CountrySpecificGroup**](CountrySpecificGroup.md) |  | [optional] 
**primary_bank_details** | [**\Swagger\Client\Model\PrimaryBankDetails**](PrimaryBankDetails.md) |  | [optional] 
**referral_given_name** | **string** | Referral First Name. | [optional] 
**referral_surname** | **string** | Referral Surname/Last Name. | [optional] 
**referral_code** | **string** | Referral Code used for the customer | [optional] 
**media_id** | **string** | The media ID will be used to determine which offer / campaign banner was clicked when the customer made his application | [optional] 
**introducer_id** | **string** | Unique identifier associated with the introducer who had referred the applicant. | [optional] 
**related_to_citi_employee_flag** | **bool** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**related_citi_employee_name** | **string** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**related_citi_employee_department** | **string** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**credit_card_usage_purpose** | **string** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 
**cash_pin_flag** | **bool** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**referral_tracking** | [**\Swagger\Client\Model\ReferralTracking**](ReferralTracking.md) |  | [optional] 
**utility_bill_details** | [**\Swagger\Client\Model\UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**fee_code** | **string** | Fee code that applied to the requested product | [optional] 
**billing_cycle_day** | **string** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**application_reference_id** | **string** | Unique reference ID associated with the application | [optional] 
**customer_segment** | **string** | Customer segment decides each applicants interest rate  Different customer target will be subjected to different interest rate..This is a reference data field. Please use /v1/utilities/referenceData/{customerSegment} resource to get valid value of this field with description. | [optional] 
**printing_serial_number** | **string** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**additional_information** | **string** | This field refers to the additional comments given by the customer which is to be noted-down during the application process. | [optional] 
**trade_reference_details** | [**\Swagger\Client\Model\TradeReferenceDetails**](TradeReferenceDetails.md) |  | [optional] 
**bureau_session_id_** | **string** | Session ID that is generated from the session / interaction of channel with bureau. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

