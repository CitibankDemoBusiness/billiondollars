# Transaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **str** | A masked account number that can be displayed to the customer | [optional] 
**transaction_date** | **date** | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | [optional] 
**transaction_description** | **str** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**transaction_reference_id** | **str** | Reference Id to uniquely identify the transaction | [optional] 
**check_serial_number** | **str** | The check serial number. Applicable for checking accounts only | [optional] 
**transaction_amount** | **float** | Transaction amount in local currency. | [optional] 
**currency_code** | **str** | The currency code of the transaction in ISO 4217 format | [optional] 
**foreign_transaction_amount** | **float** | The transaction amount in the foreign currency | [optional] 
**foreign_currency_code** | **str** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**foreign_exchange_rate** | **float** | The exchange rate at the time the foreign transaction was done | [optional] 
**transaction_type** | **str** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**transaction_status** | **str** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**running_balance** | **float** | The amount available to transact immediately | [optional] 
**transaction_posting_date** | **date** | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**transaction_code** | **str** | The transaction code | [optional] 
**merchant_name** | **str** | The merchant name with which this transaction was made with | [optional] 
**eligible_for_equal_payment_plan** | **str** | The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

