# CreditCardStatementSummary

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cardId** | **String** | The card id  in encrypted format | 
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer | 
**eligibleSourceAcctsForPaymentFlag** | **Boolean** | ’Flag to indicate if eligible source accounts are available to make credit card payment on-line. |  [optional]
**eppEligibleAmount** | **Double** | Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. |  [optional]
**eppMinimumEligibleAmount** | **Double** | Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. |  [optional]
**eppMinimumInstallmentAmount** | **Double** | Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan&#x3D;&#x27;ELIGIBLE&#x27;. |  [optional]
**creditCardStatement** | [**List&lt;CreditCardStatement&gt;**](CreditCardStatement.md) |  |  [optional]
**statementSummaryErrorDetails** | [**ErrorResponse**](ErrorResponse.md) |  |  [optional]
**nextStartIndex** | **String** | In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data. |  [optional]
