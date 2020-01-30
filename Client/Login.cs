using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Millionaire_Client
{
    public partial class Login : Form
    {
        public Login()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            javaScriptSerializer = new JavaScriptSerializer();
            clientRunnable = new Thread(new ThreadStart(receiveData));
            clientRunnable.IsBackground = true;
            clientRunnable.Start();
            responses = new List<string>();
            previousQuestions = new HashSet<string>();
            usedLifelines = new List<bool>();
            usedLifelines.Add(false);
            usedLifelines.Add(false);
            usedLifelines.Add(false);
            questionNumber = 0;
            random = new Random();

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panelRegister.Hide();
            panelPasswordRecovery.Hide();
            panelHome.Hide();
            panelRankings.Hide();
            panelGame.Hide();
            panelMessage.Hide();
        }

        private void Login_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (userScore != null)
            {
                logout();
            }
           
            string command = "disconnect";

            sendCommand(command);      
        }

        private void pictureBoxLoginButton_Click(object sender, EventArgs e)
        {
            string userName = textBoxLoginUserName.Text;
            string password = maskedTextBoxLoginPassword.Text;

            string command = "login --username " + userName + " --password " + password;

            sendCommand(command);

            string response = getResponse();

            if (response.Equals(userName + " successfully logged in."))
            {
                textBoxLoginUserName.Text = "";
                maskedTextBoxLoginPassword.Text = "";
                labelLoginErrorMessage.Text = "";

                labelHomeUserName.Text = userName;

                command = "get-user-score --username " + userName;

                sendCommand(command);

                response = getResponse();

                userScore = (UserScore)javaScriptSerializer.Deserialize(response, typeof(UserScore));

                labelHomeCreditsNumber.Text = userScore.score.ToString();

                panelPasswordRecovery.Show();
                panelRegister.Show();
                panelHome.Show();
            }

            else
            {
                labelLoginErrorMessage.Text = "Грешно потребителско име или парола";
            }
        }

        private void linkLabelLoginRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelPasswordRecovery.Show();
            panelRegister.Show();
        }

        private void linkLabelLoginPasswordRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            labelPasswordRecoveryErrorMessage.Text = "Въведете вашия email и кликнете върху \"Запази\", за да получите временна парола.";
            textBoxPasswordRecoveryEmail.Text = "";
            maskedTextBoxPasswordRecoveryOldPassword.Text = "";
            maskedTextBoxPasswordRecoveryNewPassword.Text = "";
            panelPasswordRecovery.Show();
        }

        private void pictureBoxPasswordRecoveryBackButton_Click(object sender, EventArgs e)
        {
            textBoxLoginUserName.Text = "";
            maskedTextBoxLoginPassword.Text = "";
            labelLoginErrorMessage.Text = "";

            panelPasswordRecovery.Hide();     
        }

        private void pictureBoxPasswordRecoverySaveButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPasswordRecoveryOldPassword.Text.Equals("") && maskedTextBoxPasswordRecoveryNewPassword.Text.Equals(""))
            {
                if (textBoxPasswordRecoveryEmail.Text.Equals(""))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Не сте въвели email. Въведете го и кликнете върху \"Запази\", за да получите временна парола.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                    return;
                }

                string email = textBoxPasswordRecoveryEmail.Text;
                string temporaryPassword = randomPassword();

                string command = "create-temporary-password --email " + email + " --temporary-password " + temporaryPassword;

                sendCommand(command);

                string response = getResponse();

                if (response.Equals("The password has been successfully reset."))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Проверете вашия e-mail за временната си парола.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Yellow;

                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("stani.magnat@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Стани магнат - временна парола";
                        mail.Body = "<p> Вашата временна парола е: </p> <br> <p> " + temporaryPassword + " </p>  <br> <p> " +
                                     "Използвайте я за да смените паролата си. </p>";
                        mail.IsBodyHtml = true;

                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            smtp.UseDefaultCredentials = false;
                            smtp.Credentials = new NetworkCredential("stani.magnat@gmail.com", "qwerty123QWERTY");
                            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                        }
                    }
                }

                else
                {
                    labelPasswordRecoveryErrorMessage.Text = "Потребител с този e-mail не съществува.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                }
            }

            else
            {
                if (maskedTextBoxPasswordRecoveryOldPassword.Text.Equals("") || maskedTextBoxPasswordRecoveryNewPassword.Text.Equals(""))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Има непопълнено поле. Моля попълнете го.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                    return;
                }

                string email = textBoxPasswordRecoveryEmail.Text;
                string oldPassword = maskedTextBoxPasswordRecoveryOldPassword.Text;
                string newPassword = maskedTextBoxPasswordRecoveryNewPassword.Text;

                string command = "reset-password --email " + email + " --old-password " + oldPassword + " --new-password " + newPassword;

                sendCommand(command);

                string response = getResponse();

                if (response.Equals("The password has been successfully reset."))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Паролата беше сменена успешно.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Yellow;
                }

                else if (response.Equals("The user does not exist."))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Потребител с този e-mail не съществува.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                }

                else if (response.Equals("Incorrect password."))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Грешна стара парола.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                }

                else if (response.Equals("Invalid new password"))
                {
                    labelPasswordRecoveryErrorMessage.Text = "Невалидна нова парола.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                }

                else
                {
                    labelPasswordRecoveryErrorMessage.Text = "Невалиден e-mail.";
                    labelPasswordRecoveryErrorMessage.ForeColor = Color.Red;
                }
            }
        }

        private void pictureBoxRegisterBackButton_Click(object sender, EventArgs e)
        {
            textBoxLoginUserName.Text = "";
            maskedTextBoxLoginPassword.Text = "";
            labelLoginErrorMessage.Text = "";

            panelPasswordRecovery.Hide();
            panelRegister.Hide();
        }

        private void pictureBoxRegisterButton_Click(object sender, EventArgs e)
        {
            string userName = textBoxRegisterUserName.Text;
            string email = textBoxRegisterEmail.Text;
            string password = maskedTextBoxRegisterPassword.Text;
            string confirmedPassword = maskedTextBoxRegisterRepeatedPassword.Text;

            string command = "register --username " + userName + " --email " + email + " --password " + password + " --confirmed-password " + confirmedPassword;

            sendCommand(command);

            string response = getResponse();

            if (response.Equals("Registration was successful."))
            {
                textBoxRegisterUserName.Text = "";
                textBoxRegisterEmail.Text = "";
                maskedTextBoxRegisterPassword.Text = "";
                maskedTextBoxRegisterRepeatedPassword.Text = "";
                labelRegisterErrorMessage.Text = "";

                command = "login --username " + userName + " --password " + password;

                sendCommand(command);

                response = getResponse();

                labelHomeUserName.Text = userName;

                command = "get-user-score --username " + userName;

                sendCommand(command);

                response = getResponse();

                userScore = (UserScore)javaScriptSerializer.Deserialize(response, typeof(UserScore));

                labelHomeCreditsNumber.Text = userScore.score.ToString();

                panelPasswordRecovery.Show();
                panelRegister.Show();
                panelHome.Show();
            }

            else
            {
                if (response.Equals("Passwords don't match."))
                {
                    labelRegisterErrorMessage.Text = "Паролите не съвпадат.";
                }

                else if (response.Equals("Password is not valid."))
                {
                    labelRegisterErrorMessage.Text = "Паролата трявбва да съдържа цифра, малка и голяма латинска буква.";
                }

                else if (response.Equals("A user with that user name already exists."))
                {
                    labelRegisterErrorMessage.Text = "Потребител с това име вече съществува.";
                }

                else if (response.Equals("A user with that email already exists."))
                {
                    labelRegisterErrorMessage.Text = "Потребител с този e-mail вече съществува.";
                }

                else
                {
                    labelRegisterErrorMessage.Text = "Невалидни или непопълнени данни.";
                }
            }
        }

        private void pictureBoxHomeLogoutButton_Click(object sender, EventArgs e)
        {
            logout();
        }

        private void pictureBoxHomeRankingsButton_Click(object sender, EventArgs e)
        {
            string command = "get-rankings";

            sendCommand(command);

            string response = getResponse();

            List<UserScore> userScores = (List<UserScore>)javaScriptSerializer.Deserialize(response, typeof(List<UserScore>));

            for (int i = 0; i < userScores.Count; i++)
            {
                if (userScores[i].userName.Equals(userScore.userName))
                {
                    playerScoreIndex = i;
                    break;
                }
            }

            firstScoreIndex = (playerScoreIndex / 8) * 8;

            fillRankings(userScores);

            panelPasswordRecovery.Show();
            panelRegister.Show();
            panelHome.Show();
            panelRankings.Show();
        }

        private void pictureBoxHomeNewGameButton_Click(object sender, EventArgs e)
        {
            pictureBoxGameGiveUp.Enabled = true;
            pictureBoxGameSearch.Enabled = true;
            pictureBoxGameFriend.Enabled = true;
            pictureBoxGame5050.Enabled = true;
            pictureBoxGame5050.Image = Properties.Resources._5050Active100x100;
            pictureBoxGameFriend.Image = Properties.Resources.help100x100;
            pictureBoxGameSearch.Image = Properties.Resources.search100x100ac;
            labelGameAnswerD.Enabled = true;
            labelGameAnswerC.Enabled = true;
            labelGameAnswerB.Enabled = true;
            labelGameAnswerA.Enabled = true;
            pictureBoxGameQuestionForm.Image = Properties.Resources.template;
            pictureBoxGameSumTree.Image = Properties.Resources.table1;
            labelGameAnswerA.BackColor = Color.FromArgb(71, 107, 159);
            labelGameAnswerB.BackColor = Color.FromArgb(71, 107, 159);
            labelGameAnswerC.BackColor = Color.FromArgb(71, 107, 159);
            labelGameAnswerD.BackColor = Color.FromArgb(71, 107, 159);

            labelGameHintBox.Text = "";
            usedLifelines[0] = false;
            usedLifelines[1] = false;
            usedLifelines[2] = false;

            questionNumber = 1;

            loadQuestion();

            panelPasswordRecovery.Show();
            panelRegister.Show();
            panelHome.Show();
            panelRankings.Show();
            panelGame.Show();
        }

        private void pictureBoxRankingsHomeButton_Click(object sender, EventArgs e)
        {
            panelRankings.Hide();
        }

        private void pictureBoxGameGiveUp_Click(object sender, EventArgs e)
        {
            endGame("give up");
        }

        private void pictureBoxGameFriend_Click(object sender, EventArgs e)
        {
            usedLifelines[1] = true;

            pictureBoxGameFriend.Enabled = false;
            pictureBoxGameFriend.Image = Properties.Resources.helpunactive100x100;

            string difficulty = getDifficulty();
            int correctAnswerIndex = getCorrectAnswerIndex();

            List<int> answersLeft = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                if (i != correctAnswerIndex)
                {
                    if (i == 0 && !labelGameAnswerA.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 1 && !labelGameAnswerB.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 2 && !labelGameAnswerC.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 3 && !labelGameAnswerD.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }       
                }
            }

            List<int> answers = new List<int>();
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);

            if (difficulty.Equals("easy"))
            {
                answers.Add(correctAnswerIndex);
                answers.Add(correctAnswerIndex);
            }

            else if (difficulty.Equals("medium"))
            {
                answers.Add(correctAnswerIndex);
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
            }

            else
            {
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
            }

            int answer = answers[random.Next(answers.Count)];
            char answerLetter;

            if (answer == 0)
            {
                answerLetter = 'A';
            }

            else if (answer == 1)
            {
                answerLetter = 'B';
            }

            else if (answer == 2)
            {
                answerLetter = 'C';
            }

            else
            {
                answerLetter = 'D';
            }

            labelGameHintBox.Text = "Смятам, че верният отговор е " + answerLetter + ".";
        }

        private void pictureBoxGameSearch_Click(object sender, EventArgs e)
        {
            usedLifelines[2] = true;

            pictureBoxGameSearch.Enabled = false;
            pictureBoxGameSearch.Image = Properties.Resources.search100x100;

            string difficulty = getDifficulty();
            int correctAnswerIndex = getCorrectAnswerIndex();

            List<int> answersLeft = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                if (i != correctAnswerIndex)
                {
                    if (i == 0 && !labelGameAnswerA.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 1 && !labelGameAnswerB.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 2 && !labelGameAnswerC.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }

                    else if (i == 3 && !labelGameAnswerD.Text.Equals(""))
                    {
                        answersLeft.Add(i);
                    }
                }
            }

            List<int> answers = new List<int>();
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);
            answers.Add(correctAnswerIndex);

            if (difficulty.Equals("easy"))
            {
                answers.Add(correctAnswerIndex);
                answers.Add(correctAnswerIndex);
            }

            else if (difficulty.Equals("medium"))
            {
                answers.Add(correctAnswerIndex);
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
            }

            else
            {
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
                answers.Add(answersLeft[random.Next(answersLeft.Count)]);
            }

            int answer = answers[random.Next(answers.Count)];

            List<int> percentages = new List<int>();
            percentages.Add(0);
            percentages.Add(0);
            percentages.Add(0);
            percentages.Add(0);

            int percentageLeft = 100;

            int currentPercantage;

            if (difficulty.Equals("easy"))
            {
                currentPercantage = random.Next(70, 95);
                percentages[answer] = currentPercantage;
            }

            else if (difficulty.Equals("medium"))
            {
                currentPercantage = random.Next(50, 70);
                percentages[answer] = currentPercantage;
            }

            else
            {
                currentPercantage = random.Next(30, 50);
                percentages[answer] = currentPercantage;
            }

            percentageLeft -= currentPercantage;

            for (int i = 0; i < 4; i++)
            {
                if (i != answer)
                {
                    if (i != 3)
                    {
                        currentPercantage = random.Next(percentageLeft + 1);
                    }

                    else
                    {
                        currentPercantage = percentageLeft;
                    }

                    if (i == 0 && labelGameAnswerA.Text.Equals(""))
                    {
                        percentages[answer] += currentPercantage;
                    }

                    else if (i == 1 && labelGameAnswerB.Text.Equals(""))
                    {
                        percentages[answer] += currentPercantage;
                    }

                    else if (i == 2 && labelGameAnswerC.Text.Equals(""))
                    {
                        percentages[answer] += currentPercantage;
                    }

                    else if (i == 3 && labelGameAnswerD.Text.Equals(""))
                    {
                        percentages[answer] += currentPercantage;
                    }

                    else
                    {
                        percentages[i] = currentPercantage;
                    }
                    
                    percentageLeft -= currentPercantage;
                }
            }

            if (!labelGameAnswerA.Text.Equals(""))
            {
                labelGameHintBox.Text += "A: " + percentages[0] + "%    ";
            }

            if (!labelGameAnswerB.Text.Equals(""))
            {
                labelGameHintBox.Text += "B: " + percentages[1] + "%    ";
            }

            if (!labelGameAnswerC.Text.Equals(""))
            {
                labelGameHintBox.Text += "C: " + percentages[2] + "%    ";
            }

            if (!labelGameAnswerD.Text.Equals(""))
            {
                labelGameHintBox.Text += "D: " + percentages[3] + "%    ";
            }
        }

        private void pictureBoxGame5050_Click(object sender, EventArgs e)
        {
            usedLifelines[0] = true;
            pictureBoxGame5050.Enabled = false;
            pictureBoxGame5050.Image = Properties.Resources._5050Unactive100x100;

            int correctAnswerIndex = getCorrectAnswerIndex();

            List<int> answersLeft = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                if (i != correctAnswerIndex)
                {
                    answersLeft.Add(i);
                }
            }

            answersLeft.RemoveAt(random.Next(answersLeft.Count));

            for (int i = 0; i < 2; i++)
            {
                if (answersLeft[i] == 0)
                {
                    labelGameAnswerA.Text = "";
                    labelGameAnswerA.Enabled = false;
                }

                else if (answersLeft[i] == 1)
                {
                    labelGameAnswerB.Text = "";
                    labelGameAnswerB.Enabled = false;
                }

                else if (answersLeft[i] == 2)
                {
                    labelGameAnswerC.Text = "";
                    labelGameAnswerC.Enabled = false;
                }

                else
                {
                    labelGameAnswerD.Text = "";
                    labelGameAnswerD.Enabled = false;
                }
            }
        }

        private void pictureBoxMessageHomeButton_Click(object sender, EventArgs e)
        {
            previousQuestions.Clear();
            string command = "end-game";

            sendCommand(command);

            string response = getResponse();

            panelMessage.Hide();
            panelGame.Hide();
            panelRankings.Hide();
        }

        private void labelGameAnswerA_Click(object sender, EventArgs e)
        {
            selectAnswer(labelGameAnswerA);
        }

        private void labelGameAnswerB_Click(object sender, EventArgs e)
        {
            selectAnswer(labelGameAnswerB);
        }

        private void labelGameAnswerC_Click(object sender, EventArgs e)
        {
            selectAnswer(labelGameAnswerC);
        }

        private void labelGameAnswerD_Click(object sender, EventArgs e)
        {
            selectAnswer(labelGameAnswerD); 
        }

        private void pictureBoxRankingsNextButton_Click(object sender, EventArgs e)
        {
            changeRankingsPage("next");
        }

        private void pictureBoxRankingsPreviousButton_Click(object sender, EventArgs e)
        {
            changeRankingsPage("previous");
        }

        private void textBoxesRankings_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxRankingsFirst.Enabled = false;
            textBoxRankingsFirst2.Enabled = false;
            textBoxRankingsFirst3.Enabled = false;
            textBoxRankingsSecond.Enabled = false;
            textBoxRankingsSecond2.Enabled = false;
            textBoxRankingsSecond3.Enabled = false;
            textBoxRankingsThird.Enabled = false;
            textBoxRankingsThird2.Enabled = false;
            textBoxRankingsThird3.Enabled = false;
            textBoxRankingsFourth.Enabled = false;
            textBoxRankingsFourth2.Enabled = false;
            textBoxRankingsFourth3.Enabled = false;
            textBoxRankingsFifth.Enabled = false;
            textBoxRankingsFifth2.Enabled = false;
            textBoxRankingsFifth3.Enabled = false;
            textBoxRankingsSixth.Enabled = false;
            textBoxRankingsSixth2.Enabled = false;
            textBoxRankingsSixth3.Enabled = false;
            textBoxRankingsSeventh.Enabled = false;
            textBoxRankingsSeventh2.Enabled = false;
            textBoxRankingsSeventh3.Enabled = false;
            textBoxRankingsEighth.Enabled = false;
            textBoxRankingsEighth2.Enabled = false;
            textBoxRankingsEighth3.Enabled = false;

            textBoxRankingsFirst.Enabled = true;
            textBoxRankingsFirst2.Enabled = true;
            textBoxRankingsFirst3.Enabled = true;
            textBoxRankingsSecond.Enabled = true;
            textBoxRankingsSecond2.Enabled = true;
            textBoxRankingsSecond3.Enabled = true;
            textBoxRankingsThird.Enabled = true;
            textBoxRankingsThird2.Enabled = true;
            textBoxRankingsThird3.Enabled = true;
            textBoxRankingsFourth.Enabled = true;
            textBoxRankingsFourth2.Enabled = true;
            textBoxRankingsFourth3.Enabled = true;
            textBoxRankingsFifth.Enabled = true;
            textBoxRankingsFifth2.Enabled = true;
            textBoxRankingsFifth3.Enabled = true;
            textBoxRankingsSixth.Enabled = true;
            textBoxRankingsSixth2.Enabled = true;
            textBoxRankingsSixth3.Enabled = true;
            textBoxRankingsSeventh.Enabled = true;
            textBoxRankingsSeventh2.Enabled = true;
            textBoxRankingsSeventh3.Enabled = true;
            textBoxRankingsEighth.Enabled = true;
            textBoxRankingsEighth2.Enabled = true;
            textBoxRankingsEighth3.Enabled = true;
        }

        private void sendCommand(string command)
        {
            byte[] data = Encoding.ASCII.GetBytes(command);
            string ipAddress = "127.0.0.1";
            int sendPort = 8080;

            try
            {
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse(ipAddress), sendPort);
                socket.SendTo(data, ep);
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void receiveData()
        {
            bool done = false;
            int listenPort = 40001;
    
            EndPoint listenEndPoint = new IPEndPoint(IPAddress.Any, listenPort);
            socket.Bind(listenEndPoint);

            while (!done)
            {
                byte[] receivedData = new byte[65000];

                socket.ReceiveFrom(receivedData, ref listenEndPoint);

                responses.Add(Encoding.UTF8.GetString(receivedData).Substring(0, Encoding.UTF8.GetString(receivedData).IndexOf('\0')));
            }
        }

        private void logout()
        {
            previousQuestions.Clear();
            string userName = userScore.userName;

            string command = "logout --username " + userName;

            sendCommand(command);

            string response = getResponse();

            if (response.Equals("The user was successfully logged out of the system."))
            {
                panelRegister.Hide();
                panelPasswordRecovery.Hide();
                panelHome.Hide();
            }
        }

        private string getDifficulty()
        {
            if (questionNumber <= 5)
            {
                return "easy";
            }

            else if (questionNumber <= 10)
            {
                return "medium";
            }

            return "hard";
        }

        private int getCorrectAnswerIndex()
        {
            if (currentQuestion.correctAnswer.Equals(labelGameAnswerA.Text))
            {
                return 0;
            }

            else if (currentQuestion.correctAnswer.Equals(labelGameAnswerB.Text))
            {
                return 1;
            }

            else if (currentQuestion.correctAnswer.Equals(labelGameAnswerC.Text))
            {
                return 2;
            }

            return 3;
        }

        private void loadQuestion()
        {
            do
            {
                string difficulty = getDifficulty();

                string command = "get-question --difficulty " + difficulty;

                sendCommand(command);

                string response = getResponse();

                currentQuestion = (Question)javaScriptSerializer.Deserialize(response, typeof(Question));

            } while (previousQuestions.Contains(currentQuestion.question));

            previousQuestions.Add(currentQuestion.question);

            labelGameQuestion.Text = currentQuestion.question;
            labelGameAnswerA.Text = currentQuestion.answers[0];
            labelGameAnswerB.Text = currentQuestion.answers[1];
            labelGameAnswerC.Text = currentQuestion.answers[2];
            labelGameAnswerD.Text = currentQuestion.answers[3];
        }

        private int getSumWon(String reason)
        {
            int questionWin;

            if (reason.Equals("give up"))
            {
                questionWin = questionNumber - 1;
            }

            else if (reason.Equals("finish"))
            {
                questionWin = questionNumber;
            }

            else
            {
                if (questionNumber <= 5)
                {
                    questionWin = 0;
                }

                else if (questionNumber <= 10)
                {
                    questionWin = 5;
                }

                else
                {
                    questionWin = 10;
                }
            }

            int sumWon = 0;

            switch (questionWin)
            {
                case 1:
                    sumWon = 10;
                    break;
                case 2:
                    sumWon = 20;
                    break;
                case 3:
                    sumWon = 30;
                    break;
                case 4:
                    sumWon = 40;
                    break;
                case 5:
                    sumWon = 50;
                    break;
                case 6:
                    sumWon = 100;
                    break;
                case 7:
                    sumWon = 150;
                    break;
                case 8:
                    sumWon = 200;
                    break;
                case 9:
                    sumWon = 250;
                    break;
                case 10:
                    sumWon = 300;
                    break;
                case 11:
                    sumWon = 500;
                    break;
                case 12:
                    sumWon = 750;
                    break;
                case 13:
                    sumWon = 1000;
                    break;
                case 14:
                    sumWon = 2500;
                    break;
                case 15:
                    sumWon = 5000;
                    break;
                case 16:
                    sumWon = 10000;
                    break;
            }

            return sumWon;
        }

        private void showWrongAnswer()
        {
            endGame("wrong answer");
        }

        private void showCorrectAnswer()
        {
            if (questionNumber == 16)
            {
                endGame("finish");
            }

            else
            {
                questionNumber++;
                pictureBoxGameGiveUp.Enabled = true;

                if (!usedLifelines[0])
                {
                    pictureBoxGame5050.Enabled = true;
                }

                if (!usedLifelines[1])
                {
                    pictureBoxGameFriend.Enabled = true;
                }

                if (!usedLifelines[2])
                {
                    pictureBoxGameSearch.Enabled = true;
                }

                labelGameAnswerD.Enabled = true;
                labelGameAnswerC.Enabled = true;
                labelGameAnswerB.Enabled = true;
                labelGameAnswerA.Enabled = true;
                pictureBoxGameQuestionForm.Image = Properties.Resources.template;
                labelGameAnswerA.BackColor = Color.FromArgb(71, 107, 159);
                labelGameAnswerB.BackColor = Color.FromArgb(71, 107, 159);
                labelGameAnswerC.BackColor = Color.FromArgb(71, 107, 159);
                labelGameAnswerD.BackColor = Color.FromArgb(71, 107, 159);

                labelGameHintBox.Text = "";

                loadQuestion();

                switch (questionNumber)
                {
                    case 1:
                        pictureBoxGameSumTree.Image = Properties.Resources.table1;
                        break;
                    case 2:
                        pictureBoxGameSumTree.Image = Properties.Resources.table2;
                        break;
                    case 3:
                        pictureBoxGameSumTree.Image = Properties.Resources.table3;
                        break;
                    case 4:
                        pictureBoxGameSumTree.Image = Properties.Resources.table4;
                        break;
                    case 5:
                        pictureBoxGameSumTree.Image = Properties.Resources.table5;
                        break;
                    case 6:
                        pictureBoxGameSumTree.Image = Properties.Resources.table6;
                        break;
                    case 7:
                        pictureBoxGameSumTree.Image = Properties.Resources.table7;
                        break;
                    case 8:
                        pictureBoxGameSumTree.Image = Properties.Resources.table8;
                        break;
                    case 9:
                        pictureBoxGameSumTree.Image = Properties.Resources.table9;
                        break;
                    case 10:
                        pictureBoxGameSumTree.Image = Properties.Resources.table10;
                        break;
                    case 11:
                        pictureBoxGameSumTree.Image = Properties.Resources.table11;
                        break;
                    case 12:
                        pictureBoxGameSumTree.Image = Properties.Resources.table12;
                        break;
                    case 13:
                        pictureBoxGameSumTree.Image = Properties.Resources.table13;
                        break;
                    case 14:
                        pictureBoxGameSumTree.Image = Properties.Resources.table14;
                        break;
                    case 15:
                        pictureBoxGameSumTree.Image = Properties.Resources.table15;
                        break;
                    case 16:
                        pictureBoxGameSumTree.Image = Properties.Resources.table16;
                        break;
                }
            }
        }

        private string randomPassword()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append((char)random.Next(65, 91));
            builder.Append((char)random.Next(65, 91));
            builder.Append((char)random.Next(65, 91));
            builder.Append((char)random.Next(65, 91));
            builder.Append(random.Next(1000, 10000));
            builder.Append((char)random.Next(97, 123));
            builder.Append((char)random.Next(97, 123));
            builder.Append((char)random.Next(97, 123));
            builder.Append((char)random.Next(97, 123));
            builder.Append((char)random.Next(97, 123));
        
            return builder.ToString();
        }

        private void fillRankings(List<UserScore> userScores)
        {
            fillRankingsRow(0, userScores, textBoxRankingsFirst, textBoxRankingsFirst2, textBoxRankingsFirst3);
            fillRankingsRow(1, userScores, textBoxRankingsSecond, textBoxRankingsSecond2, textBoxRankingsSecond3);
            fillRankingsRow(2, userScores, textBoxRankingsThird, textBoxRankingsThird2, textBoxRankingsThird3);
            fillRankingsRow(3, userScores, textBoxRankingsFourth, textBoxRankingsFourth2, textBoxRankingsFourth3);
            fillRankingsRow(4, userScores, textBoxRankingsFifth, textBoxRankingsFifth2, textBoxRankingsFifth3);
            fillRankingsRow(5, userScores, textBoxRankingsSixth, textBoxRankingsSixth2, textBoxRankingsSixth3);
            fillRankingsRow(6, userScores, textBoxRankingsSeventh, textBoxRankingsSeventh2, textBoxRankingsSeventh3);
            fillRankingsRow(7, userScores, textBoxRankingsEighth, textBoxRankingsEighth2, textBoxRankingsEighth3);
        }

        private void changeRankingsPage(string direction)
        {
            string command = "get-rankings";

            sendCommand(command);

            string response = getResponse();

            List<UserScore> userScores = (List<UserScore>)javaScriptSerializer.Deserialize(response, typeof(List<UserScore>));

            if (direction.Equals("next"))
            {
                if (firstScoreIndex + 8 < userScores.Count)
                {
                    firstScoreIndex += 8;
                    fillRankings(userScores);
                }
            }

            else
            {
                if(firstScoreIndex - 8 >= 0)
                {
                    firstScoreIndex -= 8;
                    fillRankings(userScores);
                }
            } 
        }

        private void fillRankingsRow(int row, List<UserScore> userScores, TextBox first, TextBox second, TextBox third)
        {
            if (firstScoreIndex + row < userScores.Count && firstScoreIndex + row >= 0)
            {
                if (row == 0)
                {
                    clearRankings();
                }

                first.Text = (firstScoreIndex + row + 1).ToString();
                second.Text = userScores[firstScoreIndex + row].userName;
                third.Text = userScores[firstScoreIndex + row].score.ToString();

                if (firstScoreIndex + row == playerScoreIndex)
                {
                    first.ForeColor = Color.Green;
                    second.ForeColor = Color.Green;
                    third.ForeColor = Color.Green;
                }
            }
        }

        private void clearRankings()
        {
            textBoxRankingsFirst.ForeColor = Color.Yellow;
            textBoxRankingsFirst2.ForeColor = Color.Yellow;
            textBoxRankingsFirst3.ForeColor = Color.Yellow;
            textBoxRankingsSecond.ForeColor = Color.Yellow;
            textBoxRankingsSecond2.ForeColor = Color.Yellow;
            textBoxRankingsSecond3.ForeColor = Color.Yellow;
            textBoxRankingsThird.ForeColor = Color.Yellow;
            textBoxRankingsThird2.ForeColor = Color.Yellow;
            textBoxRankingsThird3.ForeColor = Color.Yellow;
            textBoxRankingsFourth.ForeColor = Color.Yellow;
            textBoxRankingsFourth2.ForeColor = Color.Yellow;
            textBoxRankingsFourth3.ForeColor = Color.Yellow;
            textBoxRankingsFifth.ForeColor = Color.Yellow;
            textBoxRankingsFifth2.ForeColor = Color.Yellow;
            textBoxRankingsFifth3.ForeColor = Color.Yellow;
            textBoxRankingsSixth.ForeColor = Color.Yellow;
            textBoxRankingsSixth2.ForeColor = Color.Yellow;
            textBoxRankingsSixth3.ForeColor = Color.Yellow;
            textBoxRankingsSeventh.ForeColor = Color.Yellow;
            textBoxRankingsSeventh2.ForeColor = Color.Yellow;
            textBoxRankingsSeventh3.ForeColor = Color.Yellow;
            textBoxRankingsEighth.ForeColor = Color.Yellow;
            textBoxRankingsEighth2.ForeColor = Color.Yellow;
            textBoxRankingsEighth3.ForeColor = Color.Yellow;

            textBoxRankingsFirst.Text = "";
            textBoxRankingsFirst2.Text = "";
            textBoxRankingsFirst3.Text = "";
            textBoxRankingsSecond.Text = "";
            textBoxRankingsSecond2.Text = "";
            textBoxRankingsSecond3.Text = "";
            textBoxRankingsThird.Text = "";
            textBoxRankingsThird2.Text = "";
            textBoxRankingsThird3.Text = "";
            textBoxRankingsFourth.Text = "";
            textBoxRankingsFourth2.Text = "";
            textBoxRankingsFourth3.Text = "";
            textBoxRankingsFifth.Text = "";
            textBoxRankingsFifth2.Text = "";
            textBoxRankingsFifth3.Text = "";
            textBoxRankingsSixth.Text = "";
            textBoxRankingsSixth2.Text = "";
            textBoxRankingsSixth3.Text = "";
            textBoxRankingsSeventh.Text = "";
            textBoxRankingsSeventh2.Text = "";
            textBoxRankingsSeventh3.Text = "";
            textBoxRankingsEighth.Text = "";
            textBoxRankingsEighth2.Text = "";
            textBoxRankingsEighth3.Text = "";
        }

        private async void selectAnswer(Label label)
        {
            pictureBoxGameGiveUp.Enabled = false;
            pictureBoxGameSearch.Enabled = false;
            pictureBoxGameFriend.Enabled = false;
            pictureBoxGame5050.Enabled = false;
            labelGameAnswerD.Enabled = false;
            labelGameAnswerC.Enabled = false;
            labelGameAnswerB.Enabled = false;
            labelGameAnswerA.Enabled = false;

            Image yellow, green, red;

            if (label.Equals(labelGameAnswerA))
            {
                yellow = Properties.Resources.template_yellow_1;
                green = Properties.Resources.template_green_1;
                red = Properties.Resources.template_red_1;
            }

            else if (label.Equals(labelGameAnswerB))
            {
                yellow = Properties.Resources.template_yellow_2;
                green = Properties.Resources.template_green_2;
                red = Properties.Resources.template_red_2;
            }

            else if (label.Equals(labelGameAnswerC))
            {
                yellow = Properties.Resources.template_yellow3;
                green = Properties.Resources.template_green_3;
                red = Properties.Resources.template_red_3;
            }

            else
            {
                yellow = Properties.Resources.template_yellow_4;
                green = Properties.Resources.template_green_4;
                red = Properties.Resources.template_red_4;
            }

            pictureBoxGameQuestionForm.Image = yellow;
            label.BackColor = Color.Yellow;

            await Task.Delay(2000);

            if (currentQuestion.correctAnswer.Equals(label.Text))
            {
                pictureBoxGameQuestionForm.Image = green;
                label.BackColor = Color.FromArgb(9, 212, 22);

                await Task.Delay(1000);

                showCorrectAnswer();
            }

            else
            {
                pictureBoxGameQuestionForm.Image = red;
                label.BackColor = Color.Red;

                await Task.Delay(1000);
                showWrongAnswer();
            }
        }

        private void endGame(string reason)
        {
            int sumWon = getSumWon(reason);

            if (sumWon < 1000)
            {
                labelMessageCreditsWonNumber.Text = sumWon + " кр.";
            }

            else
            {
                labelMessageCreditsWonNumber.Text = sumWon / 1000 + " " + sumWon % 1000 + " кр.";
            }

            userScore.score += sumWon;
            labelHomeCreditsNumber.Text = userScore.score.ToString();
            string command = "update-score --username " + userScore.userName + " --score " + userScore.score;

            sendCommand(command);

            string response = getResponse();

            panelMessage.Show();
        }

        private string getResponse()
        {
            while (responses.Count < 1)
            {

            }

            string response = responses[0];

            while (response == null || response != responses[0])
            {
                response = responses[0];
            }

            responses.RemoveAt(0);

            return response;
        }
    }
}
