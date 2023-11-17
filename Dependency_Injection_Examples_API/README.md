# Dependency Injection Examples

## Overview

I created this project to demonstrate the three main methods of performing dependency injection "by hand". This is an application that
mocks a real life Cafe and orders drinks for the user. This application demonstrates how the cafe application could be implemented 
with **constructor injection**, **method injection** and **property injection**. The original project was a console app. This project 
adapts the original into a Minimal API using ASP.NET Core. 

## Dependency Injection Cafe Introduction
Hello and welcome to the dependency injection cafe! We serve all sorts of coffees and milkshakes can make each one in three different ways (**constructor injection**, 
**method injection** and **property injection**). Each of the drink is injected by 'hand'. The dependency injection container is not used in these examples so we can 
focus and understand the fundamentals of dependency injection first.

All of the drinks can be ordered using get requests.
To get a response first specify route as: ```{localhost base URL}/{drink type}/{dependency injection type}?drinkFlavour={drink flavour}```. 
The available drink trypes are: **'coffee'** and **'milkshake'**. 
The available injection types are: **'method_injection'**, **'property_injection'** and **'constructor_injection'**. 
For example: If you wanted to get a latte using constructor injection you would use the route ```{localhost base URL}/coffee/constructor_injection?drinkFlavour=latte```.
