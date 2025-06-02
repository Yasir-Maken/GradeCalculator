# The Honest Student Grade Calculator! 🍎

Hey there, future scholar! 👋 Welcome to the repository for the "Honest Student Grade Calculator." This isn't your average, stuffy grading system. Nope! This one gives you your grade with a sprinkle of humor and a dash of reality.

## What This Code Does 📝

This program acts like a wise (and slightly cheeky) grading oracle. You tell it your score on a test or assignment (out of 100) and your attendance percentage (also out of 100), and it will reveal your final grade along with a little commentary on your academic performance.

Here's the breakdown:

* **Input Validation:** First things first, it checks if you're trying to sneak in an impossible score or attendance (like -5 or 150). If so, it'll politely tell you to stick to the 0-100 range.
* **Grading Logic:** It then uses a set of rules to determine your grade based on both your score and how often you showed up:
    * **A:** You nailed it and were a consistent presence! You're a superstar.
    * **B:** Great job! You're doing well, keep that momentum going.
    * **C:** Not bad at all! You're in the middle of the pack, like a cat skillfully balanced on a curtain.
    * **D:** You barely made it! Maybe set a few extra alarms for those early classes?
    * **Incomplete:** Your brain might have been there (judging by the score), but your physical attendance was lacking. Time for a chat with the instructor!
    * **F:** Uh oh! Either the learning material didn't quite stick, or those classes were just too tempting to skip. Time to hit the books (and maybe those alarms!).
* **Humorous Feedback:** The grades come with a little extra flavor to lighten the mood (even if it's an F!).

## How to Run This Code 🚀

To get your grade revealed by this honest oracle, make sure you have .NET 6 or a later version installed on your machine. Then follow these steps:

1.  **Save the Code:** Save the provided C# code as a file named `Program.cs` in a folder (for example, `GradeCalculator`).

2.  **Open Your Terminal or Command Prompt:** Open your terminal (on Linux/macOS) or command prompt (on Windows) and navigate to the `GradeCalculator` folder. Use the `cd` command:

    ```bash
    cd GradeCalculator
    ```

3.  **Summon the Oracle!** Type the following command and press Enter:

    ```bash
    dotnet run
    ```

4.  **Answer Honestly!** The program will then ask you to enter your score and your attendance percentage. Type in the numbers and press Enter after each one.

5.  **Behold Your Fate!** The oracle will then reveal your final grade with a personalized (and hopefully slightly amusing) message.

6.  **Ponder Your Progress:** Press any key to exit the application and contemplate your academic journey.

## A Peek Behind the Curtain 👀

Here's a quick look at the code's inner workings:

* **`public static string CalculateGrade(int score, int attendance)`:** This is the main function that takes your score and attendance as input and uses a series of `if-else if` statements to determine your grade based on the defined rules. It also includes the witty feedback messages.
* **Input Validation:** The first `if` statement in `CalculateGrade` ensures that the score and attendance are within the valid range of 0 to 100.
* **Grading Logic:** The subsequent `if-else if` blocks implement the specific grading criteria, taking both score and attendance into account.
* **`public static void Main(string[] args)`:** This is where the program starts running. It welcomes you, prompts you to enter your score and attendance, calls the `CalculateGrade` function, and then displays the result.
* **Input Handling (`Console.ReadLine()`, `int.TryParse()`):** The code uses these to get your input from the console and safely convert it into numbers. This helps prevent crashes if you accidentally type letters.
* **Error Handling (`try-catch`):** The `try-catch` block is there to gracefully handle any unexpected errors that might occur (like if you try to enter your essay instead of a number!).
* **Output (`Console.WriteLine()`):** This is used to display messages and your final grade on the screen.

## Go Ahead, Get Your Grade! 🎓

Use this honest calculator to see where you stand! Just remember, while the feedback might be a bit cheeky, the grading logic is (mostly) serious. Good luck with your studies! 😉
