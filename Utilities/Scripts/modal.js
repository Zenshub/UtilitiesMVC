var revierseuri = 'api/ReverseWords/GetReversedWords';

     $("#textsubmit").click(function(event){
    var param = $('#text').val();
      // Send an AJAX request
      $.getJSON(revierseuri + '/' + param)
          .done(function (data) {
            // On success, 'data' contains a reversed string.
            var text = "Result: " + data;
              $("#reverseresult").text(text);
          });
    });

    var feboUri = 'api/Fibonacci/GetFibonacci';

     $("#numbersubmit").click(function(event){
    var param = $('#number').val();
      // Send an AJAX request
      $.getJSON(feboUri + '/' + param)
          .done(function (data) {
            // On success, 'data' contains a number.
            var text = "Result: " + data;
              $("#fiboresult").text(text);
          });
    });

     var triangleUrl = 'api/TriangleType/GetTriangleType';

     $("#gettriangle").click(function(event){
    var a1 = $('#a').val();
    var b1 = $('#b').val();
    var c1 = $('#c').val();
    var param = JSON.stringify({ SideA: a1, SideB: b1, SideC:c1 });

      // Send an AJAX request
      $.ajax({
      	url:triangleUrl,
      	type: 'POST',
      	contentType: 'application/json',
      	data: param,
      	success: function(result){
      	var text = "Result: " + result;
      	$("#resulttype").text(text);
      	}
      }); 

    });