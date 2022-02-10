# Instructions

## The Task

This repository contains a tiny fragment of a real-life project. We have changed class and interface names to protect the innocent. The code is in C# using .NET 6.0.

You have been asked to have a look at class `LegacyCalculator` and find ways for how its implementation could be improved. You are given a time box of 1 hour. This timeframe is just provided to give you an indication. You can spend as much time on it as you like.

To get started, create a fork of this repository in your Github account which we can then use for the technical interview. Once you have completed the task, just send a link to your fork. Your fork needs to be a public git repository.

To be clear: There is no right or wrong answer. You won't find the solution for this task using Google. The key goal is to improve the class `LegacyCalculator` and/or the tests in class `LegacyCalculatorTests`.

In the technical interview we will discuss the improvements that you have identified and implemented. Make sure that all test pass at all times, e.g. by running `dotnet test` in the folder containing the solution file.

## Some Suggestions

To improve the code in this repo, you can draw from your experience with previous projects. You can also consider some of the following items:

- Are there code duplicates that can be removed?
- Have all identifiers suitable names?
- Are there enough and the right type of tests?
- How could testability be improved?
- Would it make sense to consider a mock?
- To run the test suite consider running "dotnet test" at the root of the repository

You are free to add more nuget packages if you think they add value. However, stay focused on the task when making this choice.

Note: if you are considering to add a console project to the solution to run the tests, then you are on the wrong track.

## Prerequisites

To work on this task you can use any IDE that supports C#. You will need a recent .NET 6.0 SDK installed on your computer.

Free IDEs include:
- VS Code with suitable extensions for .NET / C# (most recent stable release)
- Visual Studio Community Edition (most recent stable release)

## Other Files in Repository

This repository also has files related to a dev container. These files are located in folder `.devcontainer`. You are welcome to use the dev container if you like. 

If you are not familiar with dev containers, you can safely ignore the content of the folder `.devcontainer`. Whether you use the dev container or not has no impact on the outcome of the technical assessment.
