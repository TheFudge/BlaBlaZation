# Purpose 
The BlaSettings are supposed to let you customize the behaviour of this plugin. You can set how keys are retrieved, what happenes, when an error ocurred and how and where the keys are loaded from.

# Serialization
Specifies how and where the keys are loaded from

## Load From
Under this part you can specify whether this plugin should load its content from a disk folder, a single file or the internet.

### Load From Folder
The script will parse every file in this folder and generate the localization from that.
Supported are (will be)
- XML files
	- Under XML Settings you can specify how the XML is named.
- JSON files
	- under JSON Settings you can specify how the JSON parameters are named.
- CSV files
	- You can specify different names of the Columns to link to languages (German would likn to de)
- TXT files
	- You can specify wheter a txt can contain multiple keys. If you enable it the first line defines if inside there is one key or multiple keys.
Example of header for multiple keys
```#BlaBlaZation/Multiple
MyFirstKey
de: Das ist meine Übersetzung.
en: This is my translation.
MySecondKey
de: Das ist eine zweite Übersetzung.
en: This is another translation.
```
You can also specify if a text file is only used for one language:
```
#BlaBlaZation/Multiple
#Lang:de
MyFirstKey: Das ist meine Übersetzung.
MySecondKey: Das ist eine zweite Übersetzung.
```

Empty line will be ignored in multiple mode.
If you set it to Single Mode you can use line breaks as usual.
```
#BlaBlaZation/Single:MyKey
#Lang:de
Das is meine deutsche Übersetzung.
Sie geht über mehrere Zeilen.

Leere Zeilen werden dabei auch in der Übersetzung beachtet.
Das ist super für ein Impressum oder andere super lange Texte.
#Lang:en
This is my english translation.
It will span multiple lines.

Also, empty lines will be added to the localization text.
This is great for giant text like impressum text element and other crazy stuff.
```