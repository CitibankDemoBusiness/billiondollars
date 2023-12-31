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

package io.swagger.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.client.model.BtDisbursementOptions;
import io.swagger.client.model.PaymentPans;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * BalanceTransferEligibilityDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class BalanceTransferEligibilityDetails {
  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("btSupportedAccountGroup")
  private String btSupportedAccountGroup = null;

  @SerializedName("maximumEligibleLoanAmount")
  private Double maximumEligibleLoanAmount = null;

  @SerializedName("minimumEligibleLoanAmount")
  private Double minimumEligibleLoanAmount = null;

  @SerializedName("btDisbursementOptions")
  private List<BtDisbursementOptions> btDisbursementOptions = new ArrayList<BtDisbursementOptions>();

  @SerializedName("paymentPans")
  private List<PaymentPans> paymentPans = null;

  public BalanceTransferEligibilityDetails accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The account id  in encrypted format.
   * @return accountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "The account id  in encrypted format.")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public BalanceTransferEligibilityDetails displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer.
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXXXXXXXX4521", required = true, description = "A masked account number that can be displayed to the customer.")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public BalanceTransferEligibilityDetails btSupportedAccountGroup(String btSupportedAccountGroup) {
    this.btSupportedAccountGroup = btSupportedAccountGroup;
    return this;
  }

   /**
   * This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description.
   * @return btSupportedAccountGroup
  **/
  @Schema(example = "READY_CREDIT", description = "This field refers the account group supported by Balance Transfer. This is a reference data field. Please use /v1/utilities/referenceData/{btSupportedAccountGroup} resource to get valid value of this field with description.")
  public String getBtSupportedAccountGroup() {
    return btSupportedAccountGroup;
  }

  public void setBtSupportedAccountGroup(String btSupportedAccountGroup) {
    this.btSupportedAccountGroup = btSupportedAccountGroup;
  }

  public BalanceTransferEligibilityDetails maximumEligibleLoanAmount(Double maximumEligibleLoanAmount) {
    this.maximumEligibleLoanAmount = maximumEligibleLoanAmount;
    return this;
  }

   /**
   * This field indicates the maximum eligible amount for loan.
   * @return maximumEligibleLoanAmount
  **/
  @Schema(example = "25000.25", required = true, description = "This field indicates the maximum eligible amount for loan.")
  public Double getMaximumEligibleLoanAmount() {
    return maximumEligibleLoanAmount;
  }

  public void setMaximumEligibleLoanAmount(Double maximumEligibleLoanAmount) {
    this.maximumEligibleLoanAmount = maximumEligibleLoanAmount;
  }

  public BalanceTransferEligibilityDetails minimumEligibleLoanAmount(Double minimumEligibleLoanAmount) {
    this.minimumEligibleLoanAmount = minimumEligibleLoanAmount;
    return this;
  }

   /**
   * This field indicates the minimum eligible amount for loan.
   * @return minimumEligibleLoanAmount
  **/
  @Schema(example = "5000.25", description = "This field indicates the minimum eligible amount for loan.")
  public Double getMinimumEligibleLoanAmount() {
    return minimumEligibleLoanAmount;
  }

  public void setMinimumEligibleLoanAmount(Double minimumEligibleLoanAmount) {
    this.minimumEligibleLoanAmount = minimumEligibleLoanAmount;
  }

  public BalanceTransferEligibilityDetails btDisbursementOptions(List<BtDisbursementOptions> btDisbursementOptions) {
    this.btDisbursementOptions = btDisbursementOptions;
    return this;
  }

  public BalanceTransferEligibilityDetails addBtDisbursementOptionsItem(BtDisbursementOptions btDisbursementOptionsItem) {
    this.btDisbursementOptions.add(btDisbursementOptionsItem);
    return this;
  }

   /**
   * Get btDisbursementOptions
   * @return btDisbursementOptions
  **/
  @Schema(required = true, description = "")
  public List<BtDisbursementOptions> getBtDisbursementOptions() {
    return btDisbursementOptions;
  }

  public void setBtDisbursementOptions(List<BtDisbursementOptions> btDisbursementOptions) {
    this.btDisbursementOptions = btDisbursementOptions;
  }

  public BalanceTransferEligibilityDetails paymentPans(List<PaymentPans> paymentPans) {
    this.paymentPans = paymentPans;
    return this;
  }

  public BalanceTransferEligibilityDetails addPaymentPansItem(PaymentPans paymentPansItem) {
    if (this.paymentPans == null) {
      this.paymentPans = new ArrayList<PaymentPans>();
    }
    this.paymentPans.add(paymentPansItem);
    return this;
  }

   /**
   * Get paymentPans
   * @return paymentPans
  **/
  @Schema(description = "")
  public List<PaymentPans> getPaymentPans() {
    return paymentPans;
  }

  public void setPaymentPans(List<PaymentPans> paymentPans) {
    this.paymentPans = paymentPans;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BalanceTransferEligibilityDetails balanceTransferEligibilityDetails = (BalanceTransferEligibilityDetails) o;
    return Objects.equals(this.accountId, balanceTransferEligibilityDetails.accountId) &&
        Objects.equals(this.displayAccountNumber, balanceTransferEligibilityDetails.displayAccountNumber) &&
        Objects.equals(this.btSupportedAccountGroup, balanceTransferEligibilityDetails.btSupportedAccountGroup) &&
        Objects.equals(this.maximumEligibleLoanAmount, balanceTransferEligibilityDetails.maximumEligibleLoanAmount) &&
        Objects.equals(this.minimumEligibleLoanAmount, balanceTransferEligibilityDetails.minimumEligibleLoanAmount) &&
        Objects.equals(this.btDisbursementOptions, balanceTransferEligibilityDetails.btDisbursementOptions) &&
        Objects.equals(this.paymentPans, balanceTransferEligibilityDetails.paymentPans);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accountId, displayAccountNumber, btSupportedAccountGroup, maximumEligibleLoanAmount, minimumEligibleLoanAmount, btDisbursementOptions, paymentPans);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BalanceTransferEligibilityDetails {\n");
    
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    btSupportedAccountGroup: ").append(toIndentedString(btSupportedAccountGroup)).append("\n");
    sb.append("    maximumEligibleLoanAmount: ").append(toIndentedString(maximumEligibleLoanAmount)).append("\n");
    sb.append("    minimumEligibleLoanAmount: ").append(toIndentedString(minimumEligibleLoanAmount)).append("\n");
    sb.append("    btDisbursementOptions: ").append(toIndentedString(btDisbursementOptions)).append("\n");
    sb.append("    paymentPans: ").append(toIndentedString(paymentPans)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
