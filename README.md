# GoCompare_ShoppingCart_ConsoleApp

REQUIREMENT
-----------
In a normal supermarket, things are identified using Stock Keeping Units, or SKUs. In our store, we’ll use individual letters of the alphabet (A, B, C, and so on). Our goods are priced individually. In addition, some items are multipriced: buy n of them, and they’ll cost you y pounds. For example, item ‘A’ might cost 50 pounds individually, but this week we have a special offer: buy three ‘A’s and they’ll cost you 130. The price and offer table:

Item  Price   Offer
--------------------------
A     50       3 for 130
B     30       2 for 45
C     20
D     15

Our checkout accepts items in any order, so that if we scan a B, an A, and another B, we’ll recognize the two B’s and price them at 45 (for a total price so far of 95).

----------------------------------------------------------------------------------------------------------------------------------
Developed shopping cart checkout in console application to calculate total basket price based on the input items.

Total Time: 1 HOUR

1) Cart.ConsoleApp.UnitTest

Unit test project for cart console application to write and execute the given test cases along with coding exercise and added few more test cases to cover invalid items and negative scenarios.

2) Cart.ConsoleApp

a) Main console application project to list all items give in requirement along with offer details.
b) Having static class PriceCalculation to keep the logic separate in order to write and test unit test. 

OUTPUT:

a) Users will be presented with list of items, price and offer details.
b) User can input the items in the format - AA/ABC/AABC etc.
c) Total price will be displayed.
