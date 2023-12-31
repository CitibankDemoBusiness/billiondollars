=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse
    # Unique refrence number associated with the loan.
    attr_accessor :new_loan_reference_id

    # Amount of money borrower has to pay as next installment.
    attr_accessor :next_installment_amount

    # Amount of money that contributes to principal component in next installment.
    attr_accessor :next_installment_principal_amount

    # Rate of Interest.Interest rate is the amount charged, expressed as a percentage of principal, by a lender to a borrower for the use of assets. Interest rates are typically noted on an annual basis, known as the annual percentage rate (APR).
    attr_accessor :interest_rate

    # Total amount of money that a borrower will have to pay as interest for amount borrowed.
    attr_accessor :total_interest_amount

    # First month fee/interest charge incurred from booking date to next statement cycle date.
    attr_accessor :initial_fee_amount

    # Closure Interest accrued from last cycle/booking date till date, to be charged for each of the loans getting closed due to Top up post merger.
    attr_accessor :closure_interest_amount

    # Amount to be paid as fee for loan booking.
    attr_accessor :loan_booking_fee

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'new_loan_reference_id' => :'newLoanReferenceId',
        :'next_installment_amount' => :'nextInstallmentAmount',
        :'next_installment_principal_amount' => :'nextInstallmentPrincipalAmount',
        :'interest_rate' => :'interestRate',
        :'total_interest_amount' => :'totalInterestAmount',
        :'initial_fee_amount' => :'initialFeeAmount',
        :'closure_interest_amount' => :'closureInterestAmount',
        :'loan_booking_fee' => :'loanBookingFee'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'new_loan_reference_id' => :'Object',
        :'next_installment_amount' => :'Object',
        :'next_installment_principal_amount' => :'Object',
        :'interest_rate' => :'Object',
        :'total_interest_amount' => :'Object',
        :'initial_fee_amount' => :'Object',
        :'closure_interest_amount' => :'Object',
        :'loan_booking_fee' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidateConfirmationPreLoginResponse`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'new_loan_reference_id')
        self.new_loan_reference_id = attributes[:'new_loan_reference_id']
      end

      if attributes.key?(:'next_installment_amount')
        self.next_installment_amount = attributes[:'next_installment_amount']
      end

      if attributes.key?(:'next_installment_principal_amount')
        self.next_installment_principal_amount = attributes[:'next_installment_principal_amount']
      end

      if attributes.key?(:'interest_rate')
        self.interest_rate = attributes[:'interest_rate']
      end

      if attributes.key?(:'total_interest_amount')
        self.total_interest_amount = attributes[:'total_interest_amount']
      end

      if attributes.key?(:'initial_fee_amount')
        self.initial_fee_amount = attributes[:'initial_fee_amount']
      end

      if attributes.key?(:'closure_interest_amount')
        self.closure_interest_amount = attributes[:'closure_interest_amount']
      end

      if attributes.key?(:'loan_booking_fee')
        self.loan_booking_fee = attributes[:'loan_booking_fee']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @new_loan_reference_id.nil?
        invalid_properties.push('invalid value for "new_loan_reference_id", new_loan_reference_id cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @new_loan_reference_id.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          new_loan_reference_id == o.new_loan_reference_id &&
          next_installment_amount == o.next_installment_amount &&
          next_installment_principal_amount == o.next_installment_principal_amount &&
          interest_rate == o.interest_rate &&
          total_interest_amount == o.total_interest_amount &&
          initial_fee_amount == o.initial_fee_amount &&
          closure_interest_amount == o.closure_interest_amount &&
          loan_booking_fee == o.loan_booking_fee
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [new_loan_reference_id, next_installment_amount, next_installment_principal_amount, interest_rate, total_interest_amount, initial_fee_amount, closure_interest_amount, loan_booking_fee].hash
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
