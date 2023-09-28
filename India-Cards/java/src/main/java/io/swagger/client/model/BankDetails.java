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
 * BankDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class BankDetails {
  @SerializedName("bankCode")
  private String bankCode = null;

  @SerializedName("accountNumber")
  private String accountNumber = null;

  @SerializedName("branchCode")
  private String branchCode = null;

  @SerializedName("bankName")
  private String bankName = null;

  @SerializedName("payeeName")
  private String payeeName = null;

  public BankDetails bankCode(String bankCode) {
    this.bankCode = bankCode;
    return this;
  }

   /**
   * Bank Identification Code to which the loan will be credited.
   * @return bankCode
  **/
  @Schema(example = "DBSSG0XXX", description = "Bank Identification Code to which the loan will be credited.")
  public String getBankCode() {
    return bankCode;
  }

  public void setBankCode(String bankCode) {
    this.bankCode = bankCode;
  }

  public BankDetails accountNumber(String accountNumber) {
    this.accountNumber = accountNumber;
    return this;
  }

   /**
   * Account Number to which the loan will be credited.
   * @return accountNumber
  **/
  @Schema(example = "2356456749", description = "Account Number to which the loan will be credited.")
  public String getAccountNumber() {
    return accountNumber;
  }

  public void setAccountNumber(String accountNumber) {
    this.accountNumber = accountNumber;
  }

  public BankDetails branchCode(String branchCode) {
    this.branchCode = branchCode;
    return this;
  }

   /**
   * Branch Code to which the loan will be credited
   * @return branchCode
  **/
  @Schema(example = "100034", description = "Branch Code to which the loan will be credited")
  public String getBranchCode() {
    return branchCode;
  }

  public void setBranchCode(String branchCode) {
    this.branchCode = branchCode;
  }

  public BankDetails bankName(String bankName) {
    this.bankName = bankName;
    return this;
  }

   /**
   * This refer to the name of the bank
   * @return bankName
  **/
  @Schema(example = "HSBC Bank", description = "This refer to the name of the bank")
  public String getBankName() {
    return bankName;
  }

  public void setBankName(String bankName) {
    this.bankName = bankName;
  }

  public BankDetails payeeName(String payeeName) {
    this.payeeName = payeeName;
    return this;
  }

   /**
   * Name of the Beneficiary to whom the loam amount will be disbursed.
   * @return payeeName
  **/
  @Schema(example = "Adam Smith", description = "Name of the Beneficiary to whom the loam amount will be disbursed.")
  public String getPayeeName() {
    return payeeName;
  }

  public void setPayeeName(String payeeName) {
    this.payeeName = payeeName;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BankDetails bankDetails = (BankDetails) o;
    return Objects.equals(this.bankCode, bankDetails.bankCode) &&
        Objects.equals(this.accountNumber, bankDetails.accountNumber) &&
        Objects.equals(this.branchCode, bankDetails.branchCode) &&
        Objects.equals(this.bankName, bankDetails.bankName) &&
        Objects.equals(this.payeeName, bankDetails.payeeName);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bankCode, accountNumber, branchCode, bankName, payeeName);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BankDetails {\n");
    
    sb.append("    bankCode: ").append(toIndentedString(bankCode)).append("\n");
    sb.append("    accountNumber: ").append(toIndentedString(accountNumber)).append("\n");
    sb.append("    branchCode: ").append(toIndentedString(branchCode)).append("\n");
    sb.append("    bankName: ").append(toIndentedString(bankName)).append("\n");
    sb.append("    payeeName: ").append(toIndentedString(payeeName)).append("\n");
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