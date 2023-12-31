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
import io.swagger.client.model.AccountDetails;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * MultiCurrencyAccountEnrollmentResponse
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class MultiCurrencyAccountEnrollmentResponse {
  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("enrollmentStatusFlag")
  private Boolean enrollmentStatusFlag = null;

  @SerializedName("accountDetails")
  private List<AccountDetails> accountDetails = null;

  public MultiCurrencyAccountEnrollmentResponse cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * The customer card identifier in encrypted format
   * @return cardId
  **/
  @Schema(example = "6555613852316t3c4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858353b", required = true, description = "The customer card identifier in encrypted format")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public MultiCurrencyAccountEnrollmentResponse enrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
    return this;
  }

   /**
   * This field is to indicate if the card is enrolled for multi currency account or not.
   * @return enrollmentStatusFlag
  **/
  @Schema(example = "true", description = "This field is to indicate if the card is enrolled for multi currency account or not.")
  public Boolean isEnrollmentStatusFlag() {
    return enrollmentStatusFlag;
  }

  public void setEnrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
  }

  public MultiCurrencyAccountEnrollmentResponse accountDetails(List<AccountDetails> accountDetails) {
    this.accountDetails = accountDetails;
    return this;
  }

  public MultiCurrencyAccountEnrollmentResponse addAccountDetailsItem(AccountDetails accountDetailsItem) {
    if (this.accountDetails == null) {
      this.accountDetails = new ArrayList<AccountDetails>();
    }
    this.accountDetails.add(accountDetailsItem);
    return this;
  }

   /**
   * Get accountDetails
   * @return accountDetails
  **/
  @Schema(description = "")
  public List<AccountDetails> getAccountDetails() {
    return accountDetails;
  }

  public void setAccountDetails(List<AccountDetails> accountDetails) {
    this.accountDetails = accountDetails;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    MultiCurrencyAccountEnrollmentResponse multiCurrencyAccountEnrollmentResponse = (MultiCurrencyAccountEnrollmentResponse) o;
    return Objects.equals(this.cardId, multiCurrencyAccountEnrollmentResponse.cardId) &&
        Objects.equals(this.enrollmentStatusFlag, multiCurrencyAccountEnrollmentResponse.enrollmentStatusFlag) &&
        Objects.equals(this.accountDetails, multiCurrencyAccountEnrollmentResponse.accountDetails);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardId, enrollmentStatusFlag, accountDetails);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class MultiCurrencyAccountEnrollmentResponse {\n");
    
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    enrollmentStatusFlag: ").append(toIndentedString(enrollmentStatusFlag)).append("\n");
    sb.append("    accountDetails: ").append(toIndentedString(accountDetails)).append("\n");
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
