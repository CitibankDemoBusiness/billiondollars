=begin
#Onboarding

#The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.

OpenAPI spec version: 1.0.0

Generated by: https://github.com/swagger-api/swagger-codegen.git
Swagger Codegen version: 3.0.29
=end

require 'date'

module SwaggerClient
  class ApplicationInquiryKycInformation
    # Flag for self declaration if applicant is public figure. Valid values: true and false
    attr_accessor :self_public_figure_declaration_flag

    # Flag for status of public office if applicant is public figure
    attr_accessor :public_figure_office_status

    # Office details if applicant is public figure
    attr_accessor :public_figure_office_details

    # Public figure office start date in ISO 8601 date format YYYY-MM-DD
    attr_accessor :public_figure_office_start_date

    # Public figure office end date in ISO 8601 date format YYYY-MM-DD
    attr_accessor :public_figure_office_end_date

    # Self declaration if applicant has any relation with senior public figure. Valid values: true and false
    attr_accessor :is_related_to_senior_public_figure

    # Senior Public Figure Name
    attr_accessor :related_senior_public_figure_name

    # Public figure designation.
    attr_accessor :related_senior_public_figure_designation

    # Senior Public Figure Country of Government
    attr_accessor :related_spf_country_of_government

    # Department Senior Public Figure belongs to
    attr_accessor :related_senior_public_figure_department

    # Senior Public Figure relationship with applicant
    attr_accessor :relationship_with_senior_public_figure

    # Senior Public Figure Last Name
    attr_accessor :related_senior_public_figure_last_name

    # US Tax status. This is a reference data field. Please use /v1/apac/utilities/referenceData/{usTaxStatus} resource to get valid value of this field with description. You can use usTaxStatus field name as the referenceCode parameter to retrieve the values.
    attr_accessor :us_tax_status

    # US Tax ID
    attr_accessor :us_tax_id

    # Attribute mapping from ruby-style variable name to JSON key.
    def self.attribute_map
      {
        :'self_public_figure_declaration_flag' => :'selfPublicFigureDeclarationFlag',
        :'public_figure_office_status' => :'publicFigureOfficeStatus',
        :'public_figure_office_details' => :'publicFigureOfficeDetails',
        :'public_figure_office_start_date' => :'publicFigureOfficeStartDate',
        :'public_figure_office_end_date' => :'publicFigureOfficeEndDate',
        :'is_related_to_senior_public_figure' => :'isRelatedToSeniorPublicFigure',
        :'related_senior_public_figure_name' => :'relatedSeniorPublicFigureName',
        :'related_senior_public_figure_designation' => :'relatedSeniorPublicFigureDesignation',
        :'related_spf_country_of_government' => :'relatedSpfCountryOfGovernment',
        :'related_senior_public_figure_department' => :'relatedSeniorPublicFigureDepartment',
        :'relationship_with_senior_public_figure' => :'relationshipWithSeniorPublicFigure',
        :'related_senior_public_figure_last_name' => :'relatedSeniorPublicFigureLastName',
        :'us_tax_status' => :'usTaxStatus',
        :'us_tax_id' => :'usTaxId'
      }
    end

    # Attribute type mapping.
    def self.openapi_types
      {
        :'self_public_figure_declaration_flag' => :'Object',
        :'public_figure_office_status' => :'Object',
        :'public_figure_office_details' => :'Object',
        :'public_figure_office_start_date' => :'Object',
        :'public_figure_office_end_date' => :'Object',
        :'is_related_to_senior_public_figure' => :'Object',
        :'related_senior_public_figure_name' => :'Object',
        :'related_senior_public_figure_designation' => :'Object',
        :'related_spf_country_of_government' => :'Object',
        :'related_senior_public_figure_department' => :'Object',
        :'relationship_with_senior_public_figure' => :'Object',
        :'related_senior_public_figure_last_name' => :'Object',
        :'us_tax_status' => :'Object',
        :'us_tax_id' => :'Object'
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
        fail ArgumentError, "The input argument (attributes) must be a hash in `SwaggerClient::ApplicationInquiryKycInformation` initialize method"
      end

      # check to see if the attribute exists and convert string to symbol for hash key
      attributes = attributes.each_with_object({}) { |(k, v), h|
        if (!self.class.attribute_map.key?(k.to_sym))
          fail ArgumentError, "`#{k}` is not a valid attribute in `SwaggerClient::ApplicationInquiryKycInformation`. Please check the name to make sure it's valid. List of attributes: " + self.class.attribute_map.keys.inspect
        end
        h[k.to_sym] = v
      }

      if attributes.key?(:'self_public_figure_declaration_flag')
        self.self_public_figure_declaration_flag = attributes[:'self_public_figure_declaration_flag']
      end

      if attributes.key?(:'public_figure_office_status')
        self.public_figure_office_status = attributes[:'public_figure_office_status']
      end

      if attributes.key?(:'public_figure_office_details')
        self.public_figure_office_details = attributes[:'public_figure_office_details']
      end

      if attributes.key?(:'public_figure_office_start_date')
        self.public_figure_office_start_date = attributes[:'public_figure_office_start_date']
      end

      if attributes.key?(:'public_figure_office_end_date')
        self.public_figure_office_end_date = attributes[:'public_figure_office_end_date']
      end

      if attributes.key?(:'is_related_to_senior_public_figure')
        self.is_related_to_senior_public_figure = attributes[:'is_related_to_senior_public_figure']
      end

      if attributes.key?(:'related_senior_public_figure_name')
        self.related_senior_public_figure_name = attributes[:'related_senior_public_figure_name']
      end

      if attributes.key?(:'related_senior_public_figure_designation')
        self.related_senior_public_figure_designation = attributes[:'related_senior_public_figure_designation']
      end

      if attributes.key?(:'related_spf_country_of_government')
        self.related_spf_country_of_government = attributes[:'related_spf_country_of_government']
      end

      if attributes.key?(:'related_senior_public_figure_department')
        self.related_senior_public_figure_department = attributes[:'related_senior_public_figure_department']
      end

      if attributes.key?(:'relationship_with_senior_public_figure')
        self.relationship_with_senior_public_figure = attributes[:'relationship_with_senior_public_figure']
      end

      if attributes.key?(:'related_senior_public_figure_last_name')
        self.related_senior_public_figure_last_name = attributes[:'related_senior_public_figure_last_name']
      end

      if attributes.key?(:'us_tax_status')
        self.us_tax_status = attributes[:'us_tax_status']
      end

      if attributes.key?(:'us_tax_id')
        self.us_tax_id = attributes[:'us_tax_id']
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
          self_public_figure_declaration_flag == o.self_public_figure_declaration_flag &&
          public_figure_office_status == o.public_figure_office_status &&
          public_figure_office_details == o.public_figure_office_details &&
          public_figure_office_start_date == o.public_figure_office_start_date &&
          public_figure_office_end_date == o.public_figure_office_end_date &&
          is_related_to_senior_public_figure == o.is_related_to_senior_public_figure &&
          related_senior_public_figure_name == o.related_senior_public_figure_name &&
          related_senior_public_figure_designation == o.related_senior_public_figure_designation &&
          related_spf_country_of_government == o.related_spf_country_of_government &&
          related_senior_public_figure_department == o.related_senior_public_figure_department &&
          relationship_with_senior_public_figure == o.relationship_with_senior_public_figure &&
          related_senior_public_figure_last_name == o.related_senior_public_figure_last_name &&
          us_tax_status == o.us_tax_status &&
          us_tax_id == o.us_tax_id
    end

    # @see the `==` method
    # @param [Object] Object to be compared
    def eql?(o)
      self == o
    end

    # Calculates hash code according to all attributes.
    # @return [Integer] Hash code
    def hash
      [self_public_figure_declaration_flag, public_figure_office_status, public_figure_office_details, public_figure_office_start_date, public_figure_office_end_date, is_related_to_senior_public_figure, related_senior_public_figure_name, related_senior_public_figure_designation, related_spf_country_of_government, related_senior_public_figure_department, relationship_with_senior_public_figure, related_senior_public_figure_last_name, us_tax_status, us_tax_id].hash
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
