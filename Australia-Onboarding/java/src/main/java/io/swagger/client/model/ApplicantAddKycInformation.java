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
 * ApplicantAddKycInformation
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicantAddKycInformation {
  @SerializedName("selfPublicFigureDeclarationFlag")
  private Boolean selfPublicFigureDeclarationFlag = null;

  public ApplicantAddKycInformation selfPublicFigureDeclarationFlag(Boolean selfPublicFigureDeclarationFlag) {
    this.selfPublicFigureDeclarationFlag = selfPublicFigureDeclarationFlag;
    return this;
  }

   /**
   * Flag for self declaration if applicant is public figure. Valid values: true and false
   * @return selfPublicFigureDeclarationFlag
  **/
  @Schema(example = "true", description = "Flag for self declaration if applicant is public figure. Valid values: true and false")
  public Boolean isSelfPublicFigureDeclarationFlag() {
    return selfPublicFigureDeclarationFlag;
  }

  public void setSelfPublicFigureDeclarationFlag(Boolean selfPublicFigureDeclarationFlag) {
    this.selfPublicFigureDeclarationFlag = selfPublicFigureDeclarationFlag;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicantAddKycInformation applicantAddKycInformation = (ApplicantAddKycInformation) o;
    return Objects.equals(this.selfPublicFigureDeclarationFlag, applicantAddKycInformation.selfPublicFigureDeclarationFlag);
  }

  @Override
  public int hashCode() {
    return Objects.hash(selfPublicFigureDeclarationFlag);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicantAddKycInformation {\n");
    
    sb.append("    selfPublicFigureDeclarationFlag: ").append(toIndentedString(selfPublicFigureDeclarationFlag)).append("\n");
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
