# ExistingCustomerCreditProductApplicationAddResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicationId** | **String** | Unique identifier for the application | 
**applicationStage** | **String** | Application stage of an Application | 
**survivorLineRequiredFlag** | **Boolean** | This indicates whether customer requires a Survivor Line product (Credit Card) or not. Valid values: true and false |  [optional]
**existingCreditLimit** | **Double** | Credit limit of customer for the existing credit card |  [optional]
**displayApplicantDetails** | [**DisplayApplicantDetails**](DisplayApplicantDetails.md) |  | 
**controlFlowId** | **String** | Control flow id is used to control the flow for subsequent requests in the session. |  [optional]
