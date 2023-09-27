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

class ParentInformation(object):
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
        'name': 'ParentName',
        'address': 'list[ParentAddress]',
        'phone': 'list[ParentPhone]'
    }

    attribute_map = {
        'name': 'name',
        'address': 'address',
        'phone': 'phone'
    }

    def __init__(self, name=None, address=None, phone=None):  # noqa: E501
        """ParentInformation - a model defined in Swagger"""  # noqa: E501
        self._name = None
        self._address = None
        self._phone = None
        self.discriminator = None
        if name is not None:
            self.name = name
        if address is not None:
            self.address = address
        if phone is not None:
            self.phone = phone

    @property
    def name(self):
        """Gets the name of this ParentInformation.  # noqa: E501


        :return: The name of this ParentInformation.  # noqa: E501
        :rtype: ParentName
        """
        return self._name

    @name.setter
    def name(self, name):
        """Sets the name of this ParentInformation.


        :param name: The name of this ParentInformation.  # noqa: E501
        :type: ParentName
        """

        self._name = name

    @property
    def address(self):
        """Gets the address of this ParentInformation.  # noqa: E501


        :return: The address of this ParentInformation.  # noqa: E501
        :rtype: list[ParentAddress]
        """
        return self._address

    @address.setter
    def address(self, address):
        """Sets the address of this ParentInformation.


        :param address: The address of this ParentInformation.  # noqa: E501
        :type: list[ParentAddress]
        """

        self._address = address

    @property
    def phone(self):
        """Gets the phone of this ParentInformation.  # noqa: E501


        :return: The phone of this ParentInformation.  # noqa: E501
        :rtype: list[ParentPhone]
        """
        return self._phone

    @phone.setter
    def phone(self, phone):
        """Sets the phone of this ParentInformation.


        :param phone: The phone of this ParentInformation.  # noqa: E501
        :type: list[ParentPhone]
        """

        self._phone = phone

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
        if issubclass(ParentInformation, dict):
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
        if not isinstance(other, ParentInformation):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
