# IO.Swagger.Model.ExecutePaymentInitiationTransactionMultipleTransfersAsyncRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BundleId** | **string** | This is bundle id or unique identifier for bulk transfers | [optional] 
**TotalTransferAmount** | **double?** | This is total transfer amount | [optional] 
**TypeOfTransfers** | **string** | This is type of transfers | [optional] 
**SourceAccountId** | **string** | The source account identifier in encrypted format.Typically, this is not displayed to the customer. | [optional] 
**InternalDomesticPayments** | [**List&lt;InternalDomesticPayments&gt;**](InternalDomesticPayments.md) |  | [optional] 
**ExternalDomesticPayments** | [**List&lt;ExternalDomesticPayments&gt;**](ExternalDomesticPayments.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

