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

class ECMConsentDetails(object):
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
        'consent_type': 'str',
        'consent_given_flag': 'bool'
    }

    attribute_map = {
        'consent_type': 'consentType',
        'consent_given_flag': 'consentGivenFlag'
    }

    def __init__(self, consent_type=None, consent_given_flag=None):  # noqa: E501
        """ECMConsentDetails - a model defined in Swagger"""  # noqa: E501
        self._consent_type = None
        self._consent_given_flag = None
        self.discriminator = None
        if consent_type is not None:
            self.consent_type = consent_type
        if consent_given_flag is not None:
            self.consent_given_flag = consent_given_flag

    @property
    def consent_type(self):
        """Gets the consent_type of this ECMConsentDetails.  # noqa: E501

        Applicants consent types. This is a reference data field. Please use /v1/utilities/referenceData/{consentType} resource to get valid value of this field with description.  # noqa: E501

        :return: The consent_type of this ECMConsentDetails.  # noqa: E501
        :rtype: str
        """
        return self._consent_type

    @consent_type.setter
    def consent_type(self, consent_type):
        """Sets the consent_type of this ECMConsentDetails.

        Applicants consent types. This is a reference data field. Please use /v1/utilities/referenceData/{consentType} resource to get valid value of this field with description.  # noqa: E501

        :param consent_type: The consent_type of this ECMConsentDetails.  # noqa: E501
        :type: str
        """

        self._consent_type = consent_type

    @property
    def consent_given_flag(self):
        """Gets the consent_given_flag of this ECMConsentDetails.  # noqa: E501

        Consent flag. Valid values: true and false  # noqa: E501

        :return: The consent_given_flag of this ECMConsentDetails.  # noqa: E501
        :rtype: bool
        """
        return self._consent_given_flag

    @consent_given_flag.setter
    def consent_given_flag(self, consent_given_flag):
        """Sets the consent_given_flag of this ECMConsentDetails.

        Consent flag. Valid values: true and false  # noqa: E501

        :param consent_given_flag: The consent_given_flag of this ECMConsentDetails.  # noqa: E501
        :type: bool
        """

        self._consent_given_flag = consent_given_flag

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
        if issubclass(ECMConsentDetails, dict):
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
        if not isinstance(other, ECMConsentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
