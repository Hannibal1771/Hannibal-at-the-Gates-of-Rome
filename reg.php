<!DOCTYPE html>
<html>
<head>
	<meta charset="UTF-8">
	<meta name="viewport"
		content="wdth=device=width, user=scalable=no, initial-scale=1.0, minimum-scale=1.0">
	<meta http-equiv="X-UA-Compatible" content="ie=edge">
	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
	<link href="css/style11.css" rel="stylesheet" type="text/css">
	<title>Регистрация в системе</title>
</head>
<body>
	<?php
	require('connect.php');
	if (isset($_POST['username']) && isset($_POST['password'])){
		$username = $_POST['username'];
		$email = $_POST['email'];
		$password = $_POST['password'];
		$query = "INSERT INTO users (username, email, password) VALUES ('$username', '$email', '$password')";
		$result = mysqli_query($connection, $query);

		if($result){
			$smsg = "Регистрация прошла успешно";
		}
		else{
			$fmsg = "Ошибка регистрации";
		}
	}
	?>
	<div class="container">
		<form class="form-signin" method="POST">
			<h2>Регистрация в системе</h2>
			<?php if(isset($smsg)){?><div class="alert alert-success" role="alert"> <?php echo $smsg; ?> </div><?php} ?>
			<?php if(isset($fmsg)){?><div class="alert alert-danger" role="alert"> <?php echo $fmsg; ?> </div><?php} ?>
			<input type="text" name="username" class="form-control" placeholder="Введите логин" required>
			<input type="email" name="login" class="form-control" placeholder="Введите email" required>
			<input type="password" name="password" class="form-control" placeholder="Введите пароль " required>
			<button type="button" class="btn btn-success">Регистрация</button>
		</form>
	</div>
</body>
</html>