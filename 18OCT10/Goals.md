﻿# Uppgifter
Syftet idag är att fokusera på objektorientering och MVC.   

### CASE
Vi har fått uppdraget bygga en första lösning för ett hyrbilsföretag. De har följande önskemål:
- Vi hyr ut små populära miljöbilar i Stockholms innerstad (utgå från 3 olika modeller och 10 bilar totalt)
- Hyresperioden är kort, ofta bara några timmar
- Våra kunder behöver vi registrera så vi har deras körkortsuppgifter, namn, adress, telefon och mail
- Kunden ska själv kunna beställa en bil via vår webbapplikation
- När man besöker sidan, ska man bli hälsad välkommen och få lite information om oss och våra tjänster
- Det ska vara enkelt att se lediga bokningsbara bilar
- När man bokar en bil, behöver man registrera sig som kund 
- Ingen inloggning av kunder i denna version
- Bokade bilar ska kunna visas upp så man ser när de blir lediga

## Uppgift 1
- Identifiera lämpliga klasser och deras properties, methods och events
- Skissa hur webbplatsen kan se ut och innehålla
- Ta fram en lista över controllers/actions och hur de mappar mot din skiss

### Förslag på lösning för första enkel happy path:
- Visa en lista över bilar
- Välja en bil > se mer detaljer om den valda bilen
- Boka en bil > skapa en bokning/agreement > visa upp bokningen
- inkludera att i samband med bokningen skapa en ny kund, som läggs med i bokningen


## Uppgift 2
- Skapa en ny VS lösning baserad på empty MVC
- Koppla upp den mot Git och GitHub (skapa ett eget repo)
- Skapa modeller
- Skapa controllers
- Skapa actions
- Använd _viewstart och _layout
- Skapa content/main.css
- Installera Bootstrap
- Bygg din site utifrån din skiss och CASE ovanför
- Validera att din lösning uppfyller ett minimum, happy path, av kraven i CASE ovanför
- Produktägaren/Beställaren kan du ställa frågor till i uppgiftstråden i Slack.