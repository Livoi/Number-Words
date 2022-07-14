# Question 2
## Scenario
Create a class library named Exercise01 that defines extension methods that extend number types such
as BigInteger and int with a method named Towards that returns a string describing the number; for
example, 18,000,000 would be eighteen million, and 18,456,002,032,011,000,007 would be eighteen
quintillion, four hundred and fifty-six quadrillion, two trillion, thirty-two billion, eleven million, and
seven

Create a console application names Exercise02 that uses the class library in Exercise01 to take numeric
input from the user and output the string describing the number.


# Test Plan
| Scenario | input | Expected | Result |
| --- | --- | --- | --- |
| Test billion number to words  | 1600000000 | one billion six hundred million | Passed |
| Test million number to words | 1200000 | one million two hundred thousand | passed |
| Test trillion number to words | 13000000000000 | thirteen trillion | passed |
| Test quintillion number to words | 1845600203201100000 | one quintillion eight hundred forty five quadrillion six hundred trillion two hundred three billion two hundred one million one hundred thousand | passed |


**Task Accomplished By Kevin Madiavale**





