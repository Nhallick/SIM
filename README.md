# SIM
Inventory Control Software for Tooling

----------------------------------------------------------------------------------------------------------------------------
v1.2.0 

	*Thursday, October 19th 2017 11:20 AM*
	-Integration with GitHub version control
	-Previous changes located in solution file under "StriteInventoryManagement.vb"
----------------------------------------------------------------------------------------------------------------------------
v1.2.1

	*Thursday, October 19th 2017 1:55 PM*
	-Added functionality of the lblinventoryvalue object. It will now flash on an inventory change and indicate 
	wether the value increased or decreased (green for increase and red for decrease). the text colour will stay 
	either red or green after the update to indicate what the last transaction was.
---------------------------------------------------------------------------------------------------------------------------
v1.2.2

	*Monday, October 23rd 2017 11:14 AM*
	-Added functionality to set tools with no size data to have a cost of $0.00
---------------------------------------------------------------------------------------------------------------------------
v1.2.3

	*Tuesday, November 14th 2017 11:26 AM*
	-Added progressbar for showing refresh progress and the ability to change
	the refresh interval on the monitor form
---------------------------------------------------------------------------------------------------------------------------
v1.2.4

	*Tuesday, November 21st 2017 10:34 AM*
	-Fixed an issue where when tools were automatically ordered the quantity
	would be double or more of what they should be
	-(Issue seems to have been caused by allowing multiple people to be able to 
	auto order at the same time while on the Tool Room window)
	-Issue has been fixed by allowing only one users account to automatically order
	parts while on the Tool Room window
---------------------------------------------------------------------------------------------------------------------------
v1.2.5

	*Thursday, November 23rd 2017 10:45 AM*
	-Added functionality to add quantity to cutter orders when auto ordering or signing out tools when there is
	already an order placed. This will help avoid duplicate cutter orders in the future (especially when signing
	out tools that have quantity below the minimum bin threshold)
---------------------------------------------------------------------------------------------------------------------------
v1.2.6

	*Thursday, January 11th 2018 7:17 AM*
	-First commit of the new year!
	-Added a button on the devOptions screen that will loop through all the tools in the inventory and recalculate
	the cost based on the quantity. used for the odd case where the inventory has a discrepency so it can be fixed
	anytime without me having to go through each item and find which one is wrong. Also it tells you which tools
	its changed.
