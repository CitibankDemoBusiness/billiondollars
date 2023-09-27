# IO.Swagger.Model.Payee
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeId** | **string** | The unique Id of the payee.Typically,this is not displayed to the customer. | 
**PayeeName** | **string** | The name of the payee | 
**PayeeNickname** | **string** | The nickname of the payee | 
**PaymentType** | **string** | The payment type.This is a reference data field. Please use /v1/utilities/referenceData/{paymentType} resource to get valid value of this field with description. You can use paymentType as reference code parameter to retrieve the values. | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer. | 
**AccountId** | **string** | The account identifier of the payee in encrypted format.Typically, this is not displayed to the customer,use displayAccountNumber instead. | 
**CurrencyCode** | **string** | The currency code of the account in ISO 4217 format | [optional] 
**PaymentMethods** | [**List&lt;PaymentMethod&gt;**](PaymentMethod.md) |  | [optional] 
**PayeeStatus** | **string** | The payee status. This is a reference data field. Please use /v1/utilities/referenceData/{payeeStatus} resource to get valid value of this field with description. You can use payeeStatus as reference code parameter to retrieve the values | 
**MerchantNumber** | **string** | Unique identifier associated with the merchant. Applicable only for Australia. | [optional] 
**BillTypeCode** | **string** | Bill Type Code is the sub category for the Merchant. Bill Payment Transaction  can be uniquely identified by the combination of the merchant number &amp; billTypeCode | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

