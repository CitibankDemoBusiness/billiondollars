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
import io.swagger.client.model.AdditionalDataUpdate;
import io.swagger.client.model.Address;
import io.swagger.client.model.Alerts;
import io.swagger.client.model.ConsentDetails;
import io.swagger.client.model.ContactConsent;
import io.swagger.client.model.ContactPreference;
import io.swagger.client.model.Demographics;
import io.swagger.client.model.Education;
import io.swagger.client.model.Email;
import io.swagger.client.model.EmploymentDetails;
import io.swagger.client.model.FinancialInformationAdd;
import io.swagger.client.model.IdentificationDocumentDetailsAdd;
import io.swagger.client.model.KycInformation;
import io.swagger.client.model.MarketingConsent;
import io.swagger.client.model.Name;
import io.swagger.client.model.Ocr;
import io.swagger.client.model.ParentInformation;
import io.swagger.client.model.PartnerCustomerDetails;
import io.swagger.client.model.Phone;
import io.swagger.client.model.SelfDeclaration;
import io.swagger.v3.oas.annotations.media.Schema;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
/**
 * ApplicantUpdate
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:52:20.568061Z[Etc/UTC]")
public class ApplicantUpdate {
  @SerializedName("name")
  private Name name = null;

  @SerializedName("phone")
  private List<Phone> phone = null;

  @SerializedName("email")
  private List<Email> email = null;

  @SerializedName("ocr")
  private Ocr ocr = null;

  @SerializedName("studentIndicator")
  private String studentIndicator = null;

  @SerializedName("demographics")
  private Demographics demographics = null;

  @SerializedName("address")
  private List<Address> address = null;

  @SerializedName("contactPreference")
  private ContactPreference contactPreference = null;

  @SerializedName("contactConsent")
  private ContactConsent contactConsent = null;

  @SerializedName("financialInformation")
  private FinancialInformationAdd financialInformation = null;

  @SerializedName("motherMaidenName")
  private String motherMaidenName = null;

  @SerializedName("education")
  private Education education = null;

  @SerializedName("employmentDetails")
  private List<EmploymentDetails> employmentDetails = null;

  @SerializedName("identificationDocumentDetails")
  private List<IdentificationDocumentDetailsAdd> identificationDocumentDetails = null;

  @SerializedName("additionalData")
  private AdditionalDataUpdate additionalData = null;

  @SerializedName("partnerCustomerDetails")
  private PartnerCustomerDetails partnerCustomerDetails = null;

  @SerializedName("consentDetails")
  private List<ConsentDetails> consentDetails = null;

  @SerializedName("marketingConsent")
  private MarketingConsent marketingConsent = null;

  @SerializedName("selfDeclaration")
  private SelfDeclaration selfDeclaration = null;

  @SerializedName("alerts")
  private Alerts alerts = null;

  @SerializedName("kycInformation")
  private KycInformation kycInformation = null;

  @SerializedName("parent")
  private ParentInformation parent = null;

  public ApplicantUpdate name(Name name) {
    this.name = name;
    return this;
  }

   /**
   * Get name
   * @return name
  **/
  @Schema(description = "")
  public Name getName() {
    return name;
  }

  public void setName(Name name) {
    this.name = name;
  }

  public ApplicantUpdate phone(List<Phone> phone) {
    this.phone = phone;
    return this;
  }

  public ApplicantUpdate addPhoneItem(Phone phoneItem) {
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

  public ApplicantUpdate email(List<Email> email) {
    this.email = email;
    return this;
  }

  public ApplicantUpdate addEmailItem(Email emailItem) {
    if (this.email == null) {
      this.email = new ArrayList<Email>();
    }
    this.email.add(emailItem);
    return this;
  }

   /**
   * Get email
   * @return email
  **/
  @Schema(description = "")
  public List<Email> getEmail() {
    return email;
  }

  public void setEmail(List<Email> email) {
    this.email = email;
  }

  public ApplicantUpdate ocr(Ocr ocr) {
    this.ocr = ocr;
    return this;
  }

   /**
   * Get ocr
   * @return ocr
  **/
  @Schema(description = "")
  public Ocr getOcr() {
    return ocr;
  }

  public void setOcr(Ocr ocr) {
    this.ocr = ocr;
  }

  public ApplicantUpdate studentIndicator(String studentIndicator) {
    this.studentIndicator = studentIndicator;
    return this;
  }

   /**
   * Indicates if the applicant is a student.Valid values are Yes or No
   * @return studentIndicator
  **/
  @Schema(example = "Yes", description = "Indicates if the applicant is a student.Valid values are Yes or No")
  public String getStudentIndicator() {
    return studentIndicator;
  }

  public void setStudentIndicator(String studentIndicator) {
    this.studentIndicator = studentIndicator;
  }

  public ApplicantUpdate demographics(Demographics demographics) {
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

  public ApplicantUpdate address(List<Address> address) {
    this.address = address;
    return this;
  }

  public ApplicantUpdate addAddressItem(Address addressItem) {
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

  public ApplicantUpdate contactPreference(ContactPreference contactPreference) {
    this.contactPreference = contactPreference;
    return this;
  }

   /**
   * Get contactPreference
   * @return contactPreference
  **/
  @Schema(description = "")
  public ContactPreference getContactPreference() {
    return contactPreference;
  }

  public void setContactPreference(ContactPreference contactPreference) {
    this.contactPreference = contactPreference;
  }

  public ApplicantUpdate contactConsent(ContactConsent contactConsent) {
    this.contactConsent = contactConsent;
    return this;
  }

   /**
   * Get contactConsent
   * @return contactConsent
  **/
  @Schema(description = "")
  public ContactConsent getContactConsent() {
    return contactConsent;
  }

  public void setContactConsent(ContactConsent contactConsent) {
    this.contactConsent = contactConsent;
  }

  public ApplicantUpdate financialInformation(FinancialInformationAdd financialInformation) {
    this.financialInformation = financialInformation;
    return this;
  }

   /**
   * Get financialInformation
   * @return financialInformation
  **/
  @Schema(description = "")
  public FinancialInformationAdd getFinancialInformation() {
    return financialInformation;
  }

  public void setFinancialInformation(FinancialInformationAdd financialInformation) {
    this.financialInformation = financialInformation;
  }

  public ApplicantUpdate motherMaidenName(String motherMaidenName) {
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

  public ApplicantUpdate education(Education education) {
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

  public ApplicantUpdate employmentDetails(List<EmploymentDetails> employmentDetails) {
    this.employmentDetails = employmentDetails;
    return this;
  }

  public ApplicantUpdate addEmploymentDetailsItem(EmploymentDetails employmentDetailsItem) {
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

  public ApplicantUpdate identificationDocumentDetails(List<IdentificationDocumentDetailsAdd> identificationDocumentDetails) {
    this.identificationDocumentDetails = identificationDocumentDetails;
    return this;
  }

  public ApplicantUpdate addIdentificationDocumentDetailsItem(IdentificationDocumentDetailsAdd identificationDocumentDetailsItem) {
    if (this.identificationDocumentDetails == null) {
      this.identificationDocumentDetails = new ArrayList<IdentificationDocumentDetailsAdd>();
    }
    this.identificationDocumentDetails.add(identificationDocumentDetailsItem);
    return this;
  }

   /**
   * Get identificationDocumentDetails
   * @return identificationDocumentDetails
  **/
  @Schema(description = "")
  public List<IdentificationDocumentDetailsAdd> getIdentificationDocumentDetails() {
    return identificationDocumentDetails;
  }

  public void setIdentificationDocumentDetails(List<IdentificationDocumentDetailsAdd> identificationDocumentDetails) {
    this.identificationDocumentDetails = identificationDocumentDetails;
  }

  public ApplicantUpdate additionalData(AdditionalDataUpdate additionalData) {
    this.additionalData = additionalData;
    return this;
  }

   /**
   * Get additionalData
   * @return additionalData
  **/
  @Schema(description = "")
  public AdditionalDataUpdate getAdditionalData() {
    return additionalData;
  }

  public void setAdditionalData(AdditionalDataUpdate additionalData) {
    this.additionalData = additionalData;
  }

  public ApplicantUpdate partnerCustomerDetails(PartnerCustomerDetails partnerCustomerDetails) {
    this.partnerCustomerDetails = partnerCustomerDetails;
    return this;
  }

   /**
   * Get partnerCustomerDetails
   * @return partnerCustomerDetails
  **/
  @Schema(description = "")
  public PartnerCustomerDetails getPartnerCustomerDetails() {
    return partnerCustomerDetails;
  }

  public void setPartnerCustomerDetails(PartnerCustomerDetails partnerCustomerDetails) {
    this.partnerCustomerDetails = partnerCustomerDetails;
  }

  public ApplicantUpdate consentDetails(List<ConsentDetails> consentDetails) {
    this.consentDetails = consentDetails;
    return this;
  }

  public ApplicantUpdate addConsentDetailsItem(ConsentDetails consentDetailsItem) {
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

  public ApplicantUpdate marketingConsent(MarketingConsent marketingConsent) {
    this.marketingConsent = marketingConsent;
    return this;
  }

   /**
   * Get marketingConsent
   * @return marketingConsent
  **/
  @Schema(description = "")
  public MarketingConsent getMarketingConsent() {
    return marketingConsent;
  }

  public void setMarketingConsent(MarketingConsent marketingConsent) {
    this.marketingConsent = marketingConsent;
  }

  public ApplicantUpdate selfDeclaration(SelfDeclaration selfDeclaration) {
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

  public ApplicantUpdate alerts(Alerts alerts) {
    this.alerts = alerts;
    return this;
  }

   /**
   * Get alerts
   * @return alerts
  **/
  @Schema(description = "")
  public Alerts getAlerts() {
    return alerts;
  }

  public void setAlerts(Alerts alerts) {
    this.alerts = alerts;
  }

  public ApplicantUpdate kycInformation(KycInformation kycInformation) {
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

  public ApplicantUpdate parent(ParentInformation parent) {
    this.parent = parent;
    return this;
  }

   /**
   * Get parent
   * @return parent
  **/
  @Schema(description = "")
  public ParentInformation getParent() {
    return parent;
  }

  public void setParent(ParentInformation parent) {
    this.parent = parent;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ApplicantUpdate applicantUpdate = (ApplicantUpdate) o;
    return Objects.equals(this.name, applicantUpdate.name) &&
        Objects.equals(this.phone, applicantUpdate.phone) &&
        Objects.equals(this.email, applicantUpdate.email) &&
        Objects.equals(this.ocr, applicantUpdate.ocr) &&
        Objects.equals(this.studentIndicator, applicantUpdate.studentIndicator) &&
        Objects.equals(this.demographics, applicantUpdate.demographics) &&
        Objects.equals(this.address, applicantUpdate.address) &&
        Objects.equals(this.contactPreference, applicantUpdate.contactPreference) &&
        Objects.equals(this.contactConsent, applicantUpdate.contactConsent) &&
        Objects.equals(this.financialInformation, applicantUpdate.financialInformation) &&
        Objects.equals(this.motherMaidenName, applicantUpdate.motherMaidenName) &&
        Objects.equals(this.education, applicantUpdate.education) &&
        Objects.equals(this.employmentDetails, applicantUpdate.employmentDetails) &&
        Objects.equals(this.identificationDocumentDetails, applicantUpdate.identificationDocumentDetails) &&
        Objects.equals(this.additionalData, applicantUpdate.additionalData) &&
        Objects.equals(this.partnerCustomerDetails, applicantUpdate.partnerCustomerDetails) &&
        Objects.equals(this.consentDetails, applicantUpdate.consentDetails) &&
        Objects.equals(this.marketingConsent, applicantUpdate.marketingConsent) &&
        Objects.equals(this.selfDeclaration, applicantUpdate.selfDeclaration) &&
        Objects.equals(this.alerts, applicantUpdate.alerts) &&
        Objects.equals(this.kycInformation, applicantUpdate.kycInformation) &&
        Objects.equals(this.parent, applicantUpdate.parent);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, phone, email, ocr, studentIndicator, demographics, address, contactPreference, contactConsent, financialInformation, motherMaidenName, education, employmentDetails, identificationDocumentDetails, additionalData, partnerCustomerDetails, consentDetails, marketingConsent, selfDeclaration, alerts, kycInformation, parent);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ApplicantUpdate {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    phone: ").append(toIndentedString(phone)).append("\n");
    sb.append("    email: ").append(toIndentedString(email)).append("\n");
    sb.append("    ocr: ").append(toIndentedString(ocr)).append("\n");
    sb.append("    studentIndicator: ").append(toIndentedString(studentIndicator)).append("\n");
    sb.append("    demographics: ").append(toIndentedString(demographics)).append("\n");
    sb.append("    address: ").append(toIndentedString(address)).append("\n");
    sb.append("    contactPreference: ").append(toIndentedString(contactPreference)).append("\n");
    sb.append("    contactConsent: ").append(toIndentedString(contactConsent)).append("\n");
    sb.append("    financialInformation: ").append(toIndentedString(financialInformation)).append("\n");
    sb.append("    motherMaidenName: ").append(toIndentedString(motherMaidenName)).append("\n");
    sb.append("    education: ").append(toIndentedString(education)).append("\n");
    sb.append("    employmentDetails: ").append(toIndentedString(employmentDetails)).append("\n");
    sb.append("    identificationDocumentDetails: ").append(toIndentedString(identificationDocumentDetails)).append("\n");
    sb.append("    additionalData: ").append(toIndentedString(additionalData)).append("\n");
    sb.append("    partnerCustomerDetails: ").append(toIndentedString(partnerCustomerDetails)).append("\n");
    sb.append("    consentDetails: ").append(toIndentedString(consentDetails)).append("\n");
    sb.append("    marketingConsent: ").append(toIndentedString(marketingConsent)).append("\n");
    sb.append("    selfDeclaration: ").append(toIndentedString(selfDeclaration)).append("\n");
    sb.append("    alerts: ").append(toIndentedString(alerts)).append("\n");
    sb.append("    kycInformation: ").append(toIndentedString(kycInformation)).append("\n");
    sb.append("    parent: ").append(toIndentedString(parent)).append("\n");
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
