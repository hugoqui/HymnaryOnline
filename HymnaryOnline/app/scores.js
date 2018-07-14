function CallInstruments(song) {

    
    if (window.location.toString().toLowerCase().indexOf("lyrics") > 0) {
        console.log("Lyrics ", song);
        var lines = "  ";
        if (song.Lyrics != null) {
            lines = song.Lyrics.split("\n");
        }
        
        var element = '<div class="bubble">';
        for (var line in lines) { element = element + "<p>" + lines[line] + "</p>"; }
        element = element + "</div>"

        var currentElement = $("#lyrics").html();
        if (currentElement != element) {
            $("#lyrics").html(element);
        }
    }

    if (window.location.toString().toLowerCase().indexOf("clarinet") > 0) {
        console.log("Clarinete - ", song.Clarinet)
        var element = '<img class="score-sheet" src="' + song.Clarinet + '" />';

        var currentElement = $(".score-sheet");
        var currentScore = "";
        if (currentElement.length > 0) { currentScore = currentElement[0].getAttribute('src'); }
        if (currentScore != song.Clarinet) { $("#score").html(element); }
    }

    if (window.location.toString().toLowerCase().indexOf("violin") > 0) {
        console.log("Violin 1 - ", song.Violin)
        var element = '<img class="score-sheet" src="' + song.Violin + '" />';

        var currentElement = $(".score-sheet");
        var currentScore = "";
        if (currentElement.length > 0) { currentScore = currentElement[0].getAttribute('src'); }
        if (currentScore != song.Violin) { $("#score").html(element); }
    }

    if (window.location.toString().toLowerCase().indexOf("guitar") > 0) {
        console.log("Guitarra - ", song.Guitar)
        var element = '<img class="score-sheet" src="' + song.Guitar + '" />';

        var currentElement = $(".score-sheet");
        var currentScore = "";
        if (currentElement.length > 0) { currentScore = currentElement[0].getAttribute('src'); }
        if (currentScore != song.Guitar) { $("#score").html(element); }

    }

}
