/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */

package io.swagger.client.api;

import io.swagger.client.ApiException;
import io.swagger.client.model.AccountAccessCodeGenerationResponse;
import io.swagger.client.model.AccountBalancesSummaryInquiryResponse;
import io.swagger.client.model.AccountStatementListResponse;
import io.swagger.client.model.AccountsGroupList;
import io.swagger.client.model.BalanceTransferBookingRequest;
import io.swagger.client.model.BalanceTransferBookingResponse;
import io.swagger.client.model.BalanceTransferEligibilityResponse;
import java.math.BigDecimal;
import io.swagger.client.model.CompositeTransactionDetailsRequest;
import io.swagger.client.model.CompositeTransactionDetailsResponse;
import io.swagger.client.model.ConsentsDetailsInquiryResponse;
import io.swagger.client.model.ConsentsDetailsUpdateRequest;
import io.swagger.client.model.DisbursementOptionsResponse;
import io.swagger.client.model.ErrorResponse;
import io.swagger.client.model.LoanBookingConfirmationRequest;
import io.swagger.client.model.LoanBookingConfirmationResponse;
import io.swagger.client.model.LoanBookingPlanResponse;
import io.swagger.client.model.LoanBookingRequest;
import io.swagger.client.model.LoanBookingResponse;
import io.swagger.client.model.LoanEligibilityCheckResponse;
import io.swagger.client.model.LoanRepaymentScheuleResponse;
import io.swagger.client.model.LoanSummaryResponse;
import org.threeten.bp.LocalDate;
import io.swagger.client.model.RetrieveUnmaskedAccountDataRequest;
import io.swagger.client.model.RetrieveUnmaskedAccountDataResponse;
import io.swagger.client.model.StatementsResponse;
import io.swagger.client.model.TransactionDetailedViewResponse;
import io.swagger.client.model.TransactionDetailsConfirmationRequest;
import io.swagger.client.model.TransactionDetailsConfirmationResponse;
import io.swagger.client.model.TransactionDetailsResponse;
import io.swagger.client.model.ViewTransactionDetailsDocumentResponse;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for AccountsApi
 */
@Ignore
public class AccountsApiTest {

    private final AccountsApi api = new AccountsApi();

