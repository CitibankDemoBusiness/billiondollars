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
 * CountrySpecificGroup
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class CountrySpecificGroup {
  @SerializedName("bumiputraIndicator")
  private Boolean bumiputraIndicator = null;

  @SerializedName("ethnicGroup")
  private String ethnicGroup = null;

  @SerializedName("disabilityIndicator")
  private Boolean disabilityIndicator = null;

  @SerializedName("unionPayCardNumber")
  private String unionPayCardNumber = null;

  @SerializedName("taxFileNumber")
  private String taxFileNumber = null;

  public CountrySpecificGroup bumiputraIndicator(Boolean bumiputraIndicator) {
    this.bumiputraIndicator = bumiputraIndicator;
    return this;
  }

   /**
   * Bumiputra indicator (whether the person is from Malay ethnic group/son of soil). Valid values: true and false
   * @return bumiputraIndicator
  **/
  @Schema(example = "true", description = "Bumiputra indicator (whether the person is from Malay ethnic group/son of soil). Valid values: true and false")
  public Boolean isBumiputraIndicator() {
    return bumiputraIndicator;
  }

  public void setBumiputraIndicator(Boolean bumiputraIndicator) {
    this.bumiputraIndicator = bumiputraIndicator;
  }

  public CountrySpecificGroup ethnicGroup(String ethnicGroup) {
    this.ethnicGroup = ethnicGroup;
    return this;
  }

   /**
   * Ethnic group.
   * @return ethnicGroup
  **/
  @Schema(example = "English", description = "Ethnic group.")
  public String getEthnicGroup() {
    return ethnicGroup;
  }

  public void setEthnicGroup(String ethnicGroup) {
    this.ethnicGroup = ethnicGroup;
  }

  public CountrySpecificGroup disabilityIndicator(Boolean disabilityIndicator) {
    this.disabilityIndicator = disabilityIndicator;
    return this;
  }

   /**
   * Applicable for some countries. The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false
   * @return disabilityIndicator
  **/
  @Schema(example = "true", description = "Applicable for some countries. The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false")
  public Boolean isDisabilityIndicator() {
    return disabilityIndicator;
  }

  public void setDisabilityIndicator(Boolean disabilityIndicator) {
    this.disabilityIndicator = disabilityIndicator;
  }

  public CountrySpecificGroup unionPayCardNumber(String unionPayCardNumber) {
    this.unionPayCardNumber = unionPayCardNumber;
    return this;
  }

   /**
   * Country: CN Specific to get the UnionPayCardNumber to link the product
   * @return unionPayCardNumber
  **/
  @Schema(example = "5555666600004444", description = "Country: CN Specific to get the UnionPayCardNumber to link the product")
  public String getUnionPayCardNumber() {
    return unionPayCardNumber;
  }

  public void setUnionPayCardNumber(String unionPayCardNumber) {
    this.unionPayCardNumber = unionPayCardNumber;
  }

  public CountrySpecificGroup taxFileNumber(String taxFileNumber) {
    this.taxFileNumber = taxFileNumber;
    return this;
  }

   /**
   * Country: AU Specific TaxFileNumber
   * @return taxFileNumber
  **/
  @Schema(example = "34534634734", description = "Country: AU Specific TaxFileNumber")
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
    CountrySpecificGroup countrySpecificGroup = (CountrySpecificGroup) o;
    return Objects.equals(this.bumiputraIndicator, countrySpecificGroup.bumiputraIndicator) &&
        Objects.equals(this.ethnicGroup, countrySpecificGroup.ethnicGroup) &&
        Objects.equals(this.disabilityIndicator, countrySpecificGroup.disabilityIndicator) &&
        Objects.equals(this.unionPayCardNumber, countrySpecificGroup.unionPayCardNumber) &&
        Objects.equals(this.taxFileNumber, countrySpecificGroup.taxFileNumber);
  }

  @Override
  public int hashCode() {
    return Objects.hash(bumiputraIndicator, ethnicGroup, disabilityIndicator, unionPayCardNumber, taxFileNumber);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CountrySpecificGroup {\n");
    
    sb.append("    bumiputraIndicator: ").append(toIndentedString(bumiputraIndicator)).append("\n");
    sb.append("    ethnicGroup: ").append(toIndentedString(ethnicGroup)).append("\n");
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
