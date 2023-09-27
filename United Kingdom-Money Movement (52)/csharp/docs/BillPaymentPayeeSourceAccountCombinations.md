# IO.Swagger.Model.BillPaymentPayeeSourceAccountCombinations
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PayeeId** | **string** | Unique identifier associated with the payee. Typically, this is not displayed to the customer. | 
**DisplayPayeeAccountNumber** | **string** | The display account number of the destination account. | [optional] 
**PayeeAccountCurrencyCode** | **string** | The currency code of the payee account in ISO 4217 format. | 
**PayeeName** | **string** | Name of the payee. Applicable only for Australia. | [optional] 
**PayeeNickName** | **string** | Payee account nick name. | 
**MerchantNumber** | **string** | Unique identifier associated with the merchant. Applicable only for Australia. | [optional] 
**BillTypeCode** | **string** | Bill Type Code is the sub category for the Merchant. Bill Payment Transaction  can be uniquely identified by the combination of the merchant number &amp; billTypeCode | [optional] 
**SourceAccountIds** | [**List&lt;SourceAccountIds&gt;**](SourceAccountIds.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

