# Calculator
Simple calculator to practice Test-Driven Development (TDD).

##### Step 1: Add 'Divide' Method with TDD
- Write a new unit test which divides two decimal numbers and returns the result.
- Run the unit test: It fails.
- Complete the new Division method and run the unit test again. It should pass if everything is correct.
- Refactor the code if necessary, cleanup, comment, do code review, etc...

##### Step 2: Implement a Math Text Parser
- Write tests for a text parser which can handle simple mathematic terms, like "1 + 2" or "2.5 / 0".
- Write productive code for such a text parser: Use xUnit [Theory] to feed sets of test data into test cases.


##### Step 3: Calculator Console App
- After all: Create a console app which uses the math parser and the calculator. The console app should read user text input, pass it to the parser, the parser forwards its results to the calculator, the calculator returns the result to the console.
