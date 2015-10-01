# InClass 2 - Recursion and Git Branching

## Author

Brandon Rodriguez

## Description

Using recursion to solve problems.

* Factorials: User can input a number (up to 30) to solve. Output to console.
* Towers of Hanoi: Three towers are generated. The first tower will have a number of disks equal to a number the user enters (preferably 5 or lower). The program then transfers all disks over to the third tower, without ever putting a bigger disk ontop of a smaller one. Every disk move is output to console.

### Notes



## Outside Resources Used

http://stackoverflow.com/questions/5449956/how-to-add-a-delay-for-a-2-or-3-seconds
https://msdn.microsoft.com/en-us/library/hh194873%28v=vs.110%29.aspx
* Used to figure out how to add a delay to console output. Prior to the delay, the program would solve itself way too fast for the user to follow.

## Known Problems, Issues, And/Or Errors in the Program

* Had to hardcode 30 as the upper-max for factorials. Higher than that would stack overflow or display 0 as the answer (probably was just surpassing the number of digits an int could hold).
* Towers works with more than 5 disks. However, display gets wonky, due to using console as the output (can only hold so many characters per line). Probably would just need to use a non-console UI to fix.
