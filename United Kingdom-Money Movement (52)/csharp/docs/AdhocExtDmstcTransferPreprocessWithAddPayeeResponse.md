# IO.Swagger.Model.AdhocExtDmstcTransferPreprocessWithAddPayeeResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ControlFlowId** | **string** | Control flow Id | 
**DebitDetails** | [**DebitDetails**](DebitDetails.md) |  | 
**CreditDetails** | [**CreditDetails**](CreditDetails.md) |  | 
**ForeignExchangeRate** | **double?** | Exchange rate | [optional] 
**ForexType** | **string** | This is an indicator if exchange rate received from host is Counter or Live. This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexType} resource to get valid value of this field with description. | [optional] 
**ForexConversionIndicator** | **string** | This is the indicator if FX rate sent in response is computed on one Unit of Source Currency to Destination currency or one Unit of Destination Currency to Source Currency.This is a reference data field. Please use /v1/apac/utilities/referenceData/{forexConversionIndicator} resource to get valid value of this field with description. | [optional] 
**TransactionFee** | **double?** | Transaction fee | [optional] 
**FeeCurrencyCode** | **string** | Fee currency code in  ISO 4217 format. | [optional] 
**LocalCurrencyTransactionFee** | **double?** | This is the transactionFee in local currency | [optional] 
**LocalCurrencyCode** | **string** | Local currency code in ISO 4217 Format. | [optional] 
**PaymentPriority** | **string** | Priority to the payment used to identify urgency. This is a reference data field. Please use /v1/utilities/referenceData/{paymentPriority} resource to get valid value of this field with description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

