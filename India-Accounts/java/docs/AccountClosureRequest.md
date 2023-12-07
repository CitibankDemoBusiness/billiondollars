# AccountClosureRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **String** | The account identifier in encrypted format.Typically, this is not displayed to the customer | 
**accountClosureReasonCode** | **String** | Account closure reason code. This is a reference data field. Please use /v1/apac/utilities/referenceData/{accountClosureReasonCode} resource to get valid value of this field with description. |  [optional]
**consentGivenFlag** | **Boolean** | This is consent flag from the customer to pay back if any outstanding on that account while closure | 
