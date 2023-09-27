# IO.Swagger.Model.MultiCurrencyAccountEligibility
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayCardNumber** | **string** | A masked card number that can be displayed to the customer. | 
**CardId** | **string** | The customer card identifier in encrypted format | 
**AtmCardFlag** | **bool?** | Flag to identify if the cardNumbre in response is ATM card. | [optional] 
**CardEnrollmentStatus** | **string** | This field is to indicate if the  card is enrolled for Multi Currency Account or not.Please use /v1/apac/utilities/referenceData/{cardEnrollmentStatus} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values. | [optional] 
**EligibleForCurrencyAddition** | **string** | Eligible to add new currency.This is a reference data field. Please use /utilities/referenceData/{ eligibleForCurrencyAddition} resource to get valid value of this field with description. | [optional] 
**RelationshipId** | **string** | The customer relationship identifier in encrypted format | [optional] 
**RelationshipIdType** | **string** | The type of customer relationship | [optional] 
**AccountDetails** | [**List&lt;AccountDtls&gt;**](AccountDtls.md) |  | [optional] 
**CurrencyDetails** | [**List&lt;CurrencyDetails&gt;**](CurrencyDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

