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

class ApplicationAddName(object):
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
        'local_english_given_name': 'str',
        'local_english_surname': 'str',
        'alias_name': 'str',
        'full_name': 'str',
        'salute_by': 'str'
    }

    attribute_map = {
        'salutation': 'salutation',
        'given_name': 'givenName',
        'middle_name': 'middleName',
        'surname': 'surname',
        'local_english_given_name': 'localEnglishGivenName',
        'local_english_surname': 'localEnglishSurname',
        'alias_name': 'aliasName',
        'full_name': 'fullName',
        'salute_by': 'saluteBy'
    }

    def __init__(self, salutation=None, given_name=None, middle_name=None, surname=None, local_english_given_name=None, local_english_surname=None, alias_name=None, full_name=None, salute_by=None):  # noqa: E501
        """ApplicationAddName - a model defined in Swagger"""  # noqa: E501
        self._salutation = None
        self._given_name = None
        self._middle_name = None
        self._surname = None
        self._local_english_given_name = None
        self._local_english_surname = None
        self._alias_name = None
        self._full_name = None
        self._salute_by = None
        self.discriminator = None
        if salutation is not None:
            self.salutation = salutation
        self.given_name = given_name
        if middle_name is not None:
            self.middle_name = middle_name
        if surname is not None:
            self.surname = surname
        if local_english_given_name is not None:
            self.local_english_given_name = local_english_given_name
        if local_english_surname is not None:
            self.local_english_surname = local_english_surname
        if alias_name is not None:
            self.alias_name = alias_name
        if full_name is not None:
            self.full_name = full_name
        if salute_by is not None:
            self.salute_by = salute_by

    @property
    def salutation(self):
        """Gets the salutation of this ApplicationAddName.  # noqa: E501

        Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The salutation of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._salutation

    @salutation.setter
    def salutation(self, salutation):
        """Sets the salutation of this ApplicationAddName.

        Salutation. This is a reference data field. Please use /v1/apac/utilities/referenceData/{salutation} resource to get valid value of this field with description. You can use salutation field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param salutation: The salutation of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._salutation = salutation

    @property
    def given_name(self):
        """Gets the given_name of this ApplicationAddName.  # noqa: E501

        Given/first name of the applicant  # noqa: E501

        :return: The given_name of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._given_name

    @given_name.setter
    def given_name(self, given_name):
        """Sets the given_name of this ApplicationAddName.

        Given/first name of the applicant  # noqa: E501

        :param given_name: The given_name of this ApplicationAddName.  # noqa: E501
        :type: str
        """
        if given_name is None:
            raise ValueError("Invalid value for `given_name`, must not be `None`")  # noqa: E501

        self._given_name = given_name

    @property
    def middle_name(self):
        """Gets the middle_name of this ApplicationAddName.  # noqa: E501

        Middle name of the applicant  # noqa: E501

        :return: The middle_name of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._middle_name

    @middle_name.setter
    def middle_name(self, middle_name):
        """Sets the middle_name of this ApplicationAddName.

        Middle name of the applicant  # noqa: E501

        :param middle_name: The middle_name of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._middle_name = middle_name

    @property
    def surname(self):
        """Gets the surname of this ApplicationAddName.  # noqa: E501

        Surname/last name of the applicant  # noqa: E501

        :return: The surname of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._surname

    @surname.setter
    def surname(self, surname):
        """Sets the surname of this ApplicationAddName.

        Surname/last name of the applicant  # noqa: E501

        :param surname: The surname of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._surname = surname

    @property
    def local_english_given_name(self):
        """Gets the local_english_given_name of this ApplicationAddName.  # noqa: E501

        Local given name in English  # noqa: E501

        :return: The local_english_given_name of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._local_english_given_name

    @local_english_given_name.setter
    def local_english_given_name(self, local_english_given_name):
        """Sets the local_english_given_name of this ApplicationAddName.

        Local given name in English  # noqa: E501

        :param local_english_given_name: The local_english_given_name of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._local_english_given_name = local_english_given_name

    @property
    def local_english_surname(self):
        """Gets the local_english_surname of this ApplicationAddName.  # noqa: E501

        Local surname in English  # noqa: E501

        :return: The local_english_surname of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._local_english_surname

    @local_english_surname.setter
    def local_english_surname(self, local_english_surname):
        """Sets the local_english_surname of this ApplicationAddName.

        Local surname in English  # noqa: E501

        :param local_english_surname: The local_english_surname of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._local_english_surname = local_english_surname

    @property
    def alias_name(self):
        """Gets the alias_name of this ApplicationAddName.  # noqa: E501

        Alias name of the applicant  # noqa: E501

        :return: The alias_name of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._alias_name

    @alias_name.setter
    def alias_name(self, alias_name):
        """Sets the alias_name of this ApplicationAddName.

        Alias name of the applicant  # noqa: E501

        :param alias_name: The alias_name of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._alias_name = alias_name

    @property
    def full_name(self):
        """Gets the full_name of this ApplicationAddName.  # noqa: E501

        Full name of the applicant.  # noqa: E501

        :return: The full_name of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._full_name

    @full_name.setter
    def full_name(self, full_name):
        """Sets the full_name of this ApplicationAddName.

        Full name of the applicant.  # noqa: E501

        :param full_name: The full_name of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._full_name = full_name

    @property
    def salute_by(self):
        """Gets the salute_by of this ApplicationAddName.  # noqa: E501

        Contains value with which applicant like to be addressed. This is a reference data field. Please use /v1/apac/utilities/referenceData/{saluteBy} resource to get valid value of this field with description. You can use saluteBy field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The salute_by of this ApplicationAddName.  # noqa: E501
        :rtype: str
        """
        return self._salute_by

    @salute_by.setter
    def salute_by(self, salute_by):
        """Sets the salute_by of this ApplicationAddName.

        Contains value with which applicant like to be addressed. This is a reference data field. Please use /v1/apac/utilities/referenceData/{saluteBy} resource to get valid value of this field with description. You can use saluteBy field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param salute_by: The salute_by of this ApplicationAddName.  # noqa: E501
        :type: str
        """

        self._salute_by = salute_by

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
        if issubclass(ApplicationAddName, dict):
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
        if not isinstance(other, ApplicationAddName):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
