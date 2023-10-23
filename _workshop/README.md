# BuildingCloudNativeApplicationsUsingOrleans-DotNetDeveloperDays-2023
Hands-On building Cloud Native .NET applications using Microsoft Orleans and AKS - .NET Developer Days 2023

## Workshop agenda

| Time          |         |
| ------------- | ------- |
| **08:00 - 09:00** | Welcome |
| **09:00 - 10:45** | Workshop Part 1 (Theory) |
| **10:45 - 11:15** | Coffee Break |
| **11:15 - 13:00** | Workshop Part 2 (Code Examples and Azure) |
| **13:00 - 13:45** | Lunch |
| **13:45 - 15:15** | Workshop Part 3 (Exercises) |
| **15:15 - 15:45** | Coffee Break |
| **15:45 - 17:00** | Workshop Part 4 (Exercises) |

## Workshop Exercises

* [Exercise 1](#exercise-1)
* [Exercise 2](#exercise-2)
* [Exercise 3](#exercise-3)
* [Exercise 4](#exercise-4)
* [Exercise 5](#exercise-5)
* [Exercise 6](#exercise-6)
* [Exercise 7](#exercise-7)
* [Exercise 8](#exercise-8)
* [Exercise 9](#exercise-9)

## Exercise 1

Create a new .NET 7/8 project that hosts an Orleans silo and uses the Orleans Dashboard to display detail about the running silo.

* Use an ASP.NET Web SDK application as a base. This can also be created from a Worker Service project template.
* Configure a local Orleans cluster containing a single silo.

[Solution to exercise 1](./exercise-1/)

## Exercise 2

Create a new .NET 7/8 project using the Worker Service project template that uses a StatusGrain to display the current date and time in the console.

* Use the Worker Service project template.
* Configure a local Orleans cluster containing a single silo.
* Create a StatusGrain that return the current date and time.
* Call into the StatusGrain from the Worker and log the result to the console every second.

[Solution to exercise 2](./exercise-2/)

## Exercise 3

Create a new .NET 7/8 project using the Worker Service project template that uses a StatusGrain to display the current date and time in the console.

* Use the Worker Service project template.
* Configure a local Orleans cluster containing a single silo.
* Create a StatusGrain that return the current date and time.
* Call into the StatusGrain from the Worker and log the result to the console every second.
* Configure garbage collecting to deactivate idle grains.

[Solution to exercise 3](./exercise-3/)

## Exercise 4

Create a new .NET 7/8 project using the Worker Service project template that uses a StatusGrain to display the current date and time in the console.

* Use the Worker Service project template.
* Configure a local Orleans cluster containing a single silo.
* Create a StatusGrain that return the current date and time.
* Call into the StatusGrain from the Worker and log the result to the console every second.
* Make sure to deactivate StatusGrain immediately after its work is done.

[Solution to exercise 4](./exercise-4/)

## Exercise 5

Create a new .NET 7/8 project that hosts an Orleans silo and uses the Orleans Dashboard to display detail about the running silo.

* Use an ASP.NET Web SDK application as a base. This can also be created from a Worker Service project template.
* Configure a local Orleans cluster containing a single silo.
* Create a StatusGrain that return the current date and time.
* Create an additional .NET 7/8 Worker Service that configures as an Orleans client application.
* Call into the StatusGrain from the Worker and log the result to the console every second.

[Solution to exercise 5](./exercise-5/)

## Exercise 6

Create a new .NET 7/8 project that hosts an Orleans silo and uses the Orleans Dashboard to display detail about the running silo.

* Use an ASP.NET Web SDK application as a base. This can also be created from a Worker Service project template.
* Configure a local Orleans cluster with the option to run multiple silos.
* Use a command-line argument to specify a custom port for each silo.
* Create a StatusGrain that return the current date and time.
* Create an additional .NET 7/8 Worker Service that configures as an Orleans client application.
* Call into the StatusGrain from the Worker and log the result to the console every second.
* Use the dashboard to look at the Orleans silos spreading the work.

[Solution to exercise 6](./exercise-6/)

## Exercise 7

Use Azurite for storing local grain state.

[Solution to exercise 7](./exercise-7/)

## Exercise 8

Use a timer grain.

[Solution to exercise 8](./exercise-8/)

## Exercise 9

Use heterogenous silos.

[Solution to exercise 9](./exercise-9/)