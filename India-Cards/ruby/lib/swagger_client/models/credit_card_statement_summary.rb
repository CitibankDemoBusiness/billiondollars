=begin
#Cards

#The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class CreditCardStatementSummary
    # The card id  in encrypted format
    attr_accessor :card_id

    # A masked account number that can be displayed to the customer
    attr_accessor :display_account_number

    # ’Flag to indicate if eligible source accounts are available to make credit card payment on-line.
    attr_accessor :eligible_source_accts_for_payment_flag

    # Eligible amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.
    attr_accessor :epp_eligible_amount

    # Minimum eligible amount for which Equal Payment Plan can be booked. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.
    attr_accessor :epp_minimum_eligible_amount

    # Minimum instalment amount for Equal Payment Plan. Applicable only if eligibleForEqualPaymentPlan='ELIGIBLE'.
    attr_accessor :epp_minimum_installment_amount

    attr_accessor :credit_card_statement

    attr_accessor :statement_summary_error_details

    # In some cases there is more data than what can be returned in a single response. If there is additional data available a nextStartIndex will be returned. Pass the nextStartIndex in your next request to retrieve the next set of data.
    attr_accessor :next_start_index

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'card_id' => :'cardId',
        :'display_account_number' => :'displayAccountNumber',
        :'eligible_source_accts_for_payment_flag' => :'eligibleSourceAcctsForPaymentFlag',
        :'epp_eligible_amount' => :'eppEligibleAmount',
        :'epp_minimum_eligible_amount' => :'eppMinimumEligibleAmount',
        :'epp_minimum_installment_amount' => :'eppMinimumInstallmentAmount',
        :'credit_card_statement' => :'creditCardStatement',
        :'statement_summary_error_details' => :'statementSummaryErrorDetails',
        :'next_start_index' => :'nextStartIndex'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'card_id' => :'Object',
        :'display_account_number' => :'Object',
        :'eligible_source_accts_for_payment_flag' => :'Object',
        :'epp_eligible_amount' => :'Object',
        :'epp_minimum_eligible_amount' => :'Object',
        :'epp_minimum_installment_amount' => :'Object',
        :'credit_card_statement' => :'Object',
        :'statement_summary_error_details' => :'Object',
        :'next_start_index' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::CreditCardStatementSummary` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::CreditCardStatementSummary`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'card_id')
        self.card_id = attributes[:'card_id']
      end

      if attributes.key?(:'display_account_number')
        self.display_account_number = attributes[:'display_account_number']
      end

      if attributes.key?(:'eligible_source_accts_for_payment_flag')
        self.eligible_source_accts_for_payment_flag = attributes[:'eligible_source_accts_for_payment_flag']
      end

      if attributes.key?(:'epp_eligible_amount')
        self.epp_eligible_amount = attributes[:'epp_eligible_amount']
      end

      if attributes.key?(:'epp_minimum_eligible_amount')
        self.epp_minimum_eligible_amount = attributes[:'epp_minimum_eligible_amount']
      end

      if attributes.key?(:'epp_minimum_installment_amount')
        self.epp_minimum_installment_amount = attributes[:'epp_minimum_installment_amount']
      end

      if attributes.key?(:'credit_card_statement')
        if (value = attributes[:'credit_card_statement']).is_a?(Array)
          self.credit_card_statement = value
        end
      end

      if attributes.key?(:'statement_summary_error_details')
        self.statement_summary_error_details = attributes[:'statement_summary_error_details']
      end

      if attributes.key?(:'next_start_index')
        self.next_start_index = attributes[:'next_start_index']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      if @card_id.nil?
        invalid_properties.push('invalid value for "card_id", card_id cannot be nil.')
      end

      if @display_account_number.nil?
        invalid_properties.push('invalid value for "display_account_number", display_account_number cannot be nil.')
      end

      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      return false if @card_id.nil?
      return false if @display_account_number.nil?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          card_id == o.card_id &&
          display_account_number == o.display_account_number &&
          eligible_source_accts_for_payment_flag == o.eligible_source_accts_for_payment_flag &&
          epp_eligible_amount == o.epp_eligible_amount &&
          epp_minimum_eligible_amount == o.epp_minimum_eligible_amount &&
          epp_minimum_installment_amount == o.epp_minimum_installment_amount &&
          credit_card_statement == o.credit_card_statement &&
          statement_summary_error_details == o.statement_summary_error_details &&
          next_start_index == o.next_start_index
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [card_id, display_account_number, eligible_source_accts_for_payment_flag, epp_eligible_amount, epp_minimum_eligible_amount, epp_minimum_installment_amount, credit_card_statement, statement_summary_error_details, next_start_index].hash
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
