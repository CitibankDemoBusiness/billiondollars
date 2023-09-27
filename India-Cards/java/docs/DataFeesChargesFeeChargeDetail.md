# DataFeesChargesFeeChargeDetail

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**item** | [**ItemEnum**](#ItemEnum) |  | 
**chargeable** | **Boolean** | Indicator of chargeability |  [optional]
**amount** | **Double** | Amount for fee and charge up to two digits decimal |  [optional]
**amountCurrencyCode** | **String** | ISO-4217 3 characters currency code for fee and charge amount |  [optional]
**percentage** | **Double** | Percentage of amount for fee and charge up to two digits decimal |  [optional]
**remark** | **String** | Additional notes for the fee and charge |  [optional]

<a name="ItemEnum"></a>
## Enum: ItemEnum
Name | Value
---- | -----
ACTUAL_MONTHLY_MANAGEMENT | &quot;actual_monthly_management&quot;
ANNUAL | &quot;annual&quot;
ATM_WITHDRAWAL | &quot;atm_withdrawal&quot;
CARD_REPLACEMENT | &quot;card_replacement&quot;
CASH_ADVANCE | &quot;cash_advance&quot;
CASH_WITHDRAWAL | &quot;cash_withdrawal&quot;
EARLY_SETTLEMENT | &quot;early_settlement&quot;
FINANCE_CHARGE_CASH_ADVANCE | &quot;finance_charge_cash_advance&quot;
FINANCE_CHARGE_RETAIL | &quot;finance_charge_retail&quot;
FIXED_MONTHLY_MANAGEMENT | &quot;fixed_monthly_management&quot;
LATE_PAYMENT | &quot;late_payment&quot;
MINIMUM_MONTHLY_PAYMENT | &quot;minimum_monthly_payment&quot;
OTHERS | &quot;others&quot;
OVERSEA_TRANSACTION | &quot;oversea_transaction&quot;
OVERSEA_TRANSACTION_CONVERSION | &quot;oversea_transaction_conversion&quot;
SALES_DRAFT_RETRIEVAL_COPY | &quot;sales_draft_retrieval_copy&quot;
SERVICE_TAX | &quot;service_tax&quot;
STARTER_PACK | &quot;starter_pack&quot;
STATEMENT_COPY | &quot;statement_copy&quot;
