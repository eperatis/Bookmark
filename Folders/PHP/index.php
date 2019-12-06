<?php 
$method = $_SERVER['REQUEST_METHOD'];

if(array_key_exists('A', $_GET) && $_GET['A'] == 'hello') {

	switch($method) {
		case "GET":
		if(!empty($_GET['id'])) {
			$id = intval($_GET['id']);
			getBookmark($id);
		} else getBookmark();
		break;

		case "POST":
		insertBookmark();
		break;

		case "PUT":
		$id = intval($_GET['id']);
		updateBookmark($id);
		break;

		case "DELETE":
		$id = intval($_GET['id']);
		deleteBookmark($id);
		break;

		default:
		header("HTTP/1.0 405 Method Not Allowed");	
		break;
	}

	
} else {
	header('Content-Type: application/json');
	echo json_encode("WRONG AUTH INFO", JSON_UNESCAPED_UNICODE);
}

function getBookmark($id = 0) {
	$query = "SELECT * FROM bookmark";
	if($id != 0) $query.=" WHERE id=".$id." LIMIT 1";
	////////////
	include_once 'connection.php';
	$response = getList($query);

	header('Content-Type: application/json');
	echo json_encode($response);
}

function insertBookmark() {
	$data = json_decode(file_get_contents('php://input'), true);
	$query = "INSERT INTO bookmark (name, url) VALUES (:Name, :url)";
	$params = [
		":Name" => $data["Name"],
		":url" => $data["url"]
	];
	//////////////
	include_once 'connection.php';
	$response = executeDML($query, $params);
	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}

function updateBookmark($id) {
	$data = json_decode(file_get_contents('php://input'), true);
	$query = "UPDATE bookmark SET name = :Name, url = :url WHERE id = :id";
	$params = [
		":Name" => $data["Name"],
		":url" => $data["url"],
		":id" => $id
	];
	//////////////
	include_once 'connection.php';
	$response = executeDML($query, $params);
	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}

function deleteBookmark($id) {
	$query = "DELETE FROM bookmark WHERE id=".$id;
	//////////////
	include_once 'connection.php';
	$response = getList($query);

	header('Content-Type: application/json');
	echo json_encode($response, JSON_UNESCAPED_UNICODE);
}	
?>