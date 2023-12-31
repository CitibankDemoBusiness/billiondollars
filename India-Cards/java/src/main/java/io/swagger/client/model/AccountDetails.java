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
 * AccountDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class AccountDetails {
  @SerializedName("accountId")
  private String accountId = null;

  @SerializedName("enrollmentStatusFlag")
  private Boolean enrollmentStatusFlag = null;

  public AccountDetails accountId(String accountId) {
    this.accountId = accountId;
    return this;
  }

   /**
   * The customer account identifier in encrypted format
   * @return accountId
  **/
  @Schema(example = "6555613852316t3c4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858353b", required = true, description = "The customer account identifier in encrypted format")
  public String getAccountId() {
    return accountId;
  }

  public void setAccountId(String accountId) {
    this.accountId = accountId;
  }

  public AccountDetails enrollmentStatusFlag(Boolean enrollmentStatusFlag) {
    this.enrollmentStatusFlag = enrollmentStatusFlag;
    return this;
  }

   /**
   * This field is to indicate if the  account is enrolled for multi currency account or not.
   * @return enrollmentStatusFlag
  **/
  @Schema(example = "true", required = true, description = "This field is to indicate if the  account is enrolled for multi currency account or not.")
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
    AccountDetails accountDetails = (AccountDetails) o;
    return Objects.equals(this.accountId, accountDetails.accountId) &&
        Objects.equals(this.enrollmentStatusFlag, accountDetails.enrollmentStatusFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(accountId, enrollmentStatusFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AccountDetails {\n");
    
    sb.append("    accountId: ").append(toIndentedString(accountId)).append("\n");
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
