# HQ Revenue

Backend Engineering Assignment

---

## Task 1: Web Extraction

---

## Task 2: Reporting

### Execute run

```
cd "Reporting\Reporting"
dotnet run
```

### Result
The file will be generated in the folder:
```
"Reporting\Reporting\report.xlsx"
```


---

## Task 3: Web Service / API

### Execute unit tests

```
cd "WebServiceAPI/WebServiceAPITest"
dotnet test
```

### Execute run

```
cd "WebServiceAPI/WebServiceAPI"
dotnet run
```

### Request API

Endpoints are available at http://127.0.0.1:5000

```
GET http://127.0.0.1:5000/HotelsRates?HotelID=8759&ArrivalDate=2016-03-15T20:00:00-03:00
```

### Result
```
{
    "hotel": {
        "classification": 4,
        "hotelID": 8759,
        "name": "NU Hotel am Kudamm Berlin",
        "reviewscore": 8.9
    },
    "hotelRates": [
        {
            "adults": 2,
            "los": 1,
            "price": {
                "currency": "EUR",
                "numericFloat": 116.1,
                "numericInteger": 11610
            },
            "rateDescription": "Unsere Classic Zimmer bieten Ihnen allen Komfort, den Sie von einem 5-Sterne-Hotel erwarten. Helle und freundliche Farben sorgen für ein angenehmes Ambiente, damit Sie Ihren Aufenthalt im Herzen Berlins voll und ganz genießen können. 20m². Doppelbett oder zwei separate Betten. Max. Kapazität: 2 Erwachsene oder 1 Erwachsener und 1 Kind.      ",
            "rateID": "-739857498",
            "rateName": "Classic Zimmer - Frühbucher Rate",
            "rateTags": [
                {
                    "name": "breakfast",
                    "shape": false
                }
            ],
            "targetDay": "2016-03-14T20:00:00-03:00"
        }
        ....
    ]
}
```
