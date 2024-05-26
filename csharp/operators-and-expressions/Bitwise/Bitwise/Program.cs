/*** Bitwise operators ***/
// 1. And (`&`)
int a = 5; // 0101
int b = 3; // 0011
int result_and = a & b; // 0001 in binary, which is 1 in decimal

Console.WriteLine(result_and); // Output: 1

// 2. Or (`|`)
int a2 = 5; // 0101
int b2 = 3; // 0011
int result_or = a2 | b2; // 0111 in binary, which is 7 is decimal 

Console.WriteLine(result_or); // Output: 7

// 3. Xor (`^`)
int a3 = 5; // 0101
int b3 = 3; // 0011
int result_xor = a3 ^ b3; // 0110 in binary, which is 6 in decimal
Console.WriteLine(result_xor); // Output: 6

// 4. Not (`~`)
int a4 = 5; // 0101
int result_not = ~a4;
Console.WriteLine(result_not); // Output: -6

// 5. Left shift (`<<`)
int a5 = 5; // 0101
int result_left_shift = a5 << 1; // 1010
Console.WriteLine(result_left_shift); // Output: 10

// 6. Right shift (`>>`)
int reusult_right_shift = a5 >> 1;
Console.WriteLine(reusult_right_shift); // Output: 2