# IO.Swagger.Model.AdditionalDataUpdate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountFundSource** | **string** | This field is to indicates the primary source from which this account will be funded. This is a reference data field. Please use /v1/utilities/referenceData/{accountFundSource} resource to get valid value of this field with description. | [optional] 
**NumberOfDependents** | [**decimal?**](BigDecimal.md) | Number of dependants | [optional] 
**StaffIndicator** | **bool?** | Flag to indicates if applicant is a Citi Staff. Valid values: true and false | [optional] 
**OtpAuthenticationSuccessFlag** | **bool?** | Flag to indicate if customer is authenticated successfully | [optional] 
**BureauDataPrePopulateConsentFlag** | **bool?** | Flag to capture applicant&#x27;s consent for Bureau Data Prepopulation | [optional] 
**BusinessNature** | **string** | Business nature of the applicant. This is a reference data data field. Please use /v1/utilities/referenceData/{businessNature} resource to get valid value of this field with description. | [optional] 
**EmergencyContactName** | **string** | Emergency contact given name | [optional] 
**EmergencyContactSurname** | **string** | Emergency contact surname | [optional] 
**EmergencyContactRelationship** | **string** | Applicant&#x27;s relationship with the emergency contact.This is a reference data. Please use /v1/utilities/referenceData/{emergencyContactRelationship} resource to get valid value of this field | [optional] 
**EmergencyContactPhoneNumber** | **string** | Emergency Contact Number. | [optional] 
**OverLimitConsentFlag** | **bool?** | Customer Consent on spending more than the limit assigned to him. Valid values: true and false | [optional] 
**CountrySpecificGroup** | [**CountrySpecificGroup**](CountrySpecificGroup.md) |  | [optional] 
**PrimaryBankDetails** | [**PrimaryBankDetails**](PrimaryBankDetails.md) |  | [optional] 
**ReferralGivenName** | **string** | Referral First Name. | [optional] 
**ReferralSurname** | **string** | Referral Surname/Last Name. | [optional] 
**IntroducerId** | **string** | Unique identifier associated with the introducer who had referred the applicant. | [optional] 
**RelatedToCitiEmployeeFlag** | **bool?** | Self declaration if applicant has any relation with citi bank employee. Valid values: true and false | [optional] 
**RelatedCitiEmployeeName** | **string** | Name of the citi employee if applicant has any relation with citi bank employee. | [optional] 
**RelatedCitiEmployeeDepartment** | **string** | Department of citi employee if applicant has any relation with citi bank employee. | [optional] 
**CreditCardUsagePurpose** | **string** | Indicates applicants usage of credit card whether it is for personal or business.Please use /v1/utilities/referenceData/{creditCardUsagePurpose} resource to get valid value of this field with description. | [optional] 
**CashPinFlag** | **bool?** | Indicates whether the customer wants a separate cash PIN. | [optional] 
**MediaId** | **string** | The media ID will be used to determine which offer / campaign banner was clicked when the customer made his application  | [optional] 
**ReferralCode** | **string** | Referral Code used for the customer | [optional] 
**ReferralTracking** | [**ReferralTracking**](ReferralTracking.md) |  | [optional] 
**UtilityBillDetails** | [**UtilityBillDetails**](UtilityBillDetails.md) |  | [optional] 
**FeeCode** | **string** | Fee code that applied to the requested product | [optional] 
**BillingCycleDay** | **string** | Day of each month for the bill payment. This is a reference data field. Please use /v1/utilities/referenceData/{billingCycleDay} resource to get valid value of this field with description. | [optional] 
**ApplicationReferenceId** | **string** | Unique reference ID associated with the application | [optional] 
**CustomerSegment** | **string** | Customer segment decides each applicant’s interest rate  Different customer target will be subjected to different interest rate..This is a reference data field. Please use /v1/utilities/referenceData/{customerSegment} resource to get valid value of this field with description.  | [optional] 
**PrintingSerialNumber** | **string** | This field refers to the unique number for each application to be identified by COLA and printed in PDF form.It enables to identify the customer in case the customer could not complete filling his/her details and was dropped-off in between | [optional] 
**AdditionalInformation** | **string** | This field refers to the additional comments given by the customer which is to be noted-down during the application process. | [optional] 
**TradeReferenceDetails** | [**TradeReferenceDetails**](TradeReferenceDetails.md) |  | [optional] 
**BureauSessionId_** | **string** | Session ID that is generated from the session / interaction of channel with bureau. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

