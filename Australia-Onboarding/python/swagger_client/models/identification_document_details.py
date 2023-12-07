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

class IdentificationDocumentDetails(object):
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
        'id_type': 'str',
        'id_number': 'str',
        'id_expiry_date': 'date',
        'id_issue_date': 'date',
        'id_issue_place': 'str',
        'id_issuing_authority': 'str'
    }

    attribute_map = {
        'id_type': 'idType',
        'id_number': 'idNumber',
        'id_expiry_date': 'idExpiryDate',
        'id_issue_date': 'idIssueDate',
        'id_issue_place': 'idIssuePlace',
        'id_issuing_authority': 'idIssuingAuthority'
    }

    def __init__(self, id_type=None, id_number=None, id_expiry_date=None, id_issue_date=None, id_issue_place=None, id_issuing_authority=None):  # noqa: E501
        """IdentificationDocumentDetails - a model defined in Swagger"""  # noqa: E501
        self._id_type = None
        self._id_number = None
        self._id_expiry_date = None
        self._id_issue_date = None
        self._id_issue_place = None
        self._id_issuing_authority = None
        self.discriminator = None
        if id_type is not None:
            self.id_type = id_type
        if id_number is not None:
            self.id_number = id_number
        if id_expiry_date is not None:
            self.id_expiry_date = id_expiry_date
        if id_issue_date is not None:
            self.id_issue_date = id_issue_date
        if id_issue_place is not None:
            self.id_issue_place = id_issue_place
        if id_issuing_authority is not None:
            self.id_issuing_authority = id_issuing_authority

    @property
    def id_type(self):
        """Gets the id_type of this IdentificationDocumentDetails.  # noqa: E501

        Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions  # noqa: E501

        :return: The id_type of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._id_type

    @id_type.setter
    def id_type(self, id_type):
        """Sets the id_type of this IdentificationDocumentDetails.

        Type of Identification document. This is a reference data field. Please use /v1/apac/utilities/referenceData/{idType} resource to get valid values of this field with descriptions  # noqa: E501

        :param id_type: The id_type of this IdentificationDocumentDetails.  # noqa: E501
        :type: str
        """

        self._id_type = id_type

    @property
    def id_number(self):
        """Gets the id_number of this IdentificationDocumentDetails.  # noqa: E501

        Unique identifier of identification document. Ex: Passport Number  # noqa: E501

        :return: The id_number of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._id_number

    @id_number.setter
    def id_number(self, id_number):
        """Sets the id_number of this IdentificationDocumentDetails.

        Unique identifier of identification document. Ex: Passport Number  # noqa: E501

        :param id_number: The id_number of this IdentificationDocumentDetails.  # noqa: E501
        :type: str
        """

        self._id_number = id_number

    @property
    def id_expiry_date(self):
        """Gets the id_expiry_date of this IdentificationDocumentDetails.  # noqa: E501

        Expiry date of identification document. Format: ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The id_expiry_date of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: date
        """
        return self._id_expiry_date

    @id_expiry_date.setter
    def id_expiry_date(self, id_expiry_date):
        """Sets the id_expiry_date of this IdentificationDocumentDetails.

        Expiry date of identification document. Format: ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param id_expiry_date: The id_expiry_date of this IdentificationDocumentDetails.  # noqa: E501
        :type: date
        """

        self._id_expiry_date = id_expiry_date

    @property
    def id_issue_date(self):
        """Gets the id_issue_date of this IdentificationDocumentDetails.  # noqa: E501

        Issuance date of identification document. Format: ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The id_issue_date of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: date
        """
        return self._id_issue_date

    @id_issue_date.setter
    def id_issue_date(self, id_issue_date):
        """Sets the id_issue_date of this IdentificationDocumentDetails.

        Issuance date of identification document. Format: ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param id_issue_date: The id_issue_date of this IdentificationDocumentDetails.  # noqa: E501
        :type: date
        """

        self._id_issue_date = id_issue_date

    @property
    def id_issue_place(self):
        """Gets the id_issue_place of this IdentificationDocumentDetails.  # noqa: E501

        Place of issuance  # noqa: E501

        :return: The id_issue_place of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._id_issue_place

    @id_issue_place.setter
    def id_issue_place(self, id_issue_place):
        """Sets the id_issue_place of this IdentificationDocumentDetails.

        Place of issuance  # noqa: E501

        :param id_issue_place: The id_issue_place of this IdentificationDocumentDetails.  # noqa: E501
        :type: str
        """

        self._id_issue_place = id_issue_place

    @property
    def id_issuing_authority(self):
        """Gets the id_issuing_authority of this IdentificationDocumentDetails.  # noqa: E501

        Authority which issued the identification document  # noqa: E501

        :return: The id_issuing_authority of this IdentificationDocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._id_issuing_authority

    @id_issuing_authority.setter
    def id_issuing_authority(self, id_issuing_authority):
        """Sets the id_issuing_authority of this IdentificationDocumentDetails.

        Authority which issued the identification document  # noqa: E501

        :param id_issuing_authority: The id_issuing_authority of this IdentificationDocumentDetails.  # noqa: E501
        :type: str
        """

        self._id_issuing_authority = id_issuing_authority

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
        if issubclass(IdentificationDocumentDetails, dict):
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
        if not isinstance(other, IdentificationDocumentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
