# ReadyCreditProductUpdate

## Properties
Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**product_code** | **str** | A unique code that identifies the product | [optional] 
**source_code** | **str** | A source code to identify the product | [optional] 
**organization** | **str** | Card issuing organization name | [optional] 
**logo** | **str** | Product logo to identify the product | [optional] 
**request_credit_shield** | **bool** | Insurance enrolment for outstanding balance on the card. Valid values: true and false | [optional] 
**emboss_name** | **str** | Name to be embossed on card | [optional] 
**billing_address** | **str** | Billing address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**card_delivery_address** | **str** | Card delivery address of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**pin_delivery_address** | **str** | Delivery address  for card pin of applicant. This is a reference data field. Please use /v1/utilities/referenceData/{addressType} resource to get valid value of this field with description. | [optional] 
**requested_credit_limit** | **float** | Credit limit requested by applicant for the product. | [optional] 
**gift_code** | **str** | A  unique code that identifies the gift offered along with the product | [optional] 
**credit_limit_increase_indicator** | **bool** | Option for to review the credit limit in the future.Valid values: true and false | [optional] 
**atm_required_flag** | **bool** | Option to get ATM card along with product. Valid values: true and false | [optional] 
**cheque_book_required_flag** | **bool** | Option to get cheque book along with product. Valid values: true and false | [optional] 
**balance_transfer_details** | [**list[BalanceTransferDetails]**](BalanceTransferDetails.md) |  | [optional] 
**loan_purpose** | **str** | Purpose of loan. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description. | [optional] 
**equal_payment_plan** | [**list[EqualPaymentPlanUpdate]**](EqualPaymentPlanUpdate.md) |  | [optional] 
**credit_limit_accepted_flag** | **bool** | Flag to indicate acceptance of customer for the ready credit limit. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

