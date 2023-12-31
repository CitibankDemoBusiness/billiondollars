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

class OverseasCardUsageRequest(object):
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
        'activation_request': 'ActivationRequest',
        'overseas_card_usage_option': 'str'
    }

    attribute_map = {
        'activation_request': 'ActivationRequest',
        'overseas_card_usage_option': 'overseasCardUsageOption'
    }

    def __init__(self, activation_request=None, overseas_card_usage_option=None):  # noqa: E501
        """OverseasCardUsageRequest - a model defined in Swagger"""  # noqa: E501
        self._activation_request = None
        self._overseas_card_usage_option = None
        self.discriminator = None
        if activation_request is not None:
            self.activation_request = activation_request
        self.overseas_card_usage_option = overseas_card_usage_option

    @property
    def activation_request(self):
        """Gets the activation_request of this OverseasCardUsageRequest.  # noqa: E501


        :return: The activation_request of this OverseasCardUsageRequest.  # noqa: E501
        :rtype: ActivationRequest
        """
        return self._activation_request

    @activation_request.setter
    def activation_request(self, activation_request):
        """Sets the activation_request of this OverseasCardUsageRequest.


        :param activation_request: The activation_request of this OverseasCardUsageRequest.  # noqa: E501
        :type: ActivationRequest
        """

        self._activation_request = activation_request

    @property
    def overseas_card_usage_option(self):
        """Gets the overseas_card_usage_option of this OverseasCardUsageRequest.  # noqa: E501

        Activation code for overseas card Usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardUsageOption} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :return: The overseas_card_usage_option of this OverseasCardUsageRequest.  # noqa: E501
        :rtype: str
        """
        return self._overseas_card_usage_option

    @overseas_card_usage_option.setter
    def overseas_card_usage_option(self, overseas_card_usage_option):
        """Sets the overseas_card_usage_option of this OverseasCardUsageRequest.

        Activation code for overseas card Usage. This is a reference data field. Please use /v1/apac/utilities/referenceData/{overseasCardUsageOption} resource to get valid value of this field with description. You can use the field name as the referenceCode parameter to retrieve the values  # noqa: E501

        :param overseas_card_usage_option: The overseas_card_usage_option of this OverseasCardUsageRequest.  # noqa: E501
        :type: str
        """
        if overseas_card_usage_option is None:
            raise ValueError("Invalid value for `overseas_card_usage_option`, must not be `None`")  # noqa: E501

        self._overseas_card_usage_option = overseas_card_usage_option

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
        if issubclass(OverseasCardUsageRequest, dict):
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
        if not isinstance(other, OverseasCardUsageRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
