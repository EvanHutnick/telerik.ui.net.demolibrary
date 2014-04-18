telerik.ui.net.demolibrary
==========================

Quick sample objects for testing/demo'ing Telerik UI for .Net components.
-------------------------------------------------------------------------

The goal of this library is to keep an up-to-date and ready-to-use class library for creating generic data to be consumed by Telerik components.  It doesn't require you to use Telerik, I just recommend it. ;)

Included are basic generators for single objects and List<T> of the following:

* SmallObject
* BigObject
* HierarchicalSmallObject
* HierarchicalBigObject
* ChartObject
* FinancialObject

There are also some random elements for getting text as well as some static lists you can access.  These are all List<string> and include:

* NameList (fake)
* LongNameList (fake)
* BookList (actual)
* CityList (fake)
* CountryList (actual)

But wait!  There's more!

We've also got some elements that you can use for random text generation.  These are...

* TextGenerator.GetEmail() = Grab a random name from LongNameList, replace spaces with _'s, and add @fakegmail.com for the domain.
* TextGenerator.GetRandomText() = Grab a random sentence of Lorem text.
* TextGenerator.GetRandomLengthText(int) = Pull a random substring from a really, really long string of Lorem text.  Should be fairly random, but is unchecked so it can start with a space or punctuation.
