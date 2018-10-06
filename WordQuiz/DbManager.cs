using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Globalization;

namespace WordQuiz
{
    class DbManager
    {
        private const string dbPath = "Data Source=db/database.s3db";

        /// <summary>
        /// Fills a <see cref="WordHolder"/> with data of CSV file.
        /// </summary>
        public static WordHolder ImportCsvToWordHolder(string path, bool isFirstRowHeader)
        {
            try
            {
                string header = isFirstRowHeader ? "Yes" : "No";
                string pathOnly = Path.GetDirectoryName(path);
                string fileName = Path.GetFileName(path);
                string sql = @"SELECT * FROM [" + fileName + "]";
                WordHolder wordHolder = new WordHolder();
                using (OleDbConnection cnt = new OleDbConnection(
                    @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + pathOnly +
                    ";Extended Properties=\"Text;HDR=" + header + "\""))
                using (OleDbCommand cmd = new OleDbCommand(sql, cnt))
                using (OleDbDataAdapter adapter = new OleDbDataAdapter(cmd))
                {
                    cnt.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            wordHolder.Add(reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                        }
                    }
                    cnt.Close();
                }
                return wordHolder;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return new WordHolder();
            }
        }

        /// <summary>
        /// Inserts given word into database.
        /// </summary>
        public static void InsertWord(Word word)
        {
            try
            {
                string sql = "INSERT INTO words (wrd_english, wrd_spanish, wrd_unitId) VALUES (@eng, @esp, @unt)";
                using (SQLiteConnection cnt = new SQLiteConnection(dbPath))
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnt))
                {
                    cmd.Parameters.AddWithValue("@eng", word.English);
                    cmd.Parameters.AddWithValue("@esp", word.Spanish);
                    cmd.Parameters.AddWithValue("@unt", word.UnitId);
                    cnt.Open();
                    cmd.ExecuteNonQuery();
                    cnt.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Insert new rows to database from a CSV file.
        /// </summary>
        public static void ImportCsvToDatabase(string path, bool isFirstRowHeader)
        {
            WordHolder temp = ImportCsvToWordHolder(path, isFirstRowHeader);
            temp.InsertIntoDatabase();
        }

        /// <summary>
        /// Fills the <see cref="WordHolder"/> with all the data from database
        /// </summary>
        public static void FillWordHolder(WordHolder wordHolder)
        {
            string sql = "SELECT * FROM words";
            try
            {
                using (SQLiteConnection cnt = new SQLiteConnection(dbPath))
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnt))
                {
                    cnt.Open();
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            wordHolder.Add(rdr.GetString(1), rdr.GetString(2), rdr.GetInt32(3));
                        }
                    }
                    cnt.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills the <see cref="UnitHolder"/> with all the data from database
        /// </summary>
        public static void FillUnitHolder(UnitHolder unitHolder)
        {
            string sql = "SELECT * FROM units";
            try
            {
                using (SQLiteConnection cnt = new SQLiteConnection(dbPath))
                using (SQLiteCommand cmd = new SQLiteCommand(sql, cnt))
                {
                    cnt.Open();
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            unitHolder.Add(rdr.GetInt32(0), rdr.GetString(1));
                        }
                    }
                    cnt.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Executes given SQL command, doesnt return anything.
        /// </summary>
        public static void Execute(string command)
        {
            try
            {
                using (SQLiteConnection cnt = new SQLiteConnection(dbPath))
                using (SQLiteCommand cmd = new SQLiteCommand(command, cnt))
                {
                    cnt.Open();
                    cmd.ExecuteNonQuery();
                    cnt.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Fills the List of Word with returned table of SQL.
        /// </summary>
        /// <param name="i">Column of english translations</param>
        /// <param name="j">Column of spanish translations</param>
        /// <param name="k">Column of unit numbers</param>
        public static void Execute(string command, List<Word> words, int i, int j, int k)
        {
            try
            {
                using (SQLiteConnection cnt = new SQLiteConnection(dbPath))
                using (SQLiteCommand cmd = new SQLiteCommand(command, cnt))
                {
                    cnt.Open();
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            words.Add(new Word(rdr.GetString(i), rdr.GetString(j), rdr.GetInt32(k)));
                        }
                    }
                    cnt.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
