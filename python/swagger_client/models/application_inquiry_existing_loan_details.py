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

class ApplicationInquiryExistingLoanDetails(object):
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
        'loan_type': 'str',
        'monthly_installment_amount': 'float',
        'outstanding_balance_amount': 'float'
    }

    attribute_map = {
        'loan_type': 'loanType',
        'monthly_installment_amount': 'monthlyInstallmentAmount',
        'outstanding_balance_amount': 'outstandingBalanceAmount'
    }

    def __init__(self, loan_type=None, monthly_installment_amount=None, outstanding_balance_amount=None):  # noqa: E501
        """ApplicationInquiryExistingLoanDetails - a model defined in Swagger"""  # noqa: E501
        self._loan_type = None
        self._monthly_installment_amount = None
        self._outstanding_balance_amount = None
        self.discriminator = None
        if loan_type is not None:
            self.loan_type = loan_type
        if monthly_installment_amount is not None:
            self.monthly_installment_amount = monthly_installment_amount
        if outstanding_balance_amount is not None:
            self.outstanding_balance_amount = outstanding_balance_amount

    @property
    def loan_type(self):
        """Gets the loan_type of this ApplicationInquiryExistingLoanDetails.  # noqa: E501

        Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :return: The loan_type of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :rtype: str
        """
        return self._loan_type

    @loan_type.setter
    def loan_type(self, loan_type):
        """Sets the loan_type of this ApplicationInquiryExistingLoanDetails.

        Loan Type.This is a reference data field. Please use /v1/apac/utilities/referenceData/{loanType} resource to get valid value of this field with description. You can use loanType field name as the referenceCode parameter to retrieve the values.  # noqa: E501

        :param loan_type: The loan_type of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :type: str
        """

        self._loan_type = loan_type

    @property
    def monthly_installment_amount(self):
        """Gets the monthly_installment_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501

        Monthly repayment amount  # noqa: E501

        :return: The monthly_installment_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :rtype: float
        """
        return self._monthly_installment_amount

    @monthly_installment_amount.setter
    def monthly_installment_amount(self, monthly_installment_amount):
        """Sets the monthly_installment_amount of this ApplicationInquiryExistingLoanDetails.

        Monthly repayment amount  # noqa: E501

        :param monthly_installment_amount: The monthly_installment_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :type: float
        """

        self._monthly_installment_amount = monthly_installment_amount

    @property
    def outstanding_balance_amount(self):
        """Gets the outstanding_balance_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501

        Balance Owing  # noqa: E501

        :return: The outstanding_balance_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :rtype: float
        """
        return self._outstanding_balance_amount

    @outstanding_balance_amount.setter
    def outstanding_balance_amount(self, outstanding_balance_amount):
        """Sets the outstanding_balance_amount of this ApplicationInquiryExistingLoanDetails.

        Balance Owing  # noqa: E501

        :param outstanding_balance_amount: The outstanding_balance_amount of this ApplicationInquiryExistingLoanDetails.  # noqa: E501
        :type: float
        """

        self._outstanding_balance_amount = outstanding_balance_amount

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
        if issubclass(ApplicationInquiryExistingLoanDetails, dict):
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
        if not isinstance(other, ApplicationInquiryExistingLoanDetails):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
