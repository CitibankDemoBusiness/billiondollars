<?php
/**
 * LoanSpecificRecommendations
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
 * LoanSpecificRecommendations Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class LoanSpecificRecommendations implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'LoanSpecificRecommendations';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'loan_amount' => 'double',
'tenor' => 'string',
'interest_rate' => 'double',
'handling_fee' => 'double',
'installment_amount' => 'double',
'annual_percentage_rate' => 'double',
'total_principal_amount' => 'double',
'total_interest_amount' => 'double',
'total_installment_amount' => 'double',
'repayment_schedule_issue_date' => '\DateTime',
'repayment_schedule' => '\Swagger\Client\Model\RepaymentSchedule[]'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'loan_amount' => 'double',
'tenor' => null,
'interest_rate' => 'double',
'handling_fee' => 'double',
'installment_amount' => 'double',
'annual_percentage_rate' => 'double',
'total_principal_amount' => 'double',
'total_interest_amount' => 'double',
'total_installment_amount' => 'double',
'repayment_schedule_issue_date' => 'date',
'repayment_schedule' => null    ];

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
        'loan_amount' => 'loanAmount',
'tenor' => 'tenor',
'interest_rate' => 'interestRate',
'handling_fee' => 'handlingFee',
'installment_amount' => 'installmentAmount',
'annual_percentage_rate' => 'annualPercentageRate',
'total_principal_amount' => 'totalPrincipalAmount',
'total_interest_amount' => 'totalInterestAmount',
'total_installment_amount' => 'totalInstallmentAmount',
'repayment_schedule_issue_date' => 'repaymentScheduleIssueDate',
'repayment_schedule' => 'repaymentSchedule'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'loan_amount' => 'setLoanAmount',
'tenor' => 'setTenor',
'interest_rate' => 'setInterestRate',
'handling_fee' => 'setHandlingFee',
'installment_amount' => 'setInstallmentAmount',
'annual_percentage_rate' => 'setAnnualPercentageRate',
'total_principal_amount' => 'setTotalPrincipalAmount',
'total_interest_amount' => 'setTotalInterestAmount',
'total_installment_amount' => 'setTotalInstallmentAmount',
'repayment_schedule_issue_date' => 'setRepaymentScheduleIssueDate',
'repayment_schedule' => 'setRepaymentSchedule'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'loan_amount' => 'getLoanAmount',
'tenor' => 'getTenor',
'interest_rate' => 'getInterestRate',
'handling_fee' => 'getHandlingFee',
'installment_amount' => 'getInstallmentAmount',
'annual_percentage_rate' => 'getAnnualPercentageRate',
'total_principal_amount' => 'getTotalPrincipalAmount',
'total_interest_amount' => 'getTotalInterestAmount',
'total_installment_amount' => 'getTotalInstallmentAmount',
'repayment_schedule_issue_date' => 'getRepaymentScheduleIssueDate',
'repayment_schedule' => 'getRepaymentSchedule'    ];

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
        $this->container['loan_amount'] = isset($data['loan_amount']) ? $data['loan_amount'] : null;
        $this->container['tenor'] = isset($data['tenor']) ? $data['tenor'] : null;
        $this->container['interest_rate'] = isset($data['interest_rate']) ? $data['interest_rate'] : null;
        $this->container['handling_fee'] = isset($data['handling_fee']) ? $data['handling_fee'] : null;
        $this->container['installment_amount'] = isset($data['installment_amount']) ? $data['installment_amount'] : null;
        $this->container['annual_percentage_rate'] = isset($data['annual_percentage_rate']) ? $data['annual_percentage_rate'] : null;
        $this->container['total_principal_amount'] = isset($data['total_principal_amount']) ? $data['total_principal_amount'] : null;
        $this->container['total_interest_amount'] = isset($data['total_interest_amount']) ? $data['total_interest_amount'] : null;
        $this->container['total_installment_amount'] = isset($data['total_installment_amount']) ? $data['total_installment_amount'] : null;
        $this->container['repayment_schedule_issue_date'] = isset($data['repayment_schedule_issue_date']) ? $data['repayment_schedule_issue_date'] : null;
        $this->container['repayment_schedule'] = isset($data['repayment_schedule']) ? $data['repayment_schedule'] : null;
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
     * Gets loan_amount
     *
     * @return double
     */
    public function getLoanAmount()
    {
        return $this->container['loan_amount'];
    }

    /**
     * Sets loan_amount
     *
     * @param double $loan_amount Eligible Loan amount.
     *
     * @return $this
     */
    public function setLoanAmount($loan_amount)
    {
        $this->container['loan_amount'] = $loan_amount;

        return $this;
    }

    /**
     * Gets tenor
     *
     * @return string
     */
    public function getTenor()
    {
        return $this->container['tenor'];
    }

    /**
     * Sets tenor
     *
     * @param string $tenor Tenor for the loan repayment. This is a reference data field. Please use /v1/apac/utilities/referenceData/{tenor} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setTenor($tenor)
    {
        $this->container['tenor'] = $tenor;

        return $this;
    }

    /**
     * Gets interest_rate
     *
     * @return double
     */
    public function getInterestRate()
    {
        return $this->container['interest_rate'];
    }

    /**
     * Sets interest_rate
     *
     * @param double $interest_rate The rate of interest applicable to product
     *
     * @return $this
     */
    public function setInterestRate($interest_rate)
    {
        $this->container['interest_rate'] = $interest_rate;

        return $this;
    }

    /**
     * Gets handling_fee
     *
     * @return double
     */
    public function getHandlingFee()
    {
        return $this->container['handling_fee'];
    }

    /**
     * Sets handling_fee
     *
     * @param double $handling_fee Handling fee to be paid.
     *
     * @return $this
     */
    public function setHandlingFee($handling_fee)
    {
        $this->container['handling_fee'] = $handling_fee;

        return $this;
    }

    /**
     * Gets installment_amount
     *
     * @return double
     */
    public function getInstallmentAmount()
    {
        return $this->container['installment_amount'];
    }

    /**
     * Sets installment_amount
     *
     * @param double $installment_amount Installment amount to be paid.
     *
     * @return $this
     */
    public function setInstallmentAmount($installment_amount)
    {
        $this->container['installment_amount'] = $installment_amount;

        return $this;
    }

    /**
     * Gets annual_percentage_rate
     *
     * @return double
     */
    public function getAnnualPercentageRate()
    {
        return $this->container['annual_percentage_rate'];
    }

    /**
     * Sets annual_percentage_rate
     *
     * @param double $annual_percentage_rate Applicable Annual Percentage Rate
     *
     * @return $this
     */
    public function setAnnualPercentageRate($annual_percentage_rate)
    {
        $this->container['annual_percentage_rate'] = $annual_percentage_rate;

        return $this;
    }

    /**
     * Gets total_principal_amount
     *
     * @return double
     */
    public function getTotalPrincipalAmount()
    {
        return $this->container['total_principal_amount'];
    }

    /**
     * Sets total_principal_amount
     *
     * @param double $total_principal_amount Total principal to be paid by customer
     *
     * @return $this
     */
    public function setTotalPrincipalAmount($total_principal_amount)
    {
        $this->container['total_principal_amount'] = $total_principal_amount;

        return $this;
    }

    /**
     * Gets total_interest_amount
     *
     * @return double
     */
    public function getTotalInterestAmount()
    {
        return $this->container['total_interest_amount'];
    }

    /**
     * Sets total_interest_amount
     *
     * @param double $total_interest_amount Total interest to be paid by customer
     *
     * @return $this
     */
    public function setTotalInterestAmount($total_interest_amount)
    {
        $this->container['total_interest_amount'] = $total_interest_amount;

        return $this;
    }

    /**
     * Gets total_installment_amount
     *
     * @return double
     */
    public function getTotalInstallmentAmount()
    {
        return $this->container['total_installment_amount'];
    }

    /**
     * Sets total_installment_amount
     *
     * @param double $total_installment_amount Total installment amount to be paid by customer
     *
     * @return $this
     */
    public function setTotalInstallmentAmount($total_installment_amount)
    {
        $this->container['total_installment_amount'] = $total_installment_amount;

        return $this;
    }

    /**
     * Gets repayment_schedule_issue_date
     *
     * @return \DateTime
     */
    public function getRepaymentScheduleIssueDate()
    {
        return $this->container['repayment_schedule_issue_date'];
    }

    /**
     * Sets repayment_schedule_issue_date
     *
     * @param \DateTime $repayment_schedule_issue_date Repayment schedule start date in ISO 8601 date format YYYY-MM-DD
     *
     * @return $this
     */
    public function setRepaymentScheduleIssueDate($repayment_schedule_issue_date)
    {
        $this->container['repayment_schedule_issue_date'] = $repayment_schedule_issue_date;

        return $this;
    }

    /**
     * Gets repayment_schedule
     *
     * @return \Swagger\Client\Model\RepaymentSchedule[]
     */
    public function getRepaymentSchedule()
    {
        return $this->container['repayment_schedule'];
    }

    /**
     * Sets repayment_schedule
     *
     * @param \Swagger\Client\Model\RepaymentSchedule[] $repayment_schedule repayment_schedule
     *
     * @return $this
     */
    public function setRepaymentSchedule($repayment_schedule)
    {
        $this->container['repayment_schedule'] = $repayment_schedule;

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
