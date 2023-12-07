# UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**applicationStage** | **String** | Current stage of an application.This is a reference data field. Please use /v1/utilities/referenceData/{applicationStage} resource to get possible value of this field with description. |  [optional]
**ipaExpiryDate** | [**LocalDate**](LocalDate.md) | In principle approval expiration date in ISO 8601 date format YYYY-MM-DD |  [optional]
**requestedLoanTopupDecision** | [**RequestedLoanTopupDecision**](RequestedLoanTopupDecision.md) |  |  [optional]
