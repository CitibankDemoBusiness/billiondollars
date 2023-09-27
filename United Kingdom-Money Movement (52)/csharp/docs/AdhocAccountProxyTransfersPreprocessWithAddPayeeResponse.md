# IO.Swagger.Model.AdhocAccountProxyTransfersPreprocessWithAddPayeeResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ControlFlowId** | **string** | Control flow Id | 
**DebitDetails** | [**DebitDetails**](DebitDetails.md) |  | [optional] 
**CreditDetails** | [**CreditDetails**](CreditDetails.md) |  | [optional] 
**ForeignExchangeRate** | **double?** | Exchange rate | [optional] 
**ForexType** | **string** | This is an indicator if exchange rate received from host is Counter or Live. This is a reference data field. Please use /v1/utilities/referenceData/{forexType} resource to get valid value of this field with description. | [optional] 
**ForexConversionIndicator** | **string** | This is the indicator if FX rate sent in response is computed on one Unit of Source Currency to Destination currency or one Unit of Destination Currency to Source Currency.This is a reference data field. Please use /v1/utilities/referenceData/{forexConversionIndicator} resource to get valid value of this field with description. | [optional] 
**TransactionFee** | **double?** | Transaction fee | [optional] 
**FeeCurrencyCode** | **string** | Fee currency code in  ISO 4217 format. | [optional] 
**LocalCurrencyTransactionFee** | **double?** | This is the transactionFee in local currency | [optional] 
**LocalCurrencyCode** | **string** | Local currency code in ISO 4217 Format. | [optional] 
**TransactionLimitRange** | **string** | This refers if customer&#x27;s daily limit is witin in defined criteria.Valid values are &lt;50K&#x3D;0 , &gt;50K and &lt;300K&#x3D;1 , &gt;300K &#x3D;2 | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

