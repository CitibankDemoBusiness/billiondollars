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
import io.swagger.client.model.ApplicationUpdateApplicant;
import io.swagger.client.model.ApplicationUpdateProduct;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ApplicationUpdateRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationUpdateRequest {
  @SerializedName("product")
  private ApplicationUpdateProduct product = null;

  @SerializedName("applicant")
  private ApplicationUpdateApplicant applicant = null;

  @SerializedName("controlFlowId")
  private String controlFlowId = null;

  public ApplicationUpdateRequest product(ApplicationUpdateProduct product) {
    this.product = product;
    return this;
  }

   /**
   * Get product
   * @return product
  **/
  @Schema(description = "")
  public ApplicationUpdateProduct getProduct() {
    return product;
  }

  public void setProduct(ApplicationUpdateProduct product) {
    this.product = product;
  }

  public ApplicationUpdateRequest applicant(ApplicationUpdateApplicant applicant) {
    this.applicant = applicant;
    return this;
  }

   /**
   * Get applicant
   * @return applicant
  **/
  @Schema(description = "")
  public ApplicationUpdateApplicant getApplicant() {
    return applicant;
  }

  public void setApplicant(ApplicationUpdateApplicant applicant) {
    this.applicant = applicant;
  }

  public ApplicationUpdateRequest controlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
    return this;
  }

   /**
   * Control flow id is used to control the flow for subsequent requests in the session.
   * @return controlFlowId
  **/
  @Schema(example = "6e3774334f724a2b7947663653712f52456f524c41797038516a59347a437549564a77755676376e616a733d", required = true, description = "Control flow id is used to control the flow for subsequent requests in the session.")
  public String getControlFlowId() {
    return controlFlowId;
  }

  public void setControlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationUpdateRequest applicationUpdateRequest = (ApplicationUpdateRequest) o;
    return Objects.equals(this.product, applicationUpdateRequest.product) &&
        Objects.equals(this.applicant, applicationUpdateRequest.applicant) &&
        Objects.equals(this.controlFlowId, applicationUpdateRequest.controlFlowId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(product, applicant, controlFlowId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationUpdateRequest {\n");
    
    sb.append("    product: ").append(toIndentedString(product)).append("\n");
    sb.append("    applicant: ").append(toIndentedString(applicant)).append("\n");
    sb.append("    controlFlowId: ").append(toIndentedString(controlFlowId)).append("\n");
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
