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

class ApplicantInquiryName(object):
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
        'salutation': 'str',
        'given_name': 'str',
        'middle_name': 'str',
        'surname': 'str',
        'alias_name': 'str'
    }

    attribute_map = {
        'salutation': 'salutation',
        'given_name': 'givenName',
        'middle_name': 'middleName',
        'surname': 'surname',
        'alias_name': 'aliasName'
    }

    def __init__(self, salutation=None, given_name=None, middle_name=None, surname=None, alias_name=None):  # noqa: E501
        """ApplicantInquiryName - a model defined in Swagger"""  # noqa: E501
        self._salutation = None
        self._given_name = None
        self._middle_name = None
        self._surname = None
        self._alias_name = None
        self.discriminator = None
        if salutation is not None:
            self.salutation = salutation
        self.given_name = given_name
        if middle_name is not None:
            self.middle_name = middle_name
        if surname is not None:
            self.surname = surname
        if alias_name is not None:
            self.alias_name = alias_name

    @property
    def salutation(self):
        """Gets the salutation of this ApplicantInquiryName.  # noqa: E501

        Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The salutation of this ApplicantInquiryName.  # noqa: E501
        :rtype: str
        """
        return self._salutation

    @salutation.setter
    def salutation(self, salutation):
        """Sets the salutation of this ApplicantInquiryName.

        Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param salutation: The salutation of this ApplicantInquiryName.  # noqa: E501
        :type: str
        """

        self._salutation = salutation

    @property
    def given_name(self):
        """Gets the given_name of this ApplicantInquiryName.  # noqa: E501

        Given/first name of the applicant  # noqa: E501

        :return: The given_name of this ApplicantInquiryName.  # noqa: E501
        :rtype: str
        """
        return self._given_name

    @given_name.setter
    def given_name(self, given_name):
        """Sets the given_name of this ApplicantInquiryName.

        Given/first name of the applicant  # noqa: E501

        :param given_name: The given_name of this ApplicantInquiryName.  # noqa: E501
        :type: str
        """
        if given_name is None:
            raise ValueError("Invalid value for `given_name`, must not be `None`")  # noqa: E501

        self._given_name = given_name

    @property
    def middle_name(self):
        """Gets the middle_name of this ApplicantInquiryName.  # noqa: E501

        Middle name of the applicant  # noqa: E501

        :return: The middle_name of this ApplicantInquiryName.  # noqa: E501
        :rtype: str
        """
        return self._middle_name

    @middle_name.setter
    def middle_name(self, middle_name):
        """Sets the middle_name of this ApplicantInquiryName.

        Middle name of the applicant  # noqa: E501

        :param middle_name: The middle_name of this ApplicantInquiryName.  # noqa: E501
        :type: str
        """

        self._middle_name = middle_name

    @property
    def surname(self):
        """Gets the surname of this ApplicantInquiryName.  # noqa: E501

        Surname/last name of the applicant  # noqa: E501

        :return: The surname of this ApplicantInquiryName.  # noqa: E501
        :rtype: str
        """
        return self._surname

    @surname.setter
    def surname(self, surname):
        """Sets the surname of this ApplicantInquiryName.

        Surname/last name of the applicant  # noqa: E501

        :param surname: The surname of this ApplicantInquiryName.  # noqa: E501
        :type: str
        """

        self._surname = surname

    @property
    def alias_name(self):
        """Gets the alias_name of this ApplicantInquiryName.  # noqa: E501

        Alias name of the applicant  # noqa: E501

        :return: The alias_name of this ApplicantInquiryName.  # noqa: E501
        :rtype: str
        """
        return self._alias_name

    @alias_name.setter
    def alias_name(self, alias_name):
        """Sets the alias_name of this ApplicantInquiryName.

        Alias name of the applicant  # noqa: E501

        :param alias_name: The alias_name of this ApplicantInquiryName.  # noqa: E501
        :type: str
        """

        self._alias_name = alias_name

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
        if issubclass(ApplicantInquiryName, dict):
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
        if not isinstance(other, ApplicantInquiryName):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other