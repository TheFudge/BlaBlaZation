# Usage
The BlaContainer holds many BlaKeys and their respective translations.
It´nside the container a key can exist only once.


To retrieve a container use `BlaCore.Container(string container)`.
# Methods

## Static Methods

### BlaContainer BlaContainer.Load(string container)
Loads this specified container into the memory and prepares it to be used for translation.

## Dynamic Methods

### BlaKey GetKey(string key)
Gets the specified key.

### bool AddKey(string key)
Adds a key to this container. To be used for creating a news container.
Note: If the key already exists it will overwrite the values stored for this key.

Returns: Whether the key already existed or not.

### BlaKey RemoveKey(string key)
Removes a key from this container. If not saved the container will only remove it from the current instance of this container.

Returns: the removed BlaKey.