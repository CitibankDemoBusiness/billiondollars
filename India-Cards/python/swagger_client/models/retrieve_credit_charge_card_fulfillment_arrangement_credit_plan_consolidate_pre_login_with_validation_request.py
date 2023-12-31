# coding: utf-8

"""
    Cards

    The Cards API allows you to perform actions on the actual credit cards of the Citi Customer who authorized your app.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

import pprint
import re  # noqa: F401

import six

class RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest(object):
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
        'old_loan_list': 'list[Loan]',
        'total_loan_amount': 'float',
        'loan_tenure_in_months': 'int',
        'top_up_amount': 'float',
        'disbursement_option': 'str',
        'beneficiary_detail': 'BeneficiaryDetail',
        'payee_id': 'str',
        'loan_purpose': 'str'
    }

    attribute_map = {
        'old_loan_list': 'oldLoanList',
        'total_loan_amount': 'totalLoanAmount',
        'loan_tenure_in_months': 'loanTenureInMonths',
        'top_up_amount': 'topUpAmount',
        'disbursement_option': 'disbursementOption',
        'beneficiary_detail': 'beneficiaryDetail',
        'payee_id': 'payeeId',
        'loan_purpose': 'loanPurpose'
    }

    def __init__(self, old_loan_list=None, total_loan_amount=None, loan_tenure_in_months=None, top_up_amount=None, disbursement_option=None, beneficiary_detail=None, payee_id=None, loan_purpose=None):  # noqa: E501
        """RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest - a model defined in Swagger"""  # noqa: E501
        self._old_loan_list = None
        self._total_loan_amount = None
        self._loan_tenure_in_months = None
        self._top_up_amount = None
        self._disbursement_option = None
        self._beneficiary_detail = None
        self._payee_id = None
        self._loan_purpose = None
        self.discriminator = None
        if old_loan_list is not None:
            self.old_loan_list = old_loan_list
        if total_loan_amount is not None:
            self.total_loan_amount = total_loan_amount
        if loan_tenure_in_months is not None:
            self.loan_tenure_in_months = loan_tenure_in_months
        if top_up_amount is not None:
            self.top_up_amount = top_up_amount
        if disbursement_option is not None:
            self.disbursement_option = disbursement_option
        if beneficiary_detail is not None:
            self.beneficiary_detail = beneficiary_detail
        if payee_id is not None:
            self.payee_id = payee_id
        if loan_purpose is not None:
            self.loan_purpose = loan_purpose

    @property
    def old_loan_list(self):
        """Gets the old_loan_list of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501


        :return: The old_loan_list of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: list[Loan]
        """
        return self._old_loan_list

    @old_loan_list.setter
    def old_loan_list(self, old_loan_list):
        """Sets the old_loan_list of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.


        :param old_loan_list: The old_loan_list of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: list[Loan]
        """

        self._old_loan_list = old_loan_list

    @property
    def total_loan_amount(self):
        """Gets the total_loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount  # noqa: E501

        :return: The total_loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: float
        """
        return self._total_loan_amount

    @total_loan_amount.setter
    def total_loan_amount(self, total_loan_amount):
        """Sets the total_loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        Total amount borrowed by customer as Loan ie., Old Loan Amount+Top up Amount  # noqa: E501

        :param total_loan_amount: The total_loan_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: float
        """

        self._total_loan_amount = total_loan_amount

    @property
    def loan_tenure_in_months(self):
        """Gets the loan_tenure_in_months of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        Tenure of loan against credit card. It is considered in terms of number of months  # noqa: E501

        :return: The loan_tenure_in_months of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: int
        """
        return self._loan_tenure_in_months

    @loan_tenure_in_months.setter
    def loan_tenure_in_months(self, loan_tenure_in_months):
        """Sets the loan_tenure_in_months of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        Tenure of loan against credit card. It is considered in terms of number of months  # noqa: E501

        :param loan_tenure_in_months: The loan_tenure_in_months of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: int
        """

        self._loan_tenure_in_months = loan_tenure_in_months

    @property
    def top_up_amount(self):
        """Gets the top_up_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        Additonal Topup Amount  # noqa: E501

        :return: The top_up_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: float
        """
        return self._top_up_amount

    @top_up_amount.setter
    def top_up_amount(self, top_up_amount):
        """Sets the top_up_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        Additonal Topup Amount  # noqa: E501

        :param top_up_amount: The top_up_amount of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: float
        """

        self._top_up_amount = top_up_amount

    @property
    def disbursement_option(self):
        """Gets the disbursement_option of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.  # noqa: E501

        :return: The disbursement_option of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: str
        """
        return self._disbursement_option

    @disbursement_option.setter
    def disbursement_option(self, disbursement_option):
        """Sets the disbursement_option of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        This field indicates the options/mode in which the loan amount will be disbursed. This is a reference data field. Please use /v1/utilities/referenceData/{disbursementOption} resource to get valid value of this field with description.  # noqa: E501

        :param disbursement_option: The disbursement_option of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: str
        """

        self._disbursement_option = disbursement_option

    @property
    def beneficiary_detail(self):
        """Gets the beneficiary_detail of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501


        :return: The beneficiary_detail of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: BeneficiaryDetail
        """
        return self._beneficiary_detail

    @beneficiary_detail.setter
    def beneficiary_detail(self, beneficiary_detail):
        """Sets the beneficiary_detail of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.


        :param beneficiary_detail: The beneficiary_detail of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: BeneficiaryDetail
        """

        self._beneficiary_detail = beneficiary_detail

    @property
    def payee_id(self):
        """Gets the payee_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        Payee Indicator to be mapped against Payee Detail Key  # noqa: E501

        :return: The payee_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: str
        """
        return self._payee_id

    @payee_id.setter
    def payee_id(self, payee_id):
        """Sets the payee_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        Payee Indicator to be mapped against Payee Detail Key  # noqa: E501

        :param payee_id: The payee_id of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: str
        """

        self._payee_id = payee_id

    @property
    def loan_purpose(self):
        """Gets the loan_purpose of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501

        This field indicates the options/mode in which the loan amount will be disbursed  # noqa: E501

        :return: The loan_purpose of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :rtype: str
        """
        return self._loan_purpose

    @loan_purpose.setter
    def loan_purpose(self, loan_purpose):
        """Sets the loan_purpose of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.

        This field indicates the options/mode in which the loan amount will be disbursed  # noqa: E501

        :param loan_purpose: The loan_purpose of this RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest.  # noqa: E501
        :type: str
        """

        self._loan_purpose = loan_purpose

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
        if issubclass(RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest, dict):
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
        if not isinstance(other, RetrieveCreditChargeCardFulfillmentArrangementCreditPlanConsolidatePreLoginWithValidationRequest):
            return False

        return self.__dict__ == other.__dict__

    def __ne__(self, other):
        """Returns true if both objects are not equal"""
        return not self == other
