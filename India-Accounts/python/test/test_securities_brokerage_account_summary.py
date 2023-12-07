# coding: utf-8

"""
    Accounts

    The Accounts API allows you to retrieve account and transaction data for Citi Customers who have authorized your app. In most cases, you'll want to request a summary of all accounts first, which will return basic account information and accountIds. Once you have this information, you can request additional account details and/or transactions.  # noqa: E501

    OpenAPI spec version: 1.0.0
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
"""

from __future__ import absolute_import

import unittest

import swagger_client
from swagger_client.models.securities_brokerage_account_summary import SecuritiesBrokerageAccountSummary  # noqa: E501
from swagger_client.rest import ApiException


class TestSecuritiesBrokerageAccountSummary(unittest.TestCase):
    """SecuritiesBrokerageAccountSummary unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testSecuritiesBrokerageAccountSummary(self):
        """Test SecuritiesBrokerageAccountSummary"""
        # FIXME: construct object with mandatory attributes with example values
        # model = swagger_client.models.securities_brokerage_account_summary.SecuritiesBrokerageAccountSummary()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
