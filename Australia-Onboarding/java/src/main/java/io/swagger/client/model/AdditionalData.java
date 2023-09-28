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
import io.swagger.client.model.CountrySpecificGroup;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.math.BigDecimal;
/**
 * AdditionalData
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class AdditionalData {
  @SerializedName("numberOfChildren")
  private BigDecimal numberOfChildren = null;

  @SerializedName("numberOfDependents")
  private BigDecimal numberOfDependents = null;

  @SerializedName("staffIndicator")
  private Boolean staffIndicator = null;

  @SerializedName("countrySpecificGroup")
  private CountrySpecificGroup countrySpecificGroup = null;

  public AdditionalData numberOfChildren(BigDecimal numberOfChildren) {
    this.numberOfChildren = numberOfChildren;
    return this;
  }

   /**
   * Number of children
   * @return numberOfChildren
  **/
  @Schema(example = "2.0", description = "Number of children")
  public BigDecimal getNumberOfChildren() {
    return numberOfChildren;
  }

  public void setNumberOfChildren(BigDecimal numberOfChildren) {
    this.numberOfChildren = numberOfChildren;
  }

  public AdditionalData numberOfDependents(BigDecimal numberOfDependents) {
    this.numberOfDependents = numberOfDependents;
    return this;
  }

   /**
   * Number of dependants
   * @return numberOfDependents
  **/
  @Schema(example = "3.0", description = "Number of dependants")
  public BigDecimal getNumberOfDependents() {
    return numberOfDependents;
  }

  public void setNumberOfDependents(BigDecimal numberOfDependents) {
    this.numberOfDependents = numberOfDependents;
  }

  public AdditionalData staffIndicator(Boolean staffIndicator) {
    this.staffIndicator = staffIndicator;
    return this;
  }

   /**
   * Indicates whether prospect is a Citi Staff. Valid values: true and false
   * @return staffIndicator
  **/
  @Schema(example = "true", description = "Indicates whether prospect is a Citi Staff. Valid values: true and false")
  public Boolean isStaffIndicator() {
    return staffIndicator;
  }

  public void setStaffIndicator(Boolean staffIndicator) {
    this.staffIndicator = staffIndicator;
  }

  public AdditionalData countrySpecificGroup(CountrySpecificGroup countrySpecificGroup) {
    this.countrySpecificGroup = countrySpecificGroup;
    return this;
  }

   /**
   * Get countrySpecificGroup
   * @return countrySpecificGroup
  **/
  @Schema(description = "")
  public CountrySpecificGroup getCountrySpecificGroup() {
    return countrySpecificGroup;
  }

  public void setCountrySpecificGroup(CountrySpecificGroup countrySpecificGroup) {
    this.countrySpecificGroup = countrySpecificGroup;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    AdditionalData additionalData = (AdditionalData) o;
    return Objects.equals(this.numberOfChildren, additionalData.numberOfChildren) &&
        Objects.equals(this.numberOfDependents, additionalData.numberOfDependents) &&
        Objects.equals(this.staffIndicator, additionalData.staffIndicator) &&
        Objects.equals(this.countrySpecificGroup, additionalData.countrySpecificGroup);
  }

  @Override
  public int hashCode() {
    return Objects.hash(numberOfChildren, numberOfDependents, staffIndicator, countrySpecificGroup);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class AdditionalData {\n");
    
    sb.append("    numberOfChildren: ").append(toIndentedString(numberOfChildren)).append("\n");
    sb.append("    numberOfDependents: ").append(toIndentedString(numberOfDependents)).append("\n");
    sb.append("    staffIndicator: ").append(toIndentedString(staffIndicator)).append("\n");
    sb.append("    countrySpecificGroup: ").append(toIndentedString(countrySpecificGroup)).append("\n");
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