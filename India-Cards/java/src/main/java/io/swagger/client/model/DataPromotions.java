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
import org.threeten.bp.LocalDate;
/**
 * DataPromotions
 */

@javax.annotation.Generated(value = "io.swagger.codegen.v3.generators.java.JavaClientCodegen", date = "2023-08-14T16:43:49.245466Z[Etc/UTC]")
public class DataPromotions {
  @SerializedName("start_date")
  private LocalDate startDate = null;

  @SerializedName("end_date")
  private LocalDate endDate = null;

  @SerializedName("description")
  private String description = null;

  @SerializedName("url")
  private String url = null;

  public DataPromotions startDate(LocalDate startDate) {
    this.startDate = startDate;
    return this;
  }

   /**
   * Promotion start date
   * @return startDate
  **/
  @Schema(example = "Thu Jun 14 00:00:00 UTC 2018", description = "Promotion start date")
  public LocalDate getStartDate() {
    return startDate;
  }

  public void setStartDate(LocalDate startDate) {
    this.startDate = startDate;
  }

  public DataPromotions endDate(LocalDate endDate) {
    this.endDate = endDate;
    return this;
  }

   /**
   * Promotion end date
   * @return endDate
  **/
  @Schema(example = "Sun Jul 15 00:00:00 UTC 2018", description = "Promotion end date")
  public LocalDate getEndDate() {
    return endDate;
  }

  public void setEndDate(LocalDate endDate) {
    this.endDate = endDate;
  }

  public DataPromotions description(String description) {
    this.description = description;
    return this;
  }

   /**
   * Description of promotion
   * @return description
  **/
  @Schema(example = "2018 FIFA World Cup campaign. Swipe to win a Mercedes!", description = "Description of promotion")
  public String getDescription() {
    return description;
  }

  public void setDescription(String description) {
    this.description = description;
  }

  public DataPromotions url(String url) {
    this.url = url;
    return this;
  }

   /**
   * Absolute URL to access further detail on promotion
   * @return url
  **/
  @Schema(description = "Absolute URL to access further detail on promotion")
  public String getUrl() {
    return url;
  }

  public void setUrl(String url) {
    this.url = url;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DataPromotions dataPromotions = (DataPromotions) o;
    return Objects.equals(this.startDate, dataPromotions.startDate) &&
        Objects.equals(this.endDate, dataPromotions.endDate) &&
        Objects.equals(this.description, dataPromotions.description) &&
        Objects.equals(this.url, dataPromotions.url);
  }

  @Override
  public int hashCode() {
    return Objects.hash(startDate, endDate, description, url);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DataPromotions {\n");
    
    sb.append("    startDate: ").append(toIndentedString(startDate)).append("\n");
    sb.append("    endDate: ").append(toIndentedString(endDate)).append("\n");
    sb.append("    description: ").append(toIndentedString(description)).append("\n");
    sb.append("    url: ").append(toIndentedString(url)).append("\n");
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
