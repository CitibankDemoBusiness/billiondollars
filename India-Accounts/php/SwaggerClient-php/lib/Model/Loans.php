<?php
/**
 * Loans
 *
 * PHP version 5
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */

/**
 * Accounts
 *
 * The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.
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
 * Loans Class Doc Comment
 *
 * @category Class
 * @package  Swagger\Client
 * @author   Swagger Codegen team
 * @link     https://github.com/swagger-api/swagger-codegen
 */
class Loans implements ModelInterface, ArrayAccess
{
    const DISCRIMINATOR = null;

    /**
      * The original name of the model.
      *
      * @var string
      */
    protected static $swaggerModelName = 'Loans';

    /**
      * Array of property to type mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerTypes = [
        'loan_reference_id' => 'string',
'display_account_number' => 'string',
'transaction_date' => '\DateTime',
'transaction_description' => 'string',
'installment_amount' => 'double',
'next_installment_amount' => 'double',
'outstanding_balance_amount' => 'double',
'tenor' => 'float',
'outstanding_tenor' => 'float',
'original_loan_amount' => 'double',
'annual_percentage_rate' => 'double',
'effective_interest_rate' => 'double',
'processing_charge_amount' => 'double',
'outstanding_interest_amount' => 'double',
'self_early_loan_closure_allowed_flag' => 'bool',
'installment_cycle' => 'int'    ];

    /**
      * Array of property to format mappings. Used for (de)serialization
      *
      * @var string[]
      */
    protected static $swaggerFormats = [
        'loan_reference_id' => null,
'display_account_number' => null,
'transaction_date' => 'date',
'transaction_description' => null,
'installment_amount' => 'double',
'next_installment_amount' => 'double',
'outstanding_balance_amount' => 'double',
'tenor' => 'integer',
'outstanding_tenor' => 'integer',
'original_loan_amount' => 'double',
'annual_percentage_rate' => 'double',
'effective_interest_rate' => 'double',
'processing_charge_amount' => 'double',
'outstanding_interest_amount' => 'double',
'self_early_loan_closure_allowed_flag' => null,
'installment_cycle' => null    ];

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
        'loan_reference_id' => 'loanReferenceId',
'display_account_number' => 'displayAccountNumber',
'transaction_date' => 'transactionDate',
'transaction_description' => 'transactionDescription',
'installment_amount' => 'installmentAmount',
'next_installment_amount' => 'nextInstallmentAmount',
'outstanding_balance_amount' => 'outstandingBalanceAmount',
'tenor' => 'tenor',
'outstanding_tenor' => 'outstandingTenor',
'original_loan_amount' => 'originalLoanAmount',
'annual_percentage_rate' => 'annualPercentageRate',
'effective_interest_rate' => 'effectiveInterestRate',
'processing_charge_amount' => 'processingChargeAmount',
'outstanding_interest_amount' => 'outstandingInterestAmount',
'self_early_loan_closure_allowed_flag' => 'selfEarlyLoanClosureAllowedFlag',
'installment_cycle' => 'installmentCycle'    ];

    /**
     * Array of attributes to setter functions (for deserialization of responses)
     *
     * @var string[]
     */
    protected static $setters = [
        'loan_reference_id' => 'setLoanReferenceId',
'display_account_number' => 'setDisplayAccountNumber',
'transaction_date' => 'setTransactionDate',
'transaction_description' => 'setTransactionDescription',
'installment_amount' => 'setInstallmentAmount',
'next_installment_amount' => 'setNextInstallmentAmount',
'outstanding_balance_amount' => 'setOutstandingBalanceAmount',
'tenor' => 'setTenor',
'outstanding_tenor' => 'setOutstandingTenor',
'original_loan_amount' => 'setOriginalLoanAmount',
'annual_percentage_rate' => 'setAnnualPercentageRate',
'effective_interest_rate' => 'setEffectiveInterestRate',
'processing_charge_amount' => 'setProcessingChargeAmount',
'outstanding_interest_amount' => 'setOutstandingInterestAmount',
'self_early_loan_closure_allowed_flag' => 'setSelfEarlyLoanClosureAllowedFlag',
'installment_cycle' => 'setInstallmentCycle'    ];

    /**
     * Array of attributes to getter functions (for serialization of requests)
     *
     * @var string[]
     */
    protected static $getters = [
        'loan_reference_id' => 'getLoanReferenceId',
'display_account_number' => 'getDisplayAccountNumber',
'transaction_date' => 'getTransactionDate',
'transaction_description' => 'getTransactionDescription',
'installment_amount' => 'getInstallmentAmount',
'next_installment_amount' => 'getNextInstallmentAmount',
'outstanding_balance_amount' => 'getOutstandingBalanceAmount',
'tenor' => 'getTenor',
'outstanding_tenor' => 'getOutstandingTenor',
'original_loan_amount' => 'getOriginalLoanAmount',
'annual_percentage_rate' => 'getAnnualPercentageRate',
'effective_interest_rate' => 'getEffectiveInterestRate',
'processing_charge_amount' => 'getProcessingChargeAmount',
'outstanding_interest_amount' => 'getOutstandingInterestAmount',
'self_early_loan_closure_allowed_flag' => 'getSelfEarlyLoanClosureAllowedFlag',
'installment_cycle' => 'getInstallmentCycle'    ];

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
        $this->container['loan_reference_id'] = isset($data['loan_reference_id']) ? $data['loan_reference_id'] : null;
        $this->container['display_account_number'] = isset($data['display_account_number']) ? $data['display_account_number'] : null;
        $this->container['transaction_date'] = isset($data['transaction_date']) ? $data['transaction_date'] : null;
        $this->container['transaction_description'] = isset($data['transaction_description']) ? $data['transaction_description'] : null;
        $this->container['installment_amount'] = isset($data['installment_amount']) ? $data['installment_amount'] : null;
        $this->container['next_installment_amount'] = isset($data['next_installment_amount']) ? $data['next_installment_amount'] : null;
        $this->container['outstanding_balance_amount'] = isset($data['outstanding_balance_amount']) ? $data['outstanding_balance_amount'] : null;
        $this->container['tenor'] = isset($data['tenor']) ? $data['tenor'] : null;
        $this->container['outstanding_tenor'] = isset($data['outstanding_tenor']) ? $data['outstanding_tenor'] : null;
        $this->container['original_loan_amount'] = isset($data['original_loan_amount']) ? $data['original_loan_amount'] : null;
        $this->container['annual_percentage_rate'] = isset($data['annual_percentage_rate']) ? $data['annual_percentage_rate'] : null;
        $this->container['effective_interest_rate'] = isset($data['effective_interest_rate']) ? $data['effective_interest_rate'] : null;
        $this->container['processing_charge_amount'] = isset($data['processing_charge_amount']) ? $data['processing_charge_amount'] : null;
        $this->container['outstanding_interest_amount'] = isset($data['outstanding_interest_amount']) ? $data['outstanding_interest_amount'] : null;
        $this->container['self_early_loan_closure_allowed_flag'] = isset($data['self_early_loan_closure_allowed_flag']) ? $data['self_early_loan_closure_allowed_flag'] : null;
        $this->container['installment_cycle'] = isset($data['installment_cycle']) ? $data['installment_cycle'] : null;
    }

    /**
     * Show all the invalid properties with reasons.
     *
     * @return array invalid properties with reasons
     */
    public function listInvalidProperties()
    {
        $invalidProperties = [];

        if ($this->container['loan_reference_id'] === null) {
            $invalidProperties[] = "'loan_reference_id' can't be null";
        }
        if ($this->container['transaction_date'] === null) {
            $invalidProperties[] = "'transaction_date' can't be null";
        }
        if ($this->container['transaction_description'] === null) {
            $invalidProperties[] = "'transaction_description' can't be null";
        }
        if ($this->container['installment_amount'] === null) {
            $invalidProperties[] = "'installment_amount' can't be null";
        }
        if ($this->container['outstanding_balance_amount'] === null) {
            $invalidProperties[] = "'outstanding_balance_amount' can't be null";
        }
        if ($this->container['tenor'] === null) {
            $invalidProperties[] = "'tenor' can't be null";
        }
        if ($this->container['original_loan_amount'] === null) {
            $invalidProperties[] = "'original_loan_amount' can't be null";
        }
        if ($this->container['annual_percentage_rate'] === null) {
            $invalidProperties[] = "'annual_percentage_rate' can't be null";
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
     * Gets loan_reference_id
     *
     * @return string
     */
    public function getLoanReferenceId()
    {
        return $this->container['loan_reference_id'];
    }

    /**
     * Sets loan_reference_id
     *
     * @param string $loan_reference_id Reference Id to uniquely identify the loan.
     *
     * @return $this
     */
    public function setLoanReferenceId($loan_reference_id)
    {
        $this->container['loan_reference_id'] = $loan_reference_id;

        return $this;
    }

    /**
     * Gets display_account_number
     *
     * @return string
     */
    public function getDisplayAccountNumber()
    {
        return $this->container['display_account_number'];
    }

    /**
     * Sets display_account_number
     *
     * @param string $display_account_number Last 4 digits of account number.
     *
     * @return $this
     */
    public function setDisplayAccountNumber($display_account_number)
    {
        $this->container['display_account_number'] = $display_account_number;

        return $this;
    }

    /**
     * Gets transaction_date
     *
     * @return \DateTime
     */
    public function getTransactionDate()
    {
        return $this->container['transaction_date'];
    }

    /**
     * Sets transaction_date
     *
     * @param \DateTime $transaction_date Transaction date in YYYY-MM-DD format value conforming to ISO 8601.
     *
     * @return $this
     */
    public function setTransactionDate($transaction_date)
    {
        $this->container['transaction_date'] = $transaction_date;

        return $this;
    }

    /**
     * Gets transaction_description
     *
     * @return string
     */
    public function getTransactionDescription()
    {
        return $this->container['transaction_description'];
    }

    /**
     * Sets transaction_description
     *
     * @param string $transaction_description Transaction description from the merchant, POS or bank. If there are foreign currency transactions on checking /saving account(s) then description includes exchange rate, city and country.
     *
     * @return $this
     */
    public function setTransactionDescription($transaction_description)
    {
        $this->container['transaction_description'] = $transaction_description;

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
     * @param double $installment_amount Installment loan payment amount
     *
     * @return $this
     */
    public function setInstallmentAmount($installment_amount)
    {
        $this->container['installment_amount'] = $installment_amount;

        return $this;
    }

    /**
     * Gets next_installment_amount
     *
     * @return double
     */
    public function getNextInstallmentAmount()
    {
        return $this->container['next_installment_amount'];
    }

    /**
     * Sets next_installment_amount
     *
     * @param double $next_installment_amount Next installment amount in local currency.
     *
     * @return $this
     */
    public function setNextInstallmentAmount($next_installment_amount)
    {
        $this->container['next_installment_amount'] = $next_installment_amount;

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
     * @param double $outstanding_balance_amount The amount of money owed.
     *
     * @return $this
     */
    public function setOutstandingBalanceAmount($outstanding_balance_amount)
    {
        $this->container['outstanding_balance_amount'] = $outstanding_balance_amount;

        return $this;
    }

    /**
     * Gets tenor
     *
     * @return float
     */
    public function getTenor()
    {
        return $this->container['tenor'];
    }

    /**
     * Sets tenor
     *
     * @param float $tenor Tenure of loan in months.
     *
     * @return $this
     */
    public function setTenor($tenor)
    {
        $this->container['tenor'] = $tenor;

        return $this;
    }

    /**
     * Gets outstanding_tenor
     *
     * @return float
     */
    public function getOutstandingTenor()
    {
        return $this->container['outstanding_tenor'];
    }

    /**
     * Sets outstanding_tenor
     *
     * @param float $outstanding_tenor Number of months remaining for completion of loan.
     *
     * @return $this
     */
    public function setOutstandingTenor($outstanding_tenor)
    {
        $this->container['outstanding_tenor'] = $outstanding_tenor;

        return $this;
    }

    /**
     * Gets original_loan_amount
     *
     * @return double
     */
    public function getOriginalLoanAmount()
    {
        return $this->container['original_loan_amount'];
    }

    /**
     * Sets original_loan_amount
     *
     * @param double $original_loan_amount Original loan amount borrowed by customer.
     *
     * @return $this
     */
    public function setOriginalLoanAmount($original_loan_amount)
    {
        $this->container['original_loan_amount'] = $original_loan_amount;

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
     * @param double $annual_percentage_rate Interest rate for a whole year. This includes any fees or additional cost associated.
     *
     * @return $this
     */
    public function setAnnualPercentageRate($annual_percentage_rate)
    {
        $this->container['annual_percentage_rate'] = $annual_percentage_rate;

        return $this;
    }

    /**
     * Gets effective_interest_rate
     *
     * @return double
     */
    public function getEffectiveInterestRate()
    {
        return $this->container['effective_interest_rate'];
    }

    /**
     * Sets effective_interest_rate
     *
     * @param double $effective_interest_rate Effective Percentage Rate
     *
     * @return $this
     */
    public function setEffectiveInterestRate($effective_interest_rate)
    {
        $this->container['effective_interest_rate'] = $effective_interest_rate;

        return $this;
    }

    /**
     * Gets processing_charge_amount
     *
     * @return double
     */
    public function getProcessingChargeAmount()
    {
        return $this->container['processing_charge_amount'];
    }

    /**
     * Sets processing_charge_amount
     *
     * @param double $processing_charge_amount Charges levied on applicant by the bank to process the loan.
     *
     * @return $this
     */
    public function setProcessingChargeAmount($processing_charge_amount)
    {
        $this->container['processing_charge_amount'] = $processing_charge_amount;

        return $this;
    }

    /**
     * Gets outstanding_interest_amount
     *
     * @return double
     */
    public function getOutstandingInterestAmount()
    {
        return $this->container['outstanding_interest_amount'];
    }

    /**
     * Sets outstanding_interest_amount
     *
     * @param double $outstanding_interest_amount Total Outstanding Interest Amount.
     *
     * @return $this
     */
    public function setOutstandingInterestAmount($outstanding_interest_amount)
    {
        $this->container['outstanding_interest_amount'] = $outstanding_interest_amount;

        return $this;
    }

    /**
     * Gets self_early_loan_closure_allowed_flag
     *
     * @return bool
     */
    public function getSelfEarlyLoanClosureAllowedFlag()
    {
        return $this->container['self_early_loan_closure_allowed_flag'];
    }

    /**
     * Sets self_early_loan_closure_allowed_flag
     *
     * @param bool $self_early_loan_closure_allowed_flag Flag to identify if the loan is allowed to be early self closed by customer or not..
     *
     * @return $this
     */
    public function setSelfEarlyLoanClosureAllowedFlag($self_early_loan_closure_allowed_flag)
    {
        $this->container['self_early_loan_closure_allowed_flag'] = $self_early_loan_closure_allowed_flag;

        return $this;
    }

    /**
     * Gets installment_cycle
     *
     * @return int
     */
    public function getInstallmentCycle()
    {
        return $this->container['installment_cycle'];
    }

    /**
     * Sets installment_cycle
     *
     * @param int $installment_cycle Intallment Cycle
     *
     * @return $this
     */
    public function setInstallmentCycle($installment_cycle)
    {
        $this->container['installment_cycle'] = $installment_cycle;

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