    /**
     * Retrieve Account Balance Summary
     *
     * This API allows the customers to retrieve the outstanding balance at the time of their account closure.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void accountBalancesSummaryInquiryTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String clientDetails = null;
        AccountBalancesSummaryInquiryResponse response = api.accountBalancesSummaryInquiry(authorization, uuid, accept, clientId, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Book Balance Transfer
     *
     * This API is used to book the Balance Transfer selected by the customer. After the successful Balance Transfer booking, a reference number is sent to the customer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void balanceTransferBookingTest() throws ApiException {
        BalanceTransferBookingRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String accountId = null;
        String clientDetails = null;
        BalanceTransferBookingResponse response = api.balanceTransferBooking(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Check Eligibility for Balance Transfer Offer
     *
     * This API is triggered to check eligibility for Balance Transfer Offer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void balanceTransferEligibilityTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String clientDetails = null;
        String btSupportedAccountGroup = null;
        BalanceTransferEligibilityResponse response = api.balanceTransferEligibility(authorization, uuid, accept, clientId, clientDetails, btSupportedAccountGroup);

        // TODO: test validations
    }
    /**
     * Retrieve Consents based on Account Number
     *
     * This API is used to retrieve the consents based on account number.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void consentsDetailsInquiryTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String consentType = null;
        String clientDetails = null;
        ConsentsDetailsInquiryResponse response = api.consentsDetailsInquiry(authorization, uuid, accept, clientId, accountId, consentType, clientDetails);

        // TODO: test validations
    }
    /**
     * This API is used to update the consent for an account
     *
     * This API is used to update the consent for an account
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void consentsDetailsUpdateTest() throws ApiException {
        ConsentsDetailsUpdateRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String accountId = null;
        String clientDetails = null;
        api.consentsDetailsUpdate(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * This API will retrieve the Access Code which will be used to see the clear account number
     *
     * This API will retrieve the Access Code which will be used to see the clear account number
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void partnerV1AccountsAccountIdAccessCodesGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String clientDetails = null;
        AccountAccessCodeGenerationResponse response = api.partnerV1AccountsAccountIdAccessCodesGet(authorization, uuid, accept, clientId, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Partner Account Summary
     *
     * This API is used to retrieve a summary of a customer&#x27;s partner account such as Savings Account,Checking Account,Credit Card Account,Loan Account,Ready Credit Account,Securities Brokerage Account,Mutual Fund Account,Call Deposit Account,Premium Deposit Account,Time Deposit Account,Insurance Account, etc.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void partnerV1PartnerAccountsGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String clientDetails = null;
        String nextStartIndex = null;
        AccountsGroupList response = api.partnerV1PartnerAccountsGet(authorization, uuid, accept, clientId, clientDetails, nextStartIndex);

        // TODO: test validations
    }
    /**
     * This API provides unmasked IBAN (International bank account number) for the requested account Id.
     *
     * This API returns unmasked IBAN (International bank account number) for the requested account Id. To retrieve the unmasked account number, simply pass the account id parameter, which you can get from the ‘Account Summary’ API for Accounts (AIS) and Source account eligibility API for Money Movement (PIS).Note: This API works for both Accounts (AIS) and Money Movement (PIS) APIs.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void retrieveUnmaskedAccountDataTest() throws ApiException {
        RetrieveUnmaskedAccountDataRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String clientDetails = null;
        RetrieveUnmaskedAccountDataResponse response = api.retrieveUnmaskedAccountData(body, authorization, uuid, accept, clientId, contentType, clientDetails);

        // TODO: test validations
    }
    /**
     * Book Loan Over Phone
     *
     * This API is used to book the loan with the plan selected by the customer. After the successful loan booking, a reference number is sent to the customer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdLoansBookingsPostTest() throws ApiException {
        LoanBookingRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String accountId = null;
        String clientDetails = null;
        LoanBookingResponse response = api.v1AccountsAccountIdLoansBookingsPost(body, authorization, uuid, accept, clientId, contentType, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Disbursement Options
     *
     * This API is used to get the list of eligible disbursement options like cheque, personal account and external bank account etc.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdLoansDisbursementOptionsGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String clientDetails = null;
        DisbursementOptionsResponse response = api.v1AccountsAccountIdLoansDisbursementOptionsGet(authorization, uuid, accept, clientId, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Loan Summary
     *
     * This API is used to retrieve the summary of the Loan Over Phone (LOP) or Easy Payment Plan (EPP) loans availed on a particular account id.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdLoansGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String clientDetails = null;
        String nextStartIndex = null;
        LoanSummaryResponse response = api.v1AccountsAccountIdLoansGet(authorization, uuid, accept, clientId, accountId, clientDetails, nextStartIndex);

        // TODO: test validations
    }
    /**
     * Retrieve Loan Booking Plans
     *
     * This API lists the loan booking plans that the customer can avail for credit card loan repayments. It provides the applicable interest rate, tenor, installment amount and fees etc
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdLoansLoanAmountPaymentsPlansGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String loanAmount = null;
        String tenor = null;
        String clientDetails = null;
        LoanBookingPlanResponse response = api.v1AccountsAccountIdLoansLoanAmountPaymentsPlansGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Repayment Schedules
     *
     * This API allows the customer to view the payment breakdown details.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdLoansRepaymentSchedulesGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        Double loanAmount = null;
        BigDecimal tenor = null;
        String clientDetails = null;
        String nextStartIndex = null;
        LoanRepaymentScheuleResponse response = api.v1AccountsAccountIdLoansRepaymentSchedulesGet(authorization, uuid, accept, clientId, accountId, loanAmount, tenor, clientDetails, nextStartIndex);

        // TODO: test validations
    }
    /**
     * Retrieve list of available statements.
     *
     * This API is used to retrieve list of available statements. Currently support statements for credit card accounts only.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdStatementsGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String nextStartIndex = null;
        String clientDetails = null;
        AccountStatementListResponse response = api.v1AccountsAccountIdStatementsGet(authorization, uuid, accept, clientId, accountId, nextStartIndex, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Statements Summary and Transaction
     *
     * This API is used to retrieve the summary of transactions for a statement of cards held by a customer including primary and supplementary cards.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdStatementsStatementIdGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String statementId = null;
        String clientDetails = null;
        String currencyCode = null;
        String nextStartIndex = null;
        String statementDate = null;
        StatementsResponse response = api.v1AccountsAccountIdStatementsStatementIdGet(authorization, uuid, accept, clientId, accountId, statementId, clientDetails, currencyCode, nextStartIndex, statementDate);

        // TODO: test validations
    }
    /**
     * Confirm Transaction Details
     *
     * This API is used to retrieve transaction details for a single account based on the controlflowId generated after successful OTP validation. This API is used to confirm successful OTP validation.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdTransactionsConfirmationPostTest() throws ApiException {
        TransactionDetailsConfirmationRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String controlFlowId = null;
        String accountId = null;
        String clientDetails = null;
        TransactionDetailsConfirmationResponse response = api.v1AccountsAccountIdTransactionsConfirmationPost(body, authorization, uuid, accept, clientId, controlFlowId, accountId, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Transaction Details for Limited Period
     *
     * This API is used to retrieve transactions for the specified account with maximum allowable period of 90 days. Important! For PSD2, only Credit card, Checking and Saving account are returned in the response.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdTransactionsLimitedDayRangeGetTest() throws ApiException {
        String accountId = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String transactionStatus = null;
        String nextStartIndex = null;
        BigDecimal requestSize = null;
        String transactionFromDate = null;
        String transactionToDate = null;
        String amountFrom = null;
        String amountTo = null;
        String clientDetails = null;
        TransactionDetailsResponse response = api.v1AccountsAccountIdTransactionsLimitedDayRangeGet(accountId, authorization, uuid, accept, clientId, transactionStatus, nextStartIndex, requestSize, transactionFromDate, transactionToDate, amountFrom, amountTo, clientDetails);

        // TODO: test validations
    }
    /**
     * Retrieve Additional Transaction Details By Transaction Reference Id
     *
     * This API allows you to retrieve additional transaction details data associated with a transaction reference id.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String transactionReferenceId = null;
        String transactionCode = null;
        String clientDetails = null;
        TransactionDetailedViewResponse response = api.v1AccountsAccountIdTransactionsTransactionReferenceIdDetailsGet(authorization, uuid, accept, clientId, accountId, transactionReferenceId, transactionCode, clientDetails);

        // TODO: test validations
    }
    /**
     * Loan Booking Confirmation
     *
     * This API is triggered after CMAMT interdiction in Loan Booking process.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsLoansBookingsConfirmationPostTest() throws ApiException {
        LoanBookingConfirmationRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String clientDetails = null;
        LoanBookingConfirmationResponse response = api.v1AccountsLoansBookingsConfirmationPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);

        // TODO: test validations
    }
    /**
     * Check Eligibility for Loan Offer
     *
     * This API is triggered to check eligibility for Loan Offer for a customer.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsLoansEligibilityGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String clientDetails = null;
        String lopSupportedAccountGroup = null;
        LoanEligibilityCheckResponse response = api.v1AccountsLoansEligibilityGet(authorization, uuid, accept, clientId, clientDetails, lopSupportedAccountGroup);

        // TODO: test validations
    }
    /**
     * Retrieve Repayment Schedule of Booked LOP/EPP Loan
     *
     * This API is used to retrieve the list of remaining repayment schedule of booked LOP/EPP loan by sending loan reference id.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsLoansLoanReferenceIdRepaymentSchedulesGetTest() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String loanReferenceId = null;
        String clientDetails = null;
        String nextStartIndex = null;
        LoanRepaymentScheuleResponse response = api.v1AccountsLoansLoanReferenceIdRepaymentSchedulesGet(authorization, uuid, accept, clientId, loanReferenceId, clientDetails, nextStartIndex);

        // TODO: test validations
    }
    /**
     * Retrieve Multiple Accounts Transaction Details
     *
     * This API is to retrieve transactions details &amp; history for multiple accounts in one request .If the transactions available exceeds the request size, you will be provided with a nextStartIndex. You may pass this nextStartIndex in your next request to get the next set of transactions. If nextStartIndex is blank, then there are no more transactions available.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void v1AccountsTransactionsSearchPostTest() throws ApiException {
        CompositeTransactionDetailsRequest body = null;
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String contentType = null;
        String clientDetails = null;
        CompositeTransactionDetailsResponse response = api.v1AccountsTransactionsSearchPost(body, authorization, uuid, accept, clientId, contentType, clientDetails);

        // TODO: test validations
    }
    /**
     * Download Transaction Details
     *
     * This API is used to check the customer&#x27;s eligibility for availing Balance Transfer. It is also used to provide eligible payment plans.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void viewTransactionDetailsDocument_Test() throws ApiException {
        String authorization = null;
        String uuid = null;
        String accept = null;
        String clientId = null;
        String accountId = null;
        String downloadFormat = null;
        String clientDetails = null;
        LocalDate transactionStartDate = null;
        LocalDate transactionEndDate = null;
        String nextStartIndex = null;
        ViewTransactionDetailsDocumentResponse response = api.viewTransactionDetailsDocument_(authorization, uuid, accept, clientId, accountId, downloadFormat, clientDetails, transactionStartDate, transactionEndDate, nextStartIndex);

        // TODO: test validations
    }
}