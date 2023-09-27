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
 * DataProductOfferings
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class DataProductOfferings {
  /**
   * Type of offering
   */
  @JsonAdapter(CategoryEnum.Adapter.class)
  public enum CategoryEnum {
    REWARD_CASHBACK("reward_cashback"),
    AIR_MILES("air_miles"),
    FEATURE_BENEFIT("feature_benefit");

    private String value;

    CategoryEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static CategoryEnum fromValue(String text) {
      for (CategoryEnum b : CategoryEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<CategoryEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final CategoryEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public CategoryEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return CategoryEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("category")
  private CategoryEnum category = null;

  /**
   * Gets or Sets item
   */
  @JsonAdapter(ItemEnum.Adapter.class)
  public enum ItemEnum {
    BOOKSTORE("bookstore"),
    CASHLESS_TRANSACTION("cashless_transaction"),
    CINEMA("cinema"),
    DEPARTMENT_STORE("department_store"),
    DINING("dining"),
    EDUCATION("education"),
    ENTERTAINMENT("entertainment"),
    EXPRESS_AUTOPAY("express_autopay"),
    GOLD("gold"),
    GROCERIES("groceries"),
    HIGHWAY("highway"),
    HOTEL("hotel"),
    INSTALLMENT_PLAN("installment_plan"),
    INSURANCE_PREMIUM("insurance_premium"),
    LOCAL_RETAIL("local_retail"),
    MEMBERSHIP_DAY("membership_day"),
    MOBILE_TELCO("mobile_telco"),
    MYEG_SERVICES("myeg_services"),
    ONLINE_AIR_TICKET("online_air_ticket"),
    ONLINE_BILL_PAYMENT("online_bill_payment"),
    ONLINE_SHOPPING("online_shopping"),
    OTHERS("others"),
    OVERSEA_RETAIL("oversea_retail"),
    PETROL("petrol"),
    PHARMACY("pharmacy"),
    RETAIL("retail"),
    SHOPPING("shopping"),
    TOUCH_N_GO("touch_n_go"),
    TRANSPORT("transport"),
    TRAVEL("travel"),
    UTILITY_BILL("utility_bill"),
    WEEKEND("weekend"),
    ASIA_MILES("asia_miles"),
    BIG_POINT_AASIA("big_point_aasia"),
    ENRICH_MAS("enrich_mas"),
    GARUDA_MILES_ID("garuda_miles_id"),
    KRISFYLER_SG("krisfyler_sg"),
    MALINDO_MILES_MALINDOAIR("malindo_miles_malindoair"),
    STAR_ALLIANCE("star_alliance"),
    AIRPORT_SPEED_PASS("airport_speed_pass"),
    ANNUAL_FEE_WAIVER("annual_fee_waiver"),
    AUTO_BILL_PAYMENT("auto_bill_payment"),
    BALANCE_TRANSFER_PLAN("balance_transfer_plan"),
    CASH_ADVANCE("cash_advance"),
    CASH_INSTALLMENT_PLAN("cash_installment_plan"),
    CASH_WITHDRAWAL("cash_withdrawal"),
    CHARITY_FUND("charity_fund"),
    CONCIERGE_SERVICES("concierge_services"),
    CONTACTLESS("contactless"),
    DINING_PRIVILEGES("dining_privileges"),
    DISCOUNT("discount"),
    EASY_PAYMENT_PLAN("easy_payment_plan"),
    ECOMMERCE_INSURANCE("ecommerce_insurance"),
    EMERGENCY_CHEQUE_CASHING("emergency_cheque_cashing"),
    GLOBAL_ASSISTANCE("global_assistance"),
    GOLF("golf"),
    PARTNERSHIP_DISCOUNT("partnership_discount"),
    PLAZA_PREMIUM_LOUNGE("plaza_premium_lounge"),
    RETAIL_INSURANCE("retail_insurance"),
    TRAVEL_INSURANCE("travel_insurance"),
    WALLET_GUARD("wallet_guard");

    private String value;

    ItemEnum(String value) {
      this.value = value;
    }
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }
    public static ItemEnum fromValue(String text) {
      for (ItemEnum b : ItemEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
    public static class Adapter extends TypeAdapter<ItemEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ItemEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ItemEnum read(final JsonReader jsonReader) throws IOException {
        Object value = jsonReader.nextString();
        return ItemEnum.fromValue(String.valueOf(value));
      }
    }
  }  @SerializedName("item")
  private ItemEnum item = null;

  @SerializedName("remark")
  private String remark = null;

  @SerializedName("branding")
  private String branding = null;

  @SerializedName("tnc_url")
  private String tncUrl = null;

  public DataProductOfferings category(CategoryEnum category) {
    this.category = category;
    return this;
  }

   /**
   * Type of offering
   * @return category
  **/
  @Schema(required = true, description = "Type of offering")
  public CategoryEnum getCategory() {
    return category;
  }

  public void setCategory(CategoryEnum category) {
    this.category = category;
  }

  public DataProductOfferings item(ItemEnum item) {
    this.item = item;
    return this;
  }

   /**
   * Get item
   * @return item
  **/
  @Schema(required = true, description = "")
  public ItemEnum getItem() {
    return item;
  }

  public void setItem(ItemEnum item) {
    this.item = item;
  }

  public DataProductOfferings remark(String remark) {
    this.remark = remark;
    return this;
  }

   /**
   * Additional notes for the reward, air miles and feature
   * @return remark
  **/
  @Schema(description = "Additional notes for the reward, air miles and feature")
  public String getRemark() {
    return remark;
  }

  public void setRemark(String remark) {
    this.remark = remark;
  }

  public DataProductOfferings branding(String branding) {
    this.branding = branding;
    return this;
  }

   /**
   * Branding for specific offering
   * @return branding
  **/
  @Schema(description = "Branding for specific offering")
  public String getBranding() {
    return branding;
  }

  public void setBranding(String branding) {
    this.branding = branding;
  }

  public DataProductOfferings tncUrl(String tncUrl) {
    this.tncUrl = tncUrl;
    return this;
  }

   /**
   * Absolute URL to term and conditions for specific offering
   * @return tncUrl
  **/
  @Schema(description = "Absolute URL to term and conditions for specific offering")
  public String getTncUrl() {
    return tncUrl;
  }

  public void setTncUrl(String tncUrl) {
    this.tncUrl = tncUrl;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DataProductOfferings dataProductOfferings = (DataProductOfferings) o;
    return Objects.equals(this.category, dataProductOfferings.category) &&
        Objects.equals(this.item, dataProductOfferings.item) &&
        Objects.equals(this.remark, dataProductOfferings.remark) &&
        Objects.equals(this.branding, dataProductOfferings.branding) &&
        Objects.equals(this.tncUrl, dataProductOfferings.tncUrl);
  }

  @Override
  public int hashCode() {
    return Objects.hash(category, item, remark, branding, tncUrl);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DataProductOfferings {\n");
    
    sb.append("    category: ").append(toIndentedString(category)).append("\n");
    sb.append("    item: ").append(toIndentedString(item)).append("\n");
    sb.append("    remark: ").append(toIndentedString(remark)).append("\n");
    sb.append("    branding: ").append(toIndentedString(branding)).append("\n");
    sb.append("    tncUrl: ").append(toIndentedString(tncUrl)).append("\n");
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
