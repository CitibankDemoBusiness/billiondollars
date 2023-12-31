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

class ECMNameUpdate(object):
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
        'local_english_given_name': 'str',
        'local_english_surname': 'str'
    }

    attribute_map = {
        'local_english_given_name': 'localEnglishGivenName',
        'local_english_surname': 'localEnglishSurname'
    }

    def __init__(self, local_english_given_name=None, local_english_surname=None):  # noqa: E501
        """ECMNameUpdate - a model defined in Swagger"""  # noqa: E501
        self._local_english_given_name = None
        self._local_english_surname = None
        self.discriminator = None
        if local_english_given_name is not None:
            self.local_english_given_name = local_english_given_name
        if local_english_surname is not None:
            self.local_english_surname = local_english_surname

    @property
    def local_english_given_name(self):
        """Gets the local_english_given_name of this ECMNameUpdate.  # noqa: E501

        Local given name in English  # noqa: E501

        :return: The local_english_given_name of this ECMNameUpdate.  # noqa: E501
        :rtype: str
        """
        return self._local_english_given_name

    @local_english_given_name.setter
    def local_english_given_name(self, local_english_given_name):
        """Sets the local_english_given_name of this ECMNameUpdate.

        Local given name in English  # noqa: E501

        :param local_english_given_name: The local_english_given_name of this ECMNameUpdate.  # noqa: E501
        :type: str
        """

        self._local_english_given_name = local_english_given_name

    @property
    def local_english_surname(self):
        """Gets the local_english_surname of this ECMNameUpdate.  # noqa: E501

        Local surname in English  # noqa: E501

        :return: The local_english_surname of this ECMNameUpdate.  # noqa: E501
        :rtype: str
        """
        return self._local_english_surname

    @local_english_surname.setter
    def local_english_surname(self, local_english_surname):
        """Sets the local_english_surname of this ECMNameUpdate.

        Local surname in English  # noqa: E501

        :param local_english_surname: The local_english_surname of this ECMNameUpdate.  # noqa: E501
        :type: str
        """

        self._local_english_surname = local_english_surname

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
        if issubclass(ECMNameUpdate, dict):
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
        if not isinstance(other, ECMNameUpdate):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
