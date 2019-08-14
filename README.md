# ToH
 Solving Towers of Hanoi game using uninformed search.\
 Path Cost = 2<sup>n</sup> - 1\
 Number of states = 3<sup>n</sup> where **`n`** is the number of disks.

|Initial State|Successor Function|
|---|---|
|![initial state 111](./images/111.PNG)|![move top near right](./images/211.PNG)![move top far right](./images/311.PNG)|
|![initial state 231](./images/231.PNG)|![331](./images/331.PNG)![131](./images/131.PNG)![211](./images/211.PNG)|
|**Goal Test**|![Goal Test](./images/333.PNG)|
## Actions
|Direction|Near|Far|
|---|---|---|
|**To right**|![near right](./images/rn.png)|![far right](./images/rf.png)|
|**To lift**|![near lift](./images/ln.png)|![far lift](./images/lf.png)|

## States Tree in Depth 2
![States Tree in Depth 2](./images/treeDepth2.PNG)

This solution is ispired by Dr. Sara El-Sayed El-Metwally [blog posts](http://sara-elmetwally.blogspot.com.eg/) about AI.
### References
- [Article - Assistant Prof. Sara El-Sayed El-Metwally, AI- Simple Implementation of Uninformed Search Strategies](https://www.codeproject.com/Articles/203828/AI-Simple-Implementation-of-Uninformed-Search-Stra)
- [CS324P - Artificial Intelligence - Assistant Prof. Eslam Foad - Department of Computer science - Faculty of Computers and Information Sciences - Mansoura University]() 
- [Peter Norvig, Stuart J. Russell, “Artificial Intelligence: A Modern Approach”, 3rd Edition, Prentice Hall, 2009.](http://aima.cs.berkeley.edu/)
