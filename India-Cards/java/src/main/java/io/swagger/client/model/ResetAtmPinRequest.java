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
 * ResetAtmPinRequest
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class ResetAtmPinRequest {
  @SerializedName("cardId")
  private String cardId = null;

  @SerializedName("newPin")
  private String newPin = null;

  @SerializedName("encryptionType")
  private String encryptionType = null;

  @SerializedName("keyDeviceId")
  private String keyDeviceId = null;

  @SerializedName("keyGenerationId")
  private String keyGenerationId = null;

  public ResetAtmPinRequest cardId(String cardId) {
    this.cardId = cardId;
    return this;
  }

   /**
   * Unique Id of the card in encrypted format.
   * @return cardId
  **/
  @Schema(example = "3255613852316f2b4d4d796c344e38756339654972776f663745446e6d4c32486f455a4165374a476858343d", required = true, description = "Unique Id of the card in encrypted format.")
  public String getCardId() {
    return cardId;
  }

  public void setCardId(String cardId) {
    this.cardId = cardId;
  }

  public ResetAtmPinRequest newPin(String newPin) {
    this.newPin = newPin;
    return this;
  }

   /**
   * New pin in encrypted format.
   * @return newPin
  **/
  @Schema(example = "q745963215y6d4r951753845f455a418789x", required = true, description = "New pin in encrypted format.")
  public String getNewPin() {
    return newPin;
  }

  public void setNewPin(String newPin) {
    this.newPin = newPin;
  }

  public ResetAtmPinRequest encryptionType(String encryptionType) {
    this.encryptionType = encryptionType;
    return this;
  }

   /**
   * Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.
   * @return encryptionType
  **/
  @Schema(example = "E2E", description = "Type of the encryption. This is a reference data field. Please use /v1/apac/utilities/referenceData/{encryptionType} resource to get valid value of this field with description.")
  public String getEncryptionType() {
    return encryptionType;
  }

  public void setEncryptionType(String encryptionType) {
    this.encryptionType = encryptionType;
  }

  public ResetAtmPinRequest keyDeviceId(String keyDeviceId) {
    this.keyDeviceId = keyDeviceId;
    return this;
  }

   /**
   * Label to identify the HSM keys used to encrypt ATM PIN.
   * @return keyDeviceId
  **/
  @Schema(example = "990000862471854", description = "Label to identify the HSM keys used to encrypt ATM PIN.")
  public String getKeyDeviceId() {
    return keyDeviceId;
  }

  public void setKeyDeviceId(String keyDeviceId) {
    this.keyDeviceId = keyDeviceId;
  }

  public ResetAtmPinRequest keyGenerationId(String keyGenerationId) {
    this.keyGenerationId = keyGenerationId;
    return this;
  }

   /**
   * It is the generation ID of the HSM Keys referred for encryption of ATM PIN.
   * @return keyGenerationId
  **/
  @Schema(example = "10000089$71258", description = "It is the generation ID of the HSM Keys referred for encryption of ATM PIN.")
  public String getKeyGenerationId() {
    return keyGenerationId;
  }

  public void setKeyGenerationId(String keyGenerationId) {
    this.keyGenerationId = keyGenerationId;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ResetAtmPinRequest resetAtmPinRequest = (ResetAtmPinRequest) o;
    return Objects.equals(this.cardId, resetAtmPinRequest.cardId) &&
        Objects.equals(this.newPin, resetAtmPinRequest.newPin) &&
        Objects.equals(this.encryptionType, resetAtmPinRequest.encryptionType) &&
        Objects.equals(this.keyDeviceId, resetAtmPinRequest.keyDeviceId) &&
        Objects.equals(this.keyGenerationId, resetAtmPinRequest.keyGenerationId);
  }

  @Override
  public int hashCode() {
    return Objects.hash(cardId, newPin, encryptionType, keyDeviceId, keyGenerationId);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ResetAtmPinRequest {\n");
    
    sb.append("    cardId: ").append(toIndentedString(cardId)).append("\n");
    sb.append("    newPin: ").append(toIndentedString(newPin)).append("\n");
    sb.append("    encryptionType: ").append(toIndentedString(encryptionType)).append("\n");
    sb.append("    keyDeviceId: ").append(toIndentedString(keyDeviceId)).append("\n");
    sb.append("    keyGenerationId: ").append(toIndentedString(keyGenerationId)).append("\n");
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
