# TowerDefense Van Owen
Mijn TowerDefense game 

![StartScreen](https://github.com/owen22s/TowerDefense/blob/master/readmeVisuals/Schermafbeelding%202023-10-20%20113726.png)

![also not](https://github.com/owen22s/TowerDefense/blob/master/readmeVisuals/Schermafbeelding%202023-10-20%20113832.png)


## Product 1: "DRY SRP Scripts op GitHub"

Plaats hier minimaal 1 link naar scripts die voldoen aan de eisen van **"Don't Repeat Yourself (DRY)"** en **"Single Responsibility Principle"**.
Omschrijf hier waarom jij denkt dat je in die scripts aan deze eisen voldoet.


In dit script maak ik van mijn enemyprefabs een array waardoor ik 2 verschillende enemies kan spawnen zonder dat ik mezelf herhaal.

[link naar script](/towerdefense/Assets/scripts/NPC/Enemy/EnemySpawner2.cs)"*

SRP script
[link naar script](towerdefense/Assets/scripts/NPC/Enemy/Destroy_on_hit.cs/)"*

## Product 2: "Projectmappen op GitHub"

Je commit de mappenstructuur van je unity project op github en verwijst vanuit je readme naar de root map van je project. Met een netjes en goed gestructureerde mappenstructuur en benamingen van files toon je aan dat je dit leerdoel beheerst. 

Dit is de [ROOT](/towerdefense/) folder van mijn unity project.

Zorg dat deze verwijst naar je Develop branch.

## Product 3: Build op Github

Je maakt in Unity een stabiele “build” van je game waarbij bugs en logs eerst zijn verwijderd. Deze buildfiles upload je in je repository onder releases.  Bij eventuele afwijkingen moeten deze worden gedocumenteerd in de release. (Bijv controller nodig of spelen via netwerk etc..) 

[Release Voorbeeld](https://github.com/owen22s/TowerDefense/releases)

## Product 4: Game met Sprites(animations) en Textures 

De build van je game bevat textures, sprites en sprite animations(bijv particles) die op de juiste manier zijn gebruikt en zorgen voor een goede afwerking van je game.  

Plaats in je readme een animated gif van je gameplay (+- 10 sec.) waarin de implementatie van je textures en sprites goed te zien is.

![Textures Sprites](https://github.com/owen22s/TowerDefense/blob/master/readmeVisuals/TowerDefense_trailer_gif.gif)

## Product 5: Issues met debug screenshots op GitHub 

Zodra je bugs tegenkomt maak je een issue aan op github. In de issue omschrijf je het probleem en je gaat proberen via breakpoints te achterhalen wat het probleem is. Je maakt screenshot(s) van het debuggen op het moment dat je via de debugger console ziet wat er mis is. Deze screenshots met daarbij uitleg over het probleem en de bijhorende oplossing post je in het bijhorende github issue. 
[Hier de link naar mijn issues](https://github.com/owen22s/TowerDefense/issues/2)

## Product 6: Game design met onderbouwing 

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 

Mijn one page
![](https://github.com/owen22s/TowerDefense/blob/master/readmeVisuals/OnePage.png)

Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

Je spel omvat torens die in staat zijn om doelgericht te schieten op bewegende doelwitten.

Mijn torens richten zich op de vijand die het dichtstbij is, evenals op de eindbaas.
Je spel biedt de mogelijkheid om vernietigbare vijanden te tegenkomen die één of meerdere routes kunnen volgen.

Mijn spel kent drie typen vijanden: een normale variant met 60 HP die behoorlijk snel is, een variant met een pilaar op het hoofd met 100 HP die wat trager beweegt, en een eindbaas met 1000 HP.
Je spel maakt gebruik van een golfsysteem waarbij onder specifieke voorwaarden (tijd of aantal vijanden) nieuwe golven van tegenstanders het strijdtoneel betreden.

In mijn spel wordt een golfsysteem gehanteerd dat willekeurig één van de twee typen vijanden genereert en vervolgens de aantallen verdubbelt.
Een gezondheidssysteem is geïmplementeerd waarmee spelers levens kunnen verliezen wanneer tegenstanders hun doel bereiken, wat kan resulteren in het verlies van het spel.

Wanneer mijn vijand het einde van zijn route bereikt, gaat er 1 HP van de gezondheid af.
Een resourcesysteem stelt spelers in staat om middelen te vergaren waarmee ze torens kunnen aanschaffen en eventueel kunnen upgraden.

Ik heb een economisch systeem geïmplementeerd in mijn spel. De aanschafprijs van een toren bedraagt 20 eenheden, maar bij de eerste aanschaf wordt deze verdubbeld naar 40 eenheden. Vervolgens wordt er 10 eenheden van de totale hoeveelheid afgetrokken.
Een upgradesysteem biedt de mogelijkheid om torens te verbeteren en hun functionaliteit te versterken.

Wanneer een toren wordt geüpgraded, neemt zijn vuursnelheid toe tot het dubbele.
Een voorspellingssysteem voor beweging stelt spelers in staat om de juiste richting te bepalen voor het schieten op bewegende objecten. (Geavanceerd)

Ik heb een script geschreven dat in staat is om de maximale reikwijdte van de toren te bepalen. Indien het doel binnen deze reikwijdte valt, zal de toren aanvallen.
## Product 7: Class Diagram voor volledige codebase 
![](https://github.com/owen22s/TowerDefense/blob/master/readmeVisuals/ClassenDiagram.png)

## Product 8: Prototype test video
Je hebt een werkend prototype gemaakt om een idee te testen. Omschrijf if je readme wat het idee van de mechanics is geweest wat je wilde testen en laat een korte video van de gameplay test zien. 

[![example test video](https://nl.wikipedia.org/wiki/Computerspel#/media/Bestand:Nexuiz_screenshot_10.jpg/)](https://youtu.be/8cQBuaZKKD4?si=QPYTKRL_Te-2XPT4)

## Product 9: SCRUM planning inschatting 

Je maakt een SCRUM planning en geeft daarbij een inschatting aan elke userstory d.m.v storypoints / zelf te bepalen eenheden. (bijv. Storypoints, Sizes of tijd) aan het begin van een nieuwe sprint update je deze inschatting per userstory. 

Plaats in de readme een link naar je trello en **zorg ervoor dat je deze openbaar maakt**

[Link naar de openbare trello](https://trello.com/b/MkFjlNwU/towerdefence)

## Product 10: Gitflow conventions

Je hebt voor je eigen project in je readme gitflow conventies opgesteld en je hier ook aantoonbaar aan gehouden. 

De gitflow conventions gaan uit van een extra branch Develop naast de "Master"/"Main". Op de main worden alleen stabiele releases gezet.

Verder worden features op een daarvoor bedoelde feature banch ontwikkeld. Ook kun je gebruik maken van een hotfix brancg vanaf develop.

Leg hier uit welke branches jij gaat gebruiken en wat voor namen je hier aan gaat meegeven. Hoe vaak ga je comitten en wat voor commit messages wil je geven?

Meer info over het gebruiken van gitflow [hier](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)

