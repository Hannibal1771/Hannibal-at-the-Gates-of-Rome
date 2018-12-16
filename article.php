<!DOCTYPE html>
<html>
<head>
	<?php
	require_once "functions/functions.php";
	$news = getNews(1, $_GET["id"]);
	$title = $news["title"];
	require_once "blocks/head.php"; 
	?>	
</head>
<body>
	
	<?php require_once "blocks/header.php"
	 ?>

	<div id="wrapper">
		<div id="leftCol">
			<?php 
				echo '<img src="image/article'.$news["id"].'.jpg" alt="Статья'.$news["id"].'" title="Статья'.$news["id"].'">
				<h2>'.$news[$i]["intro_text"].'</h2>
				<p>'.$news[$i]["full_text"].'
				</p>
				
			</div>';
			?>
			
		<?php require_once "blocks/rightCol.php" ?>
	</div>	


	<?php require_once "blocks/footer.php" ?>
</body>
</html>