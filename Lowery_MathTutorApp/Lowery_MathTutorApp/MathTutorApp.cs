using System;


namespace Lowery_MathTutorApp
{
	class MathTutorApp
	{
		static String name;
		static int grade;
		static String mathInput;
		static int operation;
		static int cnt = 0;
		static int more = 0;
		static int addCorrect = 0;
		static int addTotal = 0;
		static int subCorrect = 0;
		static int subTotal = 0;
		static int multCorrect = 0;
		static int multTotal = 0;
		static void Main(string[] args)
		{
			introScreen();
			
			while (cnt == 0)
			{
				if (operation == 1)
				{
					Console.WriteLine("We will be quizzing you on addition skills at the " + grade + " level. When you are ready to take the quiz, press any key to continue.");
					Console.ReadLine();
					addTest();
				}
				if (operation == 2)
				{
					Console.WriteLine("We will be quizzing you on subtraction skills at the " + grade + " level. When you are ready to take the quiz, press any key to continue.");
					Console.ReadLine();
					subTest();
				}
				if (operation == 3)
				{
					Console.WriteLine("We will be quizzing you on multiplication skills at the " + grade + " level. When you are ready to take the quiz, press any key to continue.");
					Console.ReadLine();
					multTest();
				}
				if (operation == 4)
				{
					Console.WriteLine("We will be quizzing you on random math skills at the " + grade + " level. When you are ready to take the quiz, press any key to continue.");
					Console.ReadLine();
					randomTest();
				}
			}
			resultScreen();
		}
		public static void introScreen()
		{
			Console.WriteLine("Welcome to the Math Tutor App!");
			Console.WriteLine();
			Console.WriteLine("This app will ask you questions on basic mathematics skills that an elementary student should master.");
			Console.WriteLine();
			Console.WriteLine("We would like to get some basic information about you.");
			Console.WriteLine();
			Console.Write("To get started, please provide your fullname: ");
			name = Console.ReadLine();
			Console.Write("Please Input Your Grade Level (1 to 5): ");
			String gradeInput = Console.ReadLine();
			grade = Convert.ToInt32(gradeInput);
			Console.WriteLine();
			Console.WriteLine(name + " , we appreciate you using the Math Tutor App. When you are ready to be tested on Math skills, press any key.");
			Console.ReadLine();
			Console.Clear();
			Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
			Console.WriteLine("Addition - Enter 1");
			Console.WriteLine("Subtraction - Enter 2");
			Console.WriteLine("Multiplication - Enter 3");
			Console.WriteLine("Surprise Me - Enter 4");
			Console.WriteLine();
			Console.WriteLine("Enter your testing option: ");
			Console.WriteLine();
			mathInput = Console.ReadLine();
			operation = Convert.ToInt32(mathInput);
		}
		public static void addTest()
		{
			more = 0;
			while (more == 0)
			{
				Console.Clear();
				var x = new Random();
				var y = new Random();
				int firstNum = x.Next(20 * grade);
				int secondNum = y.Next(20 * grade);
				Console.WriteLine("How much is " + firstNum + " plus " + secondNum + "?");
				String inputAnswer = Console.ReadLine();
				int guess = Convert.ToInt32(inputAnswer);
				int correctAnswer = firstNum + secondNum;
				if (guess == correctAnswer)
				{
					Console.WriteLine("Correct!");
					addCorrect++;
					addTotal++;
				}
				else
				{
					Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
					addTotal++;
				}
				Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
				String another = Console.ReadLine();
				switch (another)
				{
					case "c":
						break;
					case "m":
						more = 1;
						Console.Clear();
						Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
						Console.WriteLine("Addition - Enter 1");
						Console.WriteLine("Subtraction - Enter 2");
						Console.WriteLine("Multiplication - Enter 3");
						Console.WriteLine("Surprise Me - Enter 4");
						Console.WriteLine();
						Console.WriteLine("Enter your testing option: ");
						mathInput = Console.ReadLine();
						operation = Convert.ToInt32(mathInput);
						break;
					default:
						more = 1;
						cnt = 1;
						break;
				}
			}
		}
		public static void subTest()
		{
			more = 0;
			while (more == 0)
			{
				Console.Clear();
				var x = new Random();
				var y = new Random();
				int firstNum = x.Next(20 * grade);
				int secondNum = y.Next(20 * grade);
				Console.WriteLine("How much is " + firstNum + " minus " + secondNum + "?");
				String inputAnswer = Console.ReadLine();
				int guess = Convert.ToInt32(inputAnswer);
				int correctAnswer = firstNum - secondNum;
				if (guess == correctAnswer)
				{
					Console.WriteLine("Correct!");
					subCorrect++;
					subTotal++;
				}
				else
				{
					Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
					subTotal++;
				}
				Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
				String another = Console.ReadLine();
				switch (another)
				{
					case "c":
						break;
					case "m":
						more = 1;
						Console.Clear();
						Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
						Console.WriteLine("Addition - Enter 1");
						Console.WriteLine("Subtraction - Enter 2");
						Console.WriteLine("Multiplication - Enter 3");
						Console.WriteLine("Surprise Me - Enter 4");
						Console.WriteLine();
						Console.WriteLine("Enter your testing option: ");
						mathInput = Console.ReadLine();
						operation = Convert.ToInt32(mathInput);
						break;
					default:
						more = 1;
						cnt = 1;
						break;
				}
			}
		}
		public static void multTest()
		{
			more = 0;
			while (more == 0)
			{
				Console.Clear();
				var x = new Random();
				var y = new Random();
				int firstNum = x.Next(10 * grade);
				int secondNum = y.Next(10 * grade);
				Console.WriteLine("How much is " + firstNum + " times " + secondNum + "?");
				String inputAnswer = Console.ReadLine();
				int guess = Convert.ToInt32(inputAnswer);
				int correctAnswer = firstNum * secondNum;
				if (guess == correctAnswer)
				{
					Console.WriteLine("Correct!");
					multCorrect++;
					multTotal++;
				}
				else
				{
					Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
					multTotal++;
				}
				Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
				String another = Console.ReadLine();
				switch (another)
				{
					case "c":
						break;
					case "m":
						more = 1;
						Console.Clear();
						Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
						Console.WriteLine("Addition - Enter 1");
						Console.WriteLine("Subtraction - Enter 2");
						Console.WriteLine("Multiplication - Enter 3");
						Console.WriteLine("Surprise Me - Enter 4");
						Console.WriteLine();
						Console.WriteLine("Enter your testing option: ");
						mathInput = Console.ReadLine();
						operation = Convert.ToInt32(mathInput);
						break;
					default:
						more = 1;
						cnt = 1;
						break;
				}
			}
		}
		public static void randomTest()
		{
			more = 0;
			while(more == 0)
			{
				var z = new Random();
				int surprise = z.Next(1, 4);
				if (surprise == 1)
				{
					Console.Clear();
					var x = new Random();
					var y = new Random();
					int firstNum = x.Next(20 * grade);
					int secondNum = y.Next(20 * grade);
					Console.WriteLine("How much is " + firstNum + " plus " + secondNum + "?");
					String inputAnswer = Console.ReadLine();
					int guess = Convert.ToInt32(inputAnswer);
					int correctAnswer = firstNum + secondNum;
					if (guess == correctAnswer)
					{
						Console.WriteLine("Correct!");
						addCorrect++;
						addTotal++;
					}
					else
					{
						Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
						addTotal++;
					}
					Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
					String another = Console.ReadLine();
					switch (another)
					{
						case "c":
							break;
						case "m":
							more = 1;
							Console.Clear();
							Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
							Console.WriteLine("Addition - Enter 1");
							Console.WriteLine("Subtraction - Enter 2");
							Console.WriteLine("Multiplication - Enter 3");
							Console.WriteLine("Surprise Me - Enter 4");
							Console.WriteLine();
							Console.WriteLine("Enter your testing option: ");
							mathInput = Console.ReadLine();
							operation = Convert.ToInt32(mathInput);
							break;
						default:
							more = 1;
							cnt = 1;
							break;
					}
				}
				if (surprise == 2)
				{
					Console.Clear();
					var x = new Random();
					var y = new Random();
					int firstNum = x.Next(20 * grade);
					int secondNum = y.Next(20 * grade);
					Console.WriteLine("How much is " + firstNum + " minus " + secondNum + "?");
					String inputAnswer = Console.ReadLine();
					int guess = Convert.ToInt32(inputAnswer);
					int correctAnswer = firstNum - secondNum;
					if (guess == correctAnswer)
					{
						Console.WriteLine("Correct!");
						subCorrect++;
						subTotal++;
					}
					else
					{
						Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
						subTotal++;
					}
					Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
					String another = Console.ReadLine();
					switch (another)
					{
						case "c":
							break;
						case "m":
							more = 1;
							Console.Clear();
							Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
							Console.WriteLine("Addition - Enter 1");
							Console.WriteLine("Subtraction - Enter 2");
							Console.WriteLine("Multiplication - Enter 3");
							Console.WriteLine("Surprise Me - Enter 4");
							Console.WriteLine();
							Console.WriteLine("Enter your testing option: ");
							mathInput = Console.ReadLine();
							operation = Convert.ToInt32(mathInput);
							break;
						default:
							more = 1;
							cnt = 1;
							break;
					}
				}
				if (surprise == 3)
				{
					Console.Clear();
					var x = new Random();
					var y = new Random();
					int firstNum = x.Next(10 * grade);
					int secondNum = y.Next(10 * grade);
					Console.WriteLine("How much is " + firstNum + " times " + secondNum + "?");
					String inputAnswer = Console.ReadLine();
					int guess = Convert.ToInt32(inputAnswer);
					int correctAnswer = firstNum * secondNum;
					if (guess == correctAnswer)
					{
						Console.WriteLine("Correct!");
						multCorrect++;
						multTotal++;
					}
					else
					{
						Console.WriteLine("Sorry that is incorrect. The correct answer is " + correctAnswer);
						multTotal++;
					}
					Console.WriteLine("To continue to display next question, press c. To display menu options, press m. To stop testing, press any other key.");
					String another = Console.ReadLine();
					switch (another)
					{
						case "c":
							break;
						case "m":
							more = 1;
							Console.Clear();
							Console.WriteLine("Specify the math skill that you want to be tested on. The following are your options: ");
							Console.WriteLine("Addition - Enter 1");
							Console.WriteLine("Subtraction - Enter 2");
							Console.WriteLine("Multiplication - Enter 3");
							Console.WriteLine("Surprise Me - Enter 4");
							Console.WriteLine();
							Console.WriteLine("Enter your testing option: ");
							mathInput = Console.ReadLine();
							operation = Convert.ToInt32(mathInput);
							break;
						default:
							more = 1;
							cnt = 1;
							break;
					}
				}
			}
		}
		public static void resultScreen()
		{
			Console.Clear();
			Console.WriteLine("Name: " + name);
			Console.WriteLine("Grade: " + grade);
			Console.WriteLine();
			Console.WriteLine("Number of addition questions asked: " + addTotal);
			Console.WriteLine("Number of addition questions answered correctly: " + addCorrect);
			Console.WriteLine();
			Console.WriteLine("Number of subtraction questions asked: " + subTotal);
			Console.WriteLine("Number of subtraction questions answered correctly: " + subCorrect);
			Console.WriteLine();
			Console.WriteLine("Number of multiplication questions asked: " + multTotal);
			Console.WriteLine("Number of multiplication questions answered correctly: " + multCorrect);
			Console.WriteLine();
			Console.WriteLine("Thank you for using the Math Tutor App! We hope to see you back to practice your math skills.");
			Console.ReadLine();
		}
	}
}