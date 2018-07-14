//$.connection.hub.url = 'http://thunderasp.azurewebsites.net/signalr';

var hymnary = $.connection.hymnaryHub;

$.connection.hub.start().done(function () {
    console.log("Conexión establecida...");
    hymnary.server.getCurrentSong();
    //if (hymnary.server.currentSong != null) {
    //    console.log("no, pos si hay canto");
    //}
});


hymnary.client.showSong = function (songName) {    
    CallInstruments(songName);
}

function SendSong(songName) {    
    hymnary.server.showSong(songName);
}


$(".list-group-item").click(function (e) {
    var songName = "";   
    switch (e.toElement.tagName) {
        case "H3":
            songName = e.toElement.textContent;
            break;
        case "LI":
            songName = e.toElement.children[1].innerText;
            break;        
        default:
            songName = "No se reconoce";
    }
    SendSong(songName);
});


function clearScreen() {
    hymnary.server.clear();
}

function FullSC() {
    var docelem = document.documentElement;
    if (docelem.requestFullscreen) {
        docelem.requestFullscreen();
    }
    else if (docelem.mozRequestFullScreen) {
        docelem.mozRequestFullScreen();
    }
    else if (docelem.webkitRequestFullscreen) {
        docelem.webkitRequestFullscreen();
    }
    else if (docelem.msRequestFullscreen) {
        docelem.msRequestFullscreen();
    }
}