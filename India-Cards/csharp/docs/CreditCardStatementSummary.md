# IO.Swagger.Model.CreditCardStatementSummary
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardId** | **string** | The card id  in encrypted format | 
**DisplayAccountNumber** | **string** | A masked account number that can be displayed to the customer | 
**EligibleSourceAcctsForPaymentFlag** | **bool?** | ’Flag to indicate if eligible source accounts are available to make credit card payment on-line. | [optional] 
**EppEligibleAmount** | **double?** | Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**EppMinimumEligibleAmount** | **double?** | Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**EppMinimumInstallmentAmount** | **double?** | Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. | [optional] 
**CreditCardStatement** | [**List&lt;CreditCardStatement&gt;**](CreditCardStatement.md) |  | [optional] 
**StatementSummaryErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  | [optional] 
**NextStartIndex** | **string** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

