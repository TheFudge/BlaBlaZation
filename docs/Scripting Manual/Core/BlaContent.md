# Usage

BlaContent is a wrapper for setting specific values for a given variable inside a key.
The BlaContent Instances will be stored inside the instance.

Every BlaContent is a templated instance. The functionality for the given type is specified in the BlaContentHelper Classes.

```csharp
BlaInstance instance = BlaCore.Instance("somekey");
BlaContent<int> intContent = instance.SetContent<int>("MyVariable", 5, "N0");
```

# Methods 

## Static Methods

## Dynamic Methods

### void UpdateValue(T value)
Updates the variables content to the specified value. Note that you cannot change the type of the value here.
If you start the content with an integer value you will onyl be able to specify a integer value.
For a different value type use `BlaInstance.SetContent<T>(string variable, T value, string format = "")`.
