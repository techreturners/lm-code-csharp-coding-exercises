# Exercise 001

This set of C# challenges introduce exercises for working with the C# syntax.

It includes:

-   Methods, variable definitions and data types
-   Conditionals
-   Looping
-   Initial review of C# objects

In the [Exercise001Test.cs](../Exercises.Tests/Exercise001Tests.cs) file you'll find the tests - work through each test and implement the corresponding function within the [Exercise001.cs](../Exercises/Exercise001.cs) file.

Don't forget to restore dependencies by running:

```csharp
dotnet restore
```

You can run your tests by running the following command:

```csharp
dotnet test
```

Work through each test 1 by 1 until you have them all passing. Initially, you'll have a lot of failing tests and a lot of output on the console. To focus on a single test, you can run specific tests such as:

```csharp
dotnet test --filter Exercise001
```

Or to run a single test within a test file you can run dotnet test --filter FunctionName like so:

```csharp
dotnet test --filter CapitalizeWord
```

Happy coding!

## Extra Challenge

In the `AddVAT` function you can see that there's an extra challenge available. If you look in the `Exercise001Tests.cs` file you will find one test with the lines commented out.

👉 Uncomment these lines and make this test pass too.

## Once you're done

Time to move onto [the instructions for Exercise002](./Exercise002.md).
