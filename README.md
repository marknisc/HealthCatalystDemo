# HealthCatalystDemo

## HealthCatalyst Web
This is an Angular 10 application. The URL for the API is specified in a configuration file, /src/assets/config/config.dev.json or config.prod.json
`
{
    "api":{
        "baseUrl": "http://localhost:5200/api/"
    }
}
`

## HealthCatalyst API
This is an ASP.NET Core web application. For consistency of the demo it is coded to use http://localhost:5200


## Data Seeding
Data is seeded using in the DataSeeder class in HealthCatalyst.Data

Data is randomly created with possible givenname and surname combinations from the below lists

### Given names
"Francois",
"Claudine",
"Chic",
"Shane",
"Goober",
"Anni",
"Elvis",
"Mikaela",
"Bordie",
"Karlene",
"Trenton",
"Benoite",
"Monroe",
"Tallulah",
"Bron",
"Shirl",
"Hakeem",
"Maible",
"Gorden",
"Odetta"

### Surnames
"Georgi",
"Bruno",
"Whitesides",
"Orr",
"Houston",
"Anand-apte",
"Henneman",
"Reese",
"Maynadier",
"Schifini",
"Tohen",
"Cordova",
"Rutan",
"Parks",
"Siegfriedt",
"Luoma",
"Matarazzo",
"Croshaw",
"Ritzau",
"Britton"

