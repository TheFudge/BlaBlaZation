# Translation Changes

If the translation changes a chain of callbacks will be invoked throughout this plugin.

Firstly The BlaManager will detect a change in a language or a container was added or removed.

It will then notify the containers that they should change their values calling BlaContainer.LanguageChanged.

If a container will be removed then BlaContainer.Remove() will be called and it will try to clean up its keys and instances.
If any instance is still alive (or key) it will mark these instances as obsolete. If they themselves will change their values the conainers will be added again by the key.

The containers will call their OnChange Method and every key listens to this.

The keys themselves have a OnChange Method where the instances listen to.

The instances then will translate according to their keys and values and call their OnChange Method and update the attached components with the new values (TMP_TEXT, UI.Text, SpriteRender, etc...)

This way nobody is referenced by no one (except the keys in the container as they are a part of the container) and we have no problems with dead instances lying around.