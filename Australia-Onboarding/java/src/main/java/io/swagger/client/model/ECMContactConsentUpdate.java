/*
 * Onboarding
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
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
 * ECMContactConsentUpdate
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ECMContactConsentUpdate {
  @SerializedName("okToCall")
  private Boolean okToCall = null;

  @SerializedName("okToMail")
  private Boolean okToMail = null;

  public ECMContactConsentUpdate okToCall(Boolean okToCall) {
    this.okToCall = okToCall;
    return this;
  }

   /**
   * Applicants consent for receiving phone calls. Valid values: true and false
   * @return okToCall
  **/
  @Schema(description = "Applicants consent for receiving phone calls. Valid values: true and false")
  public Boolean isOkToCall() {
    return okToCall;
  }

  public void setOkToCall(Boolean okToCall) {
    this.okToCall = okToCall;
  }

  public ECMContactConsentUpdate okToMail(Boolean okToMail) {
    this.okToMail = okToMail;
    return this;
  }

   /**
   * Applicants consent for receiving mails. Valid values: true and false
   * @return okToMail
  **/
  @Schema(description = "Applicants consent for receiving mails. Valid values: true and false")
  public Boolean isOkToMail() {
    return okToMail;
  }

  public void setOkToMail(Boolean okToMail) {
    this.okToMail = okToMail;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ECMContactConsentUpdate ecMContactConsentUpdate = (ECMContactConsentUpdate) o;
    return Objects.equals(this.okToCall, ecMContactConsentUpdate.okToCall) &&
        Objects.equals(this.okToMail, ecMContactConsentUpdate.okToMail);
  }

  @Override
  public int hashCode() {
    return Objects.hash(okToCall, okToMail);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ECMContactConsentUpdate {\n");
    
    sb.append("    okToCall: ").append(toIndentedString(okToCall)).append("\n");
    sb.append("    okToMail: ").append(toIndentedString(okToMail)).append("\n");
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
