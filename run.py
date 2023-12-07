import plaid
from plaid.api import plaid_api
from plaid.model.item_public_token_exchange_request import ItemPublicTokenExchangeRequest
from plaid.model.processor_stripe_bank_account_token_create_request import ProcessorStripeBankAccountTokenCreateRequest

# Change sandbox to development to test with live users and change
# to production when you're ready to go live!
configuration = plaid.Configuration(
    host=plaid.Environment.Sandbox,
    api_key={
        'clientId': '650a7cf075260e001b65b4e5',
        'secret': 'c5c43b91df175323ed572da85670d4',
        'plaidVersion': '2020-09-14'
    }
)
api_client = plaid.ApiClient(configuration)
client = plaid_api.PlaidApi(api_client)

exchange_request = ItemPublicTokenExchangeRequest(public_token=public_token)
exchange_token_response = client.item_public_token_exchange(exchange_request)
access_token = exchange_token_response['access_token']

request = ProcessorStripeBankAccountTokenCreateRequest(
    access_token=access_token,
    account_id=account_id,
)
stripe_response = client.processor_stripe_bank_account_token_create(request)
bank_account_token = stripe_response['stripe_bank_account_token']