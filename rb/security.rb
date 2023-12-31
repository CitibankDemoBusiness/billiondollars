=begin
#Accounts

#The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class Security
    # The security name
    attr_accessor :security_name

    # Unique code associated with security.
    attr_accessor :stock_code

    # Trading market code for securities.
    attr_accessor :stock_market_code

    # The current market worth of investment
    attr_accessor :market_value_amount

    # The investment amount
    attr_accessor :investment_amount

    # The currency code of the account in ISO 4217 format
    attr_accessor :currency_code

    # Average unit cost
    attr_accessor :average_unit_cost

    # The maturity date in ISO 8601 format YYYY-MM-DD
    attr_accessor :maturity_date

    # The available units
    attr_accessor :available_units

    # The settled units
    attr_accessor :settled_units

    # The assigned units
    attr_accessor :assigned_units

    # The confirmed units
    attr_accessor :confirmed_units

    # The pending units
    attr_accessor :pending_units

    # The blocked units
    attr_accessor :block_units

    # The unrealized gain
    attr_accessor :unrealized_gains

    # The unrealized gain in percentage
    attr_accessor :unrealized_percentage_gain

    # The latest price
    attr_accessor :latest_price

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'security_name' => :'securityName',
        :'stock_code' => :'stockCode',
        :'stock_market_code' => :'stockMarketCode',
        :'market_value_amount' => :'marketValueAmount',
        :'investment_amount' => :'investmentAmount',
        :'currency_code' => :'currencyCode',
        :'average_unit_cost' => :'averageUnitCost',
        :'maturity_date' => :'maturityDate',
        :'available_units' => :'availableUnits',
        :'settled_units' => :'settledUnits',
        :'assigned_units' => :'assignedUnits',
        :'confirmed_units' => :'confirmedUnits',
        :'pending_units' => :'pendingUnits',
        :'block_units' => :'blockUnits',
        :'unrealized_gains' => :'unrealizedGains',
        :'unrealized_percentage_gain' => :'unrealizedPercentageGain',
        :'latest_price' => :'latestPrice'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'security_name' => :'Object',
        :'stock_code' => :'Object',
        :'stock_market_code' => :'Object',
        :'market_value_amount' => :'Object',
        :'investment_amount' => :'Object',
        :'currency_code' => :'Object',
        :'average_unit_cost' => :'Object',
        :'maturity_date' => :'Object',
        :'available_units' => :'Object',
        :'settled_units' => :'Object',
        :'assigned_units' => :'Object',
        :'confirmed_units' => :'Object',
        :'pending_units' => :'Object',
        :'block_units' => :'Object',
        :'unrealized_gains' => :'Object',
        :'unrealized_percentage_gain' => :'Object',
        :'latest_price' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::Security` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::Security`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'security_name')
        self.security_name = attributes[:'security_name']
      end

      if attributes.key?(:'stock_code')
        self.stock_code = attributes[:'stock_code']
      end

      if attributes.key?(:'stock_market_code')
        self.stock_market_code = attributes[:'stock_market_code']
      end

      if attributes.key?(:'market_value_amount')
        self.market_value_amount = attributes[:'market_value_amount']
      end

      if attributes.key?(:'investment_amount')
        self.investment_amount = attributes[:'investment_amount']
      end

      if attributes.key?(:'currency_code')
        self.currency_code = attributes[:'currency_code']
      end

      if attributes.key?(:'average_unit_cost')
        self.average_unit_cost = attributes[:'average_unit_cost']
      end

      if attributes.key?(:'maturity_date')
        self.maturity_date = attributes[:'maturity_date']
      end

      if attributes.key?(:'available_units')
        self.available_units = attributes[:'available_units']
      end

      if attributes.key?(:'settled_units')
        self.settled_units = attributes[:'settled_units']
      end

      if attributes.key?(:'assigned_units')
        self.assigned_units = attributes[:'assigned_units']
      end

      if attributes.key?(:'confirmed_units')
        self.confirmed_units = attributes[:'confirmed_units']
      end

      if attributes.key?(:'pending_units')
        self.pending_units = attributes[:'pending_units']
      end

      if attributes.key?(:'block_units')
        self.block_units = attributes[:'block_units']
      end

      if attributes.key?(:'unrealized_gains')
        self.unrealized_gains = attributes[:'unrealized_gains']
      end

      if attributes.key?(:'unrealized_percentage_gain')
        self.unrealized_percentage_gain = attributes[:'unrealized_percentage_gain']
      end

      if attributes.key?(:'latest_price')
        self.latest_price = attributes[:'latest_price']
      end
    end

    # Show invalid properties with the reasons. Usually used together with valid?
    # @return Array for valid properties with the reasons
    def list_invalid_properties
      invalid_properties = Array.new
      invalid_properties
    end

    # Check to see if the all the properties in the model are valid
    # @return true if the model is valid
    def valid?
      true
    end

    # Checks equality by comparing each attribute.
    # @param [Object] Object to be compared
    def ==(o)
      return true if self.equal?(o)
      self.class == o.class &&
          security_name == o.security_name &&
          stock_code == o.stock_code &&
          stock_market_code == o.stock_market_code &&
          market_value_amount == o.market_value_amount &&
          investment_amount == o.investment_amount &&
          currency_code == o.currency_code &&
          average_unit_cost == o.average_unit_cost &&
          maturity_date == o.maturity_date &&
          available_units == o.available_units &&
          settled_units == o.settled_units &&
          assigned_units == o.assigned_units &&
          confirmed_units == o.confirmed_units &&
          pending_units == o.pending_units &&
          block_units == o.block_units &&
          unrealized_gains == o.unrealized_gains &&
          unrealized_percentage_gain == o.unrealized_percentage_gain &&
          latest_price == o.latest_price
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [security_name, stock_code, stock_market_code, market_value_amount, investment_amount, currency_code, average_unit_cost, maturity_date, available_units, settled_units, assigned_units, confirmed_units, pending_units, block_units, unrealized_gains, unrealized_percentage_gain, latest_price].hash
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
