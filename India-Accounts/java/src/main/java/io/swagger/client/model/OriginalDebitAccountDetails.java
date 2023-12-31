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
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * OriginalDebitAccountDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class OriginalDebitAccountDetails {
  @SerializedName("displayAccountNumber")
  private String displayAccountNumber = null;

  @SerializedName("bankName")
  private String bankName = null;

  @SerializedName("bankCode")
  private String bankCode = null;

  public OriginalDebitAccountDetails displayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayAccountNumber
  **/
  @Schema(example = "XXXXXX2391", description = "A masked account number that can be displayed to the customer")
  public String getDisplayAccountNumber() {
    return displayAccountNumber;
  }

  public void setDisplayAccountNumber(String displayAccountNumber) {
    this.displayAccountNumber = displayAccountNumber;
  }

  public OriginalDebitAccountDetails bankName(String bankName) {
    this.bankName = bankName;
    return this;
  }

   /**
   * Name of the bank.
   * @return bankName
  **/
  @Schema(example = "HSBC Bank", description = "Name of the bank.")
  public String getBankName() {
    return bankName;
  }

  public void setBankName(String bankName) {
    this.bankName = bankName;
  }

  public OriginalDebitAccountDetails bankCode(String bankCode) {
    this.bankCode = bankCode;
    return this;
  }

   /**
   * The bank code of the payee account
   * @return bankCode
  **/
  @Schema(example = "44525101", description = "The bank code of the payee account")
  public String getBankCode() {
    return bankCode;
  }

  public void setBankCode(String bankCode) {
    this.bankCode = bankCode;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    OriginalDebitAccountDetails originalDebitAccountDetails = (OriginalDebitAccountDetails) o;
    return Objects.equals(this.displayAccountNumber, originalDebitAccountDetails.displayAccountNumber) &&
        Objects.equals(this.bankName, originalDebitAccountDetails.bankName) &&
        Objects.equals(this.bankCode, originalDebitAccountDetails.bankCode);
  }

  @Override
  public int hashCode() {
    return Objects.hash(displayAccountNumber, bankName, bankCode);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class OriginalDebitAccountDetails {\n");
    
    sb.append("    displayAccountNumber: ").append(toIndentedString(displayAccountNumber)).append("\n");
    sb.append("    bankName: ").append(toIndentedString(bankName)).append("\n");
    sb.append("    bankCode: ").append(toIndentedString(bankCode)).append("\n");
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
