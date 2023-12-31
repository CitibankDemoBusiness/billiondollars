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
 * ExternalBankDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class ExternalBankDetails {
  @SerializedName("bankCode")
  private String bankCode = null;

  @SerializedName("destinationAccountId")
  private String destinationAccountId = null;

  @SerializedName("displayDestinationAccountNumber")
  private String displayDestinationAccountNumber = null;

  public ExternalBankDetails bankCode(String bankCode) {
    this.bankCode = bankCode;
    return this;
  }

   /**
   * This field is to indicate the bank code. Code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions code
   * @return bankCode
  **/
  @Schema(example = "101", required = true, description = "This field is to indicate the bank code. Code assigned by a central bank, a bank supervisory body or a Bankers Association in a country to all its licensed member banks or financial institutions code")
  public String getBankCode() {
    return bankCode;
  }

  public void setBankCode(String bankCode) {
    this.bankCode = bankCode;
  }

  public ExternalBankDetails destinationAccountId(String destinationAccountId) {
    this.destinationAccountId = destinationAccountId;
    return this;
  }

   /**
   * The destination account identifier in encrypted format.Typically, this is not displayed to the customer.
   * @return destinationAccountId
  **/
  @Schema(example = "824f5141524b4d58576853766c786a45376e7637576e6d35695378515a726f494c36367763776775432f453d", required = true, description = "The destination account identifier in encrypted format.Typically, this is not displayed to the customer.")
  public String getDestinationAccountId() {
    return destinationAccountId;
  }

  public void setDestinationAccountId(String destinationAccountId) {
    this.destinationAccountId = destinationAccountId;
  }

  public ExternalBankDetails displayDestinationAccountNumber(String displayDestinationAccountNumber) {
    this.displayDestinationAccountNumber = displayDestinationAccountNumber;
    return this;
  }

   /**
   * A masked account number that can be displayed to the customer
   * @return displayDestinationAccountNumber
  **/
  @Schema(example = "XXXXXX2364", description = "A masked account number that can be displayed to the customer")
  public String getDisplayDestinationAccountNumber() {
    return displayDestinationAccountNumber;
  }

  public void setDisplayDestinationAccountNumber(String displayDestinationAccountNumber) {
    this.displayDestinationAccountNumber = displayDestinationAccountNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ExternalBankDetails externalBankDetails = (ExternalBankDetails) o;
    return Objects.equals(this.bankCode, externalBankDetails.bankCode) &&
        Objects.equals(this.destinationAccountId, externalBankDetails.destinationAccountId) &&
        Objects.equals(this.displayDestinationAccountNumber, externalBankDetails.displayDestinationAccountNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bankCode, destinationAccountId, displayDestinationAccountNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExternalBankDetails {\n");
    
    sb.append("    bankCode: ").append(toIndentedString(bankCode)).append("\n");
    sb.append("    destinationAccountId: ").append(toIndentedString(destinationAccountId)).append("\n");
    sb.append("    displayDestinationAccountNumber: ").append(toIndentedString(displayDestinationAccountNumber)).append("\n");
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
