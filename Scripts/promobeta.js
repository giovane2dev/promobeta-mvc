// tooltip

$('[data-toggle="tooltip"]').tooltip();
$('[data-toggle="tooltip"]').addClass("btn");

/*
 * BEGIN (CompanyUnits)
 */


// Create
$("#StateId").on("change", function () {
    let value = $(this).val();

    getCities(value);
})

function getCities(stateId) {
    $.ajax({
        type: "POST",
        url: "/CompanyUnits/Cities",
        dataType: 'json',
        data: { StateId: stateId },
        success: function (cities) {
            console.log(cities);
        }
    });

    return false;
}

/*
 * END
 */
