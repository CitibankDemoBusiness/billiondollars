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

class UpdateIssuedDeviceAllocationDevicePfidResponse(object):
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
        'response_timestamp': 'str'
    }

    attribute_map = {
        'response_timestamp': 'responseTimestamp'
    }

    def __init__(self, response_timestamp=None):  # noqa: E501
        """UpdateIssuedDeviceAllocationDevicePfidResponse - a model defined in Swagger"""  # noqa: E501
        self._response_timestamp = None
        self.discriminator = None
        self.response_timestamp = response_timestamp

    @property
    def response_timestamp(self):
        """Gets the response_timestamp of this UpdateIssuedDeviceAllocationDevicePfidResponse.  # noqa: E501

        Date time in MMDDYYYYHHMMSS Format.  # noqa: E501

        :return: The response_timestamp of this UpdateIssuedDeviceAllocationDevicePfidResponse.  # noqa: E501
        :rtype: str
        """
        return self._response_timestamp

    @response_timestamp.setter
    def response_timestamp(self, response_timestamp):
        """Sets the response_timestamp of this UpdateIssuedDeviceAllocationDevicePfidResponse.

        Date time in MMDDYYYYHHMMSS Format.  # noqa: E501

        :param response_timestamp: The response_timestamp of this UpdateIssuedDeviceAllocationDevicePfidResponse.  # noqa: E501
        :type: str
        """
        if response_timestamp is None:
            raise ValueError("Invalid value for `response_timestamp`, must not be `None`")  # noqa: E501

        self._response_timestamp = response_timestamp

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
        if issubclass(UpdateIssuedDeviceAllocationDevicePfidResponse, dict):
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
        if not isinstance(other, UpdateIssuedDeviceAllocationDevicePfidResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
