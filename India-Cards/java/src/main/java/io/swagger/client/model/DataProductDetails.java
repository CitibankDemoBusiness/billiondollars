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
 * DataProductDetails
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class DataProductDetails {
  @SerializedName("name")
  private String name = null;

  @SerializedName("description")
  private String description = null;

  /**
   * Type of product
   */
  @JsonAdapter(ProductTypeEnum.Adapter.class)
  public enum ProductTypeEnum {
    AMERICAN_EXPRESS("american_express"),
    JCB("jcb"),
    MASTERCARD("mastercard"),
    MYDEBIT("mydebit"),
    OTHERS("others"),
    SWITCH("switch"),
    UNIONPAY("unionpay"),
    VISA("visa");

    private String value;

    ProductTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static ProductTypeEnum fromValue(String text) {
      for (ProductTypeEnum b : ProductTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<ProductTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ProductTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ProductTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return ProductTypeEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("product_type")
  private ProductTypeEnum productType = null;

  /**
   * Type of sub-product
   */
  @JsonAdapter(SubProductTypeEnum.Adapter.class)
  public enum SubProductTypeEnum {
    BLACK("black"),
    CLASSIC("classic"),
    COMMERCIAL("commercial"),
    DIAMOND("diamond"),
    ELECTRON("electron"),
    GENERIC("generic"),
    GOLD("gold"),
    INFINITE("infinite"),
    INFINITE_PRIVILEGE("infinite_privilege"),
    MAESTRO("maestro"),
    OTHERS("others"),
    PLATINUM("platinum"),
    RESERVE("reserve"),
    SIGNATURE("signature"),
    WORLD("world"),
    WORLD_ELITE("world_elite");

    private String value;

    SubProductTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static SubProductTypeEnum fromValue(String text) {
      for (SubProductTypeEnum b : SubProductTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<SubProductTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final SubProductTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public SubProductTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return SubProductTypeEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("sub_product_type")
  private SubProductTypeEnum subProductType = null;

  @SerializedName("shariah_compliance")
  private Boolean shariahCompliance = null;

  @SerializedName("shariah_compliance_remark")
  private String shariahComplianceRemark = null;

  /**
   * Type of card
   */
  @JsonAdapter(CardTypeEnum.Adapter.class)
  public enum CardTypeEnum {
    CREDIT_CARD("credit_card"),
    DEBIT_CARD("debit_card"),
    CHARGE_CARD("charge_card"),
    PREPAID_CARD("prepaid_card");

    private String value;

    CardTypeEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static CardTypeEnum fromValue(String text) {
      for (CardTypeEnum b : CardTypeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<CardTypeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final CardTypeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public CardTypeEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return CardTypeEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("card_type")
  private CardTypeEnum cardType = null;

  @SerializedName("pds_url")
  private String pdsUrl = null;

  @SerializedName("image_url")
  private String imageUrl = null;

  @SerializedName("disclaimer_url")
  private String disclaimerUrl = null;

  public DataProductDetails name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Product name
   * @return name
  **/
  @Schema(example = "Visa Signature", required = true, description = "Product name")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public DataProductDetails description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Product description
   * @return description
  **/
  @Schema(example = "Visa Signature is a Credit Card that provides not just only rewards but with additional privileges", required = true, description = "Product description")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public DataProductDetails productType(ProductTypeEnum productType) {
    this.productType = productType;
    return this;
  }

   /**
   * Type of product
   * @return productType
  **/
  @Schema(example = "visa", required = true, description = "Type of product")
  public ProductTypeEnum getProductType() {
    return productType;
  }

  public void setProductType(ProductTypeEnum productType) {
    this.productType = productType;
  }

  public DataProductDetails subProductType(SubProductTypeEnum subProductType) {
    this.subProductType = subProductType;
    return this;
  }

   /**
   * Type of sub-product
   * @return subProductType
  **/
  @Schema(example = "classic", description = "Type of sub-product")
  public SubProductTypeEnum getSubProductType() {
    return subProductType;
  }

  public void setSubProductType(SubProductTypeEnum subProductType) {
    this.subProductType = subProductType;
  }

  public DataProductDetails shariahCompliance(Boolean shariahCompliance) {
    this.shariahCompliance = shariahCompliance;
    return this;
  }

   /**
   * The indicator for Islamic or Conventional card
   * @return shariahCompliance
  **/
  @Schema(example = "false", required = true, description = "The indicator for Islamic or Conventional card")
  public Boolean isShariahCompliance() {
    return shariahCompliance;
  }

  public void setShariahCompliance(Boolean shariahCompliance) {
    this.shariahCompliance = shariahCompliance;
  }

  public DataProductDetails shariahComplianceRemark(String shariahComplianceRemark) {
    this.shariahComplianceRemark = shariahComplianceRemark;
    return this;
  }

   /**
   * Approval body for shariah compliance
   * @return shariahComplianceRemark
  **/
  @Schema(description = "Approval body for shariah compliance")
  public String getShariahComplianceRemark() {
    return shariahComplianceRemark;
  }

  public void setShariahComplianceRemark(String shariahComplianceRemark) {
    this.shariahComplianceRemark = shariahComplianceRemark;
  }

  public DataProductDetails cardType(CardTypeEnum cardType) {
    this.cardType = cardType;
    return this;
  }

   /**
   * Type of card
   * @return cardType
  **/
  @Schema(example = "credit_card", required = true, description = "Type of card")
  public CardTypeEnum getCardType() {
    return cardType;
  }

  public void setCardType(CardTypeEnum cardType) {
    this.cardType = cardType;
  }

  public DataProductDetails pdsUrl(String pdsUrl) {
    this.pdsUrl = pdsUrl;
    return this;
  }

   /**
   * URL for product disclosure sheet
   * @return pdsUrl
  **/
  @Schema(required = true, description = "URL for product disclosure sheet")
  public String getPdsUrl() {
    return pdsUrl;
  }

  public void setPdsUrl(String pdsUrl) {
    this.pdsUrl = pdsUrl;
  }

  public DataProductDetails imageUrl(String imageUrl) {
    this.imageUrl = imageUrl;
    return this;
  }

   /**
   * Absolute URL to image in SVG format
   * @return imageUrl
  **/
  @Schema(description = "Absolute URL to image in SVG format")
  public String getImageUrl() {
    return imageUrl;
  }

  public void setImageUrl(String imageUrl) {
    this.imageUrl = imageUrl;
  }

  public DataProductDetails disclaimerUrl(String disclaimerUrl) {
    this.disclaimerUrl = disclaimerUrl;
    return this;
  }

   /**
   * Absolute URL for product disclaimer
   * @return disclaimerUrl
  **/
  @Schema(description = "Absolute URL for product disclaimer")
  public String getDisclaimerUrl() {
    return disclaimerUrl;
  }

  public void setDisclaimerUrl(String disclaimerUrl) {
    this.disclaimerUrl = disclaimerUrl;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DataProductDetails dataProductDetails = (DataProductDetails) o;
    return Objects.equals(this.name, dataProductDetails.name) &&
        Objects.equals(this.description, dataProductDetails.description) &&
        Objects.equals(this.productType, dataProductDetails.productType) &&
        Objects.equals(this.subProductType, dataProductDetails.subProductType) &&
        Objects.equals(this.shariahCompliance, dataProductDetails.shariahCompliance) &&
        Objects.equals(this.shariahComplianceRemark, dataProductDetails.shariahComplianceRemark) &&
        Objects.equals(this.cardType, dataProductDetails.cardType) &&
        Objects.equals(this.pdsUrl, dataProductDetails.pdsUrl) &&
        Objects.equals(this.imageUrl, dataProductDetails.imageUrl) &&
        Objects.equals(this.disclaimerUrl, dataProductDetails.disclaimerUrl);
  }

  @Override
  public int hashCode() {
    return Objects.hash(name, description, productType, subProductType, shariahCompliance, shariahComplianceRemark, cardType, pdsUrl, imageUrl, disclaimerUrl);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DataProductDetails {\n");
    
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    productType: ").append(toIndentedString(productType)).append("\n");
    sb.append("    subProductType: ").append(toIndentedString(subProductType)).append("\n");
    sb.append("    shariahCompliance: ").append(toIndentedString(shariahCompliance)).append("\n");
    sb.append("    shariahComplianceRemark: ").append(toIndentedString(shariahComplianceRemark)).append("\n");
    sb.append("    cardType: ").append(toIndentedString(cardType)).append("\n");
    sb.append("    pdsUrl: ").append(toIndentedString(pdsUrl)).append("\n");
    sb.append("    imageUrl: ").append(toIndentedString(imageUrl)).append("\n");
    sb.append("    disclaimerUrl: ").append(toIndentedString(disclaimerUrl)).append("\n");
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
