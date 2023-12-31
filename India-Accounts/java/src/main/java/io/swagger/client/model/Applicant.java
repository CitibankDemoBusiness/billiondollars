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
import io.swagger.client.model.Address;
import io.swagger.client.model.ConsentDetails;
import io.swagger.client.model.EmploymentDetails;
import io.swagger.client.model.FinancialInformation;
import io.swagger.client.model.Phone;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * Applicant
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:57:33.628989Z[Etc/UTC]")
public class Applicant {
  @SerializedName("consentDetails")
  private List<ConsentDetails> consentDetails = null;

  @SerializedName("employmentDetails")
  private List<EmploymentDetails> employmentDetails = null;

  @SerializedName("financialInformation")
  private FinancialInformation financialInformation = null;

  @SerializedName("address")
  private List<Address> address = null;

  @SerializedName("phone")
  private List<Phone> phone = null;

  public Applicant consentDetails(List<ConsentDetails> consentDetails) {
    this.consentDetails = consentDetails;
    return this;
  }

  public Applicant addConsentDetailsItem(ConsentDetails consentDetailsItem) {
    if (this.consentDetails == null) {
      this.consentDetails = new ArrayList<ConsentDetails>();
    }
    this.consentDetails.add(consentDetailsItem);
    return this;
  }

   /**
   * Get consentDetails
   * @return consentDetails
  **/
  @Schema(description = "")
  public List<ConsentDetails> getConsentDetails() {
    return consentDetails;
  }

  public void setConsentDetails(List<ConsentDetails> consentDetails) {
    this.consentDetails = consentDetails;
  }

  public Applicant employmentDetails(List<EmploymentDetails> employmentDetails) {
    this.employmentDetails = employmentDetails;
    return this;
  }

  public Applicant addEmploymentDetailsItem(EmploymentDetails employmentDetailsItem) {
    if (this.employmentDetails == null) {
      this.employmentDetails = new ArrayList<EmploymentDetails>();
    }
    this.employmentDetails.add(employmentDetailsItem);
    return this;
  }

   /**
   * Get employmentDetails
   * @return employmentDetails
  **/
  @Schema(description = "")
  public List<EmploymentDetails> getEmploymentDetails() {
    return employmentDetails;
  }

  public void setEmploymentDetails(List<EmploymentDetails> employmentDetails) {
    this.employmentDetails = employmentDetails;
  }

  public Applicant financialInformation(FinancialInformation financialInformation) {
    this.financialInformation = financialInformation;
    return this;
  }

   /**
   * Get financialInformation
   * @return financialInformation
  **/
  @Schema(description = "")
  public FinancialInformation getFinancialInformation() {
    return financialInformation;
  }

  public void setFinancialInformation(FinancialInformation financialInformation) {
    this.financialInformation = financialInformation;
  }

  public Applicant address(List<Address> address) {
    this.address = address;
    return this;
  }

  public Applicant addAddressItem(Address addressItem) {
    if (this.address == null) {
      this.address = new ArrayList<Address>();
    }
    this.address.add(addressItem);
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @Schema(description = "")
  public List<Address> getAddress() {
    return address;
  }

  public void setAddress(List<Address> address) {
    this.address = address;
  }

  public Applicant phone(List<Phone> phone) {
    this.phone = phone;
    return this;
  }

  public Applicant addPhoneItem(Phone phoneItem) {
    if (this.phone == null) {
      this.phone = new ArrayList<Phone>();
    }
    this.phone.add(phoneItem);
    return this;
  }

   /**
   * Get phone
   * @return phone
  **/
  @Schema(description = "")
  public List<Phone> getPhone() {
    return phone;
  }

  public void setPhone(List<Phone> phone) {
    this.phone = phone;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Applicant applicant = (Applicant) o;
    return Objects.equals(this.consentDetails, applicant.consentDetails) &&
        Objects.equals(this.employmentDetails, applicant.employmentDetails) &&
        Objects.equals(this.financialInformation, applicant.financialInformation) &&
        Objects.equals(this.address, applicant.address) &&
        Objects.equals(this.phone, applicant.phone);
  }

  @Override
  public int hashCode() {
    return Objects.hash(consentDetails, employmentDetails, financialInformation, address, phone);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Applicant {\n");
    
    sb.append("    consentDetails: ").append(toIndentedString(consentDetails)).append("\n");
    sb.append("    employmentDetails: ").append(toIndentedString(employmentDetails)).append("\n");
    sb.append("    financialInformation: ").append(toIndentedString(financialInformation)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    phone: ").append(toIndentedString(phone)).append("\n");
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
