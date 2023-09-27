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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * AccountCurrencyDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class AccountCurrencyDetails {
  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("newAccountOpenedFlag")
  private Boolean newAccountOpenedFlag = null;

  @SerializedName("globalWalletAccountType")
  private String globalWalletAccountType = null;

  @SerializedName("enrollmentStatusFlag")
  private Boolean enrollmentStatusFlag = null;

  public AccountCurrencyDetails displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "********4531", description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public AccountCurrencyDetails accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The customer account identifier in encrypted format
   * @return accountId
  **/
  @Schema(example = "6555613852316t3c4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858353b", description = "The customer account identifier in encrypted format")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public AccountCurrencyDetails newAccountOpenedFlag(Boolean newAccountOpenedFlag) {
    this.newAccountOpenedFlag = newAccountOpenedFlag;
    return this;
  }

   /**
   * This field is to indicate if the  account is newly opened or not.
   * @return newAccountOpenedFlag
  **/
  @Schema(example = "true", required = true, description = "This field is to indicate if the  account is newly opened or not.")
  public Boolean isNewAccountOpenedFlag() {
    return newAccountOpenedFlag;
  }

  public void setNewAccountOpenedFlag(Boolean newAccountOpenedFlag) {
    this.newAccountOpenedFlag = newAccountOpenedFlag;
  }

  public AccountCurrencyDetails globalWalletAccountType(String globalWalletAccountType) {
    this.globalWalletAccountType = globalWalletAccountType;
    return this;
  }

   /**
   * Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions.
   * @return globalWalletAccountType
  **/
  @Schema(example = "Checking", description = "Type of account.Type of account.This is a reference data field. Please use /v1/apac/utilities/referenceData/{globalWalletAccountType} resource to get possible values of this field with descriptions.")
  public String getGlobalWalletAccountType() {
    return globalWalletAccountType;
  }

  public void setGlobalWalletAccountType(String globalWalletAccountType) {
    this.globalWalletAccountType = globalWalletAccountType;
  }

  public AccountCurrencyDetails enrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
    return this;
  }

   /**
   * Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet).
   * @return enrollmentStatusFlag
  **/
  @Schema(example = "true", description = "Flag to indicate whether new FCY account is enrolled to Multi currency account(Global Wallet).")
  public Boolean isEnrollmentStatusFlag() {
    return enrollmentStatusFlag;
  }

  public void setEnrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AccountCurrencyDetails accountCurrencyDetails = (AccountCurrencyDetails) o;
    return Objects.equals(this.displayAccountNumber, accountCurrencyDetails.displayAccountNumber) &&
        Objects.equals(this.accountId, accountCurrencyDetails.accountId) &&
        Objects.equals(this.newAccountOpenedFlag, accountCurrencyDetails.newAccountOpenedFlag) &&
        Objects.equals(this.globalWalletAccountType, accountCurrencyDetails.globalWalletAccountType) &&
        Objects.equals(this.enrollmentStatusFlag, accountCurrencyDetails.enrollmentStatusFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(displayAccountNumber, accountId, newAccountOpenedFlag, globalWalletAccountType, enrollmentStatusFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AccountCurrencyDetails {\n");
    
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
    sb.append("    newAccountOpenedFlag: ").append(toIndentedString(newAccountOpenedFlag)).append("\n");
    sb.append("    globalWalletAccountType: ").append(toIndentedString(globalWalletAccountType)).append("\n");
    sb.append("    enrollmentStatusFlag: ").append(toIndentedString(enrollmentStatusFlag)).append("\n");
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
