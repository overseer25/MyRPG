This I learned:

- The INotifyPropertyChanged interface. When a view data binds with a class that implements this interface,
	the view will listen for potential changes of the property values. In this case, the view is data bound to
	the Player class. The Player class implements the INotifyPropertyChanged interface, so the view will listen
	for changes made to specified properties.