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

class CountrySpecificGroup(object):
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
        'bumiputra_indicator': 'bool',
        'ethnic_group': 'str',
        'disability_indicator': 'bool',
        'union_pay_card_number': 'str',
        'tax_file_number': 'str'
    }

    attribute_map = {
        'bumiputra_indicator': 'bumiputraIndicator',
        'ethnic_group': 'ethnicGroup',
        'disability_indicator': 'disabilityIndicator',
        'union_pay_card_number': 'unionPayCardNumber',
        'tax_file_number': 'taxFileNumber'
    }

    def __init__(self, bumiputra_indicator=None, ethnic_group=None, disability_indicator=None, union_pay_card_number=None, tax_file_number=None):  # noqa: E501
        """CountrySpecificGroup - a model defined in Swagger"""  # noqa: E501
        self._bumiputra_indicator = None
        self._ethnic_group = None
        self._disability_indicator = None
        self._union_pay_card_number = None
        self._tax_file_number = None
        self.discriminator = None
        if bumiputra_indicator is not None:
            self.bumiputra_indicator = bumiputra_indicator
        if ethnic_group is not None:
            self.ethnic_group = ethnic_group
        if disability_indicator is not None:
            self.disability_indicator = disability_indicator
        if union_pay_card_number is not None:
            self.union_pay_card_number = union_pay_card_number
        if tax_file_number is not None:
            self.tax_file_number = tax_file_number

    @property
    def bumiputra_indicator(self):
        """Gets the bumiputra_indicator of this CountrySpecificGroup.  # noqa: E501

        Bumiputra indicator (whether the person is from Malay ethnic group/son of soil). Valid values: true and false  # noqa: E501

        :return: The bumiputra_indicator of this CountrySpecificGroup.  # noqa: E501
        :rtype: bool
        """
        return self._bumiputra_indicator

    @bumiputra_indicator.setter
    def bumiputra_indicator(self, bumiputra_indicator):
        """Sets the bumiputra_indicator of this CountrySpecificGroup.

        Bumiputra indicator (whether the person is from Malay ethnic group/son of soil). Valid values: true and false  # noqa: E501

        :param bumiputra_indicator: The bumiputra_indicator of this CountrySpecificGroup.  # noqa: E501
        :type: bool
        """

        self._bumiputra_indicator = bumiputra_indicator

    @property
    def ethnic_group(self):
        """Gets the ethnic_group of this CountrySpecificGroup.  # noqa: E501

        Ethnic group.  # noqa: E501

        :return: The ethnic_group of this CountrySpecificGroup.  # noqa: E501
        :rtype: str
        """
        return self._ethnic_group

    @ethnic_group.setter
    def ethnic_group(self, ethnic_group):
        """Sets the ethnic_group of this CountrySpecificGroup.

        Ethnic group.  # noqa: E501

        :param ethnic_group: The ethnic_group of this CountrySpecificGroup.  # noqa: E501
        :type: str
        """

        self._ethnic_group = ethnic_group

    @property
    def disability_indicator(self):
        """Gets the disability_indicator of this CountrySpecificGroup.  # noqa: E501

        Applicable for some countries. The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false  # noqa: E501

        :return: The disability_indicator of this CountrySpecificGroup.  # noqa: E501
        :rtype: bool
        """
        return self._disability_indicator

    @disability_indicator.setter
    def disability_indicator(self, disability_indicator):
        """Sets the disability_indicator of this CountrySpecificGroup.

        Applicable for some countries. The instruments issued to applicants are provided with special needs like brailed characters on statements. Valid values: true and false  # noqa: E501

        :param disability_indicator: The disability_indicator of this CountrySpecificGroup.  # noqa: E501
        :type: bool
        """

        self._disability_indicator = disability_indicator

    @property
    def union_pay_card_number(self):
        """Gets the union_pay_card_number of this CountrySpecificGroup.  # noqa: E501

        Country: CN Specific to get the UnionPayCardNumber to link the product  # noqa: E501

        :return: The union_pay_card_number of this CountrySpecificGroup.  # noqa: E501
        :rtype: str
        """
        return self._union_pay_card_number

    @union_pay_card_number.setter
    def union_pay_card_number(self, union_pay_card_number):
        """Sets the union_pay_card_number of this CountrySpecificGroup.

        Country: CN Specific to get the UnionPayCardNumber to link the product  # noqa: E501

        :param union_pay_card_number: The union_pay_card_number of this CountrySpecificGroup.  # noqa: E501
        :type: str
        """

        self._union_pay_card_number = union_pay_card_number

    @property
    def tax_file_number(self):
        """Gets the tax_file_number of this CountrySpecificGroup.  # noqa: E501

        Country: AU Specific TaxFileNumber  # noqa: E501

        :return: The tax_file_number of this CountrySpecificGroup.  # noqa: E501
        :rtype: str
        """
        return self._tax_file_number

    @tax_file_number.setter
    def tax_file_number(self, tax_file_number):
        """Sets the tax_file_number of this CountrySpecificGroup.

        Country: AU Specific TaxFileNumber  # noqa: E501

        :param tax_file_number: The tax_file_number of this CountrySpecificGroup.  # noqa: E501
        :type: str
        """

        self._tax_file_number = tax_file_number

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
        if issubclass(CountrySpecificGroup, dict):
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
        if not isinstance(other, CountrySpecificGroup):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
