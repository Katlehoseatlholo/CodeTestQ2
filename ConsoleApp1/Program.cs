#include <stdio.h>
#include <stdlib.h>

typedef struct Node {
    TypeTag type;
    int value; // For storing the Fibonacci value
} Node;

typedef enum TypeTag {
    ADD,
    SUB,
    MUL,
    DIV,
    FIBO
} TypeTag;

// Function to create a new Node
Node* createNode(TypeTag type) {
    Node* newNode = (Node*)malloc(sizeof(Node));
    newNode->type = type;
    newNode->value = 0; // Initialize the value to 0
    return newNode;
}

// Function to calculate the Fibonacci value using dynamic programming
int fibonacci(int n) {
    int fib[n + 1];
    fib[0] = 0;
    fib[1] = 1;

    for (int i = 2; i <= n; i++) {
        fib[i] = fib[i - 1] + fib[i - 2];
    }

    return fib[n];
}

// Function to perform arithmetic operations on Nodes
void calc(Node* node) {
    if (node->type == ADD) {
        node->value = node->value1 + node->value2;
        printf("add: %d\n", node->value);
    } else if (node->type == SUB) {
        node->value = node->value1 - node->value2;
        printf("sub: %d\n", node->value);
    } else if (node->type == MUL) {
        node->value = node->value1 * node->value2;
        printf("mul: %d\n", node->value);
    } else if (node->type == DIV) {
        if (node->value2 != 0)
            node->value = node->value1 / node->value2;
        else
            printf("Error: Division by zero\n");
    } else if (node->type == FIBO) {
        node->value = fibonacci(node->value1);
        printf("fibo: %d\n", node->value);
    }
}

int main() {
    Node* add = createNode(ADD);
    add->value1 = 10;
    add->value2 = 6;

    Node* mul = createNode(MUL);
    mul->value1 = 5;
    mul->value2 = 4;

    Node* sub = createNode(SUB);
    sub->value1 = mul->value;
    sub->value2 = add->value;

    Node* fibo = createNode(FIBO);
    fibo->value1 = sub->value;
    fibo->value2 = 0; // Not used in Fibonacci calculation

    calc(add);
    calc(mul);
    calc(sub);
    calc(fibo);

    return 0;
}
