# NordCloud Academy | C# File Analytics Console App

> Project Type: Console application

## Overview
This is a C# console project that reads numeric values from a text file, calculates sum and average, and writes the results to JSON.

## What We Did
- Implemented a `MyFile` class to read from [Numbers.txt](Numbers.txt).
- Added calculation methods for sum and average.
- Printed results to console and generated [result.json](result.json).
- Wired the flow in [Program.cs](Program.cs).

## What I Learned
- How to use file I/O in C# (`File.ReadAllText`, `File.ReadAllLines`, `File.WriteAllText`).
- How to parse numeric input safely using `double.TryParse`.
- How to serialize output using `System.Text.Json`.
- How to split logic into methods and reusable class design.

## Tech Stack
- C#
- .NET 10
- System.Text.Json

## Run Locally
```bash
dotnet run
```
