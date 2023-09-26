$(document).foundation();
$.ajax(
  "https://localhost:7184/api/v1/Grupa", // request url
  {
    success: function (data, status, xhr) {
      // success callback function
      //console.log(data);
      for (let i = 0; i < data.length; i++) {
        $("#podaci").append("<li>" + data[i].naziv + "</li>");
      }
    },
  }
);

$("#dodaj").click(function () {
  $.ajax("https://localhost:7184/api/v1/Grupa", {
    type: "POST", // http method
    dataType: "json",
    contetType: "application/json",
    data: { naziv: $("naziv").val(), trajanje: $("trajanje").val() }, // data to submit
    success: function (data, status, xhr) {
      $("#podaci").append("<li>" + data[i].naziv + "</li>");
    },
    error: function (jqXhr, textStatus, errorMessage) {
      alert(errorMessage);
    },
  });

  return false;
});
