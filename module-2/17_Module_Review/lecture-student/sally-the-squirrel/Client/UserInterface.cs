using SallyClient.ApiClients;
using SallyClient.Data;
using System;
using System.Collections.Generic;

namespace SallyClient
{
    public class UserInterface
    {
        private readonly ConsoleService consoleService = new ConsoleService();
        private readonly QuestionService questionService = new QuestionService();
        private readonly AuthService authService = new AuthService();

        private bool shouldExit = false;

        public void Start()
        {
            while (!shouldExit)
            {
                while (!UserService.IsLoggedIn)
                {
                    ShowLogInMenu();
                }

                // If we got here, then the user is logged in. Go ahead and show the main menu
                ShowMainMenu();
            }
        }

        private void ShowLogInMenu()
        {
            Console.WriteLine("Welcome to Sally the Squirrel's One-Stop Interview Question Shop!");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register");
            Console.Write("Please choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out int loginRegister))
            {
                Console.WriteLine("Invalid input. Please enter only a number.");
            }
            else
            {
                Console.WriteLine();

                switch (loginRegister)
                {
                    case 1:
                        HandleUserLogin();
                        break;
                    case 2:
                        HandleUserRegister();
                        break;
                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }
            }
        }

        private void ShowMainMenu()
        {
            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to Sally's! Please make a selection: ");
                Console.WriteLine();
                Console.WriteLine("1: List all questions");
                Console.WriteLine("2: Get a random question");
                Console.WriteLine("3: Create a new question");
                Console.WriteLine("4: Delete a question");
                Console.WriteLine("5: Log in as different user");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid input. Please enter only a number.");
                }
                else
                {
                    Console.WriteLine();
                    switch (menuSelection)
                    {
                        case 1: // List all questions
                            DisplayAllQuestions();
                            break;
                        case 2: // Get a random question
                            DisplayRandomQuestion();
                            break;
                        case 3: // Create a new question
                            PromptAndAddNewQuestion();
                            break;
                        case 4: // Delete a question
                            PromptAndDeleteQuestionById();
                            break;
                        case 5: // Log out
                            Console.WriteLine();
                            UserService.SetLogin(new API_User()); //wipe out previous login info
                            this.questionService.UpdateToken(null);
                            return;
                        case 0:
                            Console.WriteLine("Goodbye!");
                            shouldExit = true;
                            return;
                        default:
                            Console.WriteLine("That's not a valid choice. Try again.");
                            break;
                    }
                }
            }
        }

        private void PromptAndDeleteQuestionById()
        {
            this.DisplayAllQuestions();

            int id = this.consoleService.PromptForNumber("the Question ID you'd like to delete");

            this.questionService.DeleteQuestion(id);
        }

        private void PromptAndAddNewQuestion()
        {
            API_Question question = this.consoleService.PromptForQuestion();

            if (this.questionService.CreateQuestion(question) != null)
            {
                Console.WriteLine("Question Created");
            }
        }

        private void DisplayAllQuestions()
        {
            List<API_Question> questions = questionService.GetAllQuestions();
            foreach (API_Question question in questions)
            {
                Console.WriteLine(question);
            }
        }

        private void DisplayRandomQuestion()
        {
            API_Question question = questionService.GetRandomQuestion();
            if (question != null)
            {
                Console.WriteLine(question);
            }
            else
            {
                Console.WriteLine("There were no questions available to display.");
            }
        }

        private void HandleUserRegister()
        {
            bool isRegistered = false;

            while (!isRegistered) //will keep looping until user is registered
            {
                LoginUser registerUser = consoleService.PromptForLogin();
                isRegistered = authService.Register(registerUser);
            }

            Console.WriteLine("");
            Console.WriteLine("Registration successful. You can now log in.");
        }

        private void HandleUserLogin()
        {
            while (!UserService.IsLoggedIn) //will keep looping until user is logged in
            {
                LoginUser loginUser = consoleService.PromptForLogin();
                API_User user = authService.Login(loginUser);
                if (user != null)
                {
                    UserService.SetLogin(user);
                    this.questionService.UpdateToken(user.Token);
                }
            }
        }
    }
}
