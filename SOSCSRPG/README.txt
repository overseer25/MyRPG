--------------------------------
Author: Josh Oblinsky
Project: My RPG (Title needed)
--------------------------------

Implementation:

- The Player class stores data about a player object. Players have HP, XP, a class, a level, and more.
- The Location class stores data about a location in the World. A location has a name, coordinates, an associated image, and more.
- The World class stores data about the world. A world contains all the locations the player can encounter.



This I learned:

- The INotifyPropertyChanged interface. When a view data binds with a class that implements this interface,
	the view will listen for potential changes of the property values. In this case, the view is data bound to
	the Player class. The Player class implements the INotifyPropertyChanged interface, so the view will listen
	for changes made to specified properties.

- WPF has a built in functionality called BooleanToVisibilityConverter, which can take a boolean value, and set 
	the visibility of a form based on the value of the boolean.

- "nameof" is a built in function that can get the name of a property. This is helpful because, when renaming a
	property, it won't refactor a string variable containing the name of the property (ie. OnPropertyChanged("Property")). However, if
	you use nameof, it will refactor, as it is not explicitly a string anymore (ie. OnPropertyChanged(nameof(Property))).

- An ObservableCollection is a collection type for ModelView structures where any changes made to the collection will be updated in the
	UI.