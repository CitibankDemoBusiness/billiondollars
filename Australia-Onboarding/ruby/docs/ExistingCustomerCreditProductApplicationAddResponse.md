# SwaggerClient::ExistingCustomerCreditProductApplicationAddResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**application_id** | **String** | Unique identifier for the application | 
**application_stage** | **String** | Application stage of an Application | 
**survivor_line_required_flag** | **BOOLEAN** | This indicates whether customer requires a Survivor Line product (Credit Card) or not. Valid values: true and false | [optional] 
**existing_credit_limit** | **Float** | Credit limit of customer for the existing credit card | [optional] 
**display_applicant_details** | [**DisplayApplicantDetails**](DisplayApplicantDetails.md) |  | 
**control_flow_id** | **String** | Control flow id is used to control the flow for subsequent requests in the session. | [optional] 

