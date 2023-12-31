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
import io.swagger.client.model.BankDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * BinaryData
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class BinaryData {
  @SerializedName("disbursementOption")
  private String disbursementOption = null;

  @SerializedName("disbursementAccountId")
  private String disbursementAccountId = null;

  @SerializedName("payeeId")
  private String payeeId = null;

  @SerializedName("bankDetails")
  private BankDetails bankDetails = null;

  public BinaryData disbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
    return this;
  }

   /**
   * This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.
   * @return disbursementOption
  **/
  @Schema(example = "STANDING_INSTRUCTION", required = true, description = "This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.")
  public String getDisbursementOption() {
    return disbursementOption;
  }

  public void setDisbursementOption(String disbursementOption) {
    this.disbursementOption = disbursementOption;
  }

  public BinaryData disbursementAccountId(String disbursementAccountId) {
    this.disbursementAccountId = disbursementAccountId;
    return this;
  }

   /**
   * The account Id of the account to which Loan amount is to be disbursed.
   * @return disbursementAccountId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", description = "The account Id of the account to which Loan amount is to be disbursed.")
  public String getDisbursementAccountId() {
    return disbursementAccountId;
  }

  public void setDisbursementAccountId(String disbursementAccountId) {
    this.disbursementAccountId = disbursementAccountId;
  }

  public BinaryData payeeId(String payeeId) {
    this.payeeId = payeeId;
    return this;
  }

   /**
   * Unique identifier associated with the payee.Typically, this is not displayed to the customer.
   * @return payeeId
  **/
  @Schema(example = "C$0003019202$AU$XX$01000540000001", description = "Unique identifier associated with the payee.Typically, this is not displayed to the customer.")
  public String getPayeeId() {
    return payeeId;
  }

  public void setPayeeId(String payeeId) {
    this.payeeId = payeeId;
  }

  public BinaryData bankDetails(BankDetails bankDetails) {
    this.bankDetails = bankDetails;
    return this;
  }

   /**
   * Get bankDetails
   * @return bankDetails
  **/
  @Schema(description = "")
  public BankDetails getBankDetails() {
    return bankDetails;
  }

  public void setBankDetails(BankDetails bankDetails) {
    this.bankDetails = bankDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    BinaryData binaryData = (BinaryData) o;
    return Objects.equals(this.disbursementOption, binaryData.disbursementOption) &&
        Objects.equals(this.disbursementAccountId, binaryData.disbursementAccountId) &&
        Objects.equals(this.payeeId, binaryData.payeeId) &&
        Objects.equals(this.bankDetails, binaryData.bankDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(disbursementOption, disbursementAccountId, payeeId, bankDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class BinaryData {\n");
    
    sb.append("    disbursementOption: ").append(toIndentedString(disbursementOption)).append("\n");
    sb.append("    disbursementAccountId: ").append(toIndentedString(disbursementAccountId)).append("\n");
    sb.append("    payeeId: ").append(toIndentedString(payeeId)).append("\n");
    sb.append("    bankDetails: ").append(toIndentedString(bankDetails)).append("\n");
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
