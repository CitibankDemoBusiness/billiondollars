/*
 * Cards
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
import io.swagger.client.model.LinkedAccountDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * AccountDtls
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class AccountDtls {
  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("currencyCode")
  private String currencyCode = null;

  @SerializedName("enrollmentStatusFlag")
  private Boolean enrollmentStatusFlag = null;

  @SerializedName("primaryAccountFlag")
  private Boolean primaryAccountFlag = null;

  @SerializedName("accountBalance")
  private Double accountBalance = null;

  @SerializedName("linkedAccountDetails")
  private List<LinkedAccountDetails> linkedAccountDetails = null;

  public AccountDtls displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * Currency code which has to be added to Multi Currency Account in ISO 4217 format.
   * @return displayAccountNumber
  **/
  @Schema(example = "********4531", description = "Currency code which has to be added to Multi Currency Account in ISO 4217 format.")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public AccountDtls accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The customer account identifier in encrypted format
   * @return accountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The customer account identifier in encrypted format")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public AccountDtls currencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
    return this;
  }

   /**
   * Currency code which has to be added to Multi Currency Account in ISO 4217 format.
   * @return currencyCode
  **/
  @Schema(example = "AUD", description = "Currency code which has to be added to Multi Currency Account in ISO 4217 format.")
  public String getCurrencyCode() {
    return currencyCode;
  }

  public void setCurrencyCode(String currencyCode) {
    this.currencyCode = currencyCode;
  }

  public AccountDtls enrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
    return this;
  }

   /**
   * This field is to indicate if the  account is enrolled for Multi Currency Account or not.
   * @return enrollmentStatusFlag
  **/
  @Schema(example = "true", description = "This field is to indicate if the  account is enrolled for Multi Currency Account or not.")
  public Boolean isEnrollmentStatusFlag() {
    return enrollmentStatusFlag;
  }

  public void setEnrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
  }

  public AccountDtls primaryAccountFlag(Boolean primaryAccountFlag) {
    this.primaryAccountFlag = primaryAccountFlag;
    return this;
  }

   /**
   * Flag to indicate if account is primary
   * @return primaryAccountFlag
  **/
  @Schema(example = "true", description = "Flag to indicate if account is primary")
  public Boolean isPrimaryAccountFlag() {
    return primaryAccountFlag;
  }

  public void setPrimaryAccountFlag(Boolean primaryAccountFlag) {
    this.primaryAccountFlag = primaryAccountFlag;
  }

  public AccountDtls accountBalance(Double accountBalance) {
    this.accountBalance = accountBalance;
    return this;
  }

   /**
   * Current Balance of the Account.
   * @return accountBalance
  **/
  @Schema(example = "5034.45", description = "Current Balance of the Account.")
  public Double getAccountBalance() {
    return accountBalance;
  }

  public void setAccountBalance(Double accountBalance) {
    this.accountBalance = accountBalance;
  }

  public AccountDtls linkedAccountDetails(List<LinkedAccountDetails> linkedAccountDetails) {
    this.linkedAccountDetails = linkedAccountDetails;
    return this;
  }

  public AccountDtls addLinkedAccountDetailsItem(LinkedAccountDetails linkedAccountDetailsItem) {
    if (this.linkedAccountDetails == null) {
      this.linkedAccountDetails = new ArrayList<LinkedAccountDetails>();
    }
    this.linkedAccountDetails.add(linkedAccountDetailsItem);
    return this;
  }

   /**
   * Get linkedAccountDetails
   * @return linkedAccountDetails
  **/
  @Schema(description = "")
  public List<LinkedAccountDetails> getLinkedAccountDetails() {
    return linkedAccountDetails;
  }

  public void setLinkedAccountDetails(List<LinkedAccountDetails> linkedAccountDetails) {
    this.linkedAccountDetails = linkedAccountDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AccountDtls accountDtls = (AccountDtls) o;
    return Objects.equals(this.displayAccountNumber, accountDtls.displayAccountNumber) &&
        Objects.equals(this.accountId, accountDtls.accountId) &&
        Objects.equals(this.currencyCode, accountDtls.currencyCode) &&
        Objects.equals(this.enrollmentStatusFlag, accountDtls.enrollmentStatusFlag) &&
        Objects.equals(this.primaryAccountFlag, accountDtls.primaryAccountFlag) &&
        Objects.equals(this.accountBalance, accountDtls.accountBalance) &&
        Objects.equals(this.linkedAccountDetails, accountDtls.linkedAccountDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(displayAccountNumber, accountId, currencyCode, enrollmentStatusFlag, primaryAccountFlag, accountBalance, linkedAccountDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AccountDtls {\n");
    
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    currencyCode: ").append(toIndentedString(currencyCode)).append("\n");
    sb.append("    enrollmentStatusFlag: ").append(toIndentedString(enrollmentStatusFlag)).append("\n");
    sb.append("    primaryAccountFlag: ").append(toIndentedString(primaryAccountFlag)).append("\n");
    sb.append("    accountBalance: ").append(toIndentedString(accountBalance)).append("\n");
    sb.append("    linkedAccountDetails: ").append(toIndentedString(linkedAccountDetails)).append("\n");
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
