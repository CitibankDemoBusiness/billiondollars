# coding: utf-8

"""
    Onboarding

    The Onboarding API allows you to initiate the basic account opening process for new customers. The resources allow you to present eligible products, send applications for screening and submit a new application for one or more products. The resources also allow you to submit supporting documents. Application status can be checked at any point in the process, with decisioning happening in real time.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class Prospect(object):
    """NOTE: This class is auto generated by the swagger code generator program.

    Do not edit the class manually.
    """
    """
    Attributes:
      swagger_types (dict): The key is attribute name
                            and the value is attribute type.
      attribute_map (dict): The key is attribute name
                            and the value is json key in definition.
    """
    swagger_types = {
        'mother_maiden_name': 'str',
        'name': 'Name',
        'demographics': 'Demographics',
        'address': 'list[Address]',
        'email': 'list[Email]',
        'phone': 'list[Phone]',
        'contact_preference': 'ContactPreference',
        'financial_information': 'FinancialInformation',
        'education': 'Education',
        'employment_details': 'list[EmploymentDetails]',
        'identification_document_details': 'list[IdentificationDocumentDetails]',
        'additional_data': 'AdditionalData',
        'self_declaration': 'SelfDeclaration',
        'kyc_information': 'KycInformation'
    }

    attribute_map = {
        'mother_maiden_name': 'motherMaidenName',
        'name': 'name',
        'demographics': 'demographics',
        'address': 'address',
        'email': 'email',
        'phone': 'phone',
        'contact_preference': 'contactPreference',
        'financial_information': 'financialInformation',
        'education': 'education',
        'employment_details': 'employmentDetails',
        'identification_document_details': 'identificationDocumentDetails',
        'additional_data': 'additionalData',
        'self_declaration': 'selfDeclaration',
        'kyc_information': 'kycInformation'
    }

    def __init__(self, mother_maiden_name=None, name=None, demographics=None, address=None, email=None, phone=None, contact_preference=None, financial_information=None, education=None, employment_details=None, identification_document_details=None, additional_data=None, self_declaration=None, kyc_information=None):  # noqa: E501
        """Prospect - a model defined in Swagger"""  # noqa: E501
        self._mother_maiden_name = None
        self._name = None
        self._demographics = None
        self._address = None
        self._email = None
        self._phone = None
        self._contact_preference = None
        self._financial_information = None
        self._education = None
        self._employment_details = None
        self._identification_document_details = None
        self._additional_data = None
        self._self_declaration = None
        self._kyc_information = None
        self.discriminator = None
        if mother_maiden_name is not None:
            self.mother_maiden_name = mother_maiden_name
        self.name = name
        if demographics is not None:
            self.demographics = demographics
        self.address = address
        self.email = email
        self.phone = phone
        self.contact_preference = contact_preference
        if financial_information is not None:
            self.financial_information = financial_information
        if education is not None:
            self.education = education
        if employment_details is not None:
            self.employment_details = employment_details
        if identification_document_details is not None:
            self.identification_document_details = identification_document_details
        if additional_data is not None:
            self.additional_data = additional_data
        if self_declaration is not None:
            self.self_declaration = self_declaration
        if kyc_information is not None:
            self.kyc_information = kyc_information

    @property
    def mother_maiden_name(self):
        """Gets the mother_maiden_name of this Prospect.  # noqa: E501

        Mother's maiden name  # noqa: E501

        :return: The mother_maiden_name of this Prospect.  # noqa: E501
        :rtype: str
        """
        return self._mother_maiden_name

    @mother_maiden_name.setter
    def mother_maiden_name(self, mother_maiden_name):
        """Sets the mother_maiden_name of this Prospect.

        Mother's maiden name  # noqa: E501

        :param mother_maiden_name: The mother_maiden_name of this Prospect.  # noqa: E501
        :type: str
        """

        self._mother_maiden_name = mother_maiden_name

    @property
    def name(self):
        """Gets the name of this Prospect.  # noqa: E501


        :return: The name of this Prospect.  # noqa: E501
        :rtype: Name
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this Prospect.


        :param name: The name of this Prospect.  # noqa: E501
        :type: Name
        """
        if name is None:
            raise ValueError("Invalid value for `name`, must not be `None`")  # noqa: E501

        self._name = name

    @property
    def demographics(self):
        """Gets the demographics of this Prospect.  # noqa: E501


        :return: The demographics of this Prospect.  # noqa: E501
        :rtype: Demographics
        """
        return self._demographics

    @demographics.setter
    def demographics(self, demographics):
        """Sets the demographics of this Prospect.


        :param demographics: The demographics of this Prospect.  # noqa: E501
        :type: Demographics
        """

        self._demographics = demographics

    @property
    def address(self):
        """Gets the address of this Prospect.  # noqa: E501


        :return: The address of this Prospect.  # noqa: E501
        :rtype: list[Address]
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this Prospect.


        :param address: The address of this Prospect.  # noqa: E501
        :type: list[Address]
        """
        if address is None:
            raise ValueError("Invalid value for `address`, must not be `None`")  # noqa: E501

        self._address = address

    @property
    def email(self):
        """Gets the email of this Prospect.  # noqa: E501


        :return: The email of this Prospect.  # noqa: E501
        :rtype: list[Email]
        """
        return self._email

    @email.setter
    def email(self, email):
        """Sets the email of this Prospect.


        :param email: The email of this Prospect.  # noqa: E501
        :type: list[Email]
        """
        if email is None:
            raise ValueError("Invalid value for `email`, must not be `None`")  # noqa: E501

        self._email = email

    @property
    def phone(self):
        """Gets the phone of this Prospect.  # noqa: E501


        :return: The phone of this Prospect.  # noqa: E501
        :rtype: list[Phone]
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """Sets the phone of this Prospect.


        :param phone: The phone of this Prospect.  # noqa: E501
        :type: list[Phone]
        """
        if phone is None:
            raise ValueError("Invalid value for `phone`, must not be `None`")  # noqa: E501

        self._phone = phone

    @property
    def contact_preference(self):
        """Gets the contact_preference of this Prospect.  # noqa: E501


        :return: The contact_preference of this Prospect.  # noqa: E501
        :rtype: ContactPreference
        """
        return self._contact_preference

    @contact_preference.setter
    def contact_preference(self, contact_preference):
        """Sets the contact_preference of this Prospect.


        :param contact_preference: The contact_preference of this Prospect.  # noqa: E501
        :type: ContactPreference
        """
        if contact_preference is None:
            raise ValueError("Invalid value for `contact_preference`, must not be `None`")  # noqa: E501

        self._contact_preference = contact_preference

    @property
    def financial_information(self):
        """Gets the financial_information of this Prospect.  # noqa: E501


        :return: The financial_information of this Prospect.  # noqa: E501
        :rtype: FinancialInformation
        """
        return self._financial_information

    @financial_information.setter
    def financial_information(self, financial_information):
        """Sets the financial_information of this Prospect.


        :param financial_information: The financial_information of this Prospect.  # noqa: E501
        :type: FinancialInformation
        """

        self._financial_information = financial_information

    @property
    def education(self):
        """Gets the education of this Prospect.  # noqa: E501


        :return: The education of this Prospect.  # noqa: E501
        :rtype: Education
        """
        return self._education

    @education.setter
    def education(self, education):
        """Sets the education of this Prospect.


        :param education: The education of this Prospect.  # noqa: E501
        :type: Education
        """

        self._education = education

    @property
    def employment_details(self):
        """Gets the employment_details of this Prospect.  # noqa: E501


        :return: The employment_details of this Prospect.  # noqa: E501
        :rtype: list[EmploymentDetails]
        """
        return self._employment_details

    @employment_details.setter
    def employment_details(self, employment_details):
        """Sets the employment_details of this Prospect.


        :param employment_details: The employment_details of this Prospect.  # noqa: E501
        :type: list[EmploymentDetails]
        """

        self._employment_details = employment_details

    @property
    def identification_document_details(self):
        """Gets the identification_document_details of this Prospect.  # noqa: E501


        :return: The identification_document_details of this Prospect.  # noqa: E501
        :rtype: list[IdentificationDocumentDetails]
        """
        return self._identification_document_details

    @identification_document_details.setter
    def identification_document_details(self, identification_document_details):
        """Sets the identification_document_details of this Prospect.


        :param identification_document_details: The identification_document_details of this Prospect.  # noqa: E501
        :type: list[IdentificationDocumentDetails]
        """

        self._identification_document_details = identification_document_details

    @property
    def additional_data(self):
        """Gets the additional_data of this Prospect.  # noqa: E501


        :return: The additional_data of this Prospect.  # noqa: E501
        :rtype: AdditionalData
        """
        return self._additional_data

    @additional_data.setter
    def additional_data(self, additional_data):
        """Sets the additional_data of this Prospect.


        :param additional_data: The additional_data of this Prospect.  # noqa: E501
        :type: AdditionalData
        """

        self._additional_data = additional_data

    @property
    def self_declaration(self):
        """Gets the self_declaration of this Prospect.  # noqa: E501


        :return: The self_declaration of this Prospect.  # noqa: E501
        :rtype: SelfDeclaration
        """
        return self._self_declaration

    @self_declaration.setter
    def self_declaration(self, self_declaration):
        """Sets the self_declaration of this Prospect.


        :param self_declaration: The self_declaration of this Prospect.  # noqa: E501
        :type: SelfDeclaration
        """

        self._self_declaration = self_declaration

    @property
    def kyc_information(self):
        """Gets the kyc_information of this Prospect.  # noqa: E501


        :return: The kyc_information of this Prospect.  # noqa: E501
        :rtype: KycInformation
        """
        return self._kyc_information

    @kyc_information.setter
    def kyc_information(self, kyc_information):
        """Sets the kyc_information of this Prospect.


        :param kyc_information: The kyc_information of this Prospect.  # noqa: E501
        :type: KycInformation
        """

        self._kyc_information = kyc_information

    def to_dict(self):
        """Returns the model properties as a dict"""
        result = {}

        for attr, _ in six.iteritems(self.swagger_types):
            value = getattr(self, attr)
            if isinstance(value, list):
                result[attr] = list(map(
                    lambda x: x.to_dict() if hasattr(x, "to_dict") else x,
                    value
                ))
            elif hasattr(value, "to_dict"):
                result[attr] = value.to_dict()
            elif isinstance(value, dict):
                result[attr] = dict(map(
                    lambda item: (item[0], item[1].to_dict())
                    if hasattr(item[1], "to_dict") else item,
                    value.items()
                ))
            else:
                result[attr] = value
        if issubclass(Prospect, dict):
            for key, value in self.items():
                result[key] = value

        return result

    def to_str(self):
        """Returns the string representation of the model"""
        return pprint.pformat(self.to_dict())

    def __repr__(self):
        """For `print` and `pprint`"""
        return self.to_str()

    def __eq__(self, other):
        """Returns true if both objects are equal"""
        if not isinstance(other, Prospect):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
