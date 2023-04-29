$(function () {
    $("#searchBy").on("blur", function () {
        var searchTerm = $("#searchBy").val();
        $("#searchByTitle").attr("href", $("#searchByTitle").attr("href").replace("dummy", searchTerm));
        $("#searchByAuthor").attr("href", $("#searchByAuthor").attr("href").replace("dummy", searchTerm));
    })
});