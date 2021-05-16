# AspNet PostgreSQL Railway App

This repo contains a simple Asp.Net Core app using PostgreSQL for deploying to [Railway.App](https://railway.app/)

## Instructions

1. Create an empty project in railway
2. Add a [PostgreSQL plugin](https://docs.railway.app/plugins/postgresql)
3. Add a `DefaultConnection` string with the following from the Variables section in your Railway app project dashboard

```json
"ConnectionStrings": {
    "DefaultConnection" : "Server=PGHOST;Port=PGPORT;Database=PGDATABASE;UserId=PGUSER;Password=PGPASSWORD;"
  }
```

4. Run the following commands with the [railway cli](https://www.npmjs.com/package/@railway/cli) 

- `railway login`
- From the setup section in your Railway project dashboard  run the `railway link` command (including the project identifier)
- `railway up`

## Docker commands

- Build
```bash
docker build . -t aspnetpostgresrailwayapp
```

- Run
```bash
docker run -it --rm -p 5001:5001 --name aspnetpostgresrailwayapp aspnetpostgresrailwayapp
```