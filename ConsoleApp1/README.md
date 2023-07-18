## Fibonacci Sequence with Dynamic Programming - C Implementation

This program demonstrates the calculation of Fibonacci sequence using dynamic programming and arithmetic operations (+, -, *, /) based on the provided `Node` structure. The program performs calculations for addition, multiplication, subtraction, and Fibonacci values.

### How the Program Works

The program follows the given arithmetic operations and conditions defined in the `Node` structure. The `calc` function performs the calculations based on the `type` of the `Node` and stores the result in the `value` field of the `Node` structure. The calculated results are then printed.

The Fibonacci sequence calculation is implemented using dynamic programming, where the values are stored in an array to avoid redundant calculations.

### Code Files

- `fibonacci.c`: The main C source code file that implements the arithmetic operations, dynamic programming for Fibonacci calculation, and the `calc` function.

### How to Run

1. Clone the repository or download the source code file to your local machine.

2. Compile the C program using a C compiler:
   ```shell
   gcc fibonacci.c -o fibonacci
