# DataProductDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**name** | **String** | Product name | 
**description** | **String** | Product description | 
**productType** | [**ProductTypeEnum**](#ProductTypeEnum) | Type of product | 
**subProductType** | [**SubProductTypeEnum**](#SubProductTypeEnum) | Type of sub-product |  [optional]
**shariahCompliance** | **Boolean** | The indicator for Islamic or Conventional card | 
**shariahComplianceRemark** | **String** | Approval body for shariah compliance |  [optional]
**cardType** | [**CardTypeEnum**](#CardTypeEnum) | Type of card | 
**pdsUrl** | **String** | URL for product disclosure sheet | 
**imageUrl** | **String** | Absolute URL to image in SVG format |  [optional]
**disclaimerUrl** | **String** | Absolute URL for product disclaimer |  [optional]

<a name="ProductTypeEnum"></a>
## Enum: ProductTypeEnum
Name | Value
---- | -----
AMERICAN_EXPRESS | &quot;american_express&quot;
JCB | &quot;jcb&quot;
MASTERCARD | &quot;mastercard&quot;
MYDEBIT | &quot;mydebit&quot;
OTHERS | &quot;others&quot;
SWITCH | &quot;switch&quot;
UNIONPAY | &quot;unionpay&quot;
VISA | &quot;visa&quot;

<a name="SubProductTypeEnum"></a>
## Enum: SubProductTypeEnum
Name | Value
---- | -----
BLACK | &quot;black&quot;
CLASSIC | &quot;classic&quot;
COMMERCIAL | &quot;commercial&quot;
DIAMOND | &quot;diamond&quot;
ELECTRON | &quot;electron&quot;
GENERIC | &quot;generic&quot;
GOLD | &quot;gold&quot;
INFINITE | &quot;infinite&quot;
INFINITE_PRIVILEGE | &quot;infinite_privilege&quot;
MAESTRO | &quot;maestro&quot;
OTHERS | &quot;others&quot;
PLATINUM | &quot;platinum&quot;
RESERVE | &quot;reserve&quot;
SIGNATURE | &quot;signature&quot;
WORLD | &quot;world&quot;
WORLD_ELITE | &quot;world_elite&quot;

<a name="CardTypeEnum"></a>
## Enum: CardTypeEnum
Name | Value
---- | -----
CREDIT_CARD | &quot;credit_card&quot;
DEBIT_CARD | &quot;debit_card&quot;
CHARGE_CARD | &quot;charge_card&quot;
PREPAID_CARD | &quot;prepaid_card&quot;
