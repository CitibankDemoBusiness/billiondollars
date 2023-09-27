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
import io.swagger.client.model.AdditionalData;
import io.swagger.client.model.Address;
import io.swagger.client.model.ContactPreference;
import io.swagger.client.model.Demographics;
import io.swagger.client.model.Education;
import io.swagger.client.model.Email;
import io.swagger.client.model.EmploymentDetails;
import io.swagger.client.model.FinancialInformation;
import io.swagger.client.model.IdentificationDocumentDetails;
import io.swagger.client.model.KycInformation;
import io.swagger.client.model.Name;
import io.swagger.client.model.Phone;
import io.swagger.client.model.SelfDeclaration;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * Prospect
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class Prospect {
  @SerializedName("motherMaidenName")
  private String motherMaidenName = null;

  @SerializedName("name")
  private Name name = null;

  @SerializedName("demographics")
  private Demographics demographics = null;

  @SerializedName("address")
  private List<Address> address = new ArrayList<Address>();

  @SerializedName("email")
  private List<Email> email = new ArrayList<Email>();

  @SerializedName("phone")
  private List<Phone> phone = new ArrayList<Phone>();

  @SerializedName("contactPreference")
  private ContactPreference contactPreference = null;

  @SerializedName("financialInformation")
  private FinancialInformation financialInformation = null;

  @SerializedName("education")
  private Education education = null;

  @SerializedName("employmentDetails")
  private List<EmploymentDetails> employmentDetails = null;

  @SerializedName("identificationDocumentDetails")
  private List<IdentificationDocumentDetails> identificationDocumentDetails = null;

  @SerializedName("additionalData")
  private AdditionalData additionalData = null;

  @SerializedName("selfDeclaration")
  private SelfDeclaration selfDeclaration = null;

  @SerializedName("kycInformation")
  private KycInformation kycInformation = null;

  public Prospect motherMaidenName(String motherMaidenName) {
    this.motherMaidenName = motherMaidenName;
    return this;
  }

   /**
   * Mother&#x27;s maiden name
   * @return motherMaidenName
  **/
  @Schema(example = "Lisa", description = "Mother's maiden name")
  public String getMotherMaidenName() {
    return motherMaidenName;
  }

  public void setMotherMaidenName(String motherMaidenName) {
    this.motherMaidenName = motherMaidenName;
  }

  public Prospect name(Name name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(required = true, description = "")
  public Name getName() {
    return name;
  }

  public void setName(Name name) {
    this.name = name;
  }

  public Prospect demographics(Demographics demographics) {
    this.demographics = demographics;
    return this;
  }

   /**
   * Get demographics
   * @return demographics
  **/
  @Schema(description = "")
  public Demographics getDemographics() {
    return demographics;
  }

  public void setDemographics(Demographics demographics) {
    this.demographics = demographics;
  }

  public Prospect address(List<Address> address) {
    this.address = address;
    return this;
  }

  public Prospect addAddressItem(Address addressItem) {
    this.address.add(addressItem);
    return this;
  }

   /**
   * Get address
   * @return address
  **/
  @Schema(required = true, description = "")
  public List<Address> getAddress() {
    return address;
  }

  public void setAddress(List<Address> address) {
    this.address = address;
  }

  public Prospect email(List<Email> email) {
    this.email = email;
    return this;
  }

  public Prospect addEmailItem(Email emailItem) {
    this.email.add(emailItem);
    return this;
  }

   /**
   * Get email
   * @return email
  **/
  @Schema(required = true, description = "")
  public List<Email> getEmail() {
    return email;
  }

  public void setEmail(List<Email> email) {
    this.email = email;
  }

  public Prospect phone(List<Phone> phone) {
    this.phone = phone;
    return this;
  }

  public Prospect addPhoneItem(Phone phoneItem) {
    this.phone.add(phoneItem);
    return this;
  }

   /**
   * Get phone
   * @return phone
  **/
  @Schema(required = true, description = "")
  public List<Phone> getPhone() {
    return phone;
  }

  public void setPhone(List<Phone> phone) {
    this.phone = phone;
  }

  public Prospect contactPreference(ContactPreference contactPreference) {
    this.contactPreference = contactPreference;
    return this;
  }

   /**
   * Get contactPreference
   * @return contactPreference
  **/
  @Schema(required = true, description = "")
  public ContactPreference getContactPreference() {
    return contactPreference;
  }

  public void setContactPreference(ContactPreference contactPreference) {
    this.contactPreference = contactPreference;
  }

  public Prospect financialInformation(FinancialInformation financialInformation) {
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

  public Prospect education(Education education) {
    this.education = education;
    return this;
  }

   /**
   * Get education
   * @return education
  **/
  @Schema(description = "")
  public Education getEducation() {
    return education;
  }

  public void setEducation(Education education) {
    this.education = education;
  }

  public Prospect employmentDetails(List<EmploymentDetails> employmentDetails) {
    this.employmentDetails = employmentDetails;
    return this;
  }

  public Prospect addEmploymentDetailsItem(EmploymentDetails employmentDetailsItem) {
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

  public Prospect identificationDocumentDetails(List<IdentificationDocumentDetails> identificationDocumentDetails) {
    this.identificationDocumentDetails = identificationDocumentDetails;
    return this;
  }

  public Prospect addIdentificationDocumentDetailsItem(IdentificationDocumentDetails identificationDocumentDetailsItem) {
    if (this.identificationDocumentDetails == null) {
      this.identificationDocumentDetails = new ArrayList<IdentificationDocumentDetails>();
    }
    this.identificationDocumentDetails.add(identificationDocumentDetailsItem);
    return this;
  }

   /**
   * Get identificationDocumentDetails
   * @return identificationDocumentDetails
  **/
  @Schema(description = "")
  public List<IdentificationDocumentDetails> getIdentificationDocumentDetails() {
    return identificationDocumentDetails;
  }

  public void setIdentificationDocumentDetails(List<IdentificationDocumentDetails> identificationDocumentDetails) {
    this.identificationDocumentDetails = identificationDocumentDetails;
  }

  public Prospect additionalData(AdditionalData additionalData) {
    this.additionalData = additionalData;
    return this;
  }

   /**
   * Get additionalData
   * @return additionalData
  **/
  @Schema(description = "")
  public AdditionalData getAdditionalData() {
    return additionalData;
  }

  public void setAdditionalData(AdditionalData additionalData) {
    this.additionalData = additionalData;
  }

  public Prospect selfDeclaration(SelfDeclaration selfDeclaration) {
    this.selfDeclaration = selfDeclaration;
    return this;
  }

   /**
   * Get selfDeclaration
   * @return selfDeclaration
  **/
  @Schema(description = "")
  public SelfDeclaration getSelfDeclaration() {
    return selfDeclaration;
  }

  public void setSelfDeclaration(SelfDeclaration selfDeclaration) {
    this.selfDeclaration = selfDeclaration;
  }

  public Prospect kycInformation(KycInformation kycInformation) {
    this.kycInformation = kycInformation;
    return this;
  }

   /**
   * Get kycInformation
   * @return kycInformation
  **/
  @Schema(description = "")
  public KycInformation getKycInformation() {
    return kycInformation;
  }

  public void setKycInformation(KycInformation kycInformation) {
    this.kycInformation = kycInformation;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Prospect prospect = (Prospect) o;
    return Objects.equals(this.motherMaidenName, prospect.motherMaidenName) &&
        Objects.equals(this.name, prospect.name) &&
        Objects.equals(this.demographics, prospect.demographics) &&
        Objects.equals(this.address, prospect.address) &&
        Objects.equals(this.email, prospect.email) &&
        Objects.equals(this.phone, prospect.phone) &&
        Objects.equals(this.contactPreference, prospect.contactPreference) &&
        Objects.equals(this.financialInformation, prospect.financialInformation) &&
        Objects.equals(this.education, prospect.education) &&
        Objects.equals(this.employmentDetails, prospect.employmentDetails) &&
        Objects.equals(this.identificationDocumentDetails, prospect.identificationDocumentDetails) &&
        Objects.equals(this.additionalData, prospect.additionalData) &&
        Objects.equals(this.selfDeclaration, prospect.selfDeclaration) &&
        Objects.equals(this.kycInformation, prospect.kycInformation);
  }

  @Override
  public int hashCode() {
    return Objects.hash(motherMaidenName, name, demographics, address, email, phone, contactPreference, financialInformation, education, employmentDetails, identificationDocumentDetails, additionalData, selfDeclaration, kycInformation);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Prospect {\n");
    
    sb.append("    motherMaidenName: ").append(toIndentedString(motherMaidenName)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    demographics: ").append(toIndentedString(demographics)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    phone: ").append(toIndentedString(phone)).append("\n");
    sb.append("    contactPreference: ").append(toIndentedString(contactPreference)).append("\n");
    sb.append("    financialInformation: ").append(toIndentedString(financialInformation)).append("\n");
    sb.append("    education: ").append(toIndentedString(education)).append("\n");
    sb.append("    employmentDetails: ").append(toIndentedString(employmentDetails)).append("\n");
    sb.append("    identificationDocumentDetails: ").append(toIndentedString(identificationDocumentDetails)).append("\n");
    sb.append("    additionalData: ").append(toIndentedString(additionalData)).append("\n");
    sb.append("    selfDeclaration: ").append(toIndentedString(selfDeclaration)).append("\n");
    sb.append("    kycInformation: ").append(toIndentedString(kycInformation)).append("\n");
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
