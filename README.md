#Delay
Sorry for the long time to get started on this. The day Nick and I talked I had to run up to my parents for a few days.
Then that weekend, I had a race (I race dirt bikes for a past time/hobby).
Finally, on Monday, my son had to be picked up from Daycare for having the flu so I am still dealing with that this week but I stayed up late tonight to get this done.

All of these things I mentioned to Jonathan my recruiter so you can validate with him so you don't feel I am bsing you or I spent all this time to just create this.

Honestly I only spent about 2-3 hours on it.

#Choices
Decided to use xUnit testing within the context itself, since the ask was pretty simple I didn't feel the need for repositories and services were needed. 
All API testing was done using PostMan, I tested each call before I finished. 
I did use scaffolding to start the calls but then altered. 

As mentioned below, I basically messed up a bit late with noticing the object and I already had my code recreating the JSON file properly per API call. 

#Hiccups
Was an idiot about the object handling with customers, after making literally all of the JSON changes, I realized that you probably wanted a model called GroceryStore and the object customers was inside...
I instead just went directly with customers, that's my bad. But I hope it doesn't stop showing what I could do with what I did.

#Improvements that I could throw in
Mainly just want to mention some things I know I could throw in if it isn't to the standard you wanted.
Javascript handling front end from API calls. Something simple but like a button and text boxes to add each.
A bunch more unit tests around things such as case sensitivity, failures, exceptions, etc. 
Creating a global exception handling class if unit tests hit exceptions so you can handle to a log properly if you wanted. 
A few other things, it always can be improved but I just wanted to state that I know I could have done more just didn't really see the need, but if you do I will try to put it in.
