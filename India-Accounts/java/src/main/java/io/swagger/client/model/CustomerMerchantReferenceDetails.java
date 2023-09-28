/*
 * Accounts
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * CustomerMerchantReferenceDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class CustomerMerchantReferenceDetails {
  @SerializedName("customerMerchantReferenceCode")
  private String customerMerchantReferenceCode = null;

  @SerializedName("customerMerchantReferenceDescription")
  private String customerMerchantReferenceDescription = null;

  public CustomerMerchantReferenceDetails customerMerchantReferenceCode(String customerMerchantReferenceCode) {
    this.customerMerchantReferenceCode = customerMerchantReferenceCode;
    return this;
  }

   /**
   * Additional bill reference code.
   * @return customerMerchantReferenceCode
  **/
  @Schema(example = "EAMA", required = true, description = "Additional bill reference code.")
  public String getCustomerMerchantReferenceCode() {
    return customerMerchantReferenceCode;
  }

  public void setCustomerMerchantReferenceCode(String customerMerchantReferenceCode) {
    this.customerMerchantReferenceCode = customerMerchantReferenceCode;
  }

  public CustomerMerchantReferenceDetails customerMerchantReferenceDescription(String customerMerchantReferenceDescription) {
    this.customerMerchantReferenceDescription = customerMerchantReferenceDescription;
    return this;
  }

   /**
   * The value associated with the corresponding additional Bill Reference Code.
   * @return customerMerchantReferenceDescription
  **/
  @Schema(example = "1234123412345", required = true, description = "The value associated with the corresponding additional Bill Reference Code.")
  public String getCustomerMerchantReferenceDescription() {
    return customerMerchantReferenceDescription;
  }

  public void setCustomerMerchantReferenceDescription(String customerMerchantReferenceDescription) {
    this.customerMerchantReferenceDescription = customerMerchantReferenceDescription;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CustomerMerchantReferenceDetails customerMerchantReferenceDetails = (CustomerMerchantReferenceDetails) o;
    return Objects.equals(this.customerMerchantReferenceCode, customerMerchantReferenceDetails.customerMerchantReferenceCode) &&
        Objects.equals(this.customerMerchantReferenceDescription, customerMerchantReferenceDetails.customerMerchantReferenceDescription);
  }

  @Override
  public int hashCode() {
    return Objects.hash(customerMerchantReferenceCode, customerMerchantReferenceDescription);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CustomerMerchantReferenceDetails {\n");
    
    sb.append("    customerMerchantReferenceCode: ").append(toIndentedString(customerMerchantReferenceCode)).append("\n");
    sb.append("    customerMerchantReferenceDescription: ").append(toIndentedString(customerMerchantReferenceDescription)).append("\n");
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