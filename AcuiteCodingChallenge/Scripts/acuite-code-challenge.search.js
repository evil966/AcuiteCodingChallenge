$(function () {
    $("#searchBy").on("blur", function () {
        var searchTerm = $("#searchBy").val();
        var idxTitle = $("#searchByTitle").attr("href").indexOf("=");
        var idxAuthor = $("#searchByAuthor").attr("href").indexOf("=");

        $("#searchByTitle").attr("href", $("#searchByTitle").attr("href").substring(0, idxTitle + 1) + searchTerm);
        $("#searchByAuthor").attr("href", $("#searchByAuthor").attr("href").substring(0, idxAuthor + 1) + searchTerm);
    })
});