<?php
/**
 * ApplicationUpdateExistingLoanDetails
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
 * ApplicationUpdateExistingLoanDetails Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class ApplicationUpdateExistingLoanDetails implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'ApplicationUpdateExistingLoanDetails';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'loan_type' => 'string',
'other_debt_obligation_type' => 'string',
'monthly_installment_amount' => 'double',
'outstanding_balance_amount' => 'double',
'debt_ownership' => 'string',
'lender_name' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'loan_type' => null,
'other_debt_obligation_type' => null,
'monthly_installment_amount' => 'double',
'outstanding_balance_amount' => 'double',
'debt_ownership' => null,
'lender_name' => null    ];

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
        'loan_type' => 'loanType',
'other_debt_obligation_type' => 'otherDebtObligationType',
'monthly_installment_amount' => 'monthlyInstallmentAmount',
'outstanding_balance_amount' => 'outstandingBalanceAmount',
'debt_ownership' => 'debtOwnership',
'lender_name' => 'lenderName'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'loan_type' => 'setLoanType',
'other_debt_obligation_type' => 'setOtherDebtObligationType',
'monthly_installment_amount' => 'setMonthlyInstallmentAmount',
'outstanding_balance_amount' => 'setOutstandingBalanceAmount',
'debt_ownership' => 'setDebtOwnership',
'lender_name' => 'setLenderName'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'loan_type' => 'getLoanType',
'other_debt_obligation_type' => 'getOtherDebtObligationType',
'monthly_installment_amount' => 'getMonthlyInstallmentAmount',
'outstanding_balance_amount' => 'getOutstandingBalanceAmount',
'debt_ownership' => 'getDebtOwnership',
'lender_name' => 'getLenderName'    ];

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
        $this->container['loan_type'] = isset($data['loan_type']) ? $data['loan_type'] : null;
        $this->container['other_debt_obligation_type'] = isset($data['other_debt_obligation_type']) ? $data['other_debt_obligation_type'] : null;
        $this->container['monthly_installment_amount'] = isset($data['monthly_installment_amount']) ? $data['monthly_installment_amount'] : null;
        $this->container['outstanding_balance_amount'] = isset($data['outstanding_balance_amount']) ? $data['outstanding_balance_amount'] : null;
        $this->container['debt_ownership'] = isset($data['debt_ownership']) ? $data['debt_ownership'] : null;
        $this->container['lender_name'] = isset($data['lender_name']) ? $data['lender_name'] : null;
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
     * Gets loan_type
     *
     * @return string
     */
    public function getLoanType()
    {
        return $this->container['loan_type'];
    }

    /**
     * Sets loan_type
     *
     * @param string $loan_type Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values.
     *
     * @return $this
     */
    public function setLoanType($loan_type)
    {
        $this->container['loan_type'] = $loan_type;

        return $this;
    }

    /**
     * Gets other_debt_obligation_type
     *
     * @return string
     */
    public function getOtherDebtObligationType()
    {
        return $this->container['other_debt_obligation_type'];
    }

    /**
     * Sets other_debt_obligation_type
     *
     * @param string $other_debt_obligation_type Other debt obligation type.
     *
     * @return $this
     */
    public function setOtherDebtObligationType($other_debt_obligation_type)
    {
        $this->container['other_debt_obligation_type'] = $other_debt_obligation_type;

        return $this;
    }

    /**
     * Gets monthly_installment_amount
     *
     * @return double
     */
    public function getMonthlyInstallmentAmount()
    {
        return $this->container['monthly_installment_amount'];
    }

    /**
     * Sets monthly_installment_amount
     *
     * @param double $monthly_installment_amount Monthly repayment amount
     *
     * @return $this
     */
    public function setMonthlyInstallmentAmount($monthly_installment_amount)
    {
        $this->container['monthly_installment_amount'] = $monthly_installment_amount;

        return $this;
    }

    /**
     * Gets outstanding_balance_amount
     *
     * @return double
     */
    public function getOutstandingBalanceAmount()
    {
        return $this->container['outstanding_balance_amount'];
    }

    /**
     * Sets outstanding_balance_amount
     *
     * @param double $outstanding_balance_amount Balance Owing
     *
     * @return $this
     */
    public function setOutstandingBalanceAmount($outstanding_balance_amount)
    {
        $this->container['outstanding_balance_amount'] = $outstanding_balance_amount;

        return $this;
    }

    /**
     * Gets debt_ownership
     *
     * @return string
     */
    public function getDebtOwnership()
    {
        return $this->container['debt_ownership'];
    }

    /**
     * Sets debt_ownership
     *
     * @param string $debt_ownership Nature debt ownership. Please use /v1/apac/utilities/referenceData/{debtOwnership} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setDebtOwnership($debt_ownership)
    {
        $this->container['debt_ownership'] = $debt_ownership;

        return $this;
    }

    /**
     * Gets lender_name
     *
     * @return string
     */
    public function getLenderName()
    {
        return $this->container['lender_name'];
    }

    /**
     * Sets lender_name
     *
     * @param string $lender_name Name of the lender/non-banking financial institution.
     *
     * @return $this
     */
    public function setLenderName($lender_name)
    {
        $this->container['lender_name'] = $lender_name;

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
