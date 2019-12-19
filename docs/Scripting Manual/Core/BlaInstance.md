# Usage
To use an instance, you need to retrieve it. You can specify the container it is in or dont specify a container. If no container is specified the default container will be used.
```csharp
BlaInstance instance = BlaCore.Instance(string key)
instance.SetContent("Highscore", 55).SetContent("Player", Player.Name);
BlaContent highscoreContent = instance.GetContent("Highscore");

// Attach to a TextMeshPro Element or a Text Element
instance.Attach(this.GetComponent<TMP_Text>());
instance.Attach(this.GetComponent<UI.Text>());
// you can also attach it to a AudioSource or an Image/Sprite Render.
instance.Attach(this.GetComponent<SpriteRenderer>());

// update a content value:
highscoreContent.Value = 1024;
```

# Methods
## Static Methods


## Dynamic Methods

### BlaInstance SetContent(string variable, string content)
Sets the variable to a string value.
Returns itself.

### BlaInstance SetContent(string variable, int content, string format = "N0")
Sets the variable to an integer value.
Returns itself.

### BlaInstance SetContent(string variable, string content, string format = "N2")
Sets the variable to a float value.
Returns itself.

### BlaInstance SetContent(string variable, bool content
Sets the variable to the specified content.
Returns itself.

### BlaInstance SetContent(string variable, BlatherInstance content)
Sets the variable to another BlatherInstance.
Returns itself.

### BlaContent GetContent(string variable)
Gets a BlatherContent.

### BlaInstance SetDisposeType(BlaInstance.DisposeType)
Sets a dispose type for this BlaInstance.
You can set here whether the instance will only live if something is attached to it or if it will dispose after a scene change.
Additionally you can set it to be Dispose if translated, which will destroy this instance immediately after the instances toString() Method has been called.

## Getters And Setters

### UnityAction OnChange
Called, if the translation string of this instance changed.