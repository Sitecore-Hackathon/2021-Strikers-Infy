window.addEventListener('DOMContentLoaded', (event) => {
    getlangs();
});

function getlangs() {
    var parameters = JSON.stringify({});
    $.ajax({
        async: true,
        type: "POST",
        url: "/api/Translator/GetActiveLanguages",
        data: parameters,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data != null) {
                displayLangs(data);
            }
        },
        error: function (response) {
            if (response != null) {
                var errorElm = document.getElementById("ErrorText");
                errorElm.innerText = response;
            }
        },
        failure: function (response) {

        }
    });
}

function displayLangs(languages) {
    if (languages != null && languages.length > 0) {
        var langDropDownHtml = "";
        $.each(languages, function (index, lang) {
            langDropDownHtml += "<option value=" + lang.LangCode + ">" + lang.LangName + "</option>";
        });

        var langElm = document.getElementById("TranslateLanguage");
        langElm.innerHTML = langDropDownHtml;
    }
}

function clearData(element, evt) {
    evt.preventDefault();
    var textFrom = document.getElementById("TextFrom");
    textFrom.value = "";
    var respElm = document.getElementById("ResultText");
    respElm.innerText = "";
}

function translateData(element, evt) {
    evt.preventDefault();
    var textFrom = document.getElementById("TextFrom").value;
    var selectedlanguage = document.getElementById("TranslateLanguage").value;

    var respElm = document.getElementById("ResultText");
    respElm.innerText = "";

    var parameters = JSON.stringify({ LangCode: selectedlanguage, ContentText: textFrom });
    $.ajax({
        async: true,
        type: "POST",
        url: "/api/Translator/TranslateContentAsync",
        data: parameters,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (data) {
            if (data != null) {
                respElm.innerText = data;
            }
        },
        error: function (response) {
            if (response != null) {
                var errorElm = document.getElementById("ErrorText");
                errorElm.innerText = response;
            }
        },
        failure: function (response) {

        }
    });
}