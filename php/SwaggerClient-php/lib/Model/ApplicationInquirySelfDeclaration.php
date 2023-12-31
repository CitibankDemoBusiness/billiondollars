<?php
/**
 * ApplicationInquirySelfDeclaration
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Onboarding
 *
 * The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 * Swagger Codegen version: 3.0.29
 */
/**
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen
 * Do not edit the class manually.
 */

namespace Swagger\Client\Model;

use \ArrayAccess;
use \Swagger\Client\ObjectSerializer;

/**
 * ApplicationInquirySelfDeclaration Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationInquirySelfDeclaration implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationInquirySelfDeclaration';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'total_active_credit_card_limit_amount' => 'double',
'anticipated_income_decrease_code' => 'string',
'loan_taken_indicator' => 'bool',
'monthly_repayment_for_all_ext_loans' => 'double'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'total_active_credit_card_limit_amount' => 'double',
'anticipated_income_decrease_code' => null,
'loan_taken_indicator' => null,
'monthly_repayment_for_all_ext_loans' => 'double'    ];

    /**
     * Array of property to type mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerTypes()
    {
        return self::$swaggerTypes;
    }

    /**
     * Array of property to format mappings. Used for (de)serialization
     *
     * @return array
     */
    public static function swaggerFormats()
    {
        return self::$swaggerFormats;
    }

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @var string[]
     */
    protected static $attributeMap = [
        'total_active_credit_card_limit_amount' => 'totalActiveCreditCardLimitAmount',
'anticipated_income_decrease_code' => 'anticipatedIncomeDecreaseCode',
'loan_taken_indicator' => 'loanTakenIndicator',
'monthly_repayment_for_all_ext_loans' => 'monthlyRepaymentForAllExtLoans'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'total_active_credit_card_limit_amount' => 'setTotalActiveCreditCardLimitAmount',
'anticipated_income_decrease_code' => 'setAnticipatedIncomeDecreaseCode',
'loan_taken_indicator' => 'setLoanTakenIndicator',
'monthly_repayment_for_all_ext_loans' => 'setMonthlyRepaymentForAllExtLoans'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'total_active_credit_card_limit_amount' => 'getTotalActiveCreditCardLimitAmount',
'anticipated_income_decrease_code' => 'getAnticipatedIncomeDecreaseCode',
'loan_taken_indicator' => 'getLoanTakenIndicator',
'monthly_repayment_for_all_ext_loans' => 'getMonthlyRepaymentForAllExtLoans'    ];

    /**
     * Array of attributes where the key is the local name,
     * and the value is the original name
     *
     * @return array
     */
    public static function attributeMap()
    {
        return self::$attributeMap;
    }

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @return array
     */
    public static function setters()
    {
        return self::$setters;
    }

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @return array
     */
    public static function getters()
    {
        return self::$getters;
    }

    /**
     * The original name of the model.
     *
     * @return string
     */
    public function getModelName()
    {
        return self::$swaggerModelName;
    }

    

    /**
     * Associative array for storing property values
     *
     * @var mixed[]
     */
    protected $container = [];

    /**
     * Constructor
     *
     * @param mixed[] $data Associated array of property values
     *                      initializing the model
     */
    public function __construct(array $data = null)
    {
        $this->container['total_active_credit_card_limit_amount'] = isset($data['total_active_credit_card_limit_amount']) ? $data['total_active_credit_card_limit_amount'] : null;
        $this->container['anticipated_income_decrease_code'] = isset($data['anticipated_income_decrease_code']) ? $data['anticipated_income_decrease_code'] : null;
        $this->container['loan_taken_indicator'] = isset($data['loan_taken_indicator']) ? $data['loan_taken_indicator'] : null;
        $this->container['monthly_repayment_for_all_ext_loans'] = isset($data['monthly_repayment_for_all_ext_loans']) ? $data['monthly_repayment_for_all_ext_loans'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        return $invalidProperties;
    }

    /**
     * Validate all the properties in the model
     * return true if all passed
     *
     * @return bool True if all properties are valid
     */
    public function valid()
    {
        return count($this->listInvalidProperties()) === 0;
    }


    /**
     * Gets total_active_credit_card_limit_amount
     *
     * @return double
     */
    public function getTotalActiveCreditCardLimitAmount()
    {
        return $this->container['total_active_credit_card_limit_amount'];
    }

    /**
     * Sets total_active_credit_card_limit_amount
     *
     * @param double $total_active_credit_card_limit_amount Total credit limit of all the credit cards the applicant is holding
     *
     * @return $this
     */
    public function setTotalActiveCreditCardLimitAmount($total_active_credit_card_limit_amount)
    {
        $this->container['total_active_credit_card_limit_amount'] = $total_active_credit_card_limit_amount;

        return $this;
    }

    /**
     * Gets anticipated_income_decrease_code
     *
     * @return string
     */
    public function getAnticipatedIncomeDecreaseCode()
    {
        return $this->container['anticipated_income_decrease_code'];
    }

    /**
     * Sets anticipated_income_decrease_code
     *
     * @param string $anticipated_income_decrease_code Anticipated income decrease code. Valid values: Yes and No
     *
     * @return $this
     */
    public function setAnticipatedIncomeDecreaseCode($anticipated_income_decrease_code)
    {
        $this->container['anticipated_income_decrease_code'] = $anticipated_income_decrease_code;

        return $this;
    }

    /**
     * Gets loan_taken_indicator
     *
     * @return bool
     */
    public function getLoanTakenIndicator()
    {
        return $this->container['loan_taken_indicator'];
    }

    /**
     * Sets loan_taken_indicator
     *
     * @param bool $loan_taken_indicator To indicate if any loan is outstanding.Valid values: true and false
     *
     * @return $this
     */
    public function setLoanTakenIndicator($loan_taken_indicator)
    {
        $this->container['loan_taken_indicator'] = $loan_taken_indicator;

        return $this;
    }

    /**
     * Gets monthly_repayment_for_all_ext_loans
     *
     * @return double
     */
    public function getMonthlyRepaymentForAllExtLoans()
    {
        return $this->container['monthly_repayment_for_all_ext_loans'];
    }

    /**
     * Sets monthly_repayment_for_all_ext_loans
     *
     * @param double $monthly_repayment_for_all_ext_loans Applicants declaration for his/her total monthly repayment amount for all the external loans.
     *
     * @return $this
     */
    public function setMonthlyRepaymentForAllExtLoans($monthly_repayment_for_all_ext_loans)
    {
        $this->container['monthly_repayment_for_all_ext_loans'] = $monthly_repayment_for_all_ext_loans;

        return $this;
    }
    /**
     * Returns true if offset exists. False otherwise.
     *
     * @param integer $offset Offset
     *
     * @return boolean
     */
    public function offsetExists($offset)
    {
        return isset($this->container[$offset]);
    }

    /**
     * Gets offset.
     *
     * @param integer $offset Offset
     *
     * @return mixed
     */
    public function offsetGet($offset)
    {
        return isset($this->container[$offset]) ? $this->container[$offset] : null;
    }

    /**
     * Sets value based on offset.
     *
     * @param integer $offset Offset
     * @param mixed   $value  Value to be set
     *
     * @return void
     */
    public function offsetSet($offset, $value)
    {
        if (is_null($offset)) {
            $this->container[] = $value;
        } else {
            $this->container[$offset] = $value;
        }
    }

    /**
     * Unsets offset.
     *
     * @param integer $offset Offset
     *
     * @return void
     */
    public function offsetUnset($offset)
    {
        unset($this->container[$offset]);
    }

    /**
     * Gets the string presentation of the object
     *
     * @return string
     */
    public function __toString()
    {
        if (defined('JSON_PRETTY_PRINT')) { // use JSON pretty print
            return json_encode(
                ObjectSerializer::sanitizeForSerialization($this),
                JSON_PRETTY_PRINT
            );
        }

        return json_encode(ObjectSerializer::sanitizeForSerialization($this));
    }
}
