# SalesTaxes

For this project I wanted to show off as many OOP concepts as possible to showcase my knowledge. I also strived for a project structure that made to most sense to me and to anyone else viewing the project folder. 

1. OOP Concepts
   I mainly used instances of Abstraction, Inheritance, and Polymorphism through out the project and where ever I deemed it necessary. For example, I created an ABSTRACT class 'Item' which the classes 'ExemptItem' and     
  'StandardItem' inherited from. I provided an example of polymorphism through the changing in function of 'calculateSalesTax()' based on if the item added to the shopping cart is exempt from sales taxes or not.   
   
3. Project Folder Structure
   I created two different folders (creating different namespaces) and arranged for closely related classes to be put in the same related folder. I feel as this provided better accessibility and declutters the project   folder while navigating through the files. Everything dealing with the receipt creation was put in the folder 'ReceiptGenerator' and everying involving the different types of items were put in the 'ShoppingItemTypes' folder. The only files left out of a folder was the starting point of the program 'Program.cs' and 'CheckOut.cs'.


## How it works

When this program is run you will be presented with a series of prompts. Your answers to these prompts will decide whether an item is added, the item price, etc. After you have no other items to add the final prices will be displayed to you as requested in the coding test instructions. 

Prompt #1: Enter item name - 
  For this the item names need to be exact, especially if you are adding multple of the same items.
  Example: Imported box of chocolates != Imported Box of chocolates != Imported box chocolates (I just realized I can solve this (Imported box of chocolates != Imported Box of chocolates) by setting it to uppercase on   entry. (Fixed)
  
Prompt #2: Enter item price - 
  Must be a number. Automatically parses and sets at double data type. 
  
Prompt #3: Is the item imported -
  Input 'Y' here to make item imported, anything else for a non imported item.
  
Prompt #4: Is the item exempt from sales tax - 
  Input 'Y' here to make item exempt from basic sales tax, anything else for a non sales tax exempt item.

Prompt #5: Do you want to add another item -
  Determines whether to continue the program or not. Answering anything but 'Y' here brings you to the receipt output. 
