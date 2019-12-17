# Usage
The BlaKey ist used to store the translation informations and translate the texts.

# Methods

## Static Methods

### BlaKey.Get(string key)
Gets the BlaKey for the given string.

## Dynamic Methods
### BlatherInstance GetInstance()
Gets a new instance. Instances hold the specific informations about a key and its content.
They can be used to add values to variables inside the code and attach Unity Components to it.
```csharp
BlatherKey key = BlatherKey.Get("TestKey");
BlatherInstance instance = key.GetInstance();
```