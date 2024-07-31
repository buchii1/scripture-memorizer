# Scripture Memorizer Program

## Overview

The Scripture Memorizer Program is designed to assist users in memorizing scriptures effectively. This program offers multiple ways to access scriptures, including selecting a random scripture, choosing from a predefined library, or fetching a scripture using an external API. To facilitate the memorization process, the program progressively hides words from the scripture text each time the user presses enter, allowing them to recall and reinforce their memory.

## Features

The Scripture Memorizer Program includes the following features:

1. **Display a Random Scripture**:
   - Selects and displays a random scripture from a predefined library of scriptures.

2. **Select a Scripture from the Library**:
   - Allows the user to browse and choose a scripture from a predefined list.

3. **Fetch a Scripture from an External API**:
   - Prompts the user to enter a scripture reference.
   - Retrieves and displays the scripture text from an external API based on the provided reference.

4. **Progressive Word Hiding**:
   - Initially displays the full scripture text.
   - Hides a few words each time the user presses enter, gradually increasing the difficulty.
   - Continues hiding words until the entire text is hidden or the user chooses to stop.

5. **Display the Scripture with Reference**:
   - Shows the complete scripture text along with its reference, helping users to remember the context and source of the scripture.

## Design
The design of the Scripture Memorizer Program emphasizes simplicity and usability. Encapsulation is achieved by encapsulating the major functionalities within separate classes for clear separation of concerns. Each class has a specific responsibility and interacts with other classes through well-defined interfaces. This modular approach ensures maintainable and scalable code.

 Here’s how encapsulation is demonstrated in the program:
- **Scripture Class:** Manages individual scripture data and methods.
  
- **ScriptureReferenceClass:** Handles the process of displaying scripture reference in a predefined format.

- **ScriptureLibrary Class:** Handles collections of predefined scriptures.

- **ScriptureFetcher Class:** Manages API interactions for fetching scriptures.

- **WordHider Class:** Controls the progressive hiding of words in scripture text.

- **UserInterface Class:** Manages user interactions and menu display.

## How to Run the Program

1. **Clone the Repository**:
   - Open a terminal or command prompt.
   - Navigate to the directory where you want to clone the repository.
   - Run the following command to clone the repository:
     ```sh
     git clone https://github.com/buchii1/scripture-memorizer.git
     ```

2. **Build the Project**:
   - Open your preferred C# development environment (such as Visual Studio or Visual Studio Code).
   - Open the cloned repository folder in your development environment.
   - Ensure that you have .NET 8 installed. If not, download and install it from the [official .NET website](https://dotnet.microsoft.com/download/dotnet/8.0).
   - Build the project by selecting `Build` > `Build Solution` in Visual Studio or by running the following command in the terminal:
     ```sh
     dotnet build
     ```
   - This step will restore any dependencies and compile the project.

3. **Run the Program**:
   - In your development environment, set the `Program.cs` file as the startup file if it is not already set.
   - Run the program by selecting `Debug` > `Start Debugging` in Visual Studio or by running the following command in the terminal:
     ```sh
     dotnet run
     ```
   - Follow the on-screen instructions to interact with the menu, display scriptures, and progressively hide words for memorization.

## Contact

For any questions or support, please contact [okonkwogodspower@yahoo.com](mailto:okonkwogodspower@yahoo.com).