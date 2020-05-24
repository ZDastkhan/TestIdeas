$(function () {
    //DOM loaded here
});

function changeCalculationType(selectedValue) {
    if (selectedValue == 'SinglePT') {
        $('#singlePT').show(500);
        $('#multipleP-singleT').hide(500);
        $('#multipleT-singleP').hide(500);

    } else if (selectedValue == 'MultiplePSingleT') {
        $('#singlePT').hide(500);
        $('#multipleP-singleT').show(500);
        $('#multipleT-singleP').hide(500);
    } else if (selectedValue == 'MultipleTSingleP') {
        $('#singlePT').hide(500);
        $('#multipleP-singleT').hide(500);
        $('#multipleT-singleP').show(500);

    }
}

function calculateGasProperties() {
    //validate
    var myData = $('#gas-properties-form').serialize();
    var url = "/GasProperties/CalculateGasProperties";

    var options = {
        url: url,
        type: "POST",
        data: myData
    };

    $.ajax(options)
        .done(function (response) {
            var obj = JSON.parse(response);
            document.getElementById("calculationMessage").innerText = obj.Message;

            if (obj.IsSuccessful) {
                
                $("#results").css({ 'display': 'block' });
            }
            else {
                $("#results").css({ 'display': 'none' });
            }
        })
}