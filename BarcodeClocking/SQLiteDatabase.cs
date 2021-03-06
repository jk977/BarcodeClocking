﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

class SQLiteDatabase {
    String dbConnection;
    public static String fileName = "barcode.sqlite";

    static String avgHoursTable = "CREATE TABLE `avgHours` ("
        + "`id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,`employeeID` INTEGER NOT NULL,"
        + "`dayOfWeek` TEXT NOT NULL, `clockIn` TEXT NOT NULL,`clockOut` TEXT NOT NULL);";

    static String employeesTable = "CREATE TABLE `employees` ("
        + "`employeeID`	INTEGER NOT NULL UNIQUE,`firstName`	TEXT NOT NULL,"
        + "`LastName` TEXT NOT NULL, `MiddleName` TEXT, `hourlyRate` NUMERIC NOT NULL,"
        + "`employeeType` TEXT NOT NULL, `currentClockInId` INTEGER, PRIMARY KEY(employeeID) );";

    static String settingsTable = "CREATE TABLE `settings` ("
        + " `name` TEXT NOT NULL UNIQUE, `value` TEXT, PRIMARY KEY(name) );";

    static String timeStampsTable = "CREATE TABLE `timeStamps` ("
        + " `id` INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE,"
        + " `employeeID` INTEGER NOT NULL, `clockIn` TEXT NOT NULL, `clockOut` TEXT);";

    /// <summary>
    ///     Default Constructor for SQLiteDatabase Class.
    /// </summary>
    public SQLiteDatabase() {
        dbConnection = "Data Source=" + fileName;
        SetDB();
    }

    /// <summary>
    ///     Single Param Constructor for specifying the DB file.
    /// </summary>
    /// <param name="inputFile">The File containing the DB</param>
    public SQLiteDatabase(String inputFile) {
        dbConnection = String.Format("Data Source={0}", inputFile);
        SetDB();
    }

    /// <summary>
    ///     Single Param Constructor for specifying advanced connection options.
    /// </summary>
    /// <param name="connectionOpts">A dictionary containing all desired options and their values</param>
    public SQLiteDatabase(Dictionary<String, String> connectionOpts) {
        String str = "";

        foreach (KeyValuePair<String, String> row in connectionOpts) {
            str += String.Format("{0}={1}; ", row.Key, row.Value);
        }

        str = str.Trim().Substring(0, str.Length - 1);
        dbConnection = str;
    }

    /// <summary>
    ///     Allows the programmer to run a query against the Database.
    /// </summary>
    /// <param name="sql">The SQL to run</param>
    /// <returns>A DataTable containing the result set.</returns>
    public DataTable GetDataTable(string sql) {
        DataTable dt = new DataTable();

        using (var cnn = new SQLiteConnection(dbConnection)) {
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn) { CommandText = sql };
            SQLiteDataReader reader = mycommand.ExecuteReader();
            dt.Load(reader);
            reader.Close();
        }

        return dt;
    }

    /// <summary>
    ///     Allows the programmer to interact with the database for purposes other than a query.
    /// </summary>
    /// <param name="sql">The SQL to be run.</param>
    /// <returns>An Integer containing the number of rows updated.</returns>
    public int ExecuteNonQuery(string sql) {
        int rowsUpdated = -1;

        using (var cnn = new SQLiteConnection(dbConnection)) {
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn) { CommandText = sql };
            rowsUpdated = mycommand.ExecuteNonQuery();
        }

        return rowsUpdated;
    }

    /// <summary>
    ///     Allows the programmer to retrieve single items from the DB.
    /// </summary>
    /// <param name="sql">The query to run.</param>
    /// <returns>A string.</returns>
    public string ExecuteScalar(string sql) {
        object value = null;

        using (var cnn = new SQLiteConnection(dbConnection)) {
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            value = mycommand.ExecuteScalar();
        }

        return value != null ?
            value.ToString() :
            "";
    }

    /// <summary>
    ///     Allows the programmer to easily update rows in the DB.
    /// </summary>
    /// <param name="tableName">The table to update.</param>
    /// <param name="data">A dictionary containing Column names and their new values.</param>
    /// <param name="where">The where clause for the update statement.</param>
    /// <returns>A boolean true or false to signify success or failure.</returns>
    public bool Update(String tableName, Dictionary<String, String> data, String where) {
        String vals = "";
        bool returnCode = true;

        if (data.Count >= 1) {
            foreach (KeyValuePair<String, String> val in data) {
                vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString());
            }

            vals = vals.Substring(0, vals.Length - 1);
        }

        try {
            ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where));
        } catch {
            returnCode = false;
        }

        return returnCode;
    }

    /// <summary>
    ///     Allows the programmer to easily delete rows from the DB.
    /// </summary>
    /// <param name="tableName">The table from which to delete.</param>
    /// <param name="where">The where clause for the delete.</param>
    /// <returns>A boolean true or false to signify success or failure.</returns>
    public bool Delete(String tableName, String where) {
        bool returnCode = true;

        try {
            ExecuteNonQuery(String.Format("delete from {0} where {1};", tableName, where));
        } catch (Exception fail) {
            MessageBox.Show(fail.Message);
            returnCode = false;
        }

        return returnCode;
    }

    /// <summary>
    ///     Allows the programmer to easily insert into the DB
    /// </summary>
    /// <param name="tableName">The table into which we insert the data.</param>
    /// <param name="data">A dictionary containing the column names and data for the insert.</param>
    /// <returns>A boolean true or false to signify success or failure.</returns>
    public bool Insert(String tableName, Dictionary<String, String> data) {
        String columns = "";
        String values = "";
        bool success = true;

        foreach (KeyValuePair<String, String> val in data) {
            columns += String.Format(" {0},", val.Key.ToString());
            values += String.Format(" '{0}',", val.Value);
        }

        columns = columns.Substring(0, columns.Length - 1);
        values = values.Substring(0, values.Length - 1);

        try {
            ExecuteNonQuery(String.Format("insert into {0}({1}) values({2});", tableName, columns, values));
        } catch (Exception fail) {
            MessageBox.Show(fail.Message);
            success = false;
        }

        return success;
    }

    /// <summary>
    ///     Allows the programmer to easily delete all data from the DB.
    /// </summary>
    /// <returns>A boolean true or false to signify success or failure.</returns>
    public bool ClearDB() {
        DataTable tables;
        bool success = true;

        try {
            tables = GetDataTable("select NAME from SQLITE_MASTER where type='table' order by NAME;");

            foreach (DataRow table in tables.Rows) {
                ClearTable(table["NAME"].ToString());
            }
        } catch {
            success = false;
        }

        return success;
    }

    /// <summary>
    ///     Allows the user to easily clear all data from a specific table.
    /// </summary>
    /// <param name="table">The name of the table to clear.</param>
    /// <returns>A boolean true or false to signify success or failure.</returns>
    public bool ClearTable(String table) {
        bool success = true;

        try {
            ExecuteNonQuery(String.Format("delete from {0};", table));
        } catch {
            success = false;
        }

        return success;
    }

    public void SetDB() {
        if (!File.Exists(fileName)) {
            try {
                SQLiteConnection.CreateFile(fileName);

                ExecuteNonQuery(avgHoursTable);
                ExecuteNonQuery(employeesTable);
                ExecuteNonQuery(settingsTable);
                ExecuteNonQuery(timeStampsTable);
            } catch (Exception err) {
                MessageBox.Show("There was an error while trying to create the database file.\n\n" + err.Message, "Database Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

