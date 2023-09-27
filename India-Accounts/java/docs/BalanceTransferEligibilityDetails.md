# BalanceTransferEligibilityDetails

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**accountId** | **String** | The account id  in encrypted format. | 
**displayAccountNumber** | **String** | A masked account number that can be displayed to the customer. | 
**btSupportedAccountGroup** | **String** | This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description. |  [optional]
**maximumEligibleLoanAmount** | **Double** | This field indicates the maximum eligible amount for loan. | 
**minimumEligibleLoanAmount** | **Double** | This field indicates the minimum eligible amount for loan. |  [optional]
**btDisbursementOptions** | [**List&lt;BtDisbursementOptions&gt;**](BtDisbursementOptions.md) |  | 
**paymentPans** | [**List&lt;PaymentPans&gt;**](PaymentPans.md) |  |  [optional]
