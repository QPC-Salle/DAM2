<?php
include 'SQL.php';
$DB = "apphp";
session_start();
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <h1>Iniciar Sessio</h1>
    <form action="login.php" method="post">
        <label for="username">Nom d'usuari:</label>
        <input type="text" id="username" name="username" required>
        <br>
        <label for="password">Contrasenya:</label>
        <input type="password" id="password" name="password" required>
        <br>
        <button type="submit"><a href="login.php"></a>Iniciar Sessio</button>

    </form>
</body>

<body>
    <div class="contenidor">
        <h1>Registro de Usuario</h1>
        <form method="POST" action="register.php">
            <input type="text" name="username" placeholder="Nombre de Usuario" required><br>
            <input type="password" name="password" placeholder="Contraseña" required><br>
            <input type="password" name="confirm_password" placeholder="Confirmar Contraseña" required><br>
            <span class="error_message"><?php if (isset($error_message))
                echo $error_message; ?></span>
            <input type="submit" value="Registrar">
            <a href="registra.php">Registrar-se</a>
        </form>
    </div>
</body>

</html>