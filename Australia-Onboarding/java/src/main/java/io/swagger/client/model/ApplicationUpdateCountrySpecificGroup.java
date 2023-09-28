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
 * ApplicationUpdateCountrySpecificGroup
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicationUpdateCountrySpecificGroup {
  @SerializedName("bumiputraIndicator")
  private Boolean bumiputraIndicator = null;

  @SerializedName("disabilityIndicator")
  private Boolean disabilityIndicator = null;

  @SerializedName("unionPayCardNumber")
  private String unionPayCardNumber = null;

  @SerializedName("taxFileNumber")
  private String taxFileNumber = null;

  public ApplicationUpdateCountrySpecificGroup bumiputraIndicator(Boolean bumiputraIndicator) {
    this.bumiputraIndicator = bumiputraIndicator;
    return this;
  }

   /**
   * Indicator to specify the regional race and other indigenous peoples of Southeast Asia, and used particularly in Malaysia. Valid values: true and false.
   * @return bumiputraIndicator
  **/
  @Schema(example = "true", description = "Indicator to specify the regional race and other indigenous peoples of Southeast Asia, and used particularly in Malaysia. Valid values: true and false.")
  public Boolean isBumiputraIndicator() {
    return bumiputraIndicator;
  }

  public void setBumiputraIndicator(Boolean bumiputraIndicator) {
    this.bumiputraIndicator = bumiputraIndicator;
  }

  public ApplicationUpdateCountrySpecificGroup disabilityIndicator(Boolean disabilityIndicator) {
    this.disabilityIndicator = disabilityIndicator;
    return this;
  }

   /**
   * The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false. Applicable to Singapore only
   * @return disabilityIndicator
  **/
  @Schema(example = "true", description = "The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false. Applicable to Singapore only")
  public Boolean isDisabilityIndicator() {
    return disabilityIndicator;
  }

  public void setDisabilityIndicator(Boolean disabilityIndicator) {
    this.disabilityIndicator = disabilityIndicator;
  }

  public ApplicationUpdateCountrySpecificGroup unionPayCardNumber(String unionPayCardNumber) {
    this.unionPayCardNumber = unionPayCardNumber;
    return this;
  }

   /**
   * Applicant&#x27;s union pay card number to link the product and applicable to China only
   * @return unionPayCardNumber
  **/
  @Schema(example = "5555666600008888", description = "Applicant's union pay card number to link the product and applicable to China only")
  public String getUnionPayCardNumber() {
    return unionPayCardNumber;
  }

  public void setUnionPayCardNumber(String unionPayCardNumber) {
    this.unionPayCardNumber = unionPayCardNumber;
  }

  public ApplicationUpdateCountrySpecificGroup taxFileNumber(String taxFileNumber) {
    this.taxFileNumber = taxFileNumber;
    return this;
  }

   /**
   * Applicant&#x27;s tax file number to link the product and applicable to Australia only
   * @return taxFileNumber
  **/
  @Schema(example = "656456737", description = "Applicant's tax file number to link the product and applicable to Australia only")
  public String getTaxFileNumber() {
    return taxFileNumber;
  }

  public void setTaxFileNumber(String taxFileNumber) {
    this.taxFileNumber = taxFileNumber;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicationUpdateCountrySpecificGroup applicationUpdateCountrySpecificGroup = (ApplicationUpdateCountrySpecificGroup) o;
    return Objects.equals(this.bumiputraIndicator, applicationUpdateCountrySpecificGroup.bumiputraIndicator) &&
        Objects.equals(this.disabilityIndicator, applicationUpdateCountrySpecificGroup.disabilityIndicator) &&
        Objects.equals(this.unionPayCardNumber, applicationUpdateCountrySpecificGroup.unionPayCardNumber) &&
        Objects.equals(this.taxFileNumber, applicationUpdateCountrySpecificGroup.taxFileNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bumiputraIndicator, disabilityIndicator, unionPayCardNumber, taxFileNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicationUpdateCountrySpecificGroup {\n");
    
    sb.append("    bumiputraIndicator: ").append(toIndentedString(bumiputraIndicator)).append("\n");
    sb.append("    disabilityIndicator: ").append(toIndentedString(disabilityIndicator)).append("\n");
    sb.append("    unionPayCardNumber: ").append(toIndentedString(unionPayCardNumber)).append("\n");
    sb.append("    taxFileNumber: ").append(toIndentedString(taxFileNumber)).append("\n");
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