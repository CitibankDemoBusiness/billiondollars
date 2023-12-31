# coding: utf-8

"""
    TaxStatement_Digital_Orchestation

    Account Documents APIs Version 2.0. These APIs will be used by Citi Partners to retrieve tax documents for existing Accounts from various regions. PCF Deployment Reference name --> DM-O-DocumentServices-Statements  </br>Version 2.0.0 Added new Tax statements apis.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class DocumentDetails(object):
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
        'statement_id': 'str',
        'statement_type': 'str',
        'statement_posting_date': 'date',
        'primary_user_indicator': 'str',
        'statement_year': 'int'
    }

    attribute_map = {
        'statement_id': 'statementId',
        'statement_type': 'statementType',
        'statement_posting_date': 'statementPostingDate',
        'primary_user_indicator': 'primaryUserIndicator',
        'statement_year': 'statementYear'
    }

    def __init__(self, statement_id=None, statement_type=None, statement_posting_date=None, primary_user_indicator=None, statement_year=None):  # noqa: E501
        """DocumentDetails - a model defined in Swagger"""  # noqa: E501
        self._statement_id = None
        self._statement_type = None
        self._statement_posting_date = None
        self._primary_user_indicator = None
        self._statement_year = None
        self.discriminator = None
        if statement_id is not None:
            self.statement_id = statement_id
        if statement_type is not None:
            self.statement_type = statement_type
        if statement_posting_date is not None:
            self.statement_posting_date = statement_posting_date
        if primary_user_indicator is not None:
            self.primary_user_indicator = primary_user_indicator
        if statement_year is not None:
            self.statement_year = statement_year

    @property
    def statement_id(self):
        """Gets the statement_id of this DocumentDetails.  # noqa: E501

        Unique identifier for the tax statement document.  # noqa: E501

        :return: The statement_id of this DocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._statement_id

    @statement_id.setter
    def statement_id(self, statement_id):
        """Sets the statement_id of this DocumentDetails.

        Unique identifier for the tax statement document.  # noqa: E501

        :param statement_id: The statement_id of this DocumentDetails.  # noqa: E501
        :type: str
        """

        self._statement_id = statement_id

    @property
    def statement_type(self):
        """Gets the statement_type of this DocumentDetails.  # noqa: E501

        Type of a tax statement.  # noqa: E501

        :return: The statement_type of this DocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._statement_type

    @statement_type.setter
    def statement_type(self, statement_type):
        """Sets the statement_type of this DocumentDetails.

        Type of a tax statement.  # noqa: E501

        :param statement_type: The statement_type of this DocumentDetails.  # noqa: E501
        :type: str
        """

        self._statement_type = statement_type

    @property
    def statement_posting_date(self):
        """Gets the statement_posting_date of this DocumentDetails.  # noqa: E501

        Date on which this tax statement was generated. Format should be MM/DD/YYYY.  # noqa: E501

        :return: The statement_posting_date of this DocumentDetails.  # noqa: E501
        :rtype: date
        """
        return self._statement_posting_date

    @statement_posting_date.setter
    def statement_posting_date(self, statement_posting_date):
        """Sets the statement_posting_date of this DocumentDetails.

        Date on which this tax statement was generated. Format should be MM/DD/YYYY.  # noqa: E501

        :param statement_posting_date: The statement_posting_date of this DocumentDetails.  # noqa: E501
        :type: date
        """

        self._statement_posting_date = statement_posting_date

    @property
    def primary_user_indicator(self):
        """Gets the primary_user_indicator of this DocumentDetails.  # noqa: E501

        This field is used for identifier for what type of user( primary or authorized) tax statement is being generated.  # noqa: E501

        :return: The primary_user_indicator of this DocumentDetails.  # noqa: E501
        :rtype: str
        """
        return self._primary_user_indicator

    @primary_user_indicator.setter
    def primary_user_indicator(self, primary_user_indicator):
        """Sets the primary_user_indicator of this DocumentDetails.

        This field is used for identifier for what type of user( primary or authorized) tax statement is being generated.  # noqa: E501

        :param primary_user_indicator: The primary_user_indicator of this DocumentDetails.  # noqa: E501
        :type: str
        """

        self._primary_user_indicator = primary_user_indicator

    @property
    def statement_year(self):
        """Gets the statement_year of this DocumentDetails.  # noqa: E501

        It represents document tax year.  # noqa: E501

        :return: The statement_year of this DocumentDetails.  # noqa: E501
        :rtype: int
        """
        return self._statement_year

    @statement_year.setter
    def statement_year(self, statement_year):
        """Sets the statement_year of this DocumentDetails.

        It represents document tax year.  # noqa: E501

        :param statement_year: The statement_year of this DocumentDetails.  # noqa: E501
        :type: int
        """

        self._statement_year = statement_year

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
        if issubclass(DocumentDetails, dict):
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
        if not isinstance(other, DocumentDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
