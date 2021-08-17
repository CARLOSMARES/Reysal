<php?
$nombre = strip_tags($_POST['name']);
$correo = strip_tags($_POST['mail']);
$comentario = strip_tags($_POST['comment']);
$correoDestino = "contacto@reysalcapacitaciones.com";
$headers =
	'From: ' . $correoFrom . "\r\n". 
	'Reply-To: ' . $correoDestino. "\r\n" . 
	'X-Mailer: PHP/' . phpversion() .
	'MIME-Version: 1.0\r\n'.
	'Content-type: text/html; charset=UTF-8\r\n';
	//Formateo el asunto del correo
$asunto = "Contacto WEB_$nombre $apellidos; de $empresa";
//Formateo el cuerpo del correo
$cuerpo = "Enviado por: " . $nombre;
$cuerpo .= "E-mail: " . $correo . "";
$cuerpo .= "Comentario: " . $comentario;
>