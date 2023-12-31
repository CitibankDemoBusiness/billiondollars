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

class ExternalCreditCardDetails(object):
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
        'bank_name': 'str',
        'display_card_number': 'str'
    }

    attribute_map = {
        'bank_name': 'bankName',
        'display_card_number': 'displayCardNumber'
    }

    def __init__(self, bank_name=None, display_card_number=None):  # noqa: E501
        """ExternalCreditCardDetails - a model defined in Swagger"""  # noqa: E501
        self._bank_name = None
        self._display_card_number = None
        self.discriminator = None
        if bank_name is not None:
            self.bank_name = bank_name
        if display_card_number is not None:
            self.display_card_number = display_card_number

    @property
    def bank_name(self):
        """Gets the bank_name of this ExternalCreditCardDetails.  # noqa: E501

        Name of the bank issued the credit card.  # noqa: E501

        :return: The bank_name of this ExternalCreditCardDetails.  # noqa: E501
        :rtype: str
        """
        return self._bank_name

    @bank_name.setter
    def bank_name(self, bank_name):
        """Sets the bank_name of this ExternalCreditCardDetails.

        Name of the bank issued the credit card.  # noqa: E501

        :param bank_name: The bank_name of this ExternalCreditCardDetails.  # noqa: E501
        :type: str
        """

        self._bank_name = bank_name

    @property
    def display_card_number(self):
        """Gets the display_card_number of this ExternalCreditCardDetails.  # noqa: E501

        Applicant's other Credit Card Number in masked format, to be used for bill payments  # noqa: E501

        :return: The display_card_number of this ExternalCreditCardDetails.  # noqa: E501
        :rtype: str
        """
        return self._display_card_number

    @display_card_number.setter
    def display_card_number(self, display_card_number):
        """Sets the display_card_number of this ExternalCreditCardDetails.

        Applicant's other Credit Card Number in masked format, to be used for bill payments  # noqa: E501

        :param display_card_number: The display_card_number of this ExternalCreditCardDetails.  # noqa: E501
        :type: str
        """

        self._display_card_number = display_card_number

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
        if issubclass(ExternalCreditCardDetails, dict):
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
        if not isinstance(other, ExternalCreditCardDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
