<?php
include('SQL.php');
$DB = "apphp";


$sql = new SQL($DB, "users");
try {
    $conn = $sql->__connectDB();
} catch (Exception $e) {
    die("Connection failed: " . $e->getMessage());
}
$conn->close();

if ($sql->__userExists($name, $password)) {
    echo "Login successful!";
} else {
    echo "Invalid credentials.";
}


?>