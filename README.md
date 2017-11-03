
<h1>Repository Content</h1>


<h1>I.<a href="http://www.introprogramming.info/">Fundamentals of Computer Programming with C#, S. Nakov</a></h1>

<h2>Chapter 1</h2>

1. Install [Visual Studio][4] and [MSDN Library Documentation][5].<br>
2. Describe the class [`System.Console`](https://msdn.microsoft.com/en-us/library/system.console%28v=vs.110%29.aspx?f=255&MSPPError=-2147217396). 
3. Describe the method  [`System.Console.WriteLine()`](https://msdn.microsoft.com/en-us/library/system.console.writeline(v=vs.110).aspx). 
4. Compile and run a program using the Command Line Interface. 
5. "Добър Ден!". 
6. First and last name. 
7. Print `1, 101, 1001`. 
8. Print date and time. 
9. Square root of `12345`. 
10. Write the first 100 terms of the sequence `2, -3, 4 , -5, 6 , -7, 8...`.
11. Read age and print age after 10 years. 
12. Differences between `C#` and `.NET Framework`. 
13. Compile a list of the most famous program languages; their differences from `C#`. 
14. Decompile Exercise 5 . <sup> Use [ILSpy-2.3.1 - Decompiler](http://ilspy.net/)</sup>

<h2>Chapter 2</h2>

1. Match values with appropriate types.
2. Witch of the values could be assigned to `float`, `double` and `decimal`.
3. Calculate with _precision_ up to the sixth digit after the decimal point.
4. Initialize an `int` with the _hexadecimal_ value `256`.
5. Initialize a `char` with the symbol with _Unicode_ value `72`.
6. Define a variable of type `bool` named `isMale` and initialize it properly.
7. Define two `string`s, concatenate them and assign the result to variable of type `object`.
8. Define two `string`s, concatenate them and assign the result to variable of type `object`; Initialize a `string` with the value held in the variable of type `object`.
9. Use _escape sequences_ or _@-quoted strings_ to declare a `string` containing `"` or `\`.
10. Print _a shape of heart_ using the symbol `o`.
11. Print _an isosceles triangle_ using the symbol © (copyright).
12. Company employees first-, last- name, gender and ID. 
13. _Swap_ tha values of two `int`variables.

<h2>Chapter 3</h2>

1. Check whether a number is _odd or even_.
2. Check if a number is _perfectly divisble_ by `5` and `7`.
3. Is the 3rd least significant digit is `7`. 
4. Is the 3rd bit of a number `0` ro `1`. <sup>MSB enumeration from right to left [LSB](https://en.wikipedia.org/wiki/Least_significant_bit)</sup>
5. _Area_ of a trapezium from given `a`, `b` and `h`.
6. _Area and circumference_ of a rectangle from given length and height.
7. Calculate the weight of an human on the Moon, given his weight on Earth.
8. Check if a _point is within_ a given circle.
9. Check if a _point is within_ a given circel and out of a rectangle.
10. Number's digits manipulation: sum, reversed digits, swap first/second and last/third. 
11. Print the bit on position `p` in the number `n`.
12. Given a number `n`, check if the bit on position `p` has a value `v = 1`.
13. Given a number `n`, a position `p` and a bit value `v`. Write a program that sets the bit at position `p` to value `v` in number `n`.
14. Check if a number is _prime_.
15. _Swap_ the bits at positions 3, 4 , 5 with those at positions 24, 25, 26.
16. _Swap_ `k` number of bits starting a position `p` with `k` number of bits starting at position `q`.

<h2>Chapter 4</h2>

1. Read<sup>1</sup> three `int`s from the console and print their values. <sup>1. "Read"/"Write" to/from Standard Input/Output.</sup>
2. Read a radius of circle , `r`, and print its area and circumference.
3. Read and print company data: name, address, phone number, FAX, website and manager (first-, last- name and phone number).
4. _Output formatting_: print three columns of numbers with: width = 10, left aligned, first column: hexadecimal , second column: positive floating point, negative floating point. The last two columns to be rounded up to the 2nd digit after the decimal point.
5. Find perfectly divisible to `5` numbers within `[a,b]`, where `a` and `b` read from console.
6. Read two numbers, print the largest without the use of conditional epxressions.
7. Read five numbers and print the largest of them.
8. Read five numbers and print their sum. (Check input validity).
9. Find the real roots of the _quadratic equation_, read the coefficients `a`, `b`, `c` from the console.
10. Sum `n` numbers, read them from console.
11. Read a number `n`, print all the numbers within `[1, n]` on a new line.
12. Print the first 100 terms of _Fibonacci sequence_.
13. Accumulate the first 1000 terms of the `Harmonic Series`.

<h2>Chapter 5</h2>

1. Write an `if` construction such that it _swaps_ the values of two variables if the first is larger than the second.
2. Print the sign (`+` , `-`) of the product of thee numbers without actually calculating it. (Use `if` statements)
3. _Find the largest_ value among the values of three numbers.
4. _Sort_ three real integers in descending oreder using nested `if` statements.
5. Read an integer `[0,9]` and print its name in Bulgarian.
6. Print the roots (0 ,1 or 2 real roots) of the _quadratic equation_.
7. _Find the largest_ among 5 integers.
8. Define variables of type `int`, `double` and `string`. Depending on their type, increment the value if the type is within the first two, append `*` if it is the last; print them. (Use `switch` statement)
9. Given five `int` values, find all subsets (if existent) that sum up to `0`.
10. Appy the following rules for the number, `n` (within [1,9]) read from the console: if `n` in: [1,3] -> `n * 10` ; [4,6] -> `n * 100`; [7,9] -> `n * 1000`.
11. Read a number `n` within [0,999] and print its name in _Bulgarian language_.

<h2>Chapter 6</h2>

1. Read a number `n`. Print the numbers from `1` to `n`.
2. Read a number `n`. Print all the numbers within [1, n] not divisible by `3` and `7`.
3. Read a sequence of integers. Print the numbers with _min_ and _max_ values.
4. Print all the possible _playing cards_. (52 in total, 4 colours and 13 ranks)
5. Read a number `n`. Print the first `n` terms of the _Fibonacci sequence_.
6. Read `n` and `k`. Print `n! / k!`, where `1 < k < n`.
7. Read `n` and `k`. Print `n! * k! / (n - k)!`, where `1 < k < n`.
8. Read `n` and calculate the nth _Catalan number_.
9. Read `n` and `x`. Calculate the first `n` terms of the series `n! / x^n`.
10. Read `n`, where `n < 20` and print a _matrix_ where each next row contains the incremented values of the above, starting with `1,2,...n`.
11. Calculate the number of trailing zeroes of a factorial of a given value `n`.
12. Convert a number from _decimal_ to _binary_ representation.
13. Convert a number from _binary_ to _decimal_ representation.
14. Convert a number from _decimal_ to _hexadecimal_ representation.
15. Convert a number from _hexadecimal_ to _decimal_ representation.
16. Read `n`, print the numbers within [1,n] in random order.
17. Read `a` and `b`. Find the _greatest common divisor_ of `a` and `b`.
18. Read `n`. Print _n x n matrix_ with values increasing in a clockwise inward pattern, starting from element with _matrix index_ _00_ and value `1`.

<h2>Chapter 7</h2>

1. Define and print an `int` array of size `20` with elements initialized to values equal to their index multiplied by `5`.
2. Read two arrays and check if they are identical.
3. Compare two `char` arrays _lexicographically_.
4. Find the longest subarray of adjacent elements with _identical values_.
5. Find the longest subarray of adjacent elements with _increasing values_.
6. Find the longest subarray (with the smallest indexes) of _consecutive elements with increasing values_. 
7. Read `n` and `k`. Read `n` elements to populate an `int` array. Find `k` adjacent elements with _max sum_.
8. Implement _selection sort_ algorithm that sorts an `int` array in increasing order.
9. Find the `int` subarray with _max sum_.
10. Find _mode_ of `int` array .
11. Read `sum`. Find whether there is a subarray of elements that sum up to `sum`.
12. Read `n`. Print _n x n matrix_ with values increasing in different patterns (in terms of the indexes of the matrix elements).
13. Read `n` and `m`. Define a _n x m matrix_ and populate its elements. Find a `3 x 3` _submatrix_ with maximum sum of its elements.
14. Find longest sequence (horizontal, vertical, diagonal) of identical `string`s within a 2D `string` array.
15. Read a word and print the indexes of its letters, where the letters of the English alphabet are within [0,25].
16. Implement _binary search_ for `int` array. 
17. Implement _merge sort_ for `int` array. 
18. Implement _quick sort_ for `int` array. 
19. Find _primes_ within [1, 10000000].
20. Check if an `int` array of `n` elements contains a subarray with elements that sum up to `s`.
21. Check if an `int` array of `n` elements contains a subarray with `k` elements that sum up to `s`.
22. Read `n` elements to populate an `int` array; remove minimal number of elements such that the array is sorted in ascending order. 
23. Print all _permutations_ of ` n` elements.
24. Print all `k` _variations_  of `n` elements. <sub>(no repetition)</sub>
25. Print all  `k` _combinations_ of `n` elements. <sub>(no repetition)</sub>
26. Go through _matrix_ elements in specific pattern: in parallel/perpendicularly to the main diagonal starting from the bottom.
27. Find the largest region of horizontally or vertically adjacent elements with equal values within a 2D `int` _matrix_.

<h2>Chapter 8</h2>

1. Convert `int` and `float` numbers into _binary_ strings.  
2. Convert a _binary_ string to _hexadecimal_ and _decimal_.
3. Convert _hexadecimal_ to _decimal_ and _binary_.
4. Convert _decimal_ to _binary_.
5. Convert _binary_ to _decimal_. 
6. Convert _decimal_ to _hexadecimal_.
7. Convert _hexadecimal_ to _decimal_.
8. Convert _hexadecimal_ to _binary_.
9. Convert _binary_ to _hexadecimal_.
10. Convert _binary_ to _decimal_ using Horner's method.
11. Convert _Roman numeral_ to _Arabic_.
12. Convert _Arabic numeral_ to _Roman_.
13. Given `N, S` and `D`, where `2 <= S` and `16 >= D`. Convert number `N` from base `S` to base `D`.
14. Store `0.000001` in `float`, `double` and `decimal` and sum it `50000000` times. Observe _rounding error_ and _execution time_.
15. Extract _sign_, _exponent_ and _mantissa_ of `float` number.

<h2>Chapter 9</h2>
 
 <sup>From now on, it is implied that all the tasks must be implemented via methods.</sup>
 1. Print a greeting by name read from standard input. Create a [_Unit Test_](https://msdn.microsoft.com/en-us/library/hh694602.aspx) for the implemented method.
 2. Implement `GetMax(int a, int b)` returning the largest of the two input parameters. 
 3. Return the English name of the last digit of a number.
 4. Read an number `n`. Check how many times `n` occures in an integer array. Write a test unit for the method.
 5. Read an index `n`. Check if an element with index `n` is smaller- or greater- than its two adjacent. Write a test unit.
 6. Find the first array element larger than its two adjacent.
 7. Reverse integer digits. 
 8. _Sum large integers_ represented as arrays, using Little-Endian representation.
 9. Write a method that finds _element with max value_ in subarray. Use the method to _sort an array_ in ascending / descending order.
 10. Calculate `n!`, where `1 < n <= 100`. Use [`BigInteger`](https://msdn.microsoft.com/en-us/library/system.numerics.biginteger(v=vs.110).aspx) or array representaion.
 11. Implement a program that contains a menu prompting the use to: reverses integer digits, calculates _arithmetic mean_, finds the _root of the linear eqation_. Checks input validity for the three cases. 
 12. _Sum polynomials_.
 13. _Multiply polynomials_. 
 
<h2>Chapter 10</h2>

1.


<h2>II.<a href="https://softuni.bg/trainings/1336/programming-basics-march-2016">Homework</a></h2>
 
<h2>1. First steps in Coding</h2>
 
1. Print _"Hello C#"_.
2. Simple Algebraic Expression.
3. _GUI application_: simple summator.
4. _Web application_: simple summator.
5. Print the numbers from `1` to `20`, each on a new line.
6. _Print a right-angle triangle_ using the symbol `*`.
7. Read base `a` and height `b`, calculate the _area of rectangle_.
8. Read side length `N`, _print a square_ of asterisks with side lenght `N`.
 
<h2>2. Simple calculations</h2>

1. Visual Studio _blank solution_. Collect projects related to different exercises under common solution.
2. Square _area_.
3. Inch to centimeter _unit converter_.
4. Greetings by personal name.
5. Text and character _concatenation_.
6. Trapezium _area_.
7. Circle _area_ and _perimeter_.
8. Rectangle _area_.
9. _GUI application_ BGN to EUR _currency converter_.
10. Triangle _area_.
11. Celsius to Fahrenheit _degrees converter_.
12. Degrees to radians _angle units converter_.
13. _GUI application_ USD to BGN _currency converter_.
14. Multiple currency converter.
15. _Astronomical date_ manipulation.
16. _GUI application_ push a button appearing on random location.
17. Number of classroom seats.
  
<h2>3. Simple conditions</h2>

 1. Area of figures.
 2. Bonus score.
 3. Cheap transport.
 4. _GUI_ Currency converter.
 5. Equal words.
 6. Even or odd.
 7. Excellent or not.
 8. Excellent result.
 9. Greater number.
 10. Metric converter.
 11. Number from 1 to 100 to text.
 12. Numbers from 100 to 200.
 13. Number to text.
 14. Password guess.
 15. Simple conditions.
 16. Speed info.
 17. Sum seconds.
 18. Swimming pool pipes.
 19. Three equal numbers.
 20. Time in 15 minutes.

<h2>4. Complex conditions</h2>

 1. Cinema.
 2. Fruit or Vegetable.
 3. Fruit shop.
 4. Invalid Number.
 5. On time for the Exam.
 6. Personal Title.
 7. _GUI_ Point and Rectangle.
 8. Point in Rectangle.
 9. Point in the figure.
 10. Point on Rectangle border.
 11. Small shop.
 12. Trade comission.
 13. Volleyball.
 14. Voyage.

<h2>5. Loops</h2>

 1. Equal Pairs.
 2. Half Sum Element.
 3. Histogram.
 4. Latin Letters.
 5. Left and Right Sum.
 6. Max Number.
 7. Min Number.
 8. Numbers 1 to 100.
 9. Numbers ending in 7.
 10. Odd - Even Position.
 11. Odd - Even sum.
 12. Perfect division.
 13. Sum numbers.
 14. GUI Turtle Graphics.
 15. Vowels Sum.
 
<h2>6. Drawing with Loops</h2>

 1. Butterfly.
 2. Christmas Tree.
 3. Diamond.
 4. Draw fort.
 5. House.
 6. Triangle with dollars.
 7. Rectangle of 10 by 10 Stars.
 8. Rectangle of N by N stars.
 9. Rhombus stars.
 10. Square of stars.
 11. Sunglasses.
 12. _Web Application_ Rattings.
 
<h2>7. Advanced Loops</h2>

 1. Check prime.
 2. Enter even number.
 3. Even powers of `2`.
 4. Factorial.
 5. Fibonacci.
 6. _Web app_ Fruits web game.
 7. Greatest common divisor.
 8. Number pyramid.
 9. Numbers from 1 to N with step 3.
 10. Numbers in range.
 11. Numbers from N to 1.
 12. Number table.
 13. Powers of `2`.
 14. Sequence of `2k + 1`.
 15. Sum digits.
 16. Magic numbers.
 17. Stupid password generator.

---

<h1>III.<a href="https://judge.softuni.bg/Contests#!/List/ByCategory/1/Programming-Basics">Exam Practice.</a></h1>

<h2>Exam date: 12.04.2014</h2>

<h3>1. Morning</h3>

1. Triangle.
2. Pairs.
3. House.
4. Magic Dates.
5. Bits Killer.

<h3>2. Evening</h3>

<h2>Exam date: 14.04.2014</h2>

<h3>1. Morning</h3>

1. Fruit Market.
2. Biggest triple.
3. Wine Glass.
4. Longest Alphabetical Word.
5. Bit Shooter.
 
<h3>2. Evening</h3>

1. Inside The Building.
2. Student Cables.
3. Programmer DNA.
4. Magic Car Numbers.
5. Bit flipper.

<h2>Exam date: 29.03.2015</h2>

<h3>1. Morning</h3>

 1. Torrent Pirate.
 2. Basket Battle.
 3. Dumbbell.
 4. Encrypted Matrix.
 5. Game of Bits.

<h3>1. Evening</h3>

 1. Array Matcher.
 2. Currency Check.
 3. Dream Item.
 4. Knight Path.
 5. Magic Wand.

<h2>Exam date: 17.03.2016</h2>

 1. Beer Stock.
 2. Cake Tycoon.
 3. Emergency Repairs.
 4. Illuminati Lock.
 5. Master Herbalist.

---

 


---
<sub>
Remarks:<br>
No enumeration of the (sub)chapter contents, e.g 3.1; 3.2<br>
Page 265, Proposed Solution to Exercise 15: upper case / lower case ? `(int) ch - (int) 'A'`, `(int) ch - (int) 'a'`.<br>
Errata:<br>
Page 260-1, Exercise 14 : Matrix rows next to each other and on next page.<br>
Page 262, Exercise 26 : Firtst row of right matrix appended at the bottom of the left.<br>
Page 330, Triangles with different size: all but two lines from the triangle on the rhs of the picture indented.<br>
The word "съответно" in Chapter 9 appears a lot.
</sub>

---

OS: Windows 10<br>
IDE: Visual Studio 2015

---

[1]: https://softuni.bg/trainings/1297/programming-basics-january-2016
[4]: https://www.visualstudio.com/
[5]: https://msdn.microsoft.com/en-us/library/ms123401.aspx

