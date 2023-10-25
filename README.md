# Introduction
Welcome to this Selenium C# project! This project focuses on learning how to automate web browser interactions using Selenium WebDriver in C# on [Onblick 2.0](https://www.onblick.com/). It aims to provide a foundation for writing automated tests for the Onblick application, performing repetitive tasks, and validating web elements.

# Prerequisites
Before running this project, ensure you have the following prerequisites installed on your system:

- .NET Core SDK
- Visual Studio or Visual Studio Code (optional but recommended, preferably Visual Studio 2022)

# Installation
**Clone this repository to your local machine using the following command**:
_git clone_ https://github.com/ssa2973/SeleniumPracticeSuite/ 

Alternatively, you can clone within your IDE manually with the same [URL](https://github.com/ssa2973/SeleniumPracticeSuite/) without using a git command.

# Configuration
**WebDriver**: This project uses Selenium WebDriver, which requires you to have the appropriate web drivers installed for the browsers you intend to use (e.g., Chrome, Firefox, etc.). Ensure you have the appropriate web drivers. You can download the latest web drivers from the following links: [Chrome](https://chromedriver.chromium.org/downloads), [Firefox](https://github.com/mozilla/geckodriver/releases), [Internet Explorer](https://selenium-release.storage.googleapis.com/index.html?path=3.141/), [Edge](https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/), [Safari](https://developer.apple.com/documentation/webkit/testing_with_webdriver_in_safari), [Opera](https://github.com/operasoftware/operachromiumdriver/releases).

# Folder Structure
The folder structure is subject to change. It is recommended to refer to the latest version of the project for the most up-to-date folder structure. The project's folder structure is organized as follows:

- **Common_Modules**: Contains code organized based on scenarios or test cases for browser interactions.
- **Test Data**: Holds test data or metadata required for running test plans.
- **Test Plans**: Contains test plans written in a step-wise manner for each scenario or test case.

# Naming Convention
We shall follow the following naming conventions for the project:

- **Class Names**: PascalCase
- **Method Names**: PascalCase
- **Variables**: camelCase
- **Test Related Files**: PascalCase
# Usage
To run the project, follow these steps:

- Open the project in Visual Studio (if you haven't already). 
- Build the solution to restore NuGet packages and compile the code. 
- Navigate to the Test directory and locate the test classes. The tests are written using the NUnit framework. You can execute the tests using the test runner in your IDE or run them via the command-line interface using dotnet test.

# Tests
The project includes previous test cases written in the Test directory. You can use these as a reference for writing your own test cases. Make sure to adhere to the best practices for writing maintainable and reliable automated tests.

# Contributing

For version control, git is used. The project follows the [GitFlow](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow) workflow. When contributing, please create a new branch from the `master` branch and submit a pull request to the `master` branch. Always, try to keep your branch up-to-date with the `master` branch. If you have more questions/doubts on how to use git, watch this [video](https://www.youtube.com/watch?v=Uszj_k0DGsg).