# HGS Project for Akbank Web3 Practicum, OOP Case

It's a simple AutoPass app running as a Console app.

In this app, when a vehicle passes, the system takes information from the vehicle's HGS like Driver's Name, Vehicle Type, Wallet balance etc. and gets paid. If there is not enough balance, then the system gives an alert. Also, the system record all passed vehicles and calculates daily profit.

- There are classes for every vehicle type. (Car.cs, minibus.cs, Bus.cs)
- There is a "Control()" function in Paydesk class to take info from every passing vehicle for checking and also register every vehicle to an array. It has also responsible of gets paid. 
- In management class, there is a "CalculateDailyProfit()" function to calculate daily profit.
