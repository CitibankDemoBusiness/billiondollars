# NotifyCreditChargeCardFulfillmentArrangementAuthorisedTransactionRequest

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**requestId** | **String** | This field provides the unique request ID generated from the VOX platform. Will be used for tracking and audit purposes | 
**vopTransactionId** | **String** | This field specifies the VOP transaction ID of the original transaction, that triggered the reward. | 
**actionType** | **String** | This field specifies the action to be performed for the request.Valid Value is Notify | 
**distributorId** | **String** | This field specifies the Distributor ID. Important when an aggregator (who is serving for more than one distributor) is building the API end point. | 
**cardId** | **String** | This field provides the card id generated during cardholder enrolment at VOX. | 
**userId** | **String** | This field provides the external user id generated during cardholder enrolment at VOX. | 
**creditStatus** | **String** | This field specifies the reward credit status.Valid Values are Successful, Eligible, Failed | 
**requestDateTime** | **String** | This field specifies the date and time which the reward request is initiated in the format YYYY-MM-DD HH:MM:SS | 
**offerId** | **Integer** | This will be the VOX qualified offer ID, which the reward is given, Will be used for tracking and audit purposes. | 
**settlementCurrency** | **String** | This field specifies the reward currency of the original offer | 
**rewardSettlementCurrency** | **Double** | This field specifies the cashback reward value in Settlement Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**billingCurrency** | **String** | This field specifies the customer purchase currency derived from the VOP transaction. | 
**rewardBillingCurrency** | **Double** | This field specifies the cashback reward value in Settlement Billing Currency.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**merchantName** | **String** | This field provides the merchant name | 
**transactionDate** | **String** | This field specifies the transaction date retrieved from the VOP Transaction in the format YYYY-MM-DD HH:MM:SS | 
**transactionBillingAmount** | **Double** | This field specifies transaction amount in billing currency as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**transactionSettlementAmount** | **Double** | This field specifies transaction amount in settlement currency  as received from the VOP transaction.If the amount is in round figure for an example 100 then the amount should be passed as per format 100.00 | 
**remarks** | **String** | This field is used to pass additional information required by the partner for their records. This can pass an empty value as well. |  [optional]
