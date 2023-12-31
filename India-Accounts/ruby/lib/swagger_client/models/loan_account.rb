=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class LoanAccount
    # The name of the product
    attr_accessor :product_name

    # A unique code that identifies the product
    attr_accessor :product_code

    # A masked account number that can be displayed to the customer
    attr_accessor :display_account_number

    # The amount borrowed
    attr_accessor :original_principal_amount

    # The remaining principal amount
    attr_accessor :current_principal_amount

    # The amount of money owed.
    attr_accessor :outstanding_balance

    # The currency code in ISO 4217 format
    attr_accessor :currency_code

    # Loan maturity date in ISO 8601 date format YYYY-MM-DD
    attr_accessor :maturity_date

    # Loan account opening date in ISO 8601 date format YYYY-MM-DD
    attr_accessor :opening_date

    # The date of the last payment in ISO 8601 format YYYY-MM-DD
    attr_accessor :last_payment_date

    # The amount of the last payment made
    attr_accessor :last_payment_amount

    # Interest amount paid for the mentioned period
    attr_accessor :interest_amount

    # The period of interest accumulation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestAccumulationPeriod} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :interest_accumulation_period

    # The next payment amount due
    attr_accessor :next_payment_amount

    # The date of the next payment in ISO 8601 date format YYYY-MM-DD
    attr_accessor :next_payment_date

    # The payment frequency
    attr_accessor :payment_frequency

    # The interest type. This is a reference data field. Please use /v1/apac/utilities/referenceData/{interestType} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values.
    attr_accessor :interest_type

    # Loan interest rate.
    attr_accessor :interest_rate

    # Loan effective interest rate
    attr_accessor :effective_interest_rate

    # Installment loan payment amount
    attr_accessor :installment_amount

    # Term remaining.
    attr_accessor :remaining_term_number

    # Past due is a loan payment that has not been made as of its due date
    attr_accessor :past_due_amount

    # The amount of principal returned to the bank
    attr_accessor :paid_principal_amount

    # Late charge amount applicable when amount is not paid by the due date
    attr_accessor :late_charge_amount

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'product_name' => :'productName',
        :'product_code' => :'productCode',
        :'display_account_number' => :'displayAccountNumber',
        :'original_principal_amount' => :'originalPrincipalAmount',
        :'current_principal_amount' => :'currentPrincipalAmount',
        :'outstanding_balance' => :'outstandingBalance',
        :'currency_code' => :'currencyCode',
        :'maturity_date' => :'maturityDate',
        :'opening_date' => :'openingDate',
        :'last_payment_date' => :'lastPaymentDate',
        :'last_payment_amount' => :'lastPaymentAmount',
        :'interest_amount' => :'interestAmount',
        :'interest_accumulation_period' => :'interestAccumulationPeriod',
        :'next_payment_amount' => :'nextPaymentAmount',
        :'next_payment_date' => :'nextPaymentDate',
        :'payment_frequency' => :'paymentFrequency',
        :'interest_type' => :'interestType',
        :'interest_rate' => :'interestRate',
        :'effective_interest_rate' => :'effectiveInterestRate',
        :'installment_amount' => :'installmentAmount',
        :'remaining_term_number' => :'remainingTermNumber',
        :'past_due_amount' => :'pastDueAmount',
        :'paid_principal_amount' => :'paidPrincipalAmount',
        :'late_charge_amount' => :'lateChargeAmount'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'product_name' => :'Object',
        :'product_code' => :'Object',
        :'display_account_number' => :'Object',
        :'original_principal_amount' => :'Object',
        :'current_principal_amount' => :'Object',
        :'outstanding_balance' => :'Object',
        :'currency_code' => :'Object',
        :'maturity_date' => :'Object',
        :'opening_date' => :'Object',
        :'last_payment_date' => :'Object',
        :'last_payment_amount' => :'Object',
        :'interest_amount' => :'Object',
        :'interest_accumulation_period' => :'Object',
        :'next_payment_amount' => :'Object',
        :'next_payment_date' => :'Object',
        :'payment_frequency' => :'Object',
        :'interest_type' => :'Object',
        :'interest_rate' => :'Object',
        :'effective_interest_rate' => :'Object',
        :'installment_amount' => :'Object',
        :'remaining_term_number' => :'Object',
        :'past_due_amount' => :'Object',
        :'paid_principal_amount' => :'Object',
        :'late_charge_amount' => :'Object'
      }
    end

    # List of attributes with nullable: true
    def self.openapi_nullable
      Set.new([
      ])
    end
  
    # Initializes the object
    # @param [Hash] attributes Model attributes in the form of hash
    def initialize(attributes = {})
      if (!attributes.is_a?(Hash))
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::LoanAccount` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::LoanAccount`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'product_name')
        self.product_name = attributes[:'product_name']
      end

      if attributes.key?(:'product_code')
        self.product_code = attributes[:'product_code']
      end

      if attributes.key?(:'display_account_number')
        self.display_account_number = attributes[:'display_account_number']
      end

      if attributes.key?(:'original_principal_amount')
        self.original_principal_amount = attributes[:'original_principal_amount']
      end

      if attributes.key?(:'current_principal_amount')
        self.current_principal_amount = attributes[:'current_principal_amount']
      end

      if attributes.key?(:'outstanding_balance')
        self.outstanding_balance = attributes[:'outstanding_balance']
      end

      if attributes.key?(:'currency_code')
        self.currency_code = attributes[:'currency_code']
      end

      if attributes.key?(:'maturity_date')
        self.maturity_date = attributes[:'maturity_date']
      end

      if attributes.key?(:'opening_date')
        self.opening_date = attributes[:'opening_date']
      end

      if attributes.key?(:'last_payment_date')
        self.last_payment_date = attributes[:'last_payment_date']
      end

      if attributes.key?(:'last_payment_amount')
        self.last_payment_amount = attributes[:'last_payment_amount']
      end

      if attributes.key?(:'interest_amount')
        self.interest_amount = attributes[:'interest_amount']
      end

      if attributes.key?(:'interest_accumulation_period')
        self.interest_accumulation_period = attributes[:'interest_accumulation_period']
      end

      if attributes.key?(:'next_payment_amount')
        self.next_payment_amount = attributes[:'next_payment_amount']
      end

      if attributes.key?(:'next_payment_date')
        self.next_payment_date = attributes[:'next_payment_date']
      end

      if attributes.key?(:'payment_frequency')
        self.payment_frequency = attributes[:'payment_frequency']
      end

      if attributes.key?(:'interest_type')
        self.interest_type = attributes[:'interest_type']
      end

      if attributes.key?(:'interest_rate')
        self.interest_rate = attributes[:'interest_rate']
      end

      if attributes.key?(:'effective_interest_rate')
        self.effective_interest_rate = attributes[:'effective_interest_rate']
      end

      if attributes.key?(:'installment_amount')
        self.installment_amount = attributes[:'installment_amount']
      end

      if attributes.key?(:'remaining_term_number')
        self.remaining_term_number = attributes[:'remaining_term_number']
      end

      if attributes.key?(:'past_due_amount')
        self.past_due_amount = attributes[:'past_due_amount']
      end

      if attributes.key?(:'paid_principal_amount')
        self.paid_principal_amount = attributes[:'paid_principal_amount']
      end

      if attributes.key?(:'late_charge_amount')
        self.late_charge_amount = attributes[:'late_charge_amount']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @display_account_number.nil?
        invalid_properties.push('invalid value for "display_account_number", display_account_number cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @display_account_number.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          product_name == o.product_name &&
          product_code == o.product_code &&
          display_account_number == o.display_account_number &&
          original_principal_amount == o.original_principal_amount &&
          current_principal_amount == o.current_principal_amount &&
          outstanding_balance == o.outstanding_balance &&
          currency_code == o.currency_code &&
          maturity_date == o.maturity_date &&
          opening_date == o.opening_date &&
          last_payment_date == o.last_payment_date &&
          last_payment_amount == o.last_payment_amount &&
          interest_amount == o.interest_amount &&
          interest_accumulation_period == o.interest_accumulation_period &&
          next_payment_amount == o.next_payment_amount &&
          next_payment_date == o.next_payment_date &&
          payment_frequency == o.payment_frequency &&
          interest_type == o.interest_type &&
          interest_rate == o.interest_rate &&
          effective_interest_rate == o.effective_interest_rate &&
          installment_amount == o.installment_amount &&
          remaining_term_number == o.remaining_term_number &&
          past_due_amount == o.past_due_amount &&
          paid_principal_amount == o.paid_principal_amount &&
          late_charge_amount == o.late_charge_amount
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [product_name, product_code, display_account_number, original_principal_amount, current_principal_amount, outstanding_balance, currency_code, maturity_date, opening_date, last_payment_date, last_payment_amount, interest_amount, interest_accumulation_period, next_payment_amount, next_payment_date, payment_frequency, interest_type, interest_rate, effective_interest_rate, installment_amount, remaining_term_number, past_due_amount, paid_principal_amount, late_charge_amount].hash
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def self.build_from_hash(attributes)
      new.build_from_hash(attributes)
    end

    # Builds the object from hash
    # @param [Hash] attributes Model attributes in the form of hash
    # @return [Object] Returns the model itself
    def build_from_hash(attributes)
      return nil unless attributes.is_a?(Hash)
      self.class.openapi_types.each_pair do |key, type|
        if type =~ /\AArray<(.*)>/i
          # check to ensure the input is an array given that the attribute
          # is documented as an array but the input is not
          if attributes[self.class.attribute_map[key]].is_a?(Array)
            self.send("#{key}=", attributes[self.class.attribute_map[key]].map { |v| _deserialize($1, v) })
          end
        elsif !attributes[self.class.attribute_map[key]].nil?
          self.send("#{key}=", _deserialize(type, attributes[self.class.attribute_map[key]]))
        elsif attributes[self.class.attribute_map[key]].nil? && self.class.openapi_nullable.include?(key)
          self.send("#{key}=", nil)
        end
      end

      self
    end

    # Deserializes the data based on type
    # @param string type Data type
    # @param string value Value to be deserialized
    # @return [Object] Deserialized data
    def _deserialize(type, value)
      case type.to_sym
      when :DateTime
        DateTime.parse(value)
      when :Date
        Date.parse(value)
      when :String
        value.to_s
      when :Integer
        value.to_i
      when :Float
        value.to_f
      when :Boolean
        if value.to_s =~ /\A(true|t|yes|y|1)\z/i
          true
        else
          false
        end
      when :Object
        # generic object (usually a Hash), return directly
        value
      when /\AArray<(?<inner_type>.+)>\z/
        inner_type = Regexp.last_match[:inner_type]
        value.map { |v| _deserialize(inner_type, v) }
      when /\AHash<(?<k_type>.+?), (?<v_type>.+)>\z/
        k_type = Regexp.last_match[:k_type]
        v_type = Regexp.last_match[:v_type]
        {}.tap do |hash|
          value.each do |k, v|
            hash[_deserialize(k_type, k)] = _deserialize(v_type, v)
          end
        end
      else # model
        SwaggerClient.const_get(type).build_from_hash(value)
      end
    end

    # Returns the string representation of the object
    # @return [String] String presentation of the object
    def to_s
      to_hash.to_s
    end

    # to_body is an alias to to_hash (backward compatibility)
    # @return [Hash] Returns the object in the form of hash
    def to_body
      to_hash
    end

    # Returns the object in the form of hash
    # @return [Hash] Returns the object in the form of hash
    def to_hash
      hash = {}
      self.class.attribute_map.each_pair do |attr, param|
        value = self.send(attr)
        if value.nil?
          is_nullable = self.class.openapi_nullable.include?(attr)
          next if !is_nullable || (is_nullable && !instance_variable_defined?(:"@#{attr}"))
        end

        hash[param] = _to_hash(value)
      end
      hash
    end

    # Outputs non-array value in the form of hash
    # For object, use to_hash. Otherwise, just return the value
    # @param [Object] value Any valid value
    # @return [Hash] Returns the value in the form of hash
    def _to_hash(value)
      if value.is_a?(Array)
        value.compact.map { |v| _to_hash(v) }
      elsif value.is_a?(Hash)
        {}.tap do |hash|
          value.each { |k, v| hash[k] = _to_hash(v) }
        end
      elsif value.respond_to? :to_hash
        value.to_hash
      else
        value
      end
    end  end
end
