<?php

class SQL
{
    public $dbname;
    public $table;

    public function __construct($dbname = "", $table = "")
    {
        $this->dbname = $dbname;
        $this->table = $table;
    }
    public function __setDB(string $db)
    {
        $this->dbname = $db;
    }
    public function __get(string $name)
    {
        return $this->dbname;
    }
    public function __setTablename(string $name)
    {
        $this->table = $name;
    }
    public function __getTablename()
    {
        return $this->table;
    }
    public function __connectDB($servername = "localhost", $username = "root", $password = ""): mysqli
    {
        $server = $servername;
        $user = $username;
        $pword = $password;
        $dbname = $this->dbname;

        $conn = new mysqli($server, $user, $pword, $dbname);

        if ($conn->connect_error) {
            die("Connection failed: " . $conn->connect_error);
        }

        return $conn;
    }
    public function __userExists($name, $password, $tablerowname = "Name", $tablerowpassword = "Password"): bool
    {
        $conn = $this->__connectDB();
        $count = 0;

        $stmt = $conn->prepare("SELECT COUNT(*) FROM " . $this->table . " WHERE " . $tablerowname . " = ? AND " . $tablerowpassword . " = ?");
        $stmt->bind_param("ss", $name, $password);
        $stmt->execute();
        $stmt->bind_result($count);
        $stmt->fetch();
        $stmt->close();
        $conn->close();
        return $count > 0;

    }
}