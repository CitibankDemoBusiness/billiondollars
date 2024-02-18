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

class ApplicationInquirySelfDeclaration(object):
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
        'total_active_credit_card_limit_amount': 'float',
        'anticipated_income_decrease_code': 'str',
        'loan_taken_indicator': 'bool',
        'monthly_repayment_for_all_ext_loans': 'float'
    }

    attribute_map = {
        'total_active_credit_card_limit_amount': 'totalActiveCreditCardLimitAmount',
        'anticipated_income_decrease_code': 'anticipatedIncomeDecreaseCode',
        'loan_taken_indicator': 'loanTakenIndicator',
        'monthly_repayment_for_all_ext_loans': 'monthlyRepaymentForAllExtLoans'
    }

    def __init__(self, total_active_credit_card_limit_amount=None, anticipated_income_decrease_code=None, loan_taken_indicator=None, monthly_repayment_for_all_ext_loans=None):  # noqa: E501
        """ApplicationInquirySelfDeclaration - a model defined in Swagger"""  # noqa: E501
        self._total_active_credit_card_limit_amount = None
        self._anticipated_income_decrease_code = None
        self._loan_taken_indicator = None
        self._monthly_repayment_for_all_ext_loans = None
        self.discriminator = None
        if total_active_credit_card_limit_amount is not None:
            self.total_active_credit_card_limit_amount = total_active_credit_card_limit_amount
        if anticipated_income_decrease_code is not None:
            self.anticipated_income_decrease_code = anticipated_income_decrease_code
        if loan_taken_indicator is not None:
            self.loan_taken_indicator = loan_taken_indicator
        if monthly_repayment_for_all_ext_loans is not None:
            self.monthly_repayment_for_all_ext_loans = monthly_repayment_for_all_ext_loans

    @property
    def total_active_credit_card_limit_amount(self):
        """Gets the total_active_credit_card_limit_amount of this ApplicationInquirySelfDeclaration.  # noqa: E501

        Total credit limit of all the credit cards the applicant is holding  # noqa: E501

        :return: The total_active_credit_card_limit_amount of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :rtype: float
        """
        return self._total_active_credit_card_limit_amount

    @total_active_credit_card_limit_amount.setter
    def total_active_credit_card_limit_amount(self, total_active_credit_card_limit_amount):
        """Sets the total_active_credit_card_limit_amount of this ApplicationInquirySelfDeclaration.

        Total credit limit of all the credit cards the applicant is holding  # noqa: E501

        :param total_active_credit_card_limit_amount: The total_active_credit_card_limit_amount of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :type: float
        """

        self._total_active_credit_card_limit_amount = total_active_credit_card_limit_amount

    @property
    def anticipated_income_decrease_code(self):
        """Gets the anticipated_income_decrease_code of this ApplicationInquirySelfDeclaration.  # noqa: E501

        Anticipated income decrease code. Valid values: Yes and No  # noqa: E501

        :return: The anticipated_income_decrease_code of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :rtype: str
        """
        return self._anticipated_income_decrease_code

    @anticipated_income_decrease_code.setter
    def anticipated_income_decrease_code(self, anticipated_income_decrease_code):
        """Sets the anticipated_income_decrease_code of this ApplicationInquirySelfDeclaration.

        Anticipated income decrease code. Valid values: Yes and No  # noqa: E501

        :param anticipated_income_decrease_code: The anticipated_income_decrease_code of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :type: str
        """

        self._anticipated_income_decrease_code = anticipated_income_decrease_code

    @property
    def loan_taken_indicator(self):
        """Gets the loan_taken_indicator of this ApplicationInquirySelfDeclaration.  # noqa: E501

        To indicate if any loan is outstanding.Valid values: true and false  # noqa: E501

        :return: The loan_taken_indicator of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :rtype: bool
        """
        return self._loan_taken_indicator

    @loan_taken_indicator.setter
    def loan_taken_indicator(self, loan_taken_indicator):
        """Sets the loan_taken_indicator of this ApplicationInquirySelfDeclaration.

        To indicate if any loan is outstanding.Valid values: true and false  # noqa: E501

        :param loan_taken_indicator: The loan_taken_indicator of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :type: bool
        """

        self._loan_taken_indicator = loan_taken_indicator

    @property
    def monthly_repayment_for_all_ext_loans(self):
        """Gets the monthly_repayment_for_all_ext_loans of this ApplicationInquirySelfDeclaration.  # noqa: E501

        Applicants declaration for his/her total monthly repayment amount for all the external loans.  # noqa: E501

        :return: The monthly_repayment_for_all_ext_loans of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :rtype: float
        """
        return self._monthly_repayment_for_all_ext_loans

    @monthly_repayment_for_all_ext_loans.setter
    def monthly_repayment_for_all_ext_loans(self, monthly_repayment_for_all_ext_loans):
        """Sets the monthly_repayment_for_all_ext_loans of this ApplicationInquirySelfDeclaration.

        Applicants declaration for his/her total monthly repayment amount for all the external loans.  # noqa: E501

        :param monthly_repayment_for_all_ext_loans: The monthly_repayment_for_all_ext_loans of this ApplicationInquirySelfDeclaration.  # noqa: E501
        :type: float
        """

        self._monthly_repayment_for_all_ext_loans = monthly_repayment_for_all_ext_loans

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
        if issubclass(ApplicationInquirySelfDeclaration, dict):
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
        if not isinstance(other, ApplicationInquirySelfDeclaration):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other