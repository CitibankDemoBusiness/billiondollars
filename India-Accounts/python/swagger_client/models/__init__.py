# coding: utf-8

# flake8: noqa
"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

# import models into model package
from swagger_client.models.account_access_code_generation_response import AccountAccessCodeGenerationResponse
from swagger_client.models.account_balances_summary_inquiry_response import AccountBalancesSummaryInquiryResponse
from swagger_client.models.account_closure_request import AccountClosureRequest
from swagger_client.models.account_closure_response import AccountClosureResponse
from swagger_client.models.account_consent_details import AccountConsentDetails
from swagger_client.models.account_details_response import AccountDetailsResponse
from swagger_client.models.account_group_summary import AccountGroupSummary
from swagger_client.models.account_info import AccountInfo
from swagger_client.models.account_statement_list_response import AccountStatementListResponse
from swagger_client.models.account_summary import AccountSummary
from swagger_client.models.accounts import Accounts
from swagger_client.models.accounts_group_list import AccountsGroupList
from swagger_client.models.address import Address
from swagger_client.models.amortization_sched import AmortizationSched
from swagger_client.models.amortization_schedule import AmortizationSchedule
from swagger_client.models.applicant import Applicant
from swagger_client.models.applicant_detail import ApplicantDetail
from swagger_client.models.balance_transfer_booking_request import BalanceTransferBookingRequest
from swagger_client.models.balance_transfer_booking_response import BalanceTransferBookingResponse
from swagger_client.models.balance_transfer_bookings import BalanceTransferBookings
from swagger_client.models.balance_transfer_eligibility_details import BalanceTransferEligibilityDetails
from swagger_client.models.balance_transfer_eligibility_response import BalanceTransferEligibilityResponse
from swagger_client.models.bank_details import BankDetails
from swagger_client.models.beneficiary_address import BeneficiaryAddress
from swagger_client.models.beneficiary_bank_detail import BeneficiaryBankDetail
from swagger_client.models.beneficiary_bank_details import BeneficiaryBankDetails
from swagger_client.models.beneficiary_detail import BeneficiaryDetail
from swagger_client.models.binary_data import BinaryData
from swagger_client.models.bt_disbursement_options import BtDisbursementOptions
from swagger_client.models.call_deposit_account import CallDepositAccount
from swagger_client.models.call_deposit_account_summary import CallDepositAccountSummary
from swagger_client.models.checking_account import CheckingAccount
from swagger_client.models.checking_account_summary import CheckingAccountSummary
from swagger_client.models.composite_transaction_details_request import CompositeTransactionDetailsRequest
from swagger_client.models.composite_transaction_details_response import CompositeTransactionDetailsResponse
from swagger_client.models.consent_details import ConsentDetails
from swagger_client.models.consents_details_inquiry_response import ConsentsDetailsInquiryResponse
from swagger_client.models.consents_details_update_request import ConsentsDetailsUpdateRequest
from swagger_client.models.country_specific_address import CountrySpecificAddress
from swagger_client.models.credit_card_account import CreditCardAccount
from swagger_client.models.credit_card_account_balance_summary import CreditCardAccountBalanceSummary
from swagger_client.models.credit_card_account_summary import CreditCardAccountSummary
from swagger_client.models.credit_card_statement import CreditCardStatement
from swagger_client.models.credit_check import CreditCheck
from swagger_client.models.credit_check_request import CreditCheckRequest
from swagger_client.models.credit_check_response import CreditCheckResponse
from swagger_client.models.creditor_details import CreditorDetails
from swagger_client.models.customer_address import CustomerAddress
from swagger_client.models.customer_merchant_reference_details import CustomerMerchantReferenceDetails
from swagger_client.models.customer_name import CustomerName
from swagger_client.models.debtor_details import DebtorDetails
from swagger_client.models.disbursement_option import DisbursementOption
from swagger_client.models.disbursement_options import DisbursementOptions
from swagger_client.models.disbursement_options_response import DisbursementOptionsResponse
from swagger_client.models.easy_payment_plan import EasyPaymentPlan
from swagger_client.models.easy_payment_plans_transaction_eligibility_response import EasyPaymentPlansTransactionEligibilityResponse
from swagger_client.models.employment_details import EmploymentDetails
from swagger_client.models.epp_amortization_schedule import EppAmortizationSchedule
from swagger_client.models.epp_loan_booking import EppLoanBooking
from swagger_client.models.epp_loan_booking_request import EppLoanBookingRequest
from swagger_client.models.epp_loan_booking_response import EppLoanBookingResponse
from swagger_client.models.epp_offers import EppOffers
from swagger_client.models.epp_repayment_scheule_response import EppRepaymentScheuleResponse
from swagger_client.models.epp_transaction import EppTransaction
from swagger_client.models.error_response import ErrorResponse
from swagger_client.models.evaluate_customer_eligibility_assessment_check_pre_login_response import EvaluateCustomerEligibilityAssessmentCheckPreLoginResponse
from swagger_client.models.execute_application_processing_unsecured_loan_topup_offer_acceptance_and_submission_request import ExecuteApplicationProcessingUnsecuredLoanTopupOfferAcceptanceAndSubmissionRequest
from swagger_client.models.expense_details import ExpenseDetails
from swagger_client.models.external_bank_details import ExternalBankDetails
from swagger_client.models.financial_information import FinancialInformation
from swagger_client.models.group_balance import GroupBalance
from swagger_client.models.income_details import IncomeDetails
from swagger_client.models.initiate_application_processing_unsecured_loan_topup_request import InitiateApplicationProcessingUnsecuredLoanTopupRequest
from swagger_client.models.initiate_application_processing_unsecured_loan_topup_response import InitiateApplicationProcessingUnsecuredLoanTopupResponse
from swagger_client.models.initiate_credit_charge_card_fulfillment_arrangement_credit_plan_epp_loan_creation_request import InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationRequest
from swagger_client.models.initiate_credit_charge_card_fulfillment_arrangement_credit_plan_epp_loan_creation_response import InitiateCreditChargeCardFulfillmentArrangementCreditPlanEppLoanCreationResponse
from swagger_client.models.insurance_policy_summary import InsurancePolicySummary
from swagger_client.models.investment_transaction import InvestmentTransaction
from swagger_client.models.list_response import ListResponse
from swagger_client.models.loan import Loan
from swagger_client.models.loan_account import LoanAccount
from swagger_client.models.loan_account_summary import LoanAccountSummary
from swagger_client.models.loan_amortization_schedule import LoanAmortizationSchedule
from swagger_client.models.loan_booking_confirmation_pre_login_request import LoanBookingConfirmationPreLoginRequest
from swagger_client.models.loan_booking_confirmation_pre_login_response import LoanBookingConfirmationPreLoginResponse
from swagger_client.models.loan_booking_confirmation_request import LoanBookingConfirmationRequest
from swagger_client.models.loan_booking_confirmation_response import LoanBookingConfirmationResponse
from swagger_client.models.loan_booking_plan import LoanBookingPlan
from swagger_client.models.loan_booking_plan_response import LoanBookingPlanResponse
from swagger_client.models.loan_booking_pre_login_request import LoanBookingPreLoginRequest
from swagger_client.models.loan_booking_pre_login_response import LoanBookingPreLoginResponse
from swagger_client.models.loan_booking_request import LoanBookingRequest
from swagger_client.models.loan_booking_response import LoanBookingResponse
from swagger_client.models.loan_eligibility_check_response import LoanEligibilityCheckResponse
from swagger_client.models.loan_eligibility_details import LoanEligibilityDetails
from swagger_client.models.loan_payment_plans import LoanPaymentPlans
from swagger_client.models.loan_payment_schedule import LoanPaymentSchedule
from swagger_client.models.loan_repayment_schedule_response import LoanRepaymentScheduleResponse
from swagger_client.models.loan_repayment_scheule_response import LoanRepaymentScheuleResponse
from swagger_client.models.loan_schedule_details import LoanScheduleDetails
from swagger_client.models.loan_summary import LoanSummary
from swagger_client.models.loan_summary_response import LoanSummaryResponse
from swagger_client.models.loan_topup import LoanTopup
from swagger_client.models.loan_topup_recommendations import LoanTopupRecommendations
from swagger_client.models.loans import Loans
from swagger_client.models.marketing_campaign_offer import MarketingCampaignOffer
from swagger_client.models.mutual_fund import MutualFund
from swagger_client.models.mutual_fund_account import MutualFundAccount
from swagger_client.models.mutual_fund_account_summary import MutualFundAccountSummary
from swagger_client.models.original_credit_account_details import OriginalCreditAccountDetails
from swagger_client.models.original_creditor_details import OriginalCreditorDetails
from swagger_client.models.original_debit_account_details import OriginalDebitAccountDetails
from swagger_client.models.original_transaction_details import OriginalTransactionDetails
from swagger_client.models.partial_response_information import PartialResponseInformation
from swagger_client.models.payee_account_details import PayeeAccountDetails
from swagger_client.models.payment_pans import PaymentPans
from swagger_client.models.pending_transaction import PendingTransaction
from swagger_client.models.personal_account_details import PersonalAccountDetails
from swagger_client.models.phone import Phone
from swagger_client.models.premium_deposit_account import PremiumDepositAccount
from swagger_client.models.premium_deposit_account_summary import PremiumDepositAccountSummary
from swagger_client.models.product import Product
from swagger_client.models.ready_credit_account import ReadyCreditAccount
from swagger_client.models.ready_credit_account_balance_summary import ReadyCreditAccountBalanceSummary
from swagger_client.models.ready_credit_account_summary import ReadyCreditAccountSummary
from swagger_client.models.relationship import Relationship
from swagger_client.models.requested_loan_topup_decision import RequestedLoanTopupDecision
from swagger_client.models.retrieve_application_processing_unsecured_loan_topup_repayment_schedule_response import RetrieveApplicationProcessingUnsecuredLoanTopupRepaymentScheduleResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_pre_login_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_confirmation_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_with_validation_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_pre_login_with_validation_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_preprocess_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_preprocess_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreprocessResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_consolidate_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loan_repay_schedule_simulator_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loan_repay_schedule_simulator_response_amortization_schedule import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoanRepayScheduleSimulatorResponseAmortizationSchedule
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_loans_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanLoansResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_bookings_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppBookingsResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_repayment_schedules_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppRepaymentSchedulesResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_epp_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersEppResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_plans_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_plans_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentPlansResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_schedules_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_payment_schedules_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanPaymentSchedulesResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules_request import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesRequest
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_loan_repayment_schedules_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersLoanRepaymentSchedulesResponse
from swagger_client.models.retrieve_credit_charge_card_fulfillment_arrangement_credit_plan_offers_outstanding_loan_repayment_schedules_response import RetrieveCreditChargeCardFulfillmentArrangementCreditPlanOffersOutstandingLoanRepaymentSchedulesResponse
from swagger_client.models.retrieve_disbursement_options_pre_login_response import RetrieveDisbursementOptionsPreLoginResponse
from swagger_client.models.retrieve_unmasked_account_data_request import RetrieveUnmaskedAccountDataRequest
from swagger_client.models.retrieve_unmasked_account_data_response import RetrieveUnmaskedAccountDataResponse
from swagger_client.models.savings_account import SavingsAccount
from swagger_client.models.savings_account_summary import SavingsAccountSummary
from swagger_client.models.securities_brokerage_account import SecuritiesBrokerageAccount
from swagger_client.models.securities_brokerage_account_summary import SecuritiesBrokerageAccountSummary
from swagger_client.models.security import Security
from swagger_client.models.statement import Statement
from swagger_client.models.statement_list import StatementList
from swagger_client.models.statement_summary import StatementSummary
from swagger_client.models.statements import Statements
from swagger_client.models.statements_response import StatementsResponse
from swagger_client.models.sufficiency_of_funds_response import SufficiencyOfFundsResponse
from swagger_client.models.time_deposit_account import TimeDepositAccount
from swagger_client.models.time_deposit_account_summary import TimeDepositAccountSummary
from swagger_client.models.transaction import Transaction
from swagger_client.models.transaction_detailed_view_response import TransactionDetailedViewResponse
from swagger_client.models.transaction_details import TransactionDetails
from swagger_client.models.transaction_details_confirmation_request import TransactionDetailsConfirmationRequest
from swagger_client.models.transaction_details_confirmation_response import TransactionDetailsConfirmationResponse
from swagger_client.models.transaction_details_request import TransactionDetailsRequest
from swagger_client.models.transaction_details_response import TransactionDetailsResponse
from swagger_client.models.transaction_document_list import TransactionDocumentList
from swagger_client.models.transactions import Transactions
from swagger_client.models.un_secured_loans import UnSecuredLoans
from swagger_client.models.update_application_processing_unsecured_loan_topup_background_screening_request import UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningRequest
from swagger_client.models.update_application_processing_unsecured_loan_topup_background_screening_response import UpdateApplicationProcessingUnsecuredLoanTopupBackgroundScreeningResponse
from swagger_client.models.update_application_processing_unsecured_loan_topup_in_principal_approval_request import UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalRequest
from swagger_client.models.update_application_processing_unsecured_loan_topup_in_principal_approval_response import UpdateApplicationProcessingUnsecuredLoanTopupInPrincipalApprovalResponse
from swagger_client.models.view_transaction_details_document_response import ViewTransactionDetailsDocumentResponse
