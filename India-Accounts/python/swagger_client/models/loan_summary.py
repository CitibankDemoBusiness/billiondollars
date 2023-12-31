# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class LoanSummary(object):
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
        'loan_amount': 'float',
        'loan_tenure': 'str',
        'promotion_id': 'str',
        'interest_rate': 'float',
        'interest_rate_effectivity_date': 'date',
        'total_interest_amount': 'float',
        'total_loan_amount': 'float',
        'loan_remaining_term_number': 'int'
    }

    attribute_map = {
        'loan_amount': 'loanAmount',
        'loan_tenure': 'loanTenure',
        'promotion_id': 'promotionId',
        'interest_rate': 'interestRate',
        'interest_rate_effectivity_date': 'interestRateEffectivityDate',
        'total_interest_amount': 'totalInterestAmount',
        'total_loan_amount': 'totalLoanAmount',
        'loan_remaining_term_number': 'loanRemainingTermNumber'
    }

    def __init__(self, loan_amount=None, loan_tenure=None, promotion_id=None, interest_rate=None, interest_rate_effectivity_date=None, total_interest_amount=None, total_loan_amount=None, loan_remaining_term_number=None):  # noqa: E501
        """LoanSummary - a model defined in Swagger"""  # noqa: E501
        self._loan_amount = None
        self._loan_tenure = None
        self._promotion_id = None
        self._interest_rate = None
        self._interest_rate_effectivity_date = None
        self._total_interest_amount = None
        self._total_loan_amount = None
        self._loan_remaining_term_number = None
        self.discriminator = None
        if loan_amount is not None:
            self.loan_amount = loan_amount
        if loan_tenure is not None:
            self.loan_tenure = loan_tenure
        if promotion_id is not None:
            self.promotion_id = promotion_id
        if interest_rate is not None:
            self.interest_rate = interest_rate
        if interest_rate_effectivity_date is not None:
            self.interest_rate_effectivity_date = interest_rate_effectivity_date
        if total_interest_amount is not None:
            self.total_interest_amount = total_interest_amount
        if total_loan_amount is not None:
            self.total_loan_amount = total_loan_amount
        if loan_remaining_term_number is not None:
            self.loan_remaining_term_number = loan_remaining_term_number

    @property
    def loan_amount(self):
        """Gets the loan_amount of this LoanSummary.  # noqa: E501

        Loan amount availed by customer  # noqa: E501

        :return: The loan_amount of this LoanSummary.  # noqa: E501
        :rtype: float
        """
        return self._loan_amount

    @loan_amount.setter
    def loan_amount(self, loan_amount):
        """Sets the loan_amount of this LoanSummary.

        Loan amount availed by customer  # noqa: E501

        :param loan_amount: The loan_amount of this LoanSummary.  # noqa: E501
        :type: float
        """

        self._loan_amount = loan_amount

    @property
    def loan_tenure(self):
        """Gets the loan_tenure of this LoanSummary.  # noqa: E501

        Tenure of loan against card.  # noqa: E501

        :return: The loan_tenure of this LoanSummary.  # noqa: E501
        :rtype: str
        """
        return self._loan_tenure

    @loan_tenure.setter
    def loan_tenure(self, loan_tenure):
        """Sets the loan_tenure of this LoanSummary.

        Tenure of loan against card.  # noqa: E501

        :param loan_tenure: The loan_tenure of this LoanSummary.  # noqa: E501
        :type: str
        """

        self._loan_tenure = loan_tenure

    @property
    def promotion_id(self):
        """Gets the promotion_id of this LoanSummary.  # noqa: E501

        Promotion ID for the loan offered  # noqa: E501

        :return: The promotion_id of this LoanSummary.  # noqa: E501
        :rtype: str
        """
        return self._promotion_id

    @promotion_id.setter
    def promotion_id(self, promotion_id):
        """Sets the promotion_id of this LoanSummary.

        Promotion ID for the loan offered  # noqa: E501

        :param promotion_id: The promotion_id of this LoanSummary.  # noqa: E501
        :type: str
        """

        self._promotion_id = promotion_id

    @property
    def interest_rate(self):
        """Gets the interest_rate of this LoanSummary.  # noqa: E501

        Interest rate for the loan  # noqa: E501

        :return: The interest_rate of this LoanSummary.  # noqa: E501
        :rtype: float
        """
        return self._interest_rate

    @interest_rate.setter
    def interest_rate(self, interest_rate):
        """Sets the interest_rate of this LoanSummary.

        Interest rate for the loan  # noqa: E501

        :param interest_rate: The interest_rate of this LoanSummary.  # noqa: E501
        :type: float
        """

        self._interest_rate = interest_rate

    @property
    def interest_rate_effectivity_date(self):
        """Gets the interest_rate_effectivity_date of this LoanSummary.  # noqa: E501

        Effectivity date of interest rate  in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :return: The interest_rate_effectivity_date of this LoanSummary.  # noqa: E501
        :rtype: date
        """
        return self._interest_rate_effectivity_date

    @interest_rate_effectivity_date.setter
    def interest_rate_effectivity_date(self, interest_rate_effectivity_date):
        """Sets the interest_rate_effectivity_date of this LoanSummary.

        Effectivity date of interest rate  in ISO 8601 date format YYYY-MM-DD  # noqa: E501

        :param interest_rate_effectivity_date: The interest_rate_effectivity_date of this LoanSummary.  # noqa: E501
        :type: date
        """

        self._interest_rate_effectivity_date = interest_rate_effectivity_date

    @property
    def total_interest_amount(self):
        """Gets the total_interest_amount of this LoanSummary.  # noqa: E501

        Total interest amount for the loan  # noqa: E501

        :return: The total_interest_amount of this LoanSummary.  # noqa: E501
        :rtype: float
        """
        return self._total_interest_amount

    @total_interest_amount.setter
    def total_interest_amount(self, total_interest_amount):
        """Sets the total_interest_amount of this LoanSummary.

        Total interest amount for the loan  # noqa: E501

        :param total_interest_amount: The total_interest_amount of this LoanSummary.  # noqa: E501
        :type: float
        """

        self._total_interest_amount = total_interest_amount

    @property
    def total_loan_amount(self):
        """Gets the total_loan_amount of this LoanSummary.  # noqa: E501

        Total loan amount comprising of principal and interest  # noqa: E501

        :return: The total_loan_amount of this LoanSummary.  # noqa: E501
        :rtype: float
        """
        return self._total_loan_amount

    @total_loan_amount.setter
    def total_loan_amount(self, total_loan_amount):
        """Sets the total_loan_amount of this LoanSummary.

        Total loan amount comprising of principal and interest  # noqa: E501

        :param total_loan_amount: The total_loan_amount of this LoanSummary.  # noqa: E501
        :type: float
        """

        self._total_loan_amount = total_loan_amount

    @property
    def loan_remaining_term_number(self):
        """Gets the loan_remaining_term_number of this LoanSummary.  # noqa: E501

        Remaining term of installment loan  # noqa: E501

        :return: The loan_remaining_term_number of this LoanSummary.  # noqa: E501
        :rtype: int
        """
        return self._loan_remaining_term_number

    @loan_remaining_term_number.setter
    def loan_remaining_term_number(self, loan_remaining_term_number):
        """Sets the loan_remaining_term_number of this LoanSummary.

        Remaining term of installment loan  # noqa: E501

        :param loan_remaining_term_number: The loan_remaining_term_number of this LoanSummary.  # noqa: E501
        :type: int
        """

        self._loan_remaining_term_number = loan_remaining_term_number

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
        if issubclass(LoanSummary, dict):
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
        if not isinstance(other, LoanSummary):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
