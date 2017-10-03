Po-Chun Chiu's CSC 254 Assignment 1 Comparing Languages(Combinations) README
  Partner with: Yujie Liu(yliu134)
	Student ID: 29433254
	Email: pchiu4@u.rochester.edu

Languges we choose for the assignment:
Ada, OCaml, C#, Python and Prolog

Extra Credit work:
We also implement Java version of combinations as extra credit work

Assignment Directory: A1
  TAs should be able to find every files under the A1 directory
  The code are all tested using the school cycle1 CSUG machine.
  My default shell is cshell while my partner's default shell is bash.

Ada:
1. Run the file combination.adb using gnatmake
2. Sample command line for running this would be
    gnatmake combination.adb
    ./combination 3 5
    Sample OUTPUT:
    1           2           3
    1           2           4
    1           2           5
    1           3           4
    1           3           5
    1           4           5
    2           3           4
    2           3           5
    2           4           5
    3           4           5
3. Ada is a programming language in which very picky about syntax. The syntax needs to have procedure (like class in java).
4. Before declaring functions, we need to declare all the variables we need before the function declaration.
5. This function takes 4 parameters as input and will print out possible combinations with the for loop and recursion inside the function.
6. begin the main part by initializing k and n from command line argument, and N_Arr with size N and filled with 0.
7. Run the cbn function and set it to Ret, although Ret value is always set to 0(because it's never written/read after firstly assigned)
8. We test the program using k=10 and n=20 as input, and the running time for Ada is about 6 seconds.
9. The easy part for Ada is that it's really english oriented and really imperative, which makes it easier to learn and pick up.
10. However, Ada is really picky about its syntax as I mentioned above.
11. It forces you to write begin and end for procedure and every functions. Also, you have to put end if; for if statement, and have to put end loop; to says a for loop ends. This will cause a lot of compilation errors if we didn't get the syntax correct.

OCaml:
1. Run the file cbn.ml using ocaml
2. Sample command line for running this would be
    ocaml cbn.ml 3 5
    Sample OUTPUT:
    1 2 3
    1 2 4
    1 2 5
    1 3 4
    1 3 5
    1 4 5
    2 3 4
    2 3 5
    2 4 5
    3 4 5
3. OCaml is a functional programming language in which it's style uses a lot of function to define.
4. First define a recursive function named cbn in which it will call itself. It takes k and list as argument. If the list is empty, the match this empty list with [].
5. This function will return list of lists. We separate original list with head and tales, where list1 will prepend head in front of recursion cbn( (k-1) tl). That is, list1 will return all those that contains the head chosen.
6. list2 will use cbn function and return with cbn k tl. At the very end of the function, concatenate list1 with list2.
7. Create two other functions newList and printList so that we can initialize a new list and can print it out later using printList function.
8. Assign k and n by command line arguments and let our answer be cbn k (newList n), where newList is a list of size n.
9. We use OCaml to test k=10 and n=20, and the running time for OCaml is joyfully the fastest, finished in 4 seconds.
10. The easy part for OCaml is that once you understand the idea of how to write functional programming and is good at thinking recursively, then OCaml will be relatively intuitive.
11. However, the idea of writing new functions for newList and printList is harder to do, where the other languages have builtin functions for those. Also, writing a program in OCaml requires strong understanding of recursion and functional programming techniques, in which takes me a while to understand.


C#:
1. Run the file cbn.cs using mcs and mono
2. Sample command line for running this would be
    mcs cbn.cs
    mono cbn.exe 3 5
    Sample OUTPUT:
    1 2 3
    1 2 4
    1 2 5
    1 3 4
    1 3 5
    1 4 5
    2 3 4
    2 3 5
    2 4 5
    3 4 5
3. C# is a really imperative programming language that's similar to java. I use a similar idea that I used in java and modify the syntax for C#.
4. Start the code by determining namespace to use in C#. I use System, System.Collections and System.Collections.Generic. By setting this, I can use the C# library of arrays and lists.
5. My idea for this is to use a function named left to return a List<int> of possible remaining choices that can be chosen. This function takes 4 inputs.
6. Integer prev means the previous selected number, index means what the index of the current choosing number, k and n are the input from command line.
7. cb function is the main function to calculate and print the possible combinations. This function takes in 4 inputs, an int array, integer named current stands for the current position, k and n stand for the user command line input.
8. In the function, if current = k, that means we find all we need for a possible combination, then just print it out using Console.WriteLine
9. Initialize a new list when current is 0, otherwise use left function to find possible remaining numbers we can use.
10. At the very end, use recursion to with current+1 and keep finding the possible solutions.
11. Use int.Parse to get the command line argument for k and n, create an array size of k and pass that into cb function.
12. The idea for this is not too complicated, and the main part of running is the recursion in for loop.
We test the program using k=10 and n=20 , and the run time for C# to run is about 8 seconds.
13. C# is a really imperative language and is really similar to java. It's easier to pick up by having java foundations. I start thinking of the problem with thinking java. Therefore, I feel C# relatively easy for me to think and learn comparing to other languages.


Python:
1. Run the file cbn.py using python3
2. Sample command line for running this would be
    python3 cbn.py 3 5
    Sample OUTPUT:
    1 2 3
    1 2 4
    1 2 5
    1 3 4
    1 3 5
    1 4 5
    2 3 4
    2 3 5
    2 4 5
    3 4 5
3. Python is a programming language that's also imperative. In fact, there are a lot things to be noticed in Python.
4. Python cares about indentation, in fact, all the code in Python is formed using indentation.
5. Also, Python doesn't have to declare types for parameters. That is, there's no declaration for int, array.
6. I imported sys package in order to take in command line argument.
7. The logic for python program is really similar to the one I used in C# and java. The main idea is to use a function "left" to find possible remaining choices using list.
8. Then, use the cb function to find and print possible combinations with for loop and recursion in the cb function.
9. For me, I think the harder part for Python is that we have to adapt ourselves to a language with out specific syntax declarations and be careful of the indentations. This is the harder part for me.
10. However, the easier part for Python is that it's really easy to understand once you get the syntax. The logic and the idea behind it is relatively simple to pick up.
11. Use k=10 and n=20 as command line arguments, python's run time is about 7 seconds.

Prolog:
1. Run the file cbn.pl using swipl
2. Sample command line for running this would be
    swipl cbn.pl , after "[ ?-" type
    cbn(3, 5 ,L).  use 3 and 5 for example argument k and n
    keep typing ;(semicolon) every line until it outputs false
    Sample OUTPUT:
    L = [1, 2, 3] ;
    L = [1, 2, 4] ;
    L = [1, 2, 5] ;
    L = [1, 3, 4] ;
    L = [1, 3, 5] ;
    L = [1, 4, 5] ;
    L = [2, 3, 4] ;
    L = [2, 3, 5] ;
    L = [2, 4, 5] ;
    L = [3, 4, 5] ;
3. The idea of Prolog is that it follows predicate logic, and uses a lot of symbols to determine whether given rules is true or false.
4. aux is the actual rule of cbn, but we named it aux. aux(0, _, []). means that stating the rule is true.
5. In order for aux(K, L, [H | TL]) to be true, we need to have K > 0, assign a new variable K2 that is K-1, sublist(L, H, SL) will find a SL such that SL is a sublist(we defined) of L and doesn't contain H and also satisfies that aux(K2, SL, TL) to be true.
6. cbn(K, N, L) is in fact the aux function in which satisfies numlist(1, N, LIST) and aux(K, LIST, L) to be true.

Extra Credit:
Java:
1. Run the file Comb.java using javac and java
2. Sample command line for running this would be
    javac  Comb.java
    java Comb 3 5
    Sample OUTPUT:
    1 2 3
    1 2 4
    1 2 5
    1 3 4
    1 3 5
    1 4 5
    2 3 4
    2 3 5
    2 4 5
    3 4 5
3. I start everything using java to think of the problem. I think it's easier to think using the most familiar language for me.
4. I build java by using a constructor. The constructor takes in 2 parameters, so that we can uses k and n globally.
5. The code idea in java is similar to python and C#. We use a left function to return an ArrayList of Integer of possible remaining using.
6. A cbn function calculates and print the result.
7. After using java to run command k=10 and n=20, the running time for java is 5 seconds.
8. I feel there's no big hard part for writing java since it's the most familiar language for me, and java's running time is also quite fast.
9. The easy part for java is that java is very imperative and I am also used to java's builtin libraries. Therefore, I can finish java before writing other languages.
