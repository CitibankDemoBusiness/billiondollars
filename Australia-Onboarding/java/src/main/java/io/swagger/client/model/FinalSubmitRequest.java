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
 * FinalSubmitRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class FinalSubmitRequest {
  @SerializedName("controlFlowId")
  private String controlFlowId = null;

  public FinalSubmitRequest controlFlowId(String controlFlowId) {
    this.controlFlowId = controlFlowId;
    return this;
  }

   /**
   * Control Flow Id
   * @return controlFlowId
  **/
  @Schema(example = "6e3774334f724a2b7947663653712f52456f524c41797038516a59347a437549564a77755676376e616a733d", required = true, description = "Control Flow Id")
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
    FinalSubmitRequest finalSubmitRequest = (FinalSubmitRequest) o;
    return Objects.equals(this.controlFlowId, finalSubmitRequest.controlFlowId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(controlFlowId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FinalSubmitRequest {\n");
    
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
