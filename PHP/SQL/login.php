<?php

require 'index.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = $_POST['username'];
    $password = $_POST['password'];

    // Connexió a la base de dades
    $conn = new mysqli('localhost', 'root', '', 'appphp');

    // Buscar l'usuari a la base de dades
    $stmt = $conn->prepare("SELECT * FROM users WHERE Name = ?");
    $stmt->bind_param("s", $username);
    $stmt->execute();
    $user = $stmt->fetch();

    if ($user && password_verify($password, $user['Password'])) {
        // Iniciar sessió si les credencials són correctes
        session_start();
        $_SESSION['username'] = $user['Name'];
        header('Location: index.php');
    } else {
        echo "Credencials incorrectes. Torna a intentar-ho.";
    }
}

?>