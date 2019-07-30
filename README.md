# WordCounter

#### _program that gathers both a word and sentence from a user, then checks how frequently the word appears in the sentence. It should check for full word matches only. (For instance, if provided the word "cat" and sentence "I'm walking to the cathedral." the first three letters of the word cathedral would not be counted.) Also, do not use regular expressions in your logic. - 7/26/2019_

#### _By **Maryana Antonyuk**_

## Description

DETAILED DESCRIPTION

### Specs
| Spec | Input | Output |
| :-------------     | :------------- | :------------- |
| 1.When a user enter a word and another same word the program shows "1" | "cat", "cat" | "1" |
| 2.When a user enter a word and another same two or more words the program shows number of words | "cat", "cat, cat" | "2" |
| 3.When a user enter a word and another word that is a part of entered word the program shows "0" | "cat", "cathedral" | "0" |
| 4.A program will accept both lower case and uppercase matches|"cat", "Cat,Cat" | "2" |
| 5.When a user enter numeric or non-alpha characters, a program display "Please enter letters only" | "123", "cat" | "Please enter letters only" |

## Setup/Installation Requirements

1. Clone this repository:
    ```
    $ git clone REPO URL HERE
    ```
2. Run the application
    ```
    $ dotnet run
    ```

## Known Bugs
* No known bugs at this time.

## Technologies Used
* C# / .NET

## Support and contact details

_Please contact Maryana Antonyuk with questions and comments._

### License

*GNU GPLv3*

Copyright (c) 2019 **_Maryana Antonyuk_**
