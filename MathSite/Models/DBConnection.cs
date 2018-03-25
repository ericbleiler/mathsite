using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;
using System.Windows;
using System.Web.UI;

namespace MathSite.Models
{
  
        public class DBConnection
        {

        //private List<Result> listResults = new List<Result>();
        private string aUserName;
        private int aQuestion;
        private string aPassword;
        private OleDbConnection aConnection = new OleDbConnection();


        public void CreateUser(string UserName, string Password, string Password1)
        {
            string aSql = " ";
            if (Password == Password1)
            {

                aSql = "INSERT INTO UserTable(UserName, UserPassword)";
                aSql = aSql + "VALUES('" + UserName + "','" + Password + "')";


                aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";



                aConnection.Open();

                OleDbCommand aCommand = aConnection.CreateCommand();

                aCommand.CommandText = aSql;

                aCommand.ExecuteNonQuery();



                aConnection.Close();
            }
        }

        public string GetUserName(string name, string pass)
        {

            string uPass = pass;
            string aSQL = "SELECT UserName, UserPassword" +
                       " FROM UserTable " +
                       " WHERE UserName =  '" + name + "';";


            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();
            
            while (aReader.Read())
            {

                string aName = (string)aReader["UserName"];
                string aPass = (string)aReader["UserPassword"];

                aUserName = aName;
                aPassword = aPass;
            }
            return aUserName; 
        
        }

        public int Addition1(string user)
        {
            
            string aSQL = "SELECT UserName, Question " +
                       " FROM Addition " +
                       " WHERE UserName =  '" + user + "';";

            if (aConnection.ConnectionString != @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;")
            {

                aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";
            }

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {

                string aName = (string)aReader["UserName"];
                int num = (int)aReader["Question"];

                aUserName = aName;
                aQuestion = num;

            }
            return aQuestion;

        }



        public int AddAddition(int num1, int num2, int userAnswer, int correctAnswer, int questionNum, string userName, int addLevel)
        {


            string aSql = "INSERT INTO Addition(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
                aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + userAnswer + ", " + correctAnswer + ", " + questionNum + ",'" + userName +"'," + addLevel + ")";

                aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

                bool flag = false;

                aConnection.Open();

                OleDbCommand aCommand1 = aConnection.CreateCommand();

                aCommand1.CommandText = aSql;

                aCommand1.ExecuteNonQuery();


                flag = true;
                
                aConnection.Close();
            
            return questionNum;

        }

        public bool DeleteAddition(int addLevel)
        {
            string aSQL = "DELETE FROM Addition WHERE AddLevel = " + addLevel + "";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            aCommand.ExecuteNonQuery();
            return true;
        }

        public bool AddSubtraction(int num1, int num2, int userAnswer, int correctAnswer, int questionNum, string userName, int addLevel)
        {

            // DeleteSubtraction(num1, num2, userAnswer, correctAnswer, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Subtraction(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + userAnswer + ", " + correctAnswer + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

            bool flag = false;

            aConnection.Open();

            OleDbCommand aCommand1 = aConnection.CreateCommand();

            aCommand1.CommandText = aSql;

            aCommand1.ExecuteNonQuery();


            flag = true;
            aConnection.Close();

            return flag;

        }

        public bool AddMultiplication(int num1, int num2, int userAnswer, int correctAnswer, int questionNum, string userName, int addLevel)
        {

            // DeleteMultiplication(num1, num2, userAnswer, correctAnswer, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Multiplication(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + userAnswer + ", " + correctAnswer + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

            bool flag = false;

            aConnection.Open();

            OleDbCommand aCommand1 = aConnection.CreateCommand();

            aCommand1.CommandText = aSql;

            aCommand1.ExecuteNonQuery();


            flag = true;
            aConnection.Close();

            return flag;

        }
        public bool AddDivision(int num1, int num2, int userAnswer, int correctAnswer, int questionNum, string userName, int addLevel)
        {

            // DeleteDivision(num1, num2, userAnswer, correctAnswer, questionNum, userName, addLevel);

            string aSql = "INSERT INTO Division(num1, num2, UserAnswer, CorrectAnswer, Question, UserName, AddLevel)";
            aSql = aSql + "VALUES(" + num1 + "," + num2 + " , " + userAnswer + ", " + correctAnswer + ", " + questionNum + ",'" + userName + "'," + addLevel + ")";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
               Data Source=C:\Users\Eric\Desktop\MathSite\UserDatabase.mdb;";

            bool flag = false;

            aConnection.Open();

            OleDbCommand aCommand1 = aConnection.CreateCommand();

            aCommand1.CommandText = aSql;

            aCommand1.ExecuteNonQuery();


            flag = true;
            aConnection.Close();

            return flag;

        }
/*
        public List<Result> Result(string name)
        {


            string aSQL = "SELECT num1, num2, correctAnswer, userAnswer" +
                " FROM UserTable " +
                " WHERE UserName =  '" + name + "';";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            Data Source=C:\Users\Eric\Desktop\VisualProgramming\MusicStore\MusicStore\MusicStore.mdb;";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            // Read the data and store it in a list
            while (aReader.Read())
            {

                int aNum1 = (int)aReader["num1"];
                int aNum2 = (int)aReader["num2"];
                int aCorrectAnswer = (int)aReader["correctAnswer"];
                int aUserAnswser = (int)aReader["userAnswer"];

                Result aResult = new Result();

                aResult.AlbumId = aNum1;
                aResult.GenreId = aNum2;
                aResult.ArtistId = aCorrectAnswer;
                aResult.Title = aUserAnswer;
                

                aListResult.Add(aResult);

            }
            */
        }
    }
    