# Exchange rate

This is service that returns historical exchange rate information.

## How to run a project

Open [VS code](https://code.visualstudio.com/download), open terminal ( CTRL+` ), go to the corresponding folder and type:

```
git init
git clone https://github.com/kslobodan/ExchangeRate.git
code .\ExchangeRate\, and open terminal again
cd .\ExchangeRate\
dotnet build
dotnet run  
```

## Testing

For testing use [Postman](https://www.postman.com/), open it and in 'Get' type next:

```
http://localhost:5000/api/commands/2022-03-03,2022-02-02,2022-01-01/EUR/USD
```

and press Send. So format is:

```
http://localhost:5000/api/commands/DatesList/FromCurrency/ToCurrency
```

You should get string like this:

```
{"MinRateAmount":1.106246,"MinRateDate":"2022-03-03","maxRateAmount":1.136796,"MaxRateDate":"2022-01-01","AverageRate":1.124503,"NumberOfDifferentAmounts":3}
```

## Contributing
Suggestions and advices are welcome.

## TODO
- Caching
- Validations
- Receiving data from client from JSON instead from url
- Tests
