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

class InsertDocumentResponse(object):
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
        'binary_data_size': 'str'
    }

    attribute_map = {
        'binary_data_size': 'binaryDataSize'
    }

    def __init__(self, binary_data_size=None):  # noqa: E501
        """InsertDocumentResponse - a model defined in Swagger"""  # noqa: E501
        self._binary_data_size = None
        self.discriminator = None
        self.binary_data_size = binary_data_size

    @property
    def binary_data_size(self):
        """Gets the binary_data_size of this InsertDocumentResponse.  # noqa: E501

        Binary stream size of the document.  # noqa: E501

        :return: The binary_data_size of this InsertDocumentResponse.  # noqa: E501
        :rtype: str
        """
        return self._binary_data_size

    @binary_data_size.setter
    def binary_data_size(self, binary_data_size):
        """Sets the binary_data_size of this InsertDocumentResponse.

        Binary stream size of the document.  # noqa: E501

        :param binary_data_size: The binary_data_size of this InsertDocumentResponse.  # noqa: E501
        :type: str
        """
        if binary_data_size is None:
            raise ValueError("Invalid value for `binary_data_size`, must not be `None`")  # noqa: E501

        self._binary_data_size = binary_data_size

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
        if issubclass(InsertDocumentResponse, dict):
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
        if not isinstance(other, InsertDocumentResponse):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
