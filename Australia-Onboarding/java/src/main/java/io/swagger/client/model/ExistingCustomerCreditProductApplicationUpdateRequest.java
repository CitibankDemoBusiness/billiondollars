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
import io.swagger.client.model.ECMApplicantUpdate;
import io.swagger.client.model.ECMProductUpdate;
import io.swagger.client.model.SalesAgentDetails;
import io.swagger.client.model.SurvivorProduct;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
/**
 * ExistingCustomerCreditProductApplicationUpdateRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ExistingCustomerCreditProductApplicationUpdateRequest {
  @SerializedName("product")
  private ECMProductUpdate product = null;

  @SerializedName("survivorProduct")
  private SurvivorProduct survivorProduct = null;

  @SerializedName("applicant")
  private ECMApplicantUpdate applicant = null;

  @SerializedName("salesAgentDetails")
  private SalesAgentDetails salesAgentDetails = null;

  @SerializedName("controlFlowId")
  private String controlFlowId = null;

  public ExistingCustomerCreditProductApplicationUpdateRequest product(ECMProductUpdate product) {
    this.product = product;
    return this;
  }

   /**
   * Get product
   * @return product
  **/
  @Schema(description = "")
  public ECMProductUpdate getProduct() {
    return product;
  }

  public void setProduct(ECMProductUpdate product) {
    this.product = product;
  }

  public ExistingCustomerCreditProductApplicationUpdateRequest survivorProduct(SurvivorProduct survivorProduct) {
    this.survivorProduct = survivorProduct;
    return this;
  }

   /**
   * Get survivorProduct
   * @return survivorProduct
  **/
  @Schema(description = "")
  public SurvivorProduct getSurvivorProduct() {
    return survivorProduct;
  }

  public void setSurvivorProduct(SurvivorProduct survivorProduct) {
    this.survivorProduct = survivorProduct;
  }

  public ExistingCustomerCreditProductApplicationUpdateRequest applicant(ECMApplicantUpdate applicant) {
    this.applicant = applicant;
    return this;
  }

   /**
   * Get applicant
   * @return applicant
  **/
  @Schema(description = "")
  public ECMApplicantUpdate getApplicant() {
    return applicant;
  }

  public void setApplicant(ECMApplicantUpdate applicant) {
    this.applicant = applicant;
  }

  public ExistingCustomerCreditProductApplicationUpdateRequest salesAgentDetails(SalesAgentDetails salesAgentDetails) {
    this.salesAgentDetails = salesAgentDetails;
    return this;
  }

   /**
   * Get salesAgentDetails
   * @return salesAgentDetails
  **/
  @Schema(description = "")
  public SalesAgentDetails getSalesAgentDetails() {
    return salesAgentDetails;
  }

  public void setSalesAgentDetails(SalesAgentDetails salesAgentDetails) {
    this.salesAgentDetails = salesAgentDetails;
  }

  public ExistingCustomerCreditProductApplicationUpdateRequest controlFlowId(String controlFlowId) {
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
    ExistingCustomerCreditProductApplicationUpdateRequest existingCustomerCreditProductApplicationUpdateRequest = (ExistingCustomerCreditProductApplicationUpdateRequest) o;
    return Objects.equals(this.product, existingCustomerCreditProductApplicationUpdateRequest.product) &&
        Objects.equals(this.survivorProduct, existingCustomerCreditProductApplicationUpdateRequest.survivorProduct) &&
        Objects.equals(this.applicant, existingCustomerCreditProductApplicationUpdateRequest.applicant) &&
        Objects.equals(this.salesAgentDetails, existingCustomerCreditProductApplicationUpdateRequest.salesAgentDetails) &&
        Objects.equals(this.controlFlowId, existingCustomerCreditProductApplicationUpdateRequest.controlFlowId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(product, survivorProduct, applicant, salesAgentDetails, controlFlowId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ExistingCustomerCreditProductApplicationUpdateRequest {\n");
    
    sb.append("    product: ").append(toIndentedString(product)).append("\n");
    sb.append("    survivorProduct: ").append(toIndentedString(survivorProduct)).append("\n");
    sb.append("    applicant: ").append(toIndentedString(applicant)).append("\n");
    sb.append("    salesAgentDetails: ").append(toIndentedString(salesAgentDetails)).append("\n");
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