# banking-system
I was insipired by this example
[Orleans example - banking application](https://github.com/dotnet/samples/tree/main/orleans/BankAccount)
Demonstrates usage of Microsoft stack
.NET 7, REST API, JSON, C#, AzureCosmosDB, Orleans.
I wanted to get experience in these technologies, so I created this project.

# Overview
## REST API, account-api project.
It has endpoints:
- GET /v1/accounts/{account_id}
Returns account details: id, name and remaining balance.

- GET /v1/accounts/{account_id}/transactions
Returns list of transactions for the account.

This is a simple REST API, which uses Azure as a database.

## REST API, transaction-api project.
It has endpoints:

- POST /v1/transactions
Creates a transaction to transfer funds between accounts passed inside of the body.



