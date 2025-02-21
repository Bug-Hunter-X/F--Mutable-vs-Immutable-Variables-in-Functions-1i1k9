# F# Mutable vs Immutable Variables in Functions
This example demonstrates the difference between mutable and immutable variables in F# functions.  The `swap` function uses mutable variables, while `swap2` attempts to use the same logic with immutable variables, resulting in a compilation error.

**bug.fs** contains the code that shows the error.

**bugSolution.fs** contains corrected code that uses tuples to achieve the desired result with immutable variables.