<?php
/**
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Cards
 *
 * The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.
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
 * RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginRequest';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'old_loan_list' => '\Swagger\Client\Model\Loan[]',
'total_loan_amount' => 'double',
'loan_tenure_inmonths' => 'int',
'top_up_amount' => 'double',
'loan_description' => 'string',
'disbursement_option' => 'string',
'account_number' => 'string',
'payee_id' => 'string',
'birth_year' => 'float',
'beneficiary_bank_detail' => '\Swagger\Client\Model\BeneficiaryBankDetail',
'loan_purpose' => 'string'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'old_loan_list' => null,
'total_loan_amount' => 'double',
'loan_tenure_inmonths' => 'int32',
'top_up_amount' => 'double',
'loan_description' => null,
'disbursement_option' => null,
'account_number' => null,
'payee_id' => null,
'birth_year' => 'integer',
'beneficiary_bank_detail' => null,
'loan_purpose' => null    ];

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
        'old_loan_list' => 'oldLoanList',
'total_loan_amount' => 'totalLoanAmount',
'loan_tenure_inmonths' => 'loanTenureInmonths',
'top_up_amount' => 'topUpAmount',
'loan_description' => 'loanDescription',
'disbursement_option' => 'disbursementOption',
'account_number' => 'accountNumber',
'payee_id' => 'payeeId',
'birth_year' => 'birthYear',
'beneficiary_bank_detail' => 'beneficiaryBankDetail',
'loan_purpose' => 'loanPurpose'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'old_loan_list' => 'setOldLoanList',
'total_loan_amount' => 'setTotalLoanAmount',
'loan_tenure_inmonths' => 'setLoanTenureInmonths',
'top_up_amount' => 'setTopUpAmount',
'loan_description' => 'setLoanDescription',
'disbursement_option' => 'setDisbursementOption',
'account_number' => 'setAccountNumber',
'payee_id' => 'setPayeeId',
'birth_year' => 'setBirthYear',
'beneficiary_bank_detail' => 'setBeneficiaryBankDetail',
'loan_purpose' => 'setLoanPurpose'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'old_loan_list' => 'getOldLoanList',
'total_loan_amount' => 'getTotalLoanAmount',
'loan_tenure_inmonths' => 'getLoanTenureInmonths',
'top_up_amount' => 'getTopUpAmount',
'loan_description' => 'getLoanDescription',
'disbursement_option' => 'getDisbursementOption',
'account_number' => 'getAccountNumber',
'payee_id' => 'getPayeeId',
'birth_year' => 'getBirthYear',
'beneficiary_bank_detail' => 'getBeneficiaryBankDetail',
'loan_purpose' => 'getLoanPurpose'    ];

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
        $this->container['old_loan_list'] = isset($data['old_loan_list']) ? $data['old_loan_list'] : null;
        $this->container['total_loan_amount'] = isset($data['total_loan_amount']) ? $data['total_loan_amount'] : null;
        $this->container['loan_tenure_inmonths'] = isset($data['loan_tenure_inmonths']) ? $data['loan_tenure_inmonths'] : null;
        $this->container['top_up_amount'] = isset($data['top_up_amount']) ? $data['top_up_amount'] : null;
        $this->container['loan_description'] = isset($data['loan_description']) ? $data['loan_description'] : null;
        $this->container['disbursement_option'] = isset($data['disbursement_option']) ? $data['disbursement_option'] : null;
        $this->container['account_number'] = isset($data['account_number']) ? $data['account_number'] : null;
        $this->container['payee_id'] = isset($data['payee_id']) ? $data['payee_id'] : null;
        $this->container['birth_year'] = isset($data['birth_year']) ? $data['birth_year'] : null;
        $this->container['beneficiary_bank_detail'] = isset($data['beneficiary_bank_detail']) ? $data['beneficiary_bank_detail'] : null;
        $this->container['loan_purpose'] = isset($data['loan_purpose']) ? $data['loan_purpose'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['total_loan_amount'] === null) {
            $invalidProperties[] = "'total_loan_amount' can't be null";
        }
        if ($this->container['loan_tenure_inmonths'] === null) {
            $invalidProperties[] = "'loan_tenure_inmonths' can't be null";
        }
        if ($this->container['top_up_amount'] === null) {
            $invalidProperties[] = "'top_up_amount' can't be null";
        }
        if ($this->container['loan_description'] === null) {
            $invalidProperties[] = "'loan_description' can't be null";
        }
        if ($this->container['disbursement_option'] === null) {
            $invalidProperties[] = "'disbursement_option' can't be null";
        }
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
     * Gets old_loan_list
     *
     * @return \Swagger\Client\Model\Loan[]
     */
    public function getOldLoanList()
    {
        return $this->container['old_loan_list'];
    }

    /**
     * Sets old_loan_list
     *
     * @param \Swagger\Client\Model\Loan[] $old_loan_list old_loan_list
     *
     * @return $this
     */
    public function setOldLoanList($old_loan_list)
    {
        $this->container['old_loan_list'] = $old_loan_list;

        return $this;
    }

    /**
     * Gets total_loan_amount
     *
     * @return double
     */
    public function getTotalLoanAmount()
    {
        return $this->container['total_loan_amount'];
    }

    /**
     * Sets total_loan_amount
     *
     * @param double $total_loan_amount Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount.
     *
     * @return $this
     */
    public function setTotalLoanAmount($total_loan_amount)
    {
        $this->container['total_loan_amount'] = $total_loan_amount;

        return $this;
    }

    /**
     * Gets loan_tenure_inmonths
     *
     * @return int
     */
    public function getLoanTenureInmonths()
    {
        return $this->container['loan_tenure_inmonths'];
    }

    /**
     * Sets loan_tenure_inmonths
     *
     * @param int $loan_tenure_inmonths Tenure of loan against credit card. It is considered in terms of number of months.
     *
     * @return $this
     */
    public function setLoanTenureInmonths($loan_tenure_inmonths)
    {
        $this->container['loan_tenure_inmonths'] = $loan_tenure_inmonths;

        return $this;
    }

    /**
     * Gets top_up_amount
     *
     * @return double
     */
    public function getTopUpAmount()
    {
        return $this->container['top_up_amount'];
    }

    /**
     * Sets top_up_amount
     *
     * @param double $top_up_amount Additonal Topup Amount
     *
     * @return $this
     */
    public function setTopUpAmount($top_up_amount)
    {
        $this->container['top_up_amount'] = $top_up_amount;

        return $this;
    }

    /**
     * Gets loan_description
     *
     * @return string
     */
    public function getLoanDescription()
    {
        return $this->container['loan_description'];
    }

    /**
     * Sets loan_description
     *
     * @param string $loan_description New Loan Description
     *
     * @return $this
     */
    public function setLoanDescription($loan_description)
    {
        $this->container['loan_description'] = $loan_description;

        return $this;
    }

    /**
     * Gets disbursement_option
     *
     * @return string
     */
    public function getDisbursementOption()
    {
        return $this->container['disbursement_option'];
    }

    /**
     * Sets disbursement_option
     *
     * @param string $disbursement_option This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description
     *
     * @return $this
     */
    public function setDisbursementOption($disbursement_option)
    {
        $this->container['disbursement_option'] = $disbursement_option;

        return $this;
    }

    /**
     * Gets account_number
     *
     * @return string
     */
    public function getAccountNumber()
    {
        return $this->container['account_number'];
    }

    /**
     * Sets account_number
     *
     * @param string $account_number Customers Account Number with the Bank.   An account number is the primary identifier for ownership of an account, whether a checking account or savings account or credit card account or investment account, or a loan account.
     *
     * @return $this
     */
    public function setAccountNumber($account_number)
    {
        $this->container['account_number'] = $account_number;

        return $this;
    }

    /**
     * Gets payee_id
     *
     * @return string
     */
    public function getPayeeId()
    {
        return $this->container['payee_id'];
    }

    /**
     * Sets payee_id
     *
     * @param string $payee_id Payee Indicator to be mapped against Payee Detail Key
     *
     * @return $this
     */
    public function setPayeeId($payee_id)
    {
        $this->container['payee_id'] = $payee_id;

        return $this;
    }

    /**
     * Gets birth_year
     *
     * @return float
     */
    public function getBirthYear()
    {
        return $this->container['birth_year'];
    }

    /**
     * Sets birth_year
     *
     * @param float $birth_year Year of birth of customer
     *
     * @return $this
     */
    public function setBirthYear($birth_year)
    {
        $this->container['birth_year'] = $birth_year;

        return $this;
    }

    /**
     * Gets beneficiary_bank_detail
     *
     * @return \Swagger\Client\Model\BeneficiaryBankDetail
     */
    public function getBeneficiaryBankDetail()
    {
        return $this->container['beneficiary_bank_detail'];
    }

    /**
     * Sets beneficiary_bank_detail
     *
     * @param \Swagger\Client\Model\BeneficiaryBankDetail $beneficiary_bank_detail beneficiary_bank_detail
     *
     * @return $this
     */
    public function setBeneficiaryBankDetail($beneficiary_bank_detail)
    {
        $this->container['beneficiary_bank_detail'] = $beneficiary_bank_detail;

        return $this;
    }

    /**
     * Gets loan_purpose
     *
     * @return string
     */
    public function getLoanPurpose()
    {
        return $this->container['loan_purpose'];
    }

    /**
     * Sets loan_purpose
     *
     * @param string $loan_purpose This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{loanPurpose} resource to get valid value of this field with description.
     *
     * @return $this
     */
    public function setLoanPurpose($loan_purpose)
    {
        $this->container['loan_purpose'] = $loan_purpose;

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
