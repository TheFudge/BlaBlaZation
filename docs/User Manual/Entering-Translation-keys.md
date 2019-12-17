You can not only translate normal text, but give that text dynamic elements.
# Variables
Variables help you write a text or some other translatable string once and specifiy dynamic parts of that text. 
## Simple Variable
A simple Variable can be set by code with *string, integer, float, boolean and BlaInstance* values. just write the name of the variable in brackets: 
```text
Das kaufst [Amount] Früchte.
You bought [Amount] fruits.
```
That way the Variable *Fruit* can be anything from integers to strings of fruits. If Fruit would be a 6 then the output would be: 
```text
Das kaufst 5 Früchte.
You bought 5 fruits.
```
## Singular and Plural
With integer values you often want to use a different text for the singular as for plural.
This can be achieved by adding a vertical line inside the brackets and add the text you want for singular. With another vertical line you can specify the plural version.
You can specify where the value will be added to the text with *<?>*. If you do not specify it the value will be prepended.
```text
Du kaufst [Fruit| Frucht| Früchte].
You bought [Fruit| fruit| fruits].
```
```text
// singular
Du kaufst 1 Frucht.
You bought 1 fruit.

// plural
Du kaufst 5 Früchte.
You bought 5 fruits.
```
If you use <?>:
```text
[Fruit|Du kaufst <?>Frucht.|Du kaufst unglaubliche <?> Früchte!]
[Fruit|You buy <?> fruit.|You buy incredible <?> fruits!]
```
```text
// singular
Du kaufst 1 Frucht.
You bought 1 fruit.

// plural
Du kaufst unglaubliche 5 Früchte.
You bought incredible 5 fruits.
```
This is not the best example, I know ;)
## Using Translation for certain values
Most of the time in text values from Zero to Twelve are written as text. This can be set by using > or < to specifiy in which range it should be. You can also use *bigger or equal*
You can even specify a region with *X>Variable<Y*.
```text
Du kaufst [0<=Fruit>=12] Früchte.
You bought [0<=Fruit<=12] fruits.
```
The localization script will check the values of *FruitN* - where N is the value - and print the values of it.
For example: 
```text
// Value is 0
Du kaufst keine Früchte.
You bought no fruits.

// Value is 13
Du kaufst 13 Früchte.
You bought 13 fruits.

// Value is 12
Du kaufst zwölf Früchte.
You bought twelve fruits.
```

You can combine singular and plural with this:
```text
Du kaufst [0<=Fruit>=12| Frucht| Früchte].
You bought [0<=Fruit<=12| fruit| fruits].
```
## Using Functions
You can program functions for the retrieval of values into the translation. This way a programmer does not need to add the value.
*This has to be implemented by a programmer.*
```text
Was willst du mit [Inventory.Count(Knife)| Messer| Messern]??
What do you want with [Inventory.Count(Knife)| knife| knives]??
```

## Using containers
You can store your translations into different containers to manage the size of the localization files. 
This can be helpful for performance as the Dictionaries will be smaller and fewer keys have to be searched through to find the key.
If you do not specify a container the translation will fall back to your default container.
To specify the container just write the Name of the container in front of the Variable and sperate them by a colon.
```text
Du wirst mir nicht glauben was [Characters.HannesShort] gerade gegessen hat.
You wont believe what [Characters.HannesShort] ate.
```

## Using boolean values in text
Here a some example why booleans could be useful in your translations.
Firstly you can specify a value for *true* and another value for *false* This works just as the singular and plural values.
```text
Diese Tür ist [DoorState|offen|geschlossen].
This door is [DoorState|open|shut].
```
You could also use this to show text that will only be visible if the boolean has one of the values:
```text
// text is only shown if WentToCafe is false.
Willkommen im Cafè. [WentToCafe||Du bist neu hier oder?]
Welcome to the cafè. [WentToCafe||Are you new here?]
// text is only shown if WentToCafe is false.
Hallo Marvin! [HasGlassesOn|Coole Brille!|]
Hey Marvin! [HasGlassesOn|Sweet glasses!|]
```
You may see the beauty if you combine that with functions:
```
// text is only shown if WentToCafe is false.
Hallo Marvin! [Player.Wears(Glasses)|Zieh mal die Brille aus. Es ist 12 Uhr.|]
Hey Marvin! [Player.Wears(Glasses)|Take off your glasses. It is 12 o'clock.|]
```
# Special Characters
Soft hyphens and other UTF-8 characters often do not work when loading via webpages or wont be shown in WYSWIG editors. To counter that here are alternative ways to specify a special character.
## Soft-Hyphens
Soft Hyphens can be added with <shy> (*s*oft-*hy*phen).
This will be changed to the utf-8 value.
## Line-Breaks
As we work with unity you can use <br> to add a line break. In the parsing process this will be changes to \r\n as it is shorter and any text editor can understand it.
## No-Break Space
A space that wont break you need? you got it! Use <nb> or < > to add a no break space key.
This will be changed to the utf-8 value.
## Project colors
With Text Mesh Pro you can use inline colors with <color=#ffffff>text</color> to colorize the content.
But most of the time you do not want a magic color code in your translation. For that every key will be scanned for pre defined Color key words (in the settings file in your unity project).
Instead of <color=#ffffff> you can write color=AwesomeYellow. The color will be added during the parsing process. (You can change this behaviour.
```
This <color=AwesomeColor>text is in my color!</color>
```