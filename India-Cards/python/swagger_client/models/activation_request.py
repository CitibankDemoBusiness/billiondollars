# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class ActivationRequest(object):
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
        'overseas_card_activation_end_date': 'date',
        'overseas_card_activation_start_date': 'date',
        'perpetual_activation_indicator': 'str'
    }

    attribute_map = {
        'overseas_card_activation_end_date': 'overseasCardActivationEndDate',
        'overseas_card_activation_start_date': 'overseasCardActivationStartDate',
        'perpetual_activation_indicator': 'perpetualActivationIndicator'
    }

    def __init__(self, overseas_card_activation_end_date=None, overseas_card_activation_start_date=None, perpetual_activation_indicator=None):  # noqa: E501
        """ActivationRequest - a model defined in Swagger"""  # noqa: E501
        self._overseas_card_activation_end_date = None
        self._overseas_card_activation_start_date = None
        self._perpetual_activation_indicator = None
        self.discriminator = None
        if overseas_card_activation_end_date is not None:
            self.overseas_card_activation_end_date = overseas_card_activation_end_date
        if overseas_card_activation_start_date is not None:
            self.overseas_card_activation_start_date = overseas_card_activation_start_date
        if perpetual_activation_indicator is not None:
            self.perpetual_activation_indicator = perpetual_activation_indicator

    @property
    def overseas_card_activation_end_date(self):
        """Gets the overseas_card_activation_end_date of this ActivationRequest.  # noqa: E501

        Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, no value to be sent.  # noqa: E501

        :return: The overseas_card_activation_end_date of this ActivationRequest.  # noqa: E501
        :rtype: date
        """
        return self._overseas_card_activation_end_date

    @overseas_card_activation_end_date.setter
    def overseas_card_activation_end_date(self, overseas_card_activation_end_date):
        """Sets the overseas_card_activation_end_date of this ActivationRequest.

        Card activation end date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, no value to be sent.  # noqa: E501

        :param overseas_card_activation_end_date: The overseas_card_activation_end_date of this ActivationRequest.  # noqa: E501
        :type: date
        """

        self._overseas_card_activation_end_date = overseas_card_activation_end_date

    @property
    def overseas_card_activation_start_date(self):
        """Gets the overseas_card_activation_start_date of this ActivationRequest.  # noqa: E501

        Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, no value to be sent.  # noqa: E501

        :return: The overseas_card_activation_start_date of this ActivationRequest.  # noqa: E501
        :rtype: date
        """
        return self._overseas_card_activation_start_date

    @overseas_card_activation_start_date.setter
    def overseas_card_activation_start_date(self, overseas_card_activation_start_date):
        """Sets the overseas_card_activation_start_date of this ActivationRequest.

        Card activation start date in ISO 8601 date format YYYY-MM-DD for overseas usage. For perpetual activation, no value to be sent.  # noqa: E501

        :param overseas_card_activation_start_date: The overseas_card_activation_start_date of this ActivationRequest.  # noqa: E501
        :type: date
        """

        self._overseas_card_activation_start_date = overseas_card_activation_start_date

    @property
    def perpetual_activation_indicator(self):
        """Gets the perpetual_activation_indicator of this ActivationRequest.  # noqa: E501

        Indicator to specify whether the card to be activated perpetually  # noqa: E501

        :return: The perpetual_activation_indicator of this ActivationRequest.  # noqa: E501
        :rtype: str
        """
        return self._perpetual_activation_indicator

    @perpetual_activation_indicator.setter
    def perpetual_activation_indicator(self, perpetual_activation_indicator):
        """Sets the perpetual_activation_indicator of this ActivationRequest.

        Indicator to specify whether the card to be activated perpetually  # noqa: E501

        :param perpetual_activation_indicator: The perpetual_activation_indicator of this ActivationRequest.  # noqa: E501
        :type: str
        """

        self._perpetual_activation_indicator = perpetual_activation_indicator

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
        if issubclass(ActivationRequest, dict):
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
        if not isinstance(other, ActivationRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other