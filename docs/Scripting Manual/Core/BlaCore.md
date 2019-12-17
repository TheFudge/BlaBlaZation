#Usage

BlaCore is a wrapper class to retrieve keys and other instances in the localization environment.

# Methods

## Static Methods

### BlaInstance BlaCore.Key(string key)
Gets the BlaKey specified by key.
```csharp
BlaKey key = BlaCore.Key("MainMenuButton");
```

### BlaInstance BlaCore.Key(string key, string container)
Gets the BlaKey specified by key inside a specified container.
```csharp
BlaKey key = BlaCore.Key("SuccessMessage", "Level3");
```

### BlaInstance BlaCore.Instance(string key)
Gets an instance of the BlaKey specified by key.
```csharp
BlaInstance instance = BlaCore.Instance("MainMenuButton");
```

### BlaInstance BlaCore.Instance(string key, string container)
Gets an instance of the BlaKey specified by key.
```csharp
BlaInstance instance = BlaCore.Instance("SuccessMessage", "Level3");
```

### bool BlaCore.LoadContainer(string container)

Loads the specified container to be used for localization.
Note: A container can be loaded automatically if a key wants to use it.

### BlaContainer BlaCore.Container(string container)
Gets the specified container to be used to get keys inside of the container.
If the container does not exist it will create a new empty container.