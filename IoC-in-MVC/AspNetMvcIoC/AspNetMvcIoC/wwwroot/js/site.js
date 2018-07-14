function LoadContent() {
	$.get("/home/getloginfo", function (data) {
		$("p#log-info").html(data);
	});
}

$(document).ready(function () {
	$('#get-log-info-button').on('click',
		function(e) {
			LoadContent();
		});
});