<?php

require 'index.php';

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $username = $_POST['username'];
    $password = $_POST['password'];
    $email = $_POST['email'];
    $confirm_password = $_POST['confirm_password'];
    // Verificar si l'usuari ja existeix
    $stmt = $conn->prepare("SELECT * FROM users WHERE Name = ?");
    $stmt->bind_param("s", $username);
    $stmt->execute();
    if ($password !== $confirm_password) {
        $error_message = "Las contraseñas no coincideixen. Si us plau, torna-ho a intentar.";
    }

    if ($stmt->rowCount() > 0) {
        echo "Aquest usuari ja existeix. Torna a intentar-ho.";
    } else {
        // Encriptar la contrasenya
        $hashed_password = password_hash($password, PASSWORD_DEFAULT);

        // Inserir l'usuari a la base de dades
        $stmt = $conn->prepare("INSERT INTO users (Name, Password, Email) VALUES (?, ?, ?)");
        $stmt->bind_param("sss", $username, $hashed_password, $email);
        $stmt->execute();

        echo "Registre completat amb èxit.";
    }
}

?>