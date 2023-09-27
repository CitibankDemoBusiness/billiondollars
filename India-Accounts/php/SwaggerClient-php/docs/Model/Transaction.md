# Transaction

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**display_account_number** | **string** | A masked account number that can be displayed to the customer | [optional] 
**transaction_date** | [**\DateTime**](\DateTime.md) | Transaction date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting, | [optional] 
**transaction_description** | **string** | Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country. | [optional] 
**transaction_reference_id** | **string** | Reference Id to uniquely identify the transaction | [optional] 
**check_serial_number** | **string** | The check serial number. Applicable for checking accounts only | [optional] 
**transaction_amount** | **double** | Transaction amount in local currency. | [optional] 
**currency_code** | **string** | The currency code of the transaction in ISO 4217 format | [optional] 
**foreign_transaction_amount** | **float** | The transaction amount in the foreign currency | [optional] 
**foreign_currency_code** | **string** | The foreign currency code of the transaction in ISO 4217 format | [optional] 
**foreign_exchange_rate** | **float** | The exchange rate at the time the foreign transaction was done | [optional] 
**transaction_type** | **string** | The type of transaction. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionType} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**transaction_status** | **string** | The status of the transaction.  Applicable for credit cards only.. This is a reference data field. Please use /v1/apac/utilities/referenceData/{transactionStatus} resource to get possible values of this field with descriptions. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 
**running_balance** | **double** | The amount available to transact immediately | [optional] 
**transaction_posting_date** | [**\DateTime**](\DateTime.md) | Transaction posting date in YYYY-MM-DD format value conforming to ISO 8601. This needs to be formatted in front-end for country/locale specific display purposes. This is the field used for default sorting | [optional] 
**transaction_code** | **string** | The transaction code | [optional] 
**merchant_name** | **string** | The merchant name with which this transaction was made with | [optional] 
**eligible_for_equal_payment_plan** | **string** | The EPP allowed indicator. This is applicable for credit cards transactions only. This is a reference data field. Please use /v1/apac/utilities/referenceData/{eligibleForEqualPaymentPlan} resource to get possible value of This field with description. You can use the field name as the referenceCode parameter to retrieve the values | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

